namespace GUI
{
    partial class frmQuickView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuickView));
            pbFoto = new PictureBox();
            outNivel = new Label();
            outUser = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            outArea = new Label();
            outStatus = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // pbFoto
            // 
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.Image = Properties.Resources._149071;
            pbFoto.Location = new Point(12, 12);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(106, 106);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 12;
            pbFoto.TabStop = false;
            // 
            // outNivel
            // 
            outNivel.AutoSize = true;
            outNivel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            outNivel.ForeColor = Color.FromArgb(218, 34, 51);
            outNivel.Location = new Point(124, 73);
            outNivel.Name = "outNivel";
            outNivel.Size = new Size(27, 19);
            outNivel.TabIndex = 16;
            outNivel.Text = "---";
            // 
            // outUser
            // 
            outUser.AutoSize = true;
            outUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            outUser.ForeColor = Color.FromArgb(218, 34, 51);
            outUser.Location = new Point(124, 33);
            outUser.Name = "outUser";
            outUser.Size = new Size(27, 19);
            outUser.TabIndex = 15;
            outUser.Text = "---";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(218, 34, 51);
            label2.Location = new Point(124, 52);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 14;
            label2.Text = "Nível:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(218, 34, 51);
            label1.Location = new Point(124, 12);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 13;
            label1.Text = "Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(218, 34, 51);
            label3.Location = new Point(124, 92);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 17;
            label3.Text = "Área:";
            // 
            // outArea
            // 
            outArea.AutoSize = true;
            outArea.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            outArea.ForeColor = Color.FromArgb(218, 34, 51);
            outArea.Location = new Point(124, 113);
            outArea.Name = "outArea";
            outArea.Size = new Size(27, 19);
            outArea.TabIndex = 18;
            outArea.Text = "---";
            // 
            // outStatus
            // 
            outStatus.AutoSize = true;
            outStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            outStatus.ForeColor = Color.FromArgb(218, 34, 51);
            outStatus.Location = new Point(124, 153);
            outStatus.Name = "outStatus";
            outStatus.Size = new Size(27, 19);
            outStatus.TabIndex = 22;
            outStatus.Text = "---";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(218, 34, 51);
            label4.Location = new Point(124, 132);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 21;
            label4.Text = "Status:";
            // 
            // frmQuickView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(404, 191);
            Controls.Add(outStatus);
            Controls.Add(label4);
            Controls.Add(outArea);
            Controls.Add(label3);
            Controls.Add(outNivel);
            Controls.Add(outUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbFoto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmQuickView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuickView";
            Load += frmQuickView_Load;
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFoto;
        private Label outNivel;
        private Label outUser;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label outArea;
        private Label outStatus;
        private Label label4;
    }
}