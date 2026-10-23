using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;
using System.Xml.Linq;

namespace GUI
{
    public partial class frmQuickView : Form
    {
        public static int code;
        public string foto = "";

        public frmQuickView()
        {
            InitializeComponent();
        }

        private void frmQuickView_Load(object sender, EventArgs e)
        {
            ModeloUser modelo = new ModeloUser();
            SqlCommand cmd = new SqlCommand();
            DALConnection cx = new DALConnection(DataConnection.stringConnection);
            BLLProducts bll = new BLLProducts(cx);
            cmd.Connection = cx.ObjectConnection;
            cmd.CommandText = "select * from users where us_cod =" + code.ToString();
            cx.Connect();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                outUser.Text = Convert.ToString(registro["us_name"]);
                outNivel.Text = Convert.ToString(registro["us_nivel"]);
                outArea.Text = Convert.ToString(registro["us_area"]);
                outStatus.Text = Convert.ToString(registro["us_estado"]);
                try
                {
                    modelo.usFoto = (byte[])registro["us_foto"];
                    MemoryStream ms = new MemoryStream(modelo.usFoto);
                    pbFoto.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";

                }
                catch { }
            }
            cx.Disconnect();
        }
    }
}
