using BLL;
using DAL;
using Microsoft.Win32;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace GUI
{
    public partial class frmViewMTGList : Form
    {
        public static int code;
        public string foto = "";
        public int[] cod = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public float[] qtd = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        DataTable tabela = new DataTable();

        public frmViewMTGList()
        {
            InitializeComponent();
        }

        private void frmViewMTGList_Load(object sender, EventArgs e)
        {
            tabela.Columns.Add("Quantidade", typeof(float));
            tabela.Columns.Add("Index", typeof(int));
            tabela.Columns.Add("Código", typeof(String));
            tabela.Columns.Add("Fornecedor", typeof(String));
            tabela.Columns.Add("Grupo", typeof(String));
            tabela.Columns.Add("Descrição", typeof(String));
            tabela.Columns.Add("Unidade", typeof(String));
            tabela.Columns.Add("Preço", typeof(float));
            tabela.Columns.Add("Data", typeof(DateTime));
            tabela.Columns.Add("Inventário", typeof(float));
            tabela.Columns.Add("Foto", typeof(Image));
            tabela.Columns.Add("Mínimo", typeof(float));
            tabela.Columns.Add("Alerta", typeof(int));

            loadCodes();
            insertProd(0);
            insertProd(1);
            insertProd(2);
            insertProd(3);
            insertProd(4);
            insertProd(5);
            insertProd(6);
            insertProd(7);
            insertProd(8);
            insertProd(9);
            insertProd(10);
            insertProd(11);
            insertProd(12);
            insertProd(13);
            insertProd(14);
            insertProd(15);
            insertProd(16);
            insertProd(17);
            insertProd(18);
            insertProd(19);
            insertProd(20);
            insertProd(21);
            insertProd(22);
            insertProd(23);
            insertProd(24);

            dgvData.DataSource = tabela;
            dgvData.Columns[0].HeaderText = "Quantidade";
            dgvData.Columns[1].HeaderText = "Index";
            dgvData.Columns[2].HeaderText = "Código";
            dgvData.Columns[3].HeaderText = "Fornecedor";
            dgvData.Columns[4].HeaderText = "Grupo";
            dgvData.Columns[5].HeaderText = "Descrição";
            dgvData.Columns[6].HeaderText = "Unidade";
            dgvData.Columns[7].HeaderText = "Preço";
            dgvData.Columns[8].HeaderText = "Data";
            dgvData.Columns[9].HeaderText = "Inventário";
            dgvData.Columns[10].HeaderText = "Foto";
            dgvData.Columns[11].HeaderText = "Mínimo";
            dgvData.Columns[12].HeaderText = "Alerta";

            dgvData.Columns["Index"].Visible = false;
            dgvData.Columns["Fornecedor"].Visible = false;
            dgvData.Columns["Grupo"].Visible = false;
            dgvData.Columns["Data"].Visible = false;
            dgvData.Columns["Inventário"].Visible = false;
            dgvData.Columns["Foto"].Visible = false;
            dgvData.Columns["Mínimo"].Visible = false;
            dgvData.Columns["Alerta"].Visible = false;
        }

        private void loadCodes()
        {
            ModeloMontagem modelo = new ModeloMontagem();
            SqlCommand cmd = new SqlCommand();
            DALConnection cx = new DALConnection(DataConnection.stringConnection);
            BLLProducts bll = new BLLProducts(cx);
            cmd.Connection = cx.ObjectConnection;
            cmd.CommandText = "select * from montagem where mtg_cod =" + code.ToString();
            cx.Connect();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();

                outCode.Text = Convert.ToString(registro["mtg_code"]);
                outDesc.Text = Convert.ToString(registro["mtg_desc"]);

                cod[0] = Convert.ToInt32(registro["mtg_item0"]);
                qtd[0] = (float)(Convert.ToDouble(registro["mtg_qtd0"]));
                cod[1] = Convert.ToInt32(registro["mtg_item1"]);
                qtd[1] = (float)(Convert.ToDouble(registro["mtg_qtd1"]));
                cod[2] = Convert.ToInt32(registro["mtg_item2"]);
                qtd[2] = (float)(Convert.ToDouble(registro["mtg_qtd2"]));
                cod[3] = Convert.ToInt32(registro["mtg_item3"]);
                qtd[3] = (float)(Convert.ToDouble(registro["mtg_qtd3"]));
                cod[4] = Convert.ToInt32(registro["mtg_item4"]);
                qtd[4] = (float)(Convert.ToDouble(registro["mtg_qtd4"]));
                cod[5] = Convert.ToInt32(registro["mtg_item5"]);
                qtd[5] = (float)(Convert.ToDouble(registro["mtg_qtd5"]));
                cod[6] = Convert.ToInt32(registro["mtg_item6"]);
                qtd[6] = (float)(Convert.ToDouble(registro["mtg_qtd6"]));
                cod[7] = Convert.ToInt32(registro["mtg_item7"]);
                qtd[7] = (float)(Convert.ToDouble(registro["mtg_qtd7"]));
                cod[8] = Convert.ToInt32(registro["mtg_item8"]);
                qtd[8] = (float)(Convert.ToDouble(registro["mtg_qtd8"]));
                cod[9] = Convert.ToInt32(registro["mtg_item9"]);
                qtd[9] = (float)(Convert.ToDouble(registro["mtg_qtd9"]));
                cod[10] = Convert.ToInt32(registro["mtg_item10"]);
                qtd[10] = (float)(Convert.ToDouble(registro["mtg_qtd10"]));
                cod[11] = Convert.ToInt32(registro["mtg_item11"]);
                qtd[11] = (float)(Convert.ToDouble(registro["mtg_qtd11"]));
                cod[12] = Convert.ToInt32(registro["mtg_item12"]);
                qtd[12] = (float)(Convert.ToDouble(registro["mtg_qtd12"]));
                cod[13] = Convert.ToInt32(registro["mtg_item13"]);
                qtd[13] = (float)(Convert.ToDouble(registro["mtg_qtd13"]));
                cod[14] = Convert.ToInt32(registro["mtg_item14"]);
                qtd[14] = (float)(Convert.ToDouble(registro["mtg_qtd14"]));
                cod[15] = Convert.ToInt32(registro["mtg_item15"]);
                qtd[15] = (float)(Convert.ToDouble(registro["mtg_qtd15"]));
                cod[16] = Convert.ToInt32(registro["mtg_item16"]);
                qtd[16] = (float)(Convert.ToDouble(registro["mtg_qtd16"]));
                cod[17] = Convert.ToInt32(registro["mtg_item17"]);
                qtd[17] = (float)(Convert.ToDouble(registro["mtg_qtd17"]));
                cod[18] = Convert.ToInt32(registro["mtg_item18"]);
                qtd[18] = (float)(Convert.ToDouble(registro["mtg_qtd18"]));
                cod[19] = Convert.ToInt32(registro["mtg_item19"]);
                qtd[19] = (float)(Convert.ToDouble(registro["mtg_qtd19"]));
                cod[20] = Convert.ToInt32(registro["mtg_item20"]);
                qtd[20] = (float)(Convert.ToDouble(registro["mtg_qtd20"]));
                cod[21] = Convert.ToInt32(registro["mtg_item21"]);
                qtd[21] = (float)(Convert.ToDouble(registro["mtg_qtd21"]));
                cod[22] = Convert.ToInt32(registro["mtg_item22"]);
                qtd[22] = (float)(Convert.ToDouble(registro["mtg_qtd22"]));
                cod[23] = Convert.ToInt32(registro["mtg_item23"]);
                qtd[23] = (float)(Convert.ToDouble(registro["mtg_qtd23"]));
                cod[24] = Convert.ToInt32(registro["mtg_item24"]);
                qtd[24] = (float)(Convert.ToDouble(registro["mtg_qtd24"]));

                try
                {
                    modelo.mtgFoto = (byte[])registro["mtg_foto"];
                    MemoryStream ms = new MemoryStream(modelo.mtgFoto);
                    pbFoto.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";

                }
                catch { }
            }
            cx.Disconnect();
        }

        private void insertProd(int valor)
        {
            DataRow line = tabela.NewRow();
            SqlCommand cmd = new SqlCommand();
            DALConnection cx = new DALConnection(DataConnection.stringConnection);
            cmd.Connection = cx.ObjectConnection;
            cmd.CommandText = "select * from produtos where prod_cod =" + cod[valor].ToString();
            cx.Connect();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                line["Quantidade"] = Convert.ToString(qtd[valor]);
                line["Index"] = Convert.ToString(registro["prod_cod"]);
                line["Código"] = Convert.ToString(registro["prod_code"]);
                line["Fornecedor"] = Convert.ToString(registro["prod_for"]);
                line["Grupo"] = Convert.ToString(registro["prod_group"]);
                line["Descrição"] = Convert.ToString(registro["prod_desc"]);
                line["Unidade"] = Convert.ToString(registro["prod_unity"]);
                line["Preço"] = Convert.ToString(registro["prod_price"]);
                line["Data"] = Convert.ToString(registro["prod_day"]);
                line["Inventário"] = Convert.ToString(registro["prod_inv"]);
                line["Mínimo"] = Convert.ToString(registro["prod_min"]);
                line["Alerta"] = Convert.ToString(registro["prod_alert"]);
                tabela.Rows.Add(line);
            }
            cx.Disconnect();
        }
    }
}
