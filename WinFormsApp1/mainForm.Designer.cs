namespace GUI
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            pnLogin = new Panel();
            label4 = new Label();
            label1 = new Label();
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            label5 = new Label();
            pbFoto = new PictureBox();
            outStatus = new Label();
            outUser = new Label();
            label3 = new Label();
            label2 = new Label();
            setOffline = new Button();
            setLunch = new Button();
            setOnline = new Button();
            pictureBox1 = new PictureBox();
            panelSideMenu = new Panel();
            ajudaSubMenu = new Panel();
            ajAbout = new Button();
            ajNew = new Button();
            ajBtn = new Button();
            ferramentasSubMenu = new Panel();
            toConn = new Button();
            toNote = new Button();
            toCalc = new Button();
            toBtn = new Button();
            fbBtn = new Button();
            pedidosSubMenu = new Panel();
            pdSep = new Button();
            pdOrder = new Button();
            pdBtn = new Button();
            alBtn = new Button();
            consultaSubMenu = new Panel();
            csUser = new Button();
            csAssist = new Button();
            csOrder = new Button();
            csRecei = new Button();
            csSupplier = new Button();
            csList = new Button();
            csAssemblies = new Button();
            csMaterials = new Button();
            csBtn = new Button();
            cadastroSubMenu = new Panel();
            cdUser = new Button();
            cdAssist = new Button();
            cdOrder = new Button();
            cdRecei = new Button();
            cdSupplier = new Button();
            cdAssemblies = new Button();
            cdMaterials = new Button();
            cdBtn = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSideMenu.SuspendLayout();
            ajudaSubMenu.SuspendLayout();
            ferramentasSubMenu.SuspendLayout();
            pedidosSubMenu.SuspendLayout();
            consultaSubMenu.SuspendLayout();
            cadastroSubMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnLogin
            // 
            pnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnLogin.Controls.Add(label4);
            pnLogin.Controls.Add(label1);
            pnLogin.Controls.Add(monthCalendar1);
            pnLogin.Location = new Point(185, 135);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(753, 425);
            pnLogin.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(218, 34, 51);
            label4.Location = new Point(591, 224);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 12;
            label4.Text = "Calendário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(218, 34, 51);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 1;
            label1.Text = "Dashboard";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            monthCalendar1.BackColor = Color.FromArgb(0, 59, 102);
            monthCalendar1.Cursor = Cursors.Cross;
            monthCalendar1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            monthCalendar1.ForeColor = Color.FromArgb(236, 134, 0);
            monthCalendar1.Location = new Point(517, 254);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.TitleBackColor = Color.FromArgb(236, 134, 0);
            monthCalendar1.TitleForeColor = Color.FromArgb(236, 134, 0);
            monthCalendar1.TrailingForeColor = Color.FromArgb(236, 134, 0);
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(218, 34, 51);
            button1.Location = new Point(797, 41);
            button1.Name = "button1";
            button1.Size = new Size(141, 35);
            button1.TabIndex = 14;
            button1.Text = "Site da Interlaser";
            button1.UseVisualStyleBackColor = true;
            button1.Click += webSite_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(218, 34, 51);
            label5.Location = new Point(715, 578);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(223, 13);
            label5.TabIndex = 13;
            label5.Text = " © 2024 NATSWORKS.  All rights reserved.";
            // 
            // pbFoto
            // 
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.Image = Properties.Resources._149071;
            pbFoto.Location = new Point(332, 6);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(106, 106);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 11;
            pbFoto.TabStop = false;
            // 
            // outStatus
            // 
            outStatus.AutoSize = true;
            outStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            outStatus.ForeColor = Color.FromArgb(218, 34, 51);
            outStatus.Location = new Point(444, 78);
            outStatus.Name = "outStatus";
            outStatus.Size = new Size(27, 19);
            outStatus.TabIndex = 10;
            outStatus.Text = "---";
            // 
            // outUser
            // 
            outUser.AutoSize = true;
            outUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            outUser.ForeColor = Color.FromArgb(218, 34, 51);
            outUser.Location = new Point(444, 38);
            outUser.Name = "outUser";
            outUser.Size = new Size(27, 19);
            outUser.TabIndex = 9;
            outUser.Text = "---";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(218, 34, 51);
            label3.Location = new Point(444, 57);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 8;
            label3.Text = "Status:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(218, 34, 51);
            label2.Location = new Point(444, 17);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 7;
            label2.Text = "Usuário:";
            // 
            // setOffline
            // 
            setOffline.FlatStyle = FlatStyle.Flat;
            setOffline.ForeColor = Color.FromArgb(218, 34, 51);
            setOffline.Location = new Point(185, 78);
            setOffline.Name = "setOffline";
            setOffline.Size = new Size(141, 34);
            setOffline.TabIndex = 6;
            setOffline.Text = "Offline";
            setOffline.UseVisualStyleBackColor = true;
            setOffline.Click += setOffline_Click;
            // 
            // setLunch
            // 
            setLunch.FlatStyle = FlatStyle.Flat;
            setLunch.ForeColor = Color.FromArgb(218, 34, 51);
            setLunch.Location = new Point(185, 39);
            setLunch.Name = "setLunch";
            setLunch.Size = new Size(141, 34);
            setLunch.TabIndex = 5;
            setLunch.Text = "Almoço";
            setLunch.UseVisualStyleBackColor = true;
            setLunch.Click += setLunch_Click;
            // 
            // setOnline
            // 
            setOnline.FlatStyle = FlatStyle.Flat;
            setOnline.ForeColor = Color.FromArgb(218, 34, 51);
            setOnline.Location = new Point(185, 0);
            setOnline.Name = "setOnline";
            setOnline.Size = new Size(141, 34);
            setOnline.TabIndex = 4;
            setOnline.Text = "Online";
            setOnline.UseVisualStyleBackColor = true;
            setOnline.Click += setOnline_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panelSideMenu
            // 
            panelSideMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelSideMenu.AutoScroll = true;
            panelSideMenu.Controls.Add(ajudaSubMenu);
            panelSideMenu.Controls.Add(ajBtn);
            panelSideMenu.Controls.Add(ferramentasSubMenu);
            panelSideMenu.Controls.Add(toBtn);
            panelSideMenu.Controls.Add(fbBtn);
            panelSideMenu.Controls.Add(pedidosSubMenu);
            panelSideMenu.Controls.Add(pdBtn);
            panelSideMenu.Controls.Add(alBtn);
            panelSideMenu.Controls.Add(consultaSubMenu);
            panelSideMenu.Controls.Add(csBtn);
            panelSideMenu.Controls.Add(cadastroSubMenu);
            panelSideMenu.Controls.Add(cdBtn);
            panelSideMenu.Controls.Add(pictureBox1);
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(150, 600);
            panelSideMenu.TabIndex = 3;
            // 
            // ajudaSubMenu
            // 
            ajudaSubMenu.BackColor = Color.FromArgb(23, 23, 23);
            ajudaSubMenu.Controls.Add(ajAbout);
            ajudaSubMenu.Controls.Add(ajNew);
            ajudaSubMenu.Dock = DockStyle.Top;
            ajudaSubMenu.Location = new Point(0, 1004);
            ajudaSubMenu.Name = "ajudaSubMenu";
            ajudaSubMenu.Size = new Size(133, 71);
            ajudaSubMenu.TabIndex = 16;
            // 
            // ajAbout
            // 
            ajAbout.Dock = DockStyle.Top;
            ajAbout.FlatAppearance.BorderSize = 0;
            ajAbout.FlatStyle = FlatStyle.Flat;
            ajAbout.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ajAbout.ForeColor = Color.FromArgb(218, 34, 51);
            ajAbout.Location = new Point(0, 35);
            ajAbout.Name = "ajAbout";
            ajAbout.Padding = new Padding(20, 0, 0, 0);
            ajAbout.Size = new Size(133, 35);
            ajAbout.TabIndex = 4;
            ajAbout.Text = "Sobre";
            ajAbout.TextAlign = ContentAlignment.MiddleLeft;
            ajAbout.UseVisualStyleBackColor = true;
            ajAbout.Click += ajAbout_Click;
            // 
            // ajNew
            // 
            ajNew.Dock = DockStyle.Top;
            ajNew.FlatAppearance.BorderSize = 0;
            ajNew.FlatStyle = FlatStyle.Flat;
            ajNew.Font = new Font("Bahnschrift SemiLight SemiConde", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ajNew.ForeColor = Color.FromArgb(100, 0, 17);
            ajNew.Location = new Point(0, 0);
            ajNew.Name = "ajNew";
            ajNew.Padding = new Padding(20, 0, 0, 0);
            ajNew.Size = new Size(133, 35);
            ajNew.TabIndex = 3;
            ajNew.Text = "O que há de novo?";
            ajNew.TextAlign = ContentAlignment.MiddleLeft;
            ajNew.UseVisualStyleBackColor = true;
            // 
            // ajBtn
            // 
            ajBtn.Dock = DockStyle.Top;
            ajBtn.FlatAppearance.BorderSize = 0;
            ajBtn.FlatStyle = FlatStyle.Flat;
            ajBtn.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ajBtn.ForeColor = Color.FromArgb(218, 34, 51);
            ajBtn.Location = new Point(0, 969);
            ajBtn.Name = "ajBtn";
            ajBtn.Size = new Size(133, 35);
            ajBtn.TabIndex = 15;
            ajBtn.Text = "Ajuda";
            ajBtn.TextAlign = ContentAlignment.MiddleLeft;
            ajBtn.UseVisualStyleBackColor = true;
            ajBtn.Click += ajBtn_Click;
            // 
            // ferramentasSubMenu
            // 
            ferramentasSubMenu.BackColor = Color.FromArgb(23, 23, 23);
            ferramentasSubMenu.Controls.Add(toConn);
            ferramentasSubMenu.Controls.Add(toNote);
            ferramentasSubMenu.Controls.Add(toCalc);
            ferramentasSubMenu.Dock = DockStyle.Top;
            ferramentasSubMenu.Location = new Point(0, 860);
            ferramentasSubMenu.Name = "ferramentasSubMenu";
            ferramentasSubMenu.Size = new Size(133, 109);
            ferramentasSubMenu.TabIndex = 14;
            // 
            // toConn
            // 
            toConn.Dock = DockStyle.Top;
            toConn.FlatAppearance.BorderSize = 0;
            toConn.FlatStyle = FlatStyle.Flat;
            toConn.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toConn.ForeColor = Color.FromArgb(100, 0, 17);
            toConn.Location = new Point(0, 70);
            toConn.Name = "toConn";
            toConn.Padding = new Padding(20, 0, 0, 0);
            toConn.Size = new Size(133, 35);
            toConn.TabIndex = 5;
            toConn.Text = "Checar conexão";
            toConn.TextAlign = ContentAlignment.MiddleLeft;
            toConn.UseVisualStyleBackColor = true;
            // 
            // toNote
            // 
            toNote.Dock = DockStyle.Top;
            toNote.FlatAppearance.BorderSize = 0;
            toNote.FlatStyle = FlatStyle.Flat;
            toNote.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toNote.ForeColor = Color.FromArgb(218, 34, 51);
            toNote.Location = new Point(0, 35);
            toNote.Name = "toNote";
            toNote.Padding = new Padding(20, 0, 0, 0);
            toNote.Size = new Size(133, 35);
            toNote.TabIndex = 4;
            toNote.Text = "Notas";
            toNote.TextAlign = ContentAlignment.MiddleLeft;
            toNote.UseVisualStyleBackColor = true;
            toNote.Click += toNote_Click;
            // 
            // toCalc
            // 
            toCalc.Dock = DockStyle.Top;
            toCalc.FlatAppearance.BorderSize = 0;
            toCalc.FlatStyle = FlatStyle.Flat;
            toCalc.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toCalc.ForeColor = Color.FromArgb(218, 34, 51);
            toCalc.Location = new Point(0, 0);
            toCalc.Name = "toCalc";
            toCalc.Padding = new Padding(20, 0, 0, 0);
            toCalc.Size = new Size(133, 35);
            toCalc.TabIndex = 3;
            toCalc.Text = "Calculadora";
            toCalc.TextAlign = ContentAlignment.MiddleLeft;
            toCalc.UseVisualStyleBackColor = true;
            toCalc.Click += toCalc_Click;
            // 
            // toBtn
            // 
            toBtn.Dock = DockStyle.Top;
            toBtn.FlatAppearance.BorderSize = 0;
            toBtn.FlatStyle = FlatStyle.Flat;
            toBtn.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toBtn.ForeColor = Color.FromArgb(218, 34, 51);
            toBtn.Location = new Point(0, 825);
            toBtn.Name = "toBtn";
            toBtn.Size = new Size(133, 35);
            toBtn.TabIndex = 13;
            toBtn.Text = "Ferramentas";
            toBtn.TextAlign = ContentAlignment.MiddleLeft;
            toBtn.UseVisualStyleBackColor = true;
            toBtn.Click += toBtn_Click;
            // 
            // fbBtn
            // 
            fbBtn.Dock = DockStyle.Top;
            fbBtn.FlatAppearance.BorderSize = 0;
            fbBtn.FlatStyle = FlatStyle.Flat;
            fbBtn.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fbBtn.ForeColor = Color.FromArgb(100, 0, 17);
            fbBtn.Location = new Point(0, 790);
            fbBtn.Name = "fbBtn";
            fbBtn.Size = new Size(133, 35);
            fbBtn.TabIndex = 11;
            fbBtn.Text = "Fábrica";
            fbBtn.TextAlign = ContentAlignment.MiddleLeft;
            fbBtn.UseVisualStyleBackColor = true;
            // 
            // pedidosSubMenu
            // 
            pedidosSubMenu.BackColor = Color.FromArgb(23, 23, 23);
            pedidosSubMenu.Controls.Add(pdSep);
            pedidosSubMenu.Controls.Add(pdOrder);
            pedidosSubMenu.Dock = DockStyle.Top;
            pedidosSubMenu.Location = new Point(0, 719);
            pedidosSubMenu.Name = "pedidosSubMenu";
            pedidosSubMenu.Size = new Size(133, 71);
            pedidosSubMenu.TabIndex = 10;
            // 
            // pdSep
            // 
            pdSep.Dock = DockStyle.Top;
            pdSep.FlatAppearance.BorderSize = 0;
            pdSep.FlatStyle = FlatStyle.Flat;
            pdSep.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pdSep.ForeColor = Color.FromArgb(100, 0, 17);
            pdSep.Location = new Point(0, 35);
            pdSep.Name = "pdSep";
            pdSep.Padding = new Padding(20, 0, 0, 0);
            pdSep.Size = new Size(133, 35);
            pdSep.TabIndex = 4;
            pdSep.Text = "Separação";
            pdSep.TextAlign = ContentAlignment.MiddleLeft;
            pdSep.UseVisualStyleBackColor = true;
            // 
            // pdOrder
            // 
            pdOrder.Dock = DockStyle.Top;
            pdOrder.FlatAppearance.BorderSize = 0;
            pdOrder.FlatStyle = FlatStyle.Flat;
            pdOrder.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pdOrder.ForeColor = Color.FromArgb(100, 0, 17);
            pdOrder.Location = new Point(0, 0);
            pdOrder.Name = "pdOrder";
            pdOrder.Padding = new Padding(20, 0, 0, 0);
            pdOrder.Size = new Size(133, 35);
            pdOrder.TabIndex = 3;
            pdOrder.Text = "Compra";
            pdOrder.TextAlign = ContentAlignment.MiddleLeft;
            pdOrder.UseVisualStyleBackColor = true;
            // 
            // pdBtn
            // 
            pdBtn.Dock = DockStyle.Top;
            pdBtn.FlatAppearance.BorderSize = 0;
            pdBtn.FlatStyle = FlatStyle.Flat;
            pdBtn.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pdBtn.ForeColor = Color.FromArgb(218, 34, 51);
            pdBtn.Location = new Point(0, 684);
            pdBtn.Name = "pdBtn";
            pdBtn.Size = new Size(133, 35);
            pdBtn.TabIndex = 9;
            pdBtn.Text = "Pedidos";
            pdBtn.TextAlign = ContentAlignment.MiddleLeft;
            pdBtn.UseVisualStyleBackColor = true;
            pdBtn.Click += pdBtn_Click;
            // 
            // alBtn
            // 
            alBtn.Dock = DockStyle.Top;
            alBtn.FlatAppearance.BorderSize = 0;
            alBtn.FlatStyle = FlatStyle.Flat;
            alBtn.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            alBtn.ForeColor = Color.FromArgb(218, 34, 51);
            alBtn.Location = new Point(0, 649);
            alBtn.Name = "alBtn";
            alBtn.Size = new Size(133, 35);
            alBtn.TabIndex = 7;
            alBtn.Text = "Almoxarifado";
            alBtn.TextAlign = ContentAlignment.MiddleLeft;
            alBtn.UseVisualStyleBackColor = true;
            alBtn.Click += alBtn_Click;
            // 
            // consultaSubMenu
            // 
            consultaSubMenu.BackColor = Color.FromArgb(23, 23, 23);
            consultaSubMenu.Controls.Add(csUser);
            consultaSubMenu.Controls.Add(csAssist);
            consultaSubMenu.Controls.Add(csOrder);
            consultaSubMenu.Controls.Add(csRecei);
            consultaSubMenu.Controls.Add(csSupplier);
            consultaSubMenu.Controls.Add(csList);
            consultaSubMenu.Controls.Add(csAssemblies);
            consultaSubMenu.Controls.Add(csMaterials);
            consultaSubMenu.Dock = DockStyle.Top;
            consultaSubMenu.Location = new Point(0, 366);
            consultaSubMenu.Name = "consultaSubMenu";
            consultaSubMenu.Size = new Size(133, 283);
            consultaSubMenu.TabIndex = 6;
            // 
            // csUser
            // 
            csUser.Dock = DockStyle.Top;
            csUser.FlatAppearance.BorderSize = 0;
            csUser.FlatStyle = FlatStyle.Flat;
            csUser.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            csUser.ForeColor = Color.FromArgb(218, 34, 51);
            csUser.Location = new Point(0, 245);
            csUser.Name = "csUser";
            csUser.Padding = new Padding(20, 0, 0, 0);
            csUser.Size = new Size(133, 35);
            csUser.TabIndex = 8;
            csUser.Text = "Usuário";
            csUser.TextAlign = ContentAlignment.MiddleLeft;
            csUser.UseVisualStyleBackColor = true;
            csUser.Click += csUser_Click;
            // 
            // csAssist
            // 
            csAssist.Dock = DockStyle.Top;
            csAssist.FlatAppearance.BorderSize = 0;
            csAssist.FlatStyle = FlatStyle.Flat;
            csAssist.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            csAssist.ForeColor = Color.FromArgb(218, 34, 51);
            csAssist.Location = new Point(0, 210);
            csAssist.Name = "csAssist";
            csAssist.Padding = new Padding(20, 0, 0, 0);
            csAssist.Size = new Size(133, 35);
            csAssist.TabIndex = 6;
            csAssist.Text = "Assistência";
            csAssist.TextAlign = ContentAlignment.MiddleLeft;
            csAssist.UseVisualStyleBackColor = true;
            csAssist.Click += csAssist_Click;
            // 
            // csOrder
            // 
            csOrder.Dock = DockStyle.Top;
            csOrder.FlatAppearance.BorderSize = 0;
            csOrder.FlatStyle = FlatStyle.Flat;
            csOrder.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            csOrder.ForeColor = Color.FromArgb(218, 34, 51);
            csOrder.Location = new Point(0, 175);
            csOrder.Name = "csOrder";
            csOrder.Padding = new Padding(20, 0, 0, 0);
            csOrder.Size = new Size(133, 35);
            csOrder.TabIndex = 5;
            csOrder.Text = "Compras";
            csOrder.TextAlign = ContentAlignment.MiddleLeft;
            csOrder.UseVisualStyleBackColor = true;
            csOrder.Click += csOrder_Click;
            // 
            // csRecei
            // 
            csRecei.Dock = DockStyle.Top;
            csRecei.FlatAppearance.BorderSize = 0;
            csRecei.FlatStyle = FlatStyle.Flat;
            csRecei.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            csRecei.ForeColor = Color.FromArgb(100, 0, 17);
            csRecei.Location = new Point(0, 140);
            csRecei.Name = "csRecei";
            csRecei.Padding = new Padding(20, 0, 0, 0);
            csRecei.Size = new Size(133, 35);
            csRecei.TabIndex = 4;
            csRecei.Text = "Recebimento";
            csRecei.TextAlign = ContentAlignment.MiddleLeft;
            csRecei.UseVisualStyleBackColor = true;
            // 
            // csSupplier
            // 
            csSupplier.Dock = DockStyle.Top;
            csSupplier.FlatAppearance.BorderSize = 0;
            csSupplier.FlatStyle = FlatStyle.Flat;
            csSupplier.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            csSupplier.ForeColor = Color.FromArgb(218, 34, 51);
            csSupplier.Location = new Point(0, 105);
            csSupplier.Name = "csSupplier";
            csSupplier.Padding = new Padding(20, 0, 0, 0);
            csSupplier.Size = new Size(133, 35);
            csSupplier.TabIndex = 3;
            csSupplier.Text = "Fornecedor";
            csSupplier.TextAlign = ContentAlignment.MiddleLeft;
            csSupplier.UseVisualStyleBackColor = true;
            csSupplier.Click += csSupplier_Click;
            // 
            // csList
            // 
            csList.Dock = DockStyle.Top;
            csList.FlatAppearance.BorderSize = 0;
            csList.FlatStyle = FlatStyle.Flat;
            csList.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            csList.ForeColor = Color.FromArgb(218, 34, 51);
            csList.Location = new Point(0, 70);
            csList.Name = "csList";
            csList.Padding = new Padding(20, 0, 0, 0);
            csList.Size = new Size(133, 35);
            csList.TabIndex = 2;
            csList.Text = "Lista completa";
            csList.TextAlign = ContentAlignment.MiddleLeft;
            csList.UseVisualStyleBackColor = true;
            csList.Click += csList_Click;
            // 
            // csAssemblies
            // 
            csAssemblies.Dock = DockStyle.Top;
            csAssemblies.FlatAppearance.BorderSize = 0;
            csAssemblies.FlatStyle = FlatStyle.Flat;
            csAssemblies.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            csAssemblies.ForeColor = Color.FromArgb(218, 34, 51);
            csAssemblies.Location = new Point(0, 35);
            csAssemblies.Name = "csAssemblies";
            csAssemblies.Padding = new Padding(20, 0, 0, 0);
            csAssemblies.Size = new Size(133, 35);
            csAssemblies.TabIndex = 1;
            csAssemblies.Text = "Montagens";
            csAssemblies.TextAlign = ContentAlignment.MiddleLeft;
            csAssemblies.UseVisualStyleBackColor = true;
            csAssemblies.Click += csAssemblies_Click;
            // 
            // csMaterials
            // 
            csMaterials.Dock = DockStyle.Top;
            csMaterials.FlatAppearance.BorderSize = 0;
            csMaterials.FlatStyle = FlatStyle.Flat;
            csMaterials.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            csMaterials.ForeColor = Color.FromArgb(218, 34, 51);
            csMaterials.Location = new Point(0, 0);
            csMaterials.Name = "csMaterials";
            csMaterials.Padding = new Padding(20, 0, 0, 0);
            csMaterials.Size = new Size(133, 35);
            csMaterials.TabIndex = 0;
            csMaterials.Text = "Materiais";
            csMaterials.TextAlign = ContentAlignment.MiddleLeft;
            csMaterials.UseVisualStyleBackColor = true;
            csMaterials.Click += csMaterials_Click;
            // 
            // csBtn
            // 
            csBtn.Dock = DockStyle.Top;
            csBtn.FlatAppearance.BorderSize = 0;
            csBtn.FlatStyle = FlatStyle.Flat;
            csBtn.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            csBtn.ForeColor = Color.FromArgb(218, 34, 51);
            csBtn.Location = new Point(0, 331);
            csBtn.Name = "csBtn";
            csBtn.Size = new Size(133, 35);
            csBtn.TabIndex = 5;
            csBtn.Text = "Consulta";
            csBtn.TextAlign = ContentAlignment.MiddleLeft;
            csBtn.UseVisualStyleBackColor = true;
            csBtn.Click += csBtn_Click;
            // 
            // cadastroSubMenu
            // 
            cadastroSubMenu.BackColor = Color.FromArgb(23, 23, 23);
            cadastroSubMenu.Controls.Add(cdUser);
            cadastroSubMenu.Controls.Add(cdAssist);
            cadastroSubMenu.Controls.Add(cdOrder);
            cadastroSubMenu.Controls.Add(cdRecei);
            cadastroSubMenu.Controls.Add(cdSupplier);
            cadastroSubMenu.Controls.Add(cdAssemblies);
            cadastroSubMenu.Controls.Add(cdMaterials);
            cadastroSubMenu.Dock = DockStyle.Top;
            cadastroSubMenu.Location = new Point(0, 85);
            cadastroSubMenu.Name = "cadastroSubMenu";
            cadastroSubMenu.Size = new Size(133, 246);
            cadastroSubMenu.TabIndex = 4;
            // 
            // cdUser
            // 
            cdUser.Dock = DockStyle.Top;
            cdUser.FlatAppearance.BorderSize = 0;
            cdUser.FlatStyle = FlatStyle.Flat;
            cdUser.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cdUser.ForeColor = Color.FromArgb(218, 34, 51);
            cdUser.Location = new Point(0, 210);
            cdUser.Name = "cdUser";
            cdUser.Padding = new Padding(20, 0, 0, 0);
            cdUser.Size = new Size(133, 35);
            cdUser.TabIndex = 6;
            cdUser.Text = "Usuário";
            cdUser.TextAlign = ContentAlignment.MiddleLeft;
            cdUser.UseVisualStyleBackColor = true;
            cdUser.Click += cdUser_Click;
            // 
            // cdAssist
            // 
            cdAssist.Dock = DockStyle.Top;
            cdAssist.FlatAppearance.BorderSize = 0;
            cdAssist.FlatStyle = FlatStyle.Flat;
            cdAssist.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cdAssist.ForeColor = Color.FromArgb(218, 34, 51);
            cdAssist.Location = new Point(0, 175);
            cdAssist.Name = "cdAssist";
            cdAssist.Padding = new Padding(20, 0, 0, 0);
            cdAssist.Size = new Size(133, 35);
            cdAssist.TabIndex = 5;
            cdAssist.Text = "Assistência";
            cdAssist.TextAlign = ContentAlignment.MiddleLeft;
            cdAssist.UseVisualStyleBackColor = true;
            cdAssist.Click += cdAssist_Click;
            // 
            // cdOrder
            // 
            cdOrder.Dock = DockStyle.Top;
            cdOrder.FlatAppearance.BorderSize = 0;
            cdOrder.FlatStyle = FlatStyle.Flat;
            cdOrder.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cdOrder.ForeColor = Color.FromArgb(218, 34, 51);
            cdOrder.Location = new Point(0, 140);
            cdOrder.Name = "cdOrder";
            cdOrder.Padding = new Padding(20, 0, 0, 0);
            cdOrder.Size = new Size(133, 35);
            cdOrder.TabIndex = 4;
            cdOrder.Text = "Compras";
            cdOrder.TextAlign = ContentAlignment.MiddleLeft;
            cdOrder.UseVisualStyleBackColor = true;
            cdOrder.Click += cdOrder_Click;
            // 
            // cdRecei
            // 
            cdRecei.Dock = DockStyle.Top;
            cdRecei.FlatAppearance.BorderSize = 0;
            cdRecei.FlatStyle = FlatStyle.Flat;
            cdRecei.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cdRecei.ForeColor = Color.FromArgb(100, 0, 17);
            cdRecei.Location = new Point(0, 105);
            cdRecei.Name = "cdRecei";
            cdRecei.Padding = new Padding(20, 0, 0, 0);
            cdRecei.Size = new Size(133, 35);
            cdRecei.TabIndex = 3;
            cdRecei.Text = "Recebimento";
            cdRecei.TextAlign = ContentAlignment.MiddleLeft;
            cdRecei.UseVisualStyleBackColor = true;
            // 
            // cdSupplier
            // 
            cdSupplier.Dock = DockStyle.Top;
            cdSupplier.FlatAppearance.BorderSize = 0;
            cdSupplier.FlatStyle = FlatStyle.Flat;
            cdSupplier.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cdSupplier.ForeColor = Color.FromArgb(218, 34, 51);
            cdSupplier.Location = new Point(0, 70);
            cdSupplier.Name = "cdSupplier";
            cdSupplier.Padding = new Padding(20, 0, 0, 0);
            cdSupplier.Size = new Size(133, 35);
            cdSupplier.TabIndex = 2;
            cdSupplier.Text = "Fornecedor";
            cdSupplier.TextAlign = ContentAlignment.MiddleLeft;
            cdSupplier.UseVisualStyleBackColor = true;
            cdSupplier.Click += cdSupplier_Click;
            // 
            // cdAssemblies
            // 
            cdAssemblies.Dock = DockStyle.Top;
            cdAssemblies.FlatAppearance.BorderSize = 0;
            cdAssemblies.FlatStyle = FlatStyle.Flat;
            cdAssemblies.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cdAssemblies.ForeColor = Color.FromArgb(218, 34, 51);
            cdAssemblies.Location = new Point(0, 35);
            cdAssemblies.Name = "cdAssemblies";
            cdAssemblies.Padding = new Padding(20, 0, 0, 0);
            cdAssemblies.Size = new Size(133, 35);
            cdAssemblies.TabIndex = 1;
            cdAssemblies.Text = "Montagens";
            cdAssemblies.TextAlign = ContentAlignment.MiddleLeft;
            cdAssemblies.UseVisualStyleBackColor = true;
            cdAssemblies.Click += cdAssemblies_Click;
            // 
            // cdMaterials
            // 
            cdMaterials.Dock = DockStyle.Top;
            cdMaterials.FlatAppearance.BorderSize = 0;
            cdMaterials.FlatStyle = FlatStyle.Flat;
            cdMaterials.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cdMaterials.ForeColor = Color.FromArgb(218, 34, 51);
            cdMaterials.Location = new Point(0, 0);
            cdMaterials.Name = "cdMaterials";
            cdMaterials.Padding = new Padding(20, 0, 0, 0);
            cdMaterials.Size = new Size(133, 35);
            cdMaterials.TabIndex = 0;
            cdMaterials.Text = "Materiais";
            cdMaterials.TextAlign = ContentAlignment.MiddleLeft;
            cdMaterials.UseVisualStyleBackColor = true;
            cdMaterials.Click += cdMaterials_Click;
            // 
            // cdBtn
            // 
            cdBtn.Dock = DockStyle.Top;
            cdBtn.FlatAppearance.BorderSize = 0;
            cdBtn.FlatStyle = FlatStyle.Flat;
            cdBtn.Font = new Font("Bahnschrift SemiLight SemiConde", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cdBtn.ForeColor = Color.FromArgb(218, 34, 51);
            cdBtn.Location = new Point(0, 50);
            cdBtn.Name = "cdBtn";
            cdBtn.Size = new Size(133, 35);
            cdBtn.TabIndex = 3;
            cdBtn.Text = "Cadastro";
            cdBtn.TextAlign = ContentAlignment.MiddleLeft;
            cdBtn.UseVisualStyleBackColor = true;
            cdBtn.Click += cdBtn_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(218, 34, 51);
            button2.Location = new Point(895, 12);
            button2.Name = "button2";
            button2.Size = new Size(43, 23);
            button2.TabIndex = 15;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnClose_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(218, 34, 51);
            button3.Location = new Point(846, 12);
            button3.Name = "button3";
            button3.Size = new Size(43, 23);
            button3.TabIndex = 16;
            button3.Text = "▢";
            button3.UseVisualStyleBackColor = true;
            button3.Click += BtnMaximize_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(218, 34, 51);
            button4.Location = new Point(797, 12);
            button4.Name = "button4";
            button4.Size = new Size(43, 23);
            button4.TabIndex = 17;
            button4.Text = "_";
            button4.UseVisualStyleBackColor = true;
            button4.Click += BntMinimize_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(950, 600);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pbFoto);
            Controls.Add(outStatus);
            Controls.Add(button1);
            Controls.Add(outUser);
            Controls.Add(panelSideMenu);
            Controls.Add(label3);
            Controls.Add(pnLogin);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(setOffline);
            Controls.Add(setOnline);
            Controls.Add(setLunch);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(950, 600);
            Name = "mainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StepUp v0.1";
            Load += mainForm_Load;
            pnLogin.ResumeLayout(false);
            pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSideMenu.ResumeLayout(false);
            ajudaSubMenu.ResumeLayout(false);
            ferramentasSubMenu.ResumeLayout(false);
            pedidosSubMenu.ResumeLayout(false);
            consultaSubMenu.ResumeLayout(false);
            cadastroSubMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnLogin;
        private Label label1;
        private MonthCalendar monthCalendar1;
        private Button setOffline;
        private Button setLunch;
        private Button setOnline;
        private Label outStatus;
        private Label outUser;
        private Label label3;
        private Label label2;
        private PictureBox pbFoto;
        private Label label4;
        private Label label5;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panelSideMenu;
        private Panel cadastroSubMenu;
        private Button cdOrder;
        private Button cdRecei;
        private Button cdSupplier;
        private Button cdAssemblies;
        private Button cdMaterials;
        private Button cdBtn;
        private Panel consultaSubMenu;
        private Button csList;
        private Button csAssemblies;
        private Button csMaterials;
        private Button csBtn;
        private Button cdUser;
        private Button cdAssist;
        private Panel ferramentasSubMenu;
        private Button toConn;
        private Button toNote;
        private Button toCalc;
        private Button toBtn;
        private Button fbBtn;
        private Panel pedidosSubMenu;
        private Button pdSep;
        private Button pdOrder;
        private Button pdBtn;
        private Button alBtn;
        private Button csUser;
        private Button csAssist;
        private Button csOrder;
        private Button csRecei;
        private Button csSupplier;
        private Panel ajudaSubMenu;
        private Button ajAbout;
        private Button ajNew;
        private Button ajBtn;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}