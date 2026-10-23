using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace GUI
{
    public partial class mainForm : Form
    {
        public static int code;
        public String? nivel;
        public string foto = "";
        public string name = "Não Logado";

        public mainForm()
        {
            InitializeComponent();
            menuBar();
        }

        private void menuBar()
        {
            cadastroSubMenu.Visible = false;
            consultaSubMenu.Visible = false;
            pedidosSubMenu.Visible = false;
            ferramentasSubMenu.Visible = false;
            ajudaSubMenu.Visible = false;
        }

        void updateForm()
        {
            ModeloUser modelo = new();
            SqlCommand cmd = new();
            DALConnection cx = new(DataConnection.stringConnection);
            BLLProducts bll = new(cx);
            cmd.Connection = cx.ObjectConnection;
            cmd.CommandText = "select * from users where us_cod =" + code.ToString();
            cx.Connect();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                outUser.Text = Convert.ToString(registro["us_name"]);
                nivel = Convert.ToString(registro["us_nivel"]);
                outStatus.Text = Convert.ToString(registro["us_estado"]);
                try
                {
                    modelo.usFoto = (byte[])registro["us_foto"];
                    MemoryStream ms = new(modelo.usFoto);
                    pbFoto.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";

                }
                catch { }
            }
            cx.Disconnect();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            updateForm();
            if (code != 0)
            {
                DALConnection cx = new(DataConnection.stringConnection);
                BLLProducts bll = new(cx);
                ModeloUser modelo = bll.CarregaModeloUser(code);
                outUser.Text = modelo.usName;
                outStatus.Text = modelo.usEstado;

                try
                {
                    MemoryStream ms = new(modelo.usFoto);
                    pbFoto.Image = Image.FromStream(ms);
                    foto = "Foto Original";
                }
                catch { }
            }
        }

        private void hideSubMenu(Panel? subMenu = null)
        {
            if ((cadastroSubMenu.Visible == true) && (subMenu != cadastroSubMenu))
            {
                cadastroSubMenu.Visible = false;
            }
            if ((consultaSubMenu.Visible == true) && (subMenu != consultaSubMenu))
            {
                consultaSubMenu.Visible = false;
            }
            if ((pedidosSubMenu.Visible == true) && (subMenu != pedidosSubMenu))
            {
                pedidosSubMenu.Visible = false;
            }
            if ((ferramentasSubMenu.Visible == true) && (subMenu != ferramentasSubMenu))
            {
                ferramentasSubMenu.Visible = false;
            }
            if ((ajudaSubMenu.Visible == true) && (subMenu != ajudaSubMenu))
            {
                ajudaSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            subMenu.Visible = subMenu.Visible == false ? true : false;
        }

        private void cdBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu(cadastroSubMenu);
            cadastroSubMenu.Visible = cadastroSubMenu.Visible == false ? true : false;
        }

        #region Cadastrar
        private void cdMaterials_Click(object sender, EventArgs e)
        {
            frmCadastrarProdutos f = new();
            f.ShowDialog();
            f.Dispose();
        }

        private void cdAssemblies_Click(object sender, EventArgs e)
        {
            frmCadastrarMontagem f = new();
            f.ShowDialog();
            f.Dispose();
        }

        private void cdSupplier_Click(object sender, EventArgs e)
        {
            frmCadastrarFornecedor f = new();
            f.ShowDialog();
            f.Dispose();
        }

        private void cdOrder_Click(object sender, EventArgs e)
        {
            frmCadastrarCompra f = new();
            f.ShowDialog();
            f.Dispose();
        }

        private void cdAssist_Click(object sender, EventArgs e)
        {
            frmCadastrarAssistencia f = new();
            f.ShowDialog();
            f.Dispose();
        }

        private void cdUser_Click(object sender, EventArgs e)
        {
            frmCadastrarUsuario f = new();
            f.ShowDialog();
            f.Dispose();
        }

        #endregion

        private void csBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu(consultaSubMenu);
            consultaSubMenu.Visible = consultaSubMenu.Visible == false ? true : false;
        }

        #region Consulta
        private void csMaterials_Click(object sender, EventArgs e)
        {
            frmConsultaProdutos f = new();
            f.ShowDialog();
            f.Dispose();
        }

        private void csAssemblies_Click(object sender, EventArgs e)
        {
            frmConsultaMontagem.function = "View";
            frmConsultaMontagem f = new();
            f.ShowDialog();
            f.Dispose();
        }

        private void csList_Click(object sender, EventArgs e)
        {
            frmConsultaComplexa f = new();
            f.ShowDialog();
            f.Dispose();
        }

        private void csSupplier_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new();
            f.ShowDialog();
            f.Dispose();
        }

        private void csOrder_Click(object sender, EventArgs e)
        {
            frmConsultaCompras f = new();
            f.ShowDialog();
            f.Dispose();
        }

        private void csAssist_Click(object sender, EventArgs e)
        {
            frmConsultaAssistencia f = new();
            f.ShowDialog();
            f.Dispose();
        }

        private void csUser_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario.function = "View";
            frmConsultaUsuario f = new();
            f.ShowDialog();
            f.Dispose();
        }

        #endregion

        private void pdBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu(pedidosSubMenu);
            pedidosSubMenu.Visible = pedidosSubMenu.Visible == false ? true : false;
        }

        #region Pedidos
        #endregion

        private void toBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu(ferramentasSubMenu);
            ferramentasSubMenu.Visible = ferramentasSubMenu.Visible == false ? true : false;
        }

        #region Ferramentas
        private void toCalc_Click(object sender, EventArgs e)
        {
            Process ExternalProcess = new();
            ExternalProcess.StartInfo.FileName = "Calc.exe";
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            ExternalProcess.Start();
            ExternalProcess.WaitForExit();
        }

        private void toNote_Click(object sender, EventArgs e)
        {
            Process ExternalProcess = new();
            ExternalProcess.StartInfo.FileName = "Notepad.exe";
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            ExternalProcess.Start();
            ExternalProcess.WaitForExit();
        }

        #endregion

        private void ajBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu(ajudaSubMenu);
            ajudaSubMenu.Visible = ajudaSubMenu.Visible == false ? true : false;
        }

        #region Ajuda
        private void ajAbout_Click(object sender, EventArgs e)
        {
            frmAbout f = new();
            f.ShowDialog();
            f.Dispose();
        }

        #endregion

        private void alBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            frmAlmoxarifado f = new();
            f.ShowDialog();
            f.Dispose();
        }

        #region User Status
        private void setOnline_Click(object sender, EventArgs e)
        {
            DALConnection cx = new(DataConnection.stringConnection);
            SqlCommand cmd = new();
            cmd.Connection = cx.ObjectConnection;
            cmd.CommandText = "update users set us_estado = (@us_estado) where us_cod = (@us_cod)";
            cmd.Parameters.AddWithValue("@us_cod", code);
            cmd.Parameters.AddWithValue("@us_estado", "Online");
            cx.Connect();
            cmd.ExecuteNonQuery();
            cx.Disconnect();
            outStatus.Text = "Online";
            updateForm();
        }

        private void setLunch_Click(object sender, EventArgs e)
        {
            DALConnection cx = new(DataConnection.stringConnection);
            SqlCommand cmd = new();
            cmd.Connection = cx.ObjectConnection;
            cmd.CommandText = "update users set us_estado = (@us_estado) where us_cod = (@us_cod)";
            cmd.Parameters.AddWithValue("@us_cod", code);
            cmd.Parameters.AddWithValue("@us_estado", "Almoço");
            cx.Connect();
            cmd.ExecuteNonQuery();
            cx.Disconnect();
            outStatus.Text = "Almoço";
            updateForm();
        }

        private void setOffline_Click(object sender, EventArgs e)
        {
            DALConnection cx = new(DataConnection.stringConnection);
            SqlCommand cmd = new();
            cmd.Connection = cx.ObjectConnection;
            cmd.CommandText = "update users set us_estado = (@us_estado) where us_cod = (@us_cod)";
            cmd.Parameters.AddWithValue("@us_cod", code);
            cmd.Parameters.AddWithValue("@us_estado", "Offline");
            cx.Connect();
            cmd.ExecuteNonQuery();
            cx.Disconnect();
            outStatus.Text = "Offline";
            updateForm();
        }

        #endregion

        private void webSite_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new()
            {
                FileName = "https://interlasermaquinas.com.br",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void BntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
