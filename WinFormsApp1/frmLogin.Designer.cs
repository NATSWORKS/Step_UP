namespace GUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            inPass = new TextBox();
            inLog = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            erro = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(218, 34, 51);
            button1.Location = new Point(123, 251);
            button1.Name = "button1";
            button1.Size = new Size(160, 30);
            button1.TabIndex = 10;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(218, 34, 51);
            label2.Location = new Point(176, 186);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 9;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(218, 34, 51);
            label1.Location = new Point(176, 140);
            label1.Name = "label1";
            label1.Size = new Size(46, 19);
            label1.TabIndex = 8;
            label1.Text = "Login";
            // 
            // inPass
            // 
            inPass.BackColor = Color.FromArgb(23, 23, 23);
            inPass.BorderStyle = BorderStyle.FixedSingle;
            inPass.ForeColor = Color.FromArgb(236, 134, 0);
            inPass.Location = new Point(123, 208);
            inPass.Name = "inPass";
            inPass.Size = new Size(160, 23);
            inPass.TabIndex = 7;
            inPass.TextAlign = HorizontalAlignment.Center;
            inPass.UseSystemPasswordChar = true;
            // 
            // inLog
            // 
            inLog.BackColor = Color.FromArgb(23, 23, 23);
            inLog.BorderStyle = BorderStyle.FixedSingle;
            inLog.ForeColor = Color.FromArgb(236, 134, 0);
            inLog.Location = new Point(123, 162);
            inLog.Name = "inLog";
            inLog.Size = new Size(160, 23);
            inLog.TabIndex = 6;
            inLog.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(218, 34, 51);
            label5.Location = new Point(183, 364);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(223, 13);
            label5.TabIndex = 11;
            label5.Text = " © 2022 NATSWORKS.  All rights reserved.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._149071;
            pictureBox1.Location = new Point(152, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // erro
            // 
            erro.AutoSize = true;
            erro.BackColor = Color.Transparent;
            erro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            erro.ForeColor = Color.Red;
            erro.Location = new Point(123, 127);
            erro.Name = "erro";
            erro.Size = new Size(147, 15);
            erro.TabIndex = 13;
            erro.Text = "Login ou senha incorreto.";
            erro.Visible = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(403, 377);
            Controls.Add(erro);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inPass);
            Controls.Add(inLog);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StepUp v0.1 - Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox inPass;
        private TextBox inLog;
        private Label label5;
        private PictureBox pictureBox1;
        private Label erro;
    }
}