using BLL;
using DAL;
using Microsoft.Win32;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmViewComplete : Form
    {
        public static int code;
        public string foto = "";
        public int[] cod = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public float[] qtd = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        DataTable tabela = new DataTable();

        public frmViewComplete()
        {
            InitializeComponent();
        }

        private void frmViewComplete_Load(object sender, EventArgs e)
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
            tabela.Columns.Add("Mínimo", typeof(float));
            tabela.Columns.Add("Alerta", typeof(int));
            tabela.Columns.Add("Total peça", typeof(float));
            tabela.Columns.Add("Foto", typeof(Image));

            loadCodes();
            insertItem(0);
            insertItem(1);
            insertItem(2);
            insertItem(3);
            insertItem(4);
            insertItem(5);
            insertItem(6);
            insertItem(7);
            insertItem(8);
            insertItem(9);
            insertItem(10);
            insertItem(11);
            insertItem(12);
            insertItem(13);
            insertItem(14);
            insertItem(15);
            insertItem(16);
            insertItem(17);
            insertItem(18);
            insertItem(19);
            insertItem(20);
            insertItem(21);
            insertItem(22);
            insertItem(23);
            insertItem(24);

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
            dgvData.Columns[10].HeaderText = "Mínimo";
            dgvData.Columns[11].HeaderText = "Alerta";
            dgvData.Columns[12].HeaderText = "Total peça";
            dgvData.Columns[13].HeaderText = "Foto";

            analiseTable();
            givePrice();
            outSum.Text = "R$  " + Convert.ToString(tabela.AsEnumerable().Sum(row => row.Field<float>("Total peça")));

            dgvData.Columns["Quantidade"].Width = 50;
            dgvData.Columns["Código"].Width = 50;
            dgvData.Columns["Descrição"].Width = 130;
            dgvData.Columns["Unidade"].Width = 30;
            dgvData.Columns["Preço"].Width = 20;
            dgvData.Columns["Foto"].Width = 80;
            dgvData.Columns["Total peça"].Width = 50;

            dgvData.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.Columns["Código"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.Columns["Unidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvData.Columns["Preço"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvData.Columns["Total peça"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Stretch();


            dgvData.Columns["Código"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns["Descrição"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns["Unidade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns["Preço"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns["Total peça"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvData.Columns["Index"].Visible = false;
            dgvData.Columns["Fornecedor"].Visible = false;
            dgvData.Columns["Grupo"].Visible = false;
            dgvData.Columns["Data"].Visible = false;
            dgvData.Columns["Inventário"].Visible = false;
            dgvData.Columns["Mínimo"].Visible = false;
            dgvData.Columns["Alerta"].Visible = false;
            if (cb1.Checked == false)
            {
                dgvData.Columns["Foto"].Visible = false;
            }
        }

        private void analiseTable()
        {
            int number = dgvData.Rows.Count;

            for (int n = 0; n < number; n++)
            {
                for (int m = n + 1; m < number; m++)
                {
                    if (Convert.ToInt32(dgvData.Rows[n].Cells["Index"].Value) == Convert.ToInt32(dgvData.Rows[m].Cells["Index"].Value))
                    {
                        (dgvData.Rows[n].Cells["Quantidade"].Value) = Convert.ToString(((float)Convert.ToDecimal(dgvData.Rows[m].Cells["Quantidade"].Value)) + ((float)Convert.ToDecimal(dgvData.Rows[n].Cells["Quantidade"].Value)));
                        dgvData.Rows.RemoveAt(m);
                        number--;
                        m--;
                    }
                }
            }
        }

        private void givePrice()
        {
            for (int n = 0; n < dgvData.Rows.Count; n++)
            {
                dgvData.Rows[n].Cells["Total peça"].Value = Convert.ToString(((float)Convert.ToDecimal(dgvData.Rows[n].Cells["Quantidade"].Value)) * ((float)Convert.ToDecimal(dgvData.Rows[n].Cells["Preço"].Value)));
            }
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

        private void insertItem(int valor)
        {
            String? code = getCode(cod[valor]);
            SqlCommand cmd = new SqlCommand();
            DALConnection cx = new DALConnection(DataConnection.stringConnection);
            cmd.Connection = cx.ObjectConnection;
            cmd.CommandText = string.Format("select * from montagem where mtg_code ='{0}'", code);
            cx.Connect();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                insertPMtg(code);
            }
            else
            {
                insertProd(valor);
            }
            cx.Disconnect();
        }

        private void insertPMtg(String? valor)
        {
            int[] codi = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            float[] qtdi = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            DataRow line = tabela.NewRow();
            SqlCommand cmd = new SqlCommand();
            DALConnection cx = new DALConnection(DataConnection.stringConnection);
            cmd.Connection = cx.ObjectConnection;
            cmd.CommandText = string.Format("select * from montagem where mtg_code ='{0}'", valor);
            cx.Connect();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                codi[0] = Convert.ToInt32(registro["mtg_item0"]);
                qtdi[0] = (float)(Convert.ToDouble(registro["mtg_qtd0"]));
                codi[1] = Convert.ToInt32(registro["mtg_item1"]);
                qtdi[1] = (float)(Convert.ToDouble(registro["mtg_qtd1"]));
                codi[2] = Convert.ToInt32(registro["mtg_item2"]);
                qtdi[2] = (float)(Convert.ToDouble(registro["mtg_qtd2"]));
                codi[3] = Convert.ToInt32(registro["mtg_item3"]);
                qtdi[3] = (float)(Convert.ToDouble(registro["mtg_qtd3"]));
                codi[4] = Convert.ToInt32(registro["mtg_item4"]);
                qtdi[4] = (float)(Convert.ToDouble(registro["mtg_qtd4"]));
                codi[5] = Convert.ToInt32(registro["mtg_item5"]);
                qtdi[5] = (float)(Convert.ToDouble(registro["mtg_qtd5"]));
                codi[6] = Convert.ToInt32(registro["mtg_item6"]);
                qtdi[6] = (float)(Convert.ToDouble(registro["mtg_qtd6"]));
                codi[7] = Convert.ToInt32(registro["mtg_item7"]);
                qtdi[7] = (float)(Convert.ToDouble(registro["mtg_qtd7"]));
                codi[8] = Convert.ToInt32(registro["mtg_item8"]);
                qtdi[8] = (float)(Convert.ToDouble(registro["mtg_qtd8"]));
                codi[9] = Convert.ToInt32(registro["mtg_item9"]);
                qtdi[9] = (float)(Convert.ToDouble(registro["mtg_qtd9"]));
                codi[10] = Convert.ToInt32(registro["mtg_item10"]);
                qtdi[10] = (float)(Convert.ToDouble(registro["mtg_qtd10"]));
                codi[11] = Convert.ToInt32(registro["mtg_item11"]);
                qtdi[11] = (float)(Convert.ToDouble(registro["mtg_qtd11"]));
                codi[12] = Convert.ToInt32(registro["mtg_item12"]);
                qtdi[12] = (float)(Convert.ToDouble(registro["mtg_qtd12"]));
                codi[13] = Convert.ToInt32(registro["mtg_item13"]);
                qtdi[13] = (float)(Convert.ToDouble(registro["mtg_qtd13"]));
                codi[14] = Convert.ToInt32(registro["mtg_item14"]);
                qtdi[14] = (float)(Convert.ToDouble(registro["mtg_qtd14"]));
                codi[15] = Convert.ToInt32(registro["mtg_item15"]);
                qtdi[15] = (float)(Convert.ToDouble(registro["mtg_qtd15"]));
                codi[16] = Convert.ToInt32(registro["mtg_item16"]);
                qtdi[16] = (float)(Convert.ToDouble(registro["mtg_qtd16"]));
                codi[17] = Convert.ToInt32(registro["mtg_item17"]);
                qtdi[17] = (float)(Convert.ToDouble(registro["mtg_qtd17"]));
                codi[18] = Convert.ToInt32(registro["mtg_item18"]);
                qtdi[18] = (float)(Convert.ToDouble(registro["mtg_qtd18"]));
                codi[19] = Convert.ToInt32(registro["mtg_item19"]);
                qtdi[19] = (float)(Convert.ToDouble(registro["mtg_qtd19"]));
                codi[20] = Convert.ToInt32(registro["mtg_item20"]);
                qtdi[20] = (float)(Convert.ToDouble(registro["mtg_qtd20"]));
                codi[21] = Convert.ToInt32(registro["mtg_item21"]);
                qtdi[21] = (float)(Convert.ToDouble(registro["mtg_qtd21"]));
                codi[22] = Convert.ToInt32(registro["mtg_item22"]);
                qtdi[22] = (float)(Convert.ToDouble(registro["mtg_qtd22"]));
                codi[23] = Convert.ToInt32(registro["mtg_item23"]);
                qtdi[23] = (float)(Convert.ToDouble(registro["mtg_qtd23"]));
                codi[24] = Convert.ToInt32(registro["mtg_item24"]);
                qtdi[24] = (float)(Convert.ToDouble(registro["mtg_qtd24"]));
                insertItemi(codi[0], qtdi[0]);
                insertItemi(codi[1], qtdi[1]);
                insertItemi(codi[2], qtdi[2]);
                insertItemi(codi[3], qtdi[3]);
                insertItemi(codi[4], qtdi[4]);
                insertItemi(codi[5], qtdi[5]);
                insertItemi(codi[6], qtdi[6]);
                insertItemi(codi[7], qtdi[7]);
                insertItemi(codi[8], qtdi[8]);
                insertItemi(codi[9], qtdi[9]);
                insertItemi(codi[10], qtdi[10]);
                insertItemi(codi[11], qtdi[11]);
                insertItemi(codi[12], qtdi[12]);
                insertItemi(codi[13], qtdi[13]);
                insertItemi(codi[14], qtdi[14]);
                insertItemi(codi[15], qtdi[15]);
                insertItemi(codi[16], qtdi[16]);
                insertItemi(codi[17], qtdi[17]);
                insertItemi(codi[18], qtdi[18]);
                insertItemi(codi[19], qtdi[19]);
                insertItemi(codi[20], qtdi[20]);
                insertItemi(codi[21], qtdi[21]);
                insertItemi(codi[22], qtdi[22]);
                insertItemi(codi[23], qtdi[23]);
                insertItemi(codi[24], qtdi[24]);
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
                try
                {
                    MemoryStream ms = new MemoryStream((byte[])registro["prod_foto"]);
                    line["Foto"] = Image.FromStream(ms);
                }
                catch { }
                tabela.Rows.Add(line);
            }
            registro.Close();
            cx.Disconnect();
        }

        private void insertItemi(int codi, float valori)
        {
            String? code = getCode(codi);
            SqlCommand cmd = new SqlCommand();
            DALConnection cx = new DALConnection(DataConnection.stringConnection);
            cmd.Connection = cx.ObjectConnection;
            cmd.CommandText = string.Format("select * from montagem where mtg_code ='{0}'", code);
            cx.Connect();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                insertPMtgi(code);
            }
            else
            {
                insertProdi(codi, valori);
            }
            cx.Disconnect();
        }

        private void insertPMtgi(String? valor)
        {
            int[] codi = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            float[] qtdi = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            DataRow line = tabela.NewRow();
            SqlCommand cmd = new SqlCommand();
            DALConnection cx = new DALConnection(DataConnection.stringConnection);
            cmd.Connection = cx.ObjectConnection;
            cmd.CommandText = string.Format("select * from montagem where mtg_code ='{0}'", valor);
            cx.Connect();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                codi[0] = Convert.ToInt32(registro["mtg_item0"]);
                qtdi[0] = (float)(Convert.ToDouble(registro["mtg_qtd0"]));
                codi[1] = Convert.ToInt32(registro["mtg_item1"]);
                qtdi[1] = (float)(Convert.ToDouble(registro["mtg_qtd1"]));
                codi[2] = Convert.ToInt32(registro["mtg_item2"]);
                qtdi[2] = (float)(Convert.ToDouble(registro["mtg_qtd2"]));
                codi[3] = Convert.ToInt32(registro["mtg_item3"]);
                qtdi[3] = (float)(Convert.ToDouble(registro["mtg_qtd3"]));
                codi[4] = Convert.ToInt32(registro["mtg_item4"]);
                qtdi[4] = (float)(Convert.ToDouble(registro["mtg_qtd4"]));
                codi[5] = Convert.ToInt32(registro["mtg_item5"]);
                qtdi[5] = (float)(Convert.ToDouble(registro["mtg_qtd5"]));
                codi[6] = Convert.ToInt32(registro["mtg_item6"]);
                qtdi[6] = (float)(Convert.ToDouble(registro["mtg_qtd6"]));
                codi[7] = Convert.ToInt32(registro["mtg_item7"]);
                qtdi[7] = (float)(Convert.ToDouble(registro["mtg_qtd7"]));
                codi[8] = Convert.ToInt32(registro["mtg_item8"]);
                qtdi[8] = (float)(Convert.ToDouble(registro["mtg_qtd8"]));
                codi[9] = Convert.ToInt32(registro["mtg_item9"]);
                qtdi[9] = (float)(Convert.ToDouble(registro["mtg_qtd9"]));
                codi[10] = Convert.ToInt32(registro["mtg_item10"]);
                qtdi[10] = (float)(Convert.ToDouble(registro["mtg_qtd10"]));
                codi[11] = Convert.ToInt32(registro["mtg_item11"]);
                qtdi[11] = (float)(Convert.ToDouble(registro["mtg_qtd11"]));
                codi[12] = Convert.ToInt32(registro["mtg_item12"]);
                qtdi[12] = (float)(Convert.ToDouble(registro["mtg_qtd12"]));
                codi[13] = Convert.ToInt32(registro["mtg_item13"]);
                qtdi[13] = (float)(Convert.ToDouble(registro["mtg_qtd13"]));
                codi[14] = Convert.ToInt32(registro["mtg_item14"]);
                qtdi[14] = (float)(Convert.ToDouble(registro["mtg_qtd14"]));
                codi[15] = Convert.ToInt32(registro["mtg_item15"]);
                qtdi[15] = (float)(Convert.ToDouble(registro["mtg_qtd15"]));
                codi[16] = Convert.ToInt32(registro["mtg_item16"]);
                qtdi[16] = (float)(Convert.ToDouble(registro["mtg_qtd16"]));
                codi[17] = Convert.ToInt32(registro["mtg_item17"]);
                qtdi[17] = (float)(Convert.ToDouble(registro["mtg_qtd17"]));
                codi[18] = Convert.ToInt32(registro["mtg_item18"]);
                qtdi[18] = (float)(Convert.ToDouble(registro["mtg_qtd18"]));
                codi[19] = Convert.ToInt32(registro["mtg_item19"]);
                qtdi[19] = (float)(Convert.ToDouble(registro["mtg_qtd19"]));
                codi[20] = Convert.ToInt32(registro["mtg_item20"]);
                qtdi[20] = (float)(Convert.ToDouble(registro["mtg_qtd20"]));
                codi[21] = Convert.ToInt32(registro["mtg_item21"]);
                qtdi[21] = (float)(Convert.ToDouble(registro["mtg_qtd21"]));
                codi[22] = Convert.ToInt32(registro["mtg_item22"]);
                qtdi[22] = (float)(Convert.ToDouble(registro["mtg_qtd22"]));
                codi[23] = Convert.ToInt32(registro["mtg_item23"]);
                qtdi[23] = (float)(Convert.ToDouble(registro["mtg_qtd23"]));
                codi[24] = Convert.ToInt32(registro["mtg_item24"]);
                qtdi[24] = (float)(Convert.ToDouble(registro["mtg_qtd24"]));
                insertProdi(codi[0], qtdi[0]);
                insertProdi(codi[1], qtdi[1]);
                insertProdi(codi[2], qtdi[2]);
                insertProdi(codi[3], qtdi[3]);
                insertProdi(codi[4], qtdi[4]);
                insertProdi(codi[5], qtdi[5]);
                insertProdi(codi[6], qtdi[6]);
                insertProdi(codi[7], qtdi[7]);
                insertProdi(codi[8], qtdi[8]);
                insertProdi(codi[9], qtdi[9]);
                insertProdi(codi[10], qtdi[10]);
                insertProdi(codi[11], qtdi[11]);
                insertProdi(codi[12], qtdi[12]);
                insertProdi(codi[13], qtdi[13]);
                insertProdi(codi[14], qtdi[14]);
                insertProdi(codi[15], qtdi[15]);
                insertProdi(codi[16], qtdi[16]);
                insertProdi(codi[17], qtdi[17]);
                insertProdi(codi[18], qtdi[18]);
                insertProdi(codi[19], qtdi[19]);
                insertProdi(codi[20], qtdi[20]);
                insertProdi(codi[21], qtdi[21]);
                insertProdi(codi[22], qtdi[22]);
                insertProdi(codi[23], qtdi[23]);
                insertProdi(codi[24], qtdi[24]);
            }
            cx.Disconnect();
        }

        private void insertProdi(int codi, float valori)
        {
            DataRow line = tabela.NewRow();
            SqlCommand cmd = new SqlCommand();
            DALConnection cx = new DALConnection(DataConnection.stringConnection);
            cmd.Connection = cx.ObjectConnection;
            cmd.CommandText = "select * from produtos where prod_cod =" + codi.ToString();
            cx.Connect();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                line["Quantidade"] = Convert.ToString(valori);
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
                try
                {
                    MemoryStream ms = new MemoryStream((byte[])registro["prod_foto"]);
                    line["Foto"] = Image.FromStream(ms);
                }
                catch { }
                tabela.Rows.Add(line);
            }
            registro.Close();
            cx.Disconnect();
        }

        public string? getCode(int x)
        {
            String? cd = "";
            DALConnection cx = new DALConnection(DataConnection.stringConnection);
            string sql = string.Format("select * from produtos where prod_cod='{0}'", x);
            cx.Connect();
            SqlCommand cmd = new SqlCommand(sql, cx.ObjectConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                cd = (reader["prod_code"].ToString());
            }
            cx.Disconnect();
            return cd;
        }

        private void Stretch()
        {
            for (int i = 0; i < dgvData.Columns.Count; i++)
            {
                if (dgvData.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgvData.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            }
        }

        private void dgvData_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //new ToolTip().Show("Nats", this, Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y, 1000);
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1.Checked == false)
            {
                dgvData.Columns["Foto"].Visible = false;
            }
            else
            {
                dgvData.Columns["Foto"].Visible = true;
            }
            dgvData.Refresh();
        }

        private void dgvData_Sorted(object sender, EventArgs e)
        {
            dgvData.Columns["Foto"].Visible = false;
            dgvData.Refresh();
            if (cb1.Checked == true)
            {
                dgvData.Columns["Foto"].Visible = true;
            }

        }
    }
}
