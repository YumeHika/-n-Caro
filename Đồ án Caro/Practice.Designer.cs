namespace Đồ_án_Caro
{
    partial class Practice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Practice));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLAN = new System.Windows.Forms.Button();
            this.IPTxb = new System.Windows.Forms.TextBox();
            this.Player_Ava_ptb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerName_txb = new System.Windows.Forms.TextBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.UndoBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.NewGameBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player_Ava_ptb)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.Color.White;
            this.pnlChessBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlChessBoard.BackgroundImage")));
            this.pnlChessBoard.Location = new System.Drawing.Point(-1, 123);
            this.pnlChessBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(590, 533);
            this.pnlChessBoard.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Đồ_án_Caro.Properties.Resources.Logo_Caro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Location = new System.Drawing.Point(13, 13);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(122, 102);
            this.pnlLogo.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.BtnLAN);
            this.panel1.Controls.Add(this.IPTxb);
            this.panel1.Controls.Add(this.Player_Ava_ptb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PlayerName_txb);
            this.panel1.Location = new System.Drawing.Point(597, 123);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 533);
            this.panel1.TabIndex = 12;
            // 
            // BtnLAN
            // 
            this.BtnLAN.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLAN.Image = ((System.Drawing.Image)(resources.GetObject("BtnLAN.Image")));
            this.BtnLAN.Location = new System.Drawing.Point(152, 34);
            this.BtnLAN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLAN.Name = "BtnLAN";
            this.BtnLAN.Size = new System.Drawing.Size(69, 33);
            this.BtnLAN.TabIndex = 0;
            this.BtnLAN.Text = "LAN";
            this.BtnLAN.UseVisualStyleBackColor = true;
            this.BtnLAN.Click += new System.EventHandler(this.BtnLAN_Click);
            // 
            // IPTxb
            // 
            this.IPTxb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPTxb.Location = new System.Drawing.Point(9, 36);
            this.IPTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IPTxb.Name = "IPTxb";
            this.IPTxb.Size = new System.Drawing.Size(139, 30);
            this.IPTxb.TabIndex = 1;
            this.IPTxb.Text = "127.0.0.1";
            // 
            // Player_Ava_ptb
            // 
            this.Player_Ava_ptb.Location = new System.Drawing.Point(151, 90);
            this.Player_Ava_ptb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Player_Ava_ptb.Name = "Player_Ava_ptb";
            this.Player_Ava_ptb.Size = new System.Drawing.Size(69, 65);
            this.Player_Ava_ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player_Ava_ptb.TabIndex = 0;
            this.Player_Ava_ptb.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player\'s turn:";
            // 
            // PlayerName_txb
            // 
            this.PlayerName_txb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerName_txb.Location = new System.Drawing.Point(3, 123);
            this.PlayerName_txb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayerName_txb.Name = "PlayerName_txb";
            this.PlayerName_txb.Size = new System.Drawing.Size(139, 30);
            this.PlayerName_txb.TabIndex = 4;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlInfo.BackgroundImage")));
            this.pnlInfo.Controls.Add(this.UndoBtn);
            this.pnlInfo.Controls.Add(this.button1);
            this.pnlInfo.Controls.Add(this.richTextBox1);
            this.pnlInfo.Controls.Add(this.QuitBtn);
            this.pnlInfo.Controls.Add(this.NewGameBtn);
            this.pnlInfo.Location = new System.Drawing.Point(143, 13);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(681, 103);
            this.pnlInfo.TabIndex = 13;
            // 
            // UndoBtn
            // 
            this.UndoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UndoBtn.BackgroundImage")));
            this.UndoBtn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UndoBtn.Location = new System.Drawing.Point(4, 59);
            this.UndoBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UndoBtn.Name = "UndoBtn";
            this.UndoBtn.Size = new System.Drawing.Size(120, 38);
            this.UndoBtn.TabIndex = 16;
            this.UndoBtn.Text = "Undo";
            this.UndoBtn.UseVisualStyleBackColor = true;
            this.UndoBtn.Click += new System.EventHandler(this.UndoBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Location = new System.Drawing.Point(441, 1);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(240, 96);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "LUẬT:\n- Ai có 5 con trên 1 hàng trước sẽ thắng.";
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.QuitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuitBtn.BackgroundImage")));
            this.QuitBtn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitBtn.Location = new System.Drawing.Point(260, 4);
            this.QuitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(120, 38);
            this.QuitBtn.TabIndex = 3;
            this.QuitBtn.Text = "Quit";
            this.QuitBtn.UseVisualStyleBackColor = false;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewGameBtn.BackgroundImage")));
            this.NewGameBtn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameBtn.Location = new System.Drawing.Point(132, 4);
            this.NewGameBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(120, 38);
            this.NewGameBtn.TabIndex = 0;
            this.NewGameBtn.Text = "New Game";
            this.NewGameBtn.UseVisualStyleBackColor = true;
            this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // Practice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(838, 668);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlChessBoard);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Practice";
            this.Text = "Practice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Practice_FormClosing);
            this.Shown += new System.EventHandler(this.Practice_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player_Ava_ptb)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLAN;
        private System.Windows.Forms.TextBox IPTxb;
        private System.Windows.Forms.PictureBox Player_Ava_ptb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PlayerName_txb;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button NewGameBtn;
        private System.Windows.Forms.Button UndoBtn;
    }
}