namespace GUI
{
    partial class frmModeloCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModeloCadastro));
            this.pnDados = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Location = new System.Drawing.Point(12, 56);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(760, 493);
            this.pnDados.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btExcluir);
            this.panel1.Controls.Add(this.btInserir);
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Controls.Add(this.btSalvar);
            this.panel1.Controls.Add(this.btAlterar);
            this.panel1.Controls.Add(this.btLocalizar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 38);
            this.panel1.TabIndex = 1;
            // 
            // btExcluir
            // 
            this.btExcluir.Image = global::GUI.Properties.Resources.trash1;
            this.btExcluir.Location = new System.Drawing.Point(683, 3);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(110, 30);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btInserir
            // 
            this.btInserir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btInserir.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btInserir.Image = global::GUI.Properties.Resources.insert1;
            this.btInserir.Location = new System.Drawing.Point(3, 3);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(110, 30);
            this.btInserir.TabIndex = 0;
            this.btInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btInserir.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Image = global::GUI.Properties.Resources.cancel1;
            this.btCancelar.Location = new System.Drawing.Point(411, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(110, 30);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Image = global::GUI.Properties.Resources.save1;
            this.btSalvar.Location = new System.Drawing.Point(547, 3);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(110, 30);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Image = global::GUI.Properties.Resources.refresh1;
            this.btAlterar.Location = new System.Drawing.Point(275, 3);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(110, 30);
            this.btAlterar.TabIndex = 2;
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btLocalizar
            // 
            this.btLocalizar.Image = global::GUI.Properties.Resources.search1;
            this.btLocalizar.Location = new System.Drawing.Point(139, 3);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(110, 30);
            this.btLocalizar.TabIndex = 1;
            this.btLocalizar.UseVisualStyleBackColor = true;
            // 
            // frmModeloCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModeloCadastroProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        protected Button btCancelar;
        protected Button btSalvar;
        protected Button btExcluir;
        protected Button btAlterar;
        protected Button btLocalizar;
        protected Button btInserir;
        protected Panel pnDados;
    }
}