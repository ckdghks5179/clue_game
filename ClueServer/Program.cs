using System.Net.Sockets;
using System.Net;
using System.Text;

class Program
{
    static List<string> connectedPlayers = new List<string>();
    static List<NetworkStream> clientStreams = new List<NetworkStream>();
    static object lockObj = new object();
    static int maxPlayers = 6;

    static void Main(string[] args)
    {
        TcpListener server = new TcpListener(IPAddress.Any, 5000);
        server.Start();
        Console.WriteLine("서버 시작됨. 클라이언트 접속 대기 중...");

        while (true)
        {
            TcpClient client = server.AcceptTcpClient();

            lock (lockObj)
            {
                if (connectedPlayers.Count >= maxPlayers)
                {
                    Console.WriteLine("접속 인원 초과: 연결 거부됨");

                    NetworkStream tempStream = client.GetStream();
                    byte[] fullMsg = Encoding.UTF8.GetBytes("❌ 인원이 가득 찼습니다.");
                    tempStream.Write(fullMsg, 0, fullMsg.Length);
                    client.Close();
                    continue;
                }
            }

            Console.WriteLine("클라이언트 연결됨.");
            Thread t = new Thread(() => HandleClient(client));
            t.Start();
        }
    }

    static void HandleClient(TcpClient client)
    {
        NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[1024];
        string name = "";

        try
        {
            // 1. 接收昵称
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            name = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();

            lock (lockObj)
            {
                connectedPlayers.Add(name);
                clientStreams.Add(stream);

                Console.WriteLine($"플레이어 이름 수신됨: {name}");
                Console.WriteLine($"현재 접속 인원: {connectedPlayers.Count}명");

                // 2. 广播通知
                BroadcastMessage($"📢 {name}님이 입장하였습니다!\n");
            }

            // 3. 给本人发送欢迎信息
            string welcome = $"환영합니다, {name}님!\n";
            byte[] response = Encoding.UTF8.GetBytes(welcome);
            stream.Write(response, 0, response.Length);

            // 🔄 可以在此添加消息接收循环（채팅逻辑）
        }
        catch (Exception ex)
        {
            Console.WriteLine("에러 발생: " + ex.Message);
        }
        finally
        {
            // ✅ 清理连接
            lock (lockObj)
            {
                connectedPlayers.Remove(name);
                clientStreams.Remove(stream);
            }

            try { stream.Close(); } catch { }
            try { client.Close(); } catch { }
        }
    }

    static void BroadcastMessage(string msg)
    {
        byte[] data = Encoding.UTF8.GetBytes(msg);
        lock (lockObj)
        {
            foreach (var s in clientStreams)
            {
                try { s.Write(data, 0, data.Length); } catch { }
            }
        }
    }
}
