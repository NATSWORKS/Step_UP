namespace GUI
{
    partial class frmViewMTGList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewMTGList));
            label1 = new Label();
            dgvData = new DataGridView();
            outCode = new Label();
            outDesc = new Label();
            label4 = new Label();
            panel1 = new Panel();
            pbFoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(218, 34, 51);
            label1.Location = new Point(178, 12);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 6;
            label1.Text = "Código";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvData.BackgroundColor = SystemColors.ControlLightLight;
            dgvData.Cursor = Cursors.Cross;
            dgvData.Location = new Point(12, 178);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(760, 471);
            dgvData.TabIndex = 9;
            // 
            // outCode
            // 
            outCode.AutoSize = true;
            outCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            outCode.ForeColor = Color.FromArgb(218, 34, 51);
            outCode.Location = new Point(178, 40);
            outCode.Name = "outCode";
            outCode.Size = new Size(27, 19);
            outCode.TabIndex = 10;
            outCode.Text = "---";
            // 
            // outDesc
            // 
            outDesc.AutoSize = true;
            outDesc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            outDesc.ForeColor = Color.FromArgb(218, 34, 51);
            outDesc.Location = new Point(178, 97);
            outDesc.Name = "outDesc";
            outDesc.Size = new Size(27, 19);
            outDesc.TabIndex = 12;
            outDesc.Text = "---";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(218, 34, 51);
            label4.Location = new Point(178, 69);
            label4.Name = "label4";
            label4.Size = new Size(74, 19);
            label4.TabIndex = 11;
            label4.Text = "Descrição";
            // 
            // panel1
            // 
            panel1.Controls.Add(pbFoto);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 160);
            panel1.TabIndex = 14;
            // 
            // pbFoto
            // 
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.Dock = DockStyle.Fill;
            pbFoto.Location = new Point(0, 0);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(160, 160);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 0;
            pbFoto.TabStop = false;
            // 
            // frmViewMTGList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(784, 661);
            Controls.Add(panel1);
            Controls.Add(outDesc);
            Controls.Add(label4);
            Controls.Add(outCode);
            Controls.Add(dgvData);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmViewMTGList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizar montagem";
            Load += frmViewMTGList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvData;
        private Label outCode;
        private Label outDesc;
        private Label label4;
        private Panel panel1;
        private PictureBox pbFoto;
    }
}