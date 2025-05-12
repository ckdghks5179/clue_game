namespace Clue
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnTurnEnd = new System.Windows.Forms.Button();
            this.dice1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbRemain = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.btnNote = new System.Windows.Forms.Button();
            this.btnSug = new System.Windows.Forms.Button();
            this.btnFinalSug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(510, 348);
            this.btnRoll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(87, 36);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll Dice";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnTurnEnd
            // 
            this.btnTurnEnd.Location = new System.Drawing.Point(510, 394);
            this.btnTurnEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTurnEnd.Name = "btnTurnEnd";
            this.btnTurnEnd.Size = new System.Drawing.Size(87, 36);
            this.btnTurnEnd.TabIndex = 1;
            this.btnTurnEnd.Text = "End Turn";
            this.btnTurnEnd.UseVisualStyleBackColor = true;
            this.btnTurnEnd.Click += new System.EventHandler(this.btnTurnEnd_Click);
            // 
            // dice1
            // 
            this.dice1.AutoSize = true;
            this.dice1.Location = new System.Drawing.Point(551, 311);
            this.dice1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(11, 12);
            this.dice1.TabIndex = 2;
            this.dice1.Text = "1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 400);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbRemain
            // 
            this.lbRemain.AutoSize = true;
            this.lbRemain.Location = new System.Drawing.Point(566, 334);
            this.lbRemain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRemain.Name = "lbRemain";
            this.lbRemain.Size = new System.Drawing.Size(11, 12);
            this.lbRemain.TabIndex = 5;
            this.lbRemain.Text = "0";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(690, 320);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(30, 38);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(690, 401);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(30, 38);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(726, 366);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(43, 26);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(638, 366);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(44, 26);
            this.btnLeft.TabIndex = 9;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 334);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Remain:";
            // 
            // player1
            // 
            this.player1.Image = ((System.Drawing.Image)(resources.GetObject("player1.Image")));
            this.player1.Location = new System.Drawing.Point(5, 5);
            this.player1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(13, 12);
            this.player1.TabIndex = 11;
            this.player1.TabStop = false;
            // 
            // player2
            // 
            this.player2.Image = ((System.Drawing.Image)(resources.GetObject("player2.Image")));
            this.player2.Location = new System.Drawing.Point(393, 250);
            this.player2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(13, 12);
            this.player2.TabIndex = 12;
            this.player2.TabStop = false;
            // 
            // btnNote
            // 
            this.btnNote.Location = new System.Drawing.Point(516, 30);
            this.btnNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(94, 30);
            this.btnNote.TabIndex = 13;
            this.btnNote.Text = "Memo";
            this.btnNote.UseVisualStyleBackColor = true;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // btnSug
            // 
            this.btnSug.Location = new System.Drawing.Point(516, 88);
            this.btnSug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSug.Name = "btnSug";
            this.btnSug.Size = new System.Drawing.Size(94, 30);
            this.btnSug.TabIndex = 14;
            this.btnSug.Text = "Suggest";
            this.btnSug.UseVisualStyleBackColor = true;
            // 
            // btnFinalSug
            // 
            this.btnFinalSug.ForeColor = System.Drawing.Color.Red;
            this.btnFinalSug.Location = new System.Drawing.Point(516, 151);
            this.btnFinalSug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFinalSug.Name = "btnFinalSug";
            this.btnFinalSug.Size = new System.Drawing.Size(111, 42);
            this.btnFinalSug.TabIndex = 15;
            this.btnFinalSug.Text = "Final\r\nSuggest";
            this.btnFinalSug.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 512);
            this.Controls.Add(this.btnFinalSug);
            this.Controls.Add(this.btnSug);
            this.Controls.Add(this.btnNote);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lbRemain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dice1);
            this.Controls.Add(this.btnTurnEnd);
            this.Controls.Add(this.btnRoll);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnTurnEnd;
        private System.Windows.Forms.Label dice1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbRemain;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.Button btnSug;
        private System.Windows.Forms.Button btnFinalSug;
    }
}

