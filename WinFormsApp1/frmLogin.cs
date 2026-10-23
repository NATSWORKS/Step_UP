using BLL;
using DAL;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace GUI
{
    public partial class frmLogin : Form
    {
        public int code;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DALConnection cx = new DALConnection(DataConnection.stringConnection);
            string sql = string.Format("select * from users where us_login='{0}'", inLog.Text);
            cx.Connect();
            SqlCommand cmd = new SqlCommand(sql, cx.ObjectConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if ((reader["us_senha"].ToString()) == inPass.Text)
                    {
                        this.Hide();
                        var mainForm = new mainForm();
                        mainForm.code = Convert.ToInt32(reader["us_cod"]);
                        mainForm.Closed += (s, args) => this.Close();
                        mainForm.Show();
                    }
                    else
                    {
                        erro.Visible = true;
                    }
                }
            }
            else
            {
                erro.Visible = true;
            }
            cx.Disconnect();
        }
    }
}
