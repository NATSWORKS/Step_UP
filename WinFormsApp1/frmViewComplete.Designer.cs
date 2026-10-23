namespace GUI
{
    partial class frmViewComplete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewComplete));
            panel1 = new Panel();
            pbFoto = new PictureBox();
            outDesc = new Label();
            label4 = new Label();
            outCode = new Label();
            dgvData = new DataGridView();
            label1 = new Label();
            outSum = new Label();
            label3 = new Label();
            cb1 = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pbFoto);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 160);
            panel1.TabIndex = 20;
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
            // outDesc
            // 
            outDesc.AutoSize = true;
            outDesc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            outDesc.ForeColor = Color.FromArgb(218, 34, 51);
            outDesc.Location = new Point(178, 97);
            outDesc.Name = "outDesc";
            outDesc.Size = new Size(27, 19);
            outDesc.TabIndex = 19;
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
            label4.TabIndex = 18;
            label4.Text = "Descrição";
            // 
            // outCode
            // 
            outCode.AutoSize = true;
            outCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            outCode.ForeColor = Color.FromArgb(218, 34, 51);
            outCode.Location = new Point(178, 40);
            outCode.Name = "outCode";
            outCode.Size = new Size(27, 19);
            outCode.TabIndex = 17;
            outCode.Text = "---";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.BackgroundColor = SystemColors.ControlLightLight;
            dgvData.Cursor = Cursors.Cross;
            dgvData.Location = new Point(12, 189);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvData.RowTemplate.Height = 80;
            dgvData.Size = new Size(760, 462);
            dgvData.TabIndex = 16;
            dgvData.CellMouseEnter += dgvData_CellMouseEnter;
            dgvData.Sorted += dgvData_Sorted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(218, 34, 51);
            label1.Location = new Point(178, 12);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 15;
            label1.Text = "Código";
            // 
            // outSum
            // 
            outSum.AutoSize = true;
            outSum.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            outSum.ForeColor = Color.FromArgb(218, 34, 51);
            outSum.Location = new Point(178, 153);
            outSum.Name = "outSum";
            outSum.Size = new Size(27, 19);
            outSum.TabIndex = 22;
            outSum.Text = "---";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(218, 34, 51);
            label3.Location = new Point(178, 125);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 21;
            label3.Text = "Valor total";
            // 
            // cb1
            // 
            cb1.AutoSize = true;
            cb1.ForeColor = Color.FromArgb(236, 134, 0);
            cb1.Location = new Point(698, 12);
            cb1.Name = "cb1";
            cb1.Size = new Size(67, 19);
            cb1.TabIndex = 23;
            cb1.Text = "Ver foto";
            cb1.UseVisualStyleBackColor = true;
            cb1.CheckedChanged += cb1_CheckedChanged;
            // 
            // frmViewComplete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(784, 661);
            Controls.Add(cb1);
            Controls.Add(outSum);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(outDesc);
            Controls.Add(label4);
            Controls.Add(outCode);
            Controls.Add(dgvData);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmViewComplete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizar lista completa";
            Load += frmViewComplete_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pbFoto;
        private Label outDesc;
        private Label label4;
        private Label outCode;
        private DataGridView dgvData;
        private Label label1;
        private Label outSum;
        private Label label3;
        private CheckBox cb1;
    }
}