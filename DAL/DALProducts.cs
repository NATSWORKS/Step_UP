//-----NATSWORKS-----\\
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALProducts
    {
        public DALConnection connection;

        public DALProducts(DALConnection cx)
        {
            this.connection = cx;
        }

        #region Produtos
        public void Include(ModeloProdutos modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "insert into produtos(prod_code,prod_for,prod_group,prod_desc," +
            "prod_unity,prod_price,prod_day,prod_inv,prod_foto,prod_min) values (@prod_code,@prod_for,@prod_group,@prod_desc," +
            "@prod_unity,@prod_price,@prod_day,@prod_inv,@prod_foto,@prod_min); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@prod_code", modelo.prodCode);
            cmd.Parameters.AddWithValue("@prod_for", modelo.prodFor);
            cmd.Parameters.AddWithValue("@prod_group", modelo.prodGroup);
            cmd.Parameters.AddWithValue("@prod_desc", modelo.prodDesc);
            cmd.Parameters.AddWithValue("@prod_unity", modelo.prodUnity);
            cmd.Parameters.AddWithValue("@prod_price", modelo.prodPrice);
            cmd.Parameters.AddWithValue("@prod_day", modelo.prodDay);
            cmd.Parameters.AddWithValue("@prod_inv", modelo.prodInv);
            cmd.Parameters.AddWithValue("@prod_min", modelo.prodMin);
            cmd.Parameters.Add("@prod_foto", System.Data.SqlDbType.Image);
            if (modelo.ProFoto == null)
            {
                cmd.Parameters["@prod_foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@prod_foto"].Value = modelo.ProFoto;
            }
            
            connection.Connect();
            modelo.prodCod = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Disconnect();
        }

        public void Change(ModeloProdutos modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "update produtos set prod_code = (@prod_code),prod_for = (@prod_for), " +
            "prod_group = (@prod_group),prod_desc = (@prod_desc),prod_unity = (@prod_unity),prod_price = (@prod_price)," +
            "prod_day = (@prod_day),prod_inv = (@prod_inv), prod_foto = (@prod_foto),prod_min = (@prod_min) where prod_cod = (@prod_cod)";
            cmd.Parameters.AddWithValue("@prod_cod", modelo.prodCod);
            cmd.Parameters.AddWithValue("@prod_code", modelo.prodCode);
            cmd.Parameters.AddWithValue("@prod_for", modelo.prodFor);
            cmd.Parameters.AddWithValue("@prod_group", modelo.prodGroup);
            cmd.Parameters.AddWithValue("@prod_desc", modelo.prodDesc);
            cmd.Parameters.AddWithValue("@prod_unity", modelo.prodUnity);
            cmd.Parameters.AddWithValue("@prod_price", modelo.prodPrice);
            cmd.Parameters.AddWithValue("@prod_day", modelo.prodDay);
            cmd.Parameters.AddWithValue("@prod_inv", modelo.prodInv);
            cmd.Parameters.AddWithValue("@prod_min", modelo.prodMin);
            cmd.Parameters.Add("@prod_foto", System.Data.SqlDbType.Image);
            if (modelo.ProFoto == null)
            {
                cmd.Parameters["@prod_foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@prod_foto"].Value = modelo.ProFoto;
            }
            connection.Connect();
            cmd.ExecuteNonQuery();
            connection.Disconnect();
        }

        public void Change(ModeloProdutos modelo, Boolean transacao)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "update produtos set prod_code = (@prod_code),prod_for = (@prod_for), " +
            "prod_group = (@prod_group),prod_desc = (@prod_desc),prod_unity = (@prod_unity),prod_price = (@prod_price)," +
            "prod_day = (@prod_day),prod_inv = (@prod_inv), prod_foto = (@prod_foto),prod_min = (@prod_min) where prod_cod = (@prod_cod)";
            cmd.Parameters.AddWithValue("@prod_cod", modelo.prodCod);
            cmd.Parameters.AddWithValue("@prod_code", modelo.prodCode);
            cmd.Parameters.AddWithValue("@prod_for", modelo.prodFor);
            cmd.Parameters.AddWithValue("@prod_group", modelo.prodGroup);
            cmd.Parameters.AddWithValue("@prod_desc", modelo.prodDesc);
            cmd.Parameters.AddWithValue("@prod_unity", modelo.prodUnity);
            cmd.Parameters.AddWithValue("@prod_price", modelo.prodPrice);
            cmd.Parameters.AddWithValue("@prod_day", modelo.prodDay);
            cmd.Parameters.AddWithValue("@prod_inv", modelo.prodInv);
            cmd.Parameters.AddWithValue("@prod_min", modelo.prodMin);
            cmd.Parameters.Add("@prod_foto", System.Data.SqlDbType.Image);
            if (modelo.ProFoto == null)
            {
                cmd.Parameters["@prod_foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@prod_foto"].Value = modelo.ProFoto;
            }
            if (transacao)
            {
                cmd.Transaction = connection.ObjetoTransacao;
                cmd.ExecuteNonQuery();
            }
            else
            {
                connection.Connect();
                cmd.ExecuteNonQuery();
                connection.Disconnect();
            }
        }

        public void Delete(int code)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "delete from produtos where (prod_cod) = (@prod_cod)";
            cmd.Parameters.AddWithValue("@prod_cod", code);
            connection.Connect();
            cmd.ExecuteNonQuery();
            connection.Disconnect();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from produtos where prod_code like '%" +
                valor + "%'", connection.StringConnection);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarFornecedor(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from produtos where prod_for like '%" +
                valor + "%'", connection.StringConnection);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarGrupo(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from produtos where prod_group like '%" +
                valor + "%'", connection.StringConnection);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarDescricao(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from produtos where prod_desc like '%" +
                valor + "%'", connection.StringConnection);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloProdutos CarregaModeloCategoria(int codigo)
        {
            DALConnection cx = new DALConnection(DataConnection.stringConnection);
            ModeloProdutos modelo = new ModeloProdutos();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "select * from produtos where prod_cod =" + codigo.ToString();
            connection.Connect();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.prodCod = Convert.ToInt32(registro["prod_cod"]);
                modelo.prodCode = Convert.ToString(registro["prod_code"]);
                modelo.prodFor = Convert.ToString(registro["prod_for"]);
                modelo.prodGroup = Convert.ToString(registro["prod_group"]);
                modelo.prodDesc = Convert.ToString(registro["prod_desc"]);
                modelo.prodUnity = Convert.ToString(registro["prod_unity"]);
                modelo.prodPrice = (float)(Convert.ToDouble(registro["prod_price"]));
                modelo.prodDay = ((DateTime)registro["prod_day"]);
                modelo.prodInv = (float)(Convert.ToDouble(registro["prod_inv"]));
                modelo.prodMin = (float)(Convert.ToDouble(registro["prod_min"]));
                modelo.prodAlert = Convert.ToBoolean(registro["prod_alert"]);
                try
                {
                    modelo.ProFoto = (byte[])registro["prod_foto"];

                }
                catch { }
            }
            connection.Disconnect();
            return modelo;
        }

        public ModeloProdutos CarregaModeloCategoria(int codigo, Boolean transacao)
        {
            ModeloProdutos? modelo = new ModeloProdutos();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "select * from produtos where prod_cod = " + codigo.ToString();
            cmd.Parameters.AddWithValue("@prod_cod", codigo);
            connection.Connect();
            if (transacao == false)
            {
                connection.Connect();
            }
            else
            {
                cmd.Transaction = connection.ObjetoTransacao;
            }
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {

                registro.Read();
                modelo.prodCod = Convert.ToInt32(registro["prod_cod"]);
                modelo.prodCode = Convert.ToString(registro["prod_code"]);
                modelo.prodFor = Convert.ToString(registro["prod_for"]);
                modelo.prodGroup = Convert.ToString(registro["prod_group"]);
                modelo.prodDesc = Convert.ToString(registro["prod_desc"]);
                modelo.prodUnity = Convert.ToString(registro["prod_unity"]);
                modelo.prodPrice = (float)(Convert.ToDouble(registro["prod_price"]));
                modelo.prodDay = ((DateTime)registro["prod_day"]);
                modelo.prodInv = (float)(Convert.ToDouble(registro["prod_inv"]));
                modelo.prodMin = (float)(Convert.ToDouble(registro["prod_min"]));
                modelo.prodAlert = Convert.ToBoolean(registro["prod_alert"]);
                try
                {
                    modelo.ProFoto = (byte[])registro["prod_foto"];
                }
                catch { }
            }
            registro.Close();
            //connection.Disconnect();
            if (transacao == false) connection.Disconnect();
            return modelo;
        }

        #endregion

        # region Fornecedor
        public void IncludeFornecedor(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "insert into fornecedor (for_nome,for_rsocial,for_cnpj," +
            "for_cep,for_endereco,for_bairro,for_fone,for_cel,for_email,for_endnumero,for_cidade,for_estado,for_cont) values (@for_nome," +
            "@for_rsocial,@for_cnpj,@for_cep,@for_endereco,@for_bairro,@for_fone,@for_cel,@for_email,@for_endnumero," +
            "@for_cidade,@for_estado,@for_cont); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@for_nome", modelo.forNome);
            cmd.Parameters.AddWithValue("@for_rsocial", modelo.forRsocial);
            cmd.Parameters.AddWithValue("@for_cnpj", modelo.forCNPJ);
            cmd.Parameters.AddWithValue("@for_cep", modelo.forCEP);
            cmd.Parameters.AddWithValue("@for_endereco", modelo.forEnd);
            cmd.Parameters.AddWithValue("@for_bairro", modelo.forBairro);
            cmd.Parameters.AddWithValue("@for_fone", modelo.forFone);
            cmd.Parameters.AddWithValue("@for_cel", modelo.forCel);
            cmd.Parameters.AddWithValue("@for_email", modelo.forEmail);
            cmd.Parameters.AddWithValue("@for_endnumero", modelo.forNumero);
            cmd.Parameters.AddWithValue("@for_cidade", modelo.forCidade);
            cmd.Parameters.AddWithValue("@for_estado", modelo.forEstado);
            cmd.Parameters.AddWithValue("@for_cont", modelo.forContato);
            connection.Connect();
            modelo.forCod = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Disconnect();
        }

        public void ChangeFornecedor(ModeloFornecedor modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "update fornecedor set for_nome = (@for_nome), " +
            "for_rsocial = (@for_rsocial), for_cnpj = (@for_cnpj), for_cep = (@for_cep), for_endereco = (@for_endereco)," +
            "for_bairro = (@for_bairro), for_fone = (@for_fone), for_cel = (@for_cel), for_endnumero = (@for_endnumero), " +
            "for_email = (@for_email), for_cidade = (@for_cidade), for_estado = (@for_estado), for_cont = (@for_cont) where for_cod = (@for_cod)";
            cmd.Parameters.AddWithValue("@for_cod", modelo.forCod);
            cmd.Parameters.AddWithValue("@for_nome", modelo.forNome);
            cmd.Parameters.AddWithValue("@for_rsocial", modelo.forRsocial);
            cmd.Parameters.AddWithValue("@for_cnpj", modelo.forCNPJ);
            cmd.Parameters.AddWithValue("@for_cep", modelo.forCEP) ;
            cmd.Parameters.AddWithValue("@for_endereco", modelo.forEnd) ;
            cmd.Parameters.AddWithValue("@for_bairro", modelo.forBairro) ;
            cmd.Parameters.AddWithValue("@for_fone", modelo.forFone) ;
            cmd.Parameters.AddWithValue("@for_cel", modelo.forCel) ;
            cmd.Parameters.AddWithValue("@for_email", modelo.forEmail) ;
            cmd.Parameters.AddWithValue("@for_endnumero", modelo.forNumero) ;
            cmd.Parameters.AddWithValue("@for_cidade", modelo.forCidade) ;
            cmd.Parameters.AddWithValue("@for_estado", modelo.forEstado) ;
            cmd.Parameters.AddWithValue("@for_cont", modelo.forContato);
            connection.Connect();
            cmd.ExecuteNonQuery();
            connection.Disconnect();
        }

        public void DeleteFornecedor(int code)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "delete from fornecedor where (for_cod) = (@for_cod)";
            cmd.Parameters.AddWithValue("@for_cod", code);
            connection.Connect();
            cmd.ExecuteNonQuery();
            connection.Disconnect();
        }

        public DataTable LocalizarForn(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from fornecedor where for_cod like '%" +
                valor + "%'", connection.StringConnection);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "select * from fornecedor where for_cod =" + codigo.ToString();
            connection.Connect();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.forCod = Convert.ToInt32(registro["for_cod"]);
                modelo.forNome = Convert.ToString(registro["for_nome"]);
                modelo.forRsocial = Convert.ToString(registro["for_rsocial"]);
                modelo.forCNPJ = Convert.ToString(registro["for_cnpj"]);
                modelo.forCEP = Convert.ToString(registro["for_cep"]);
                modelo.forEnd = Convert.ToString(registro["for_endereco"]);
                modelo.forBairro = Convert.ToString(registro["for_bairro"]);
                modelo.forFone = Convert.ToString(registro["for_fone"]);
                modelo.forCel = Convert.ToString(registro["for_cel"]);
                modelo.forEmail = Convert.ToString(registro["for_email"]);
                modelo.forNumero = Convert.ToString(registro["for_endnumero"]);
                modelo.forCidade = Convert.ToString(registro["for_cidade"]);
                modelo.forEstado = Convert.ToString(registro["for_estado"]);
                modelo.forContato = Convert.ToString(registro["for_cont"]);
            }
            connection.Disconnect();
            return modelo;
        }

        #endregion

        #region Usuário
        public void IncludeUser(ModeloUser modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "insert into users(us_login,us_senha,us_name,us_nivel,us_area,us_estado,us_foto)" +
            "values (@us_login, @us_senha, @us_name,@us_nivel, @us_area, @us_estado, @us_foto); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@us_login", modelo.usLogin);
            cmd.Parameters.AddWithValue("@us_senha", modelo.usSenha);
            cmd.Parameters.AddWithValue("@us_name", modelo.usName);
            cmd.Parameters.AddWithValue("@us_nivel", modelo.usNivel);
            cmd.Parameters.AddWithValue("@us_area", modelo.usArea);
            cmd.Parameters.AddWithValue("@us_estado", "Offline");
            cmd.Parameters.Add("@us_foto", System.Data.SqlDbType.Image);
            if (modelo.usFoto == null)
            {
                cmd.Parameters["@us_foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@us_foto"].Value = modelo.usFoto;
            }
            connection.Connect();
            modelo.usCod = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Disconnect();
        }

        public void ChangeUser(ModeloUser modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "update users set us_login = (@us_login),us_senha = (@us_senha),us_name = (@us_name), " +
            "us_nivel = (@us_nivel),us_area = (@us_area),us_estado = (@us_estado),us_foto = (@us_foto) where us_cod = (@us_cod)";
            cmd.Parameters.AddWithValue("@us_cod", modelo.usCod);
            cmd.Parameters.AddWithValue("@us_login", modelo.usLogin);
            cmd.Parameters.AddWithValue("@us_senha", modelo.usSenha);
            cmd.Parameters.AddWithValue("@us_name", modelo.usName);
            cmd.Parameters.AddWithValue("@us_nivel", modelo.usNivel);
            cmd.Parameters.AddWithValue("@us_area", modelo.usArea);
            cmd.Parameters.AddWithValue("@us_estado", "Offline");
            cmd.Parameters.Add("@us_foto", System.Data.SqlDbType.Image);
            if (modelo.usFoto == null)
            {
                cmd.Parameters["@us_foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@us_foto"].Value = modelo.usFoto;
            }
            connection.Connect();
            cmd.ExecuteNonQuery();
            connection.Disconnect();
        }

        public void ChangeUser(ModeloUser modelo, Boolean transacao)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "update users set us_login = (@us_login),us_senha = (@us_senha),us_name = (@us_name), " +
            "us_nivel = (@us_nivel),us_area = (@us_area),us_estado = (@us_estado),us_foto = (@us_foto) where us_cod = (@us_cod)";
            cmd.Parameters.AddWithValue("@us_cod", modelo.usCod);
            cmd.Parameters.AddWithValue("@us_login", modelo.usLogin);
            cmd.Parameters.AddWithValue("@us_senha", modelo.usSenha);
            cmd.Parameters.AddWithValue("@us_name", modelo.usName);
            cmd.Parameters.AddWithValue("@us_nivel", modelo.usNivel);
            cmd.Parameters.AddWithValue("@us_area", modelo.usArea);
            cmd.Parameters.AddWithValue("@us_estado", modelo.usEstado);
            cmd.Parameters.Add("@us_foto", System.Data.SqlDbType.Image);
            if (modelo.usFoto == null)
            {
                cmd.Parameters["@us_foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@us_foto"].Value = modelo.usFoto;
            }
            if (transacao)
            {
                cmd.Transaction = connection.ObjetoTransacao;
                cmd.ExecuteNonQuery();
            }
            else
            {
                connection.Connect();
                cmd.ExecuteNonQuery();
                connection.Disconnect();
            }
        }

        public void DeleteUser(int code)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "delete from users where (us_cod) = (@us_cod)";
            cmd.Parameters.AddWithValue("@us_cod", code);
            connection.Connect();
            cmd.ExecuteNonQuery();
            connection.Disconnect();
        }

        public DataTable LocalizarUser(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from users where us_name like '%" +
                valor + "%'", connection.StringConnection);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarUserLog(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from users where us_name like '%" + valor + "%'", connection.StringConnection);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloUser CarregaModeloUser(int codigo)
        {
            ModeloUser modelo = new ModeloUser();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "select * from users where us_cod =" + codigo.ToString();
            connection.Connect();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.usCod = Convert.ToInt32(registro["us_cod"]);
                modelo.usLogin = Convert.ToString(registro["us_login"]);
                modelo.usSenha = Convert.ToString(registro["us_senha"]);
                modelo.usName = Convert.ToString(registro["us_name"]);
                modelo.usNivel = Convert.ToString(registro["us_nivel"]);
                modelo.usArea = Convert.ToString(registro["us_area"]);
                modelo.usEstado = Convert.ToString(registro["us_estado"]);
                try
                {
                    modelo.usFoto = (byte[])registro["us_foto"];

                }
                catch { }
            }
            connection.Disconnect();
            return modelo;
        }

        public ModeloUser CarregaModeloUser(int codigo, Boolean transacao)
        {
            ModeloUser? modelo = new ModeloUser();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "select * from users where us_cod =" + codigo.ToString();
            cmd.Parameters.AddWithValue("@us_cod", codigo);
            connection.Connect();
            if (transacao == false)
            {
                connection.Connect();
            }
            else
            {
                cmd.Transaction = connection.ObjetoTransacao;
            }
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {

                registro.Read();
                modelo.usCod = Convert.ToInt32(registro["us_cod"]);
                modelo.usLogin = Convert.ToString(registro["us_login"]);
                modelo.usSenha = Convert.ToString(registro["us_senha"]);
                modelo.usName = Convert.ToString(registro["us_name"]);
                modelo.usNivel = Convert.ToString(registro["us_nivel"]);
                modelo.usArea = Convert.ToString(registro["us_area"]);
                modelo.usEstado = Convert.ToString(registro["us_estado"]);
                try
                {
                    modelo.usFoto = (byte[])registro["prod_foto"];
                }
                catch { }
            }
            registro.Close();
            //connection.Disconnect();
            if (transacao == false) connection.Disconnect();
            return modelo;
        }

        #endregion

        #region Compras
        public void IncludeCompra(ModeloCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "insert into compra (com_data,com_nfiscal,prod_cod,com_qtd," +
            "com_unity,com_total,for_cod,com_entrega,com_status) values (@com_data," +
            "@com_nfiscal,@prod_cod,@com_qtd,@com_unity,@com_total,@for_cod,@com_entrega,@com_status); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@com_data", modelo.comData);
            cmd.Parameters.AddWithValue("@com_nfiscal", modelo.comNfiscal);
            cmd.Parameters.AddWithValue("@prod_cod", modelo.prodCod);
            cmd.Parameters.AddWithValue("@com_qtd", modelo.comQtd);
            cmd.Parameters.AddWithValue("@com_unity", modelo.comUnity);
            cmd.Parameters.AddWithValue("@com_total", modelo.comTotal);
            cmd.Parameters.AddWithValue("@for_cod", modelo.forCod);
            cmd.Parameters.AddWithValue("@com_entrega", modelo.comEntrega);
            cmd.Parameters.AddWithValue("@com_status", modelo.comStatus);
            connection.Connect();
            modelo.comCod = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Disconnect();
        }

        public void ChangeCompra(ModeloCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "update compra set com_data = (@com_data), " +
            "com_nfiscal = (@com_nfiscal), prod_cod = (@prod_cod), com_qtd = (@com_qtd), com_unity = (@com_unity), com_total = (@com_total)," +
            "for_cod = (@for_cod), com_entrega = (@com_entrega), com_status = (@com_status) where com_cod = (@com_cod)";
            cmd.Parameters.AddWithValue("@com_cod", modelo.comCod);
            cmd.Parameters.AddWithValue("@com_data", modelo.comData);
            cmd.Parameters.AddWithValue("@com_nfiscal", modelo.comNfiscal);
            cmd.Parameters.AddWithValue("@prod_cod", modelo.prodCod);
            cmd.Parameters.AddWithValue("@com_qtd", modelo.comQtd);
            cmd.Parameters.AddWithValue("@com_unity", modelo.comUnity);
            cmd.Parameters.AddWithValue("@com_total", modelo.comTotal);
            cmd.Parameters.AddWithValue("@for_cod", modelo.forCod);
            cmd.Parameters.AddWithValue("@com_entrega", modelo.comEntrega);
            cmd.Parameters.AddWithValue("@com_status", modelo.comStatus);
            connection.Connect();
            cmd.ExecuteNonQuery();
            connection.Disconnect();
        }

        public void DeleteCompra(int code)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "delete from compra where (com_cod) = (@com_cod)";
            cmd.Parameters.AddWithValue("@com_cod", code);
            connection.Connect();
            cmd.ExecuteNonQuery();
            connection.Disconnect();
        }

        public DataTable LocalizarCompra(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from compra where for_cod like '%" +
                valor + "%'", connection.StringConnection);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            ModeloCompra modelo = new ModeloCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "select * from compra where com_cod =" + codigo.ToString();
            connection.Connect();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.comCod = Convert.ToInt32(registro["com_cod"]);
                modelo.comData = ((DateTime)registro["com_data"]);
                modelo.comNfiscal = Convert.ToInt32(registro["com_nfiscal"]);
                modelo.comQtd = Convert.ToInt32(registro["com_qtd"]);
                modelo.comUnity = Convert.ToString(registro["com_unity"]);
                modelo.comTotal = (float)(Convert.ToDouble(registro["com_total"]));
                modelo.comEntrega = Convert.ToString(registro["com_entrega"]);
                modelo.comStatus = Convert.ToString(registro["com_status"]);
            }
            connection.Disconnect();
            return modelo;
        }

        #endregion

        #region Assistência
        public void IncludeAssist(ModeloAssist modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "insert into assistencia (as_nome,as_cidade,as_estado," +
            "as_maquina,as_defeito,as_tecnico,as_day) values (@as_nome," +
            "@as_cidade,@as_estado,@as_maquina,@as_defeito,@as_tecnico,@as_day); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@as_nome", modelo.asNome);
            cmd.Parameters.AddWithValue("@as_cidade", modelo.asCidade);
            cmd.Parameters.AddWithValue("@as_estado", modelo.asEstado);
            cmd.Parameters.AddWithValue("@as_maquina", modelo.asMaquina);
            cmd.Parameters.AddWithValue("@as_defeito", modelo.asDefeito);
            cmd.Parameters.AddWithValue("@as_tecnico", modelo.asTecnico);
            cmd.Parameters.AddWithValue("@as_day", modelo.asDay);
            connection.Connect();
            modelo.asCod = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Disconnect();
        }

        public void ChangeAssist(ModeloAssist modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "update assistencia set as_nome = (@as_nome), " +
            "as_cidade = (@as_cidade), as_estado = (@as_estado), as_maquina = (@as_maquina), as_defeito = (@as_defeito)," +
            "as_tecnico = (@com_entrega), as_day = (@as_day) where as_cod = (@as_cod)";
            cmd.Parameters.AddWithValue("@as_cod", modelo.asCod);
            cmd.Parameters.AddWithValue("@as_nome", modelo.asNome);
            cmd.Parameters.AddWithValue("@as_cidade", modelo.asCidade);
            cmd.Parameters.AddWithValue("@as_estado", modelo.asEstado);
            cmd.Parameters.AddWithValue("@as_maquina", modelo.asMaquina);
            cmd.Parameters.AddWithValue("@as_defeito", modelo.asDefeito);
            cmd.Parameters.AddWithValue("@as_tecnico", modelo.asTecnico);
            connection.Connect();
            cmd.ExecuteNonQuery();
            connection.Disconnect();
        }

        public void DeleteAssist(int code)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "delete from assistencia where (as_cod) = (@as_cod)";
            cmd.Parameters.AddWithValue("@as_cod", code);
            connection.Connect();
            cmd.ExecuteNonQuery();
            connection.Disconnect();
        }

        public DataTable LocalizarAssist(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from assistencia where as_cod like '%" +
                valor + "%'", connection.StringConnection);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloAssist CarregaModeloAssist(int codigo)
        {
            ModeloAssist modelo = new ModeloAssist();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "select * from assistencia where as_cod =" + codigo.ToString();
            connection.Connect();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.asCod = Convert.ToInt32(registro["as_cod"]);
                modelo.asNome = Convert.ToString(registro["as_nome"]);
                modelo.asCidade = Convert.ToString(registro["as_cidade"]);
                modelo.asEstado = Convert.ToString(registro["as_estado"]);
                modelo.asMaquina = Convert.ToString(registro["as_maquina"]);
                modelo.asDefeito = Convert.ToString(registro["as_defeito"]);
                modelo.asTecnico = Convert.ToString(registro["as_tecnico"]);
                modelo.asDay = ((DateTime)registro["com_day"]);
            }
            connection.Disconnect();
            return modelo;
        }

        #endregion

        #region Montagem
        public void IncludeMontagem(ModeloMontagem modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "insert into montagem(mtg_code,mtg_desc,mtg_foto,mtg_item0,mtg_item1,mtg_item2,mtg_item3,mtg_item4,mtg_item5, " +
            "mtg_item6,mtg_item7,mtg_item8,mtg_item9,mtg_item10,mtg_item11,mtg_item12,mtg_item13,mtg_item14,mtg_item15,mtg_item16,mtg_item17, " +
            "mtg_item18,mtg_item19,mtg_item20,mtg_item21,mtg_item22,mtg_item23,mtg_item24,mtg_qtd0,mtg_qtd1,mtg_qtd2,mtg_qtd3,mtg_qtd4,mtg_qtd5," +
            "mtg_qtd6,mtg_qtd7,mtg_qtd8,mtg_qtd9,mtg_qtd10,mtg_qtd11,mtg_qtd12,mtg_qtd13,mtg_qtd14,mtg_qtd15,mtg_qtd16,mtg_qtd17,mtg_qtd18,mtg_qtd19," +
            "mtg_qtd20,mtg_qtd21,mtg_qtd22,mtg_qtd23,mtg_qtd24) values (@mtg_code,@mtg_desc,@mtg_foto,@mtg_item0,@mtg_item1,@mtg_item2,@mtg_item3," +
            "@mtg_item4,@mtg_item5,@mtg_item6,@mtg_item7,@mtg_item8,@mtg_item9,@mtg_item10,@mtg_item11,@mtg_item12,@mtg_item13,@mtg_item14," +
            "@mtg_item15,@mtg_item16,@mtg_item17,@mtg_item18,@mtg_item19,@mtg_item20,@mtg_item21,@mtg_item22,@mtg_item23,@mtg_item24,@mtg_qtd0," +
            "@mtg_qtd1,@mtg_qtd2,@mtg_qtd3,@mtg_qtd4,@mtg_qtd5,@mtg_qtd6,@mtg_qtd7,@mtg_qtd8,@mtg_qtd9,@mtg_qtd10,@mtg_qtd11,@mtg_qtd12,@mtg_qtd13,@mtg_qtd14," +
            "@mtg_qtd15,@mtg_qtd16,@mtg_qtd17,@mtg_qtd18,@mtg_qtd19,@mtg_qtd20,@mtg_qtd21,@mtg_qtd22,@mtg_qtd23,@mtg_qtd24); select @@IDENTITY;";

            cmd.Parameters.AddWithValue("@mtg_code", modelo.mtgCode);
            cmd.Parameters.AddWithValue("@mtg_desc", modelo.mtgDesc);
            cmd.Parameters.AddWithValue("@mtg_item0", modelo.mLsCod0);
            cmd.Parameters.AddWithValue("@mtg_item1", modelo.mLsCod1);
            cmd.Parameters.AddWithValue("@mtg_item2", modelo.mLsCod2);
            cmd.Parameters.AddWithValue("@mtg_item3", modelo.mLsCod3);
            cmd.Parameters.AddWithValue("@mtg_item4", modelo.mLsCod4);
            cmd.Parameters.AddWithValue("@mtg_item5", modelo.mLsCod5);
            cmd.Parameters.AddWithValue("@mtg_item6", modelo.mLsCod6);
            cmd.Parameters.AddWithValue("@mtg_item7", modelo.mLsCod7);
            cmd.Parameters.AddWithValue("@mtg_item8", modelo.mLsCod8);
            cmd.Parameters.AddWithValue("@mtg_item9", modelo.mLsCod9);
            cmd.Parameters.AddWithValue("@mtg_item10", modelo.mLsCod10);
            cmd.Parameters.AddWithValue("@mtg_item11", modelo.mLsCod11);
            cmd.Parameters.AddWithValue("@mtg_item12", modelo.mLsCod12);
            cmd.Parameters.AddWithValue("@mtg_item13", modelo.mLsCod13);
            cmd.Parameters.AddWithValue("@mtg_item14", modelo.mLsCod14);
            cmd.Parameters.AddWithValue("@mtg_item15", modelo.mLsCod15);
            cmd.Parameters.AddWithValue("@mtg_item16", modelo.mLsCod16);
            cmd.Parameters.AddWithValue("@mtg_item17", modelo.mLsCod17);
            cmd.Parameters.AddWithValue("@mtg_item18", modelo.mLsCod18);
            cmd.Parameters.AddWithValue("@mtg_item19", modelo.mLsCod19);
            cmd.Parameters.AddWithValue("@mtg_item20", modelo.mLsCod20);
            cmd.Parameters.AddWithValue("@mtg_item21", modelo.mLsCod21);
            cmd.Parameters.AddWithValue("@mtg_item22", modelo.mLsCod22);
            cmd.Parameters.AddWithValue("@mtg_item23", modelo.mLsCod23);
            cmd.Parameters.AddWithValue("@mtg_item24", modelo.mLsCod24);
            cmd.Parameters.AddWithValue("@mtg_qtd0", modelo.mLsQtd0);
            cmd.Parameters.AddWithValue("@mtg_qtd1", modelo.mLsQtd1);
            cmd.Parameters.AddWithValue("@mtg_qtd2", modelo.mLsQtd2);
            cmd.Parameters.AddWithValue("@mtg_qtd3", modelo.mLsQtd3);
            cmd.Parameters.AddWithValue("@mtg_qtd4", modelo.mLsQtd4);
            cmd.Parameters.AddWithValue("@mtg_qtd5", modelo.mLsQtd5);
            cmd.Parameters.AddWithValue("@mtg_qtd6", modelo.mLsQtd6);
            cmd.Parameters.AddWithValue("@mtg_qtd7", modelo.mLsQtd7);
            cmd.Parameters.AddWithValue("@mtg_qtd8", modelo.mLsQtd8);
            cmd.Parameters.AddWithValue("@mtg_qtd9", modelo.mLsQtd9);
            cmd.Parameters.AddWithValue("@mtg_qtd10", modelo.mLsQtd10);
            cmd.Parameters.AddWithValue("@mtg_qtd11", modelo.mLsQtd11);
            cmd.Parameters.AddWithValue("@mtg_qtd12", modelo.mLsQtd12);
            cmd.Parameters.AddWithValue("@mtg_qtd13", modelo.mLsQtd13);
            cmd.Parameters.AddWithValue("@mtg_qtd14", modelo.mLsQtd14);
            cmd.Parameters.AddWithValue("@mtg_qtd15", modelo.mLsQtd15);
            cmd.Parameters.AddWithValue("@mtg_qtd16", modelo.mLsQtd16);
            cmd.Parameters.AddWithValue("@mtg_qtd17", modelo.mLsQtd17);
            cmd.Parameters.AddWithValue("@mtg_qtd18", modelo.mLsQtd18);
            cmd.Parameters.AddWithValue("@mtg_qtd19", modelo.mLsQtd19);
            cmd.Parameters.AddWithValue("@mtg_qtd20", modelo.mLsQtd20);
            cmd.Parameters.AddWithValue("@mtg_qtd21", modelo.mLsQtd21);
            cmd.Parameters.AddWithValue("@mtg_qtd22", modelo.mLsQtd22);
            cmd.Parameters.AddWithValue("@mtg_qtd23", modelo.mLsQtd23);
            cmd.Parameters.AddWithValue("@mtg_qtd24", modelo.mLsQtd24);

            cmd.Parameters.Add("@mtg_foto", System.Data.SqlDbType.Image);
            if (modelo.mtgFoto == null)
            {
                cmd.Parameters["@mtg_foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@mtg_foto"].Value = modelo.mtgFoto;
            }
            connection.Connect();
            modelo.mtgCod = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Disconnect();
        }

        public void ChangeMontagem(ModeloMontagem modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "update montagem set mtg_code = (@mtg_code),mtg_desc = (@mtg_desc),mtg_item0 = (@mtg_item0),mtg_item1 = (@mtg_item1)," +
            "mtg_item2 = (@mtg_item2),mtg_item3 = (@mtg_item3),mtg_item4 = (@mtg_item4),mtg_item5 = (@mtg_item5),mtg_item6 = (@mtg_item6)," +
            "mtg_item7 = (@mtg_item7),mtg_item8 = (@mtg_item8),mtg_item9 = (@mtg_item9),mtg_item10 = (@mtg_item10),mtg_item11 = (@mtg_item11)," +
            "mtg_item12 = (@mtg_item12),mtg_item13 = (@mtg_item13),mtg_item14 = (@mtg_item14),mtg_item15 = (@mtg_item15),mtg_item16 = (@mtg_item16)," +
            "mtg_item17 = (@mtg_item17),mtg_item18 = (@mtg_item18),mtg_item19 = (@mtg_item19),mtg_item20 = (@mtg_item20),mtg_item21 = (@mtg_item21)," +
            "mtg_item22 = (@mtg_item22),mtg_item23 = (@mtg_item23),mtg_item24 = (@mtg_item24),mtg_qtd0 = (@mtg_qtd0),mtg_qtd1 = (@mtg_qtd1)," +
            "mtg_qtd2 = (@mtg_qtd2),mtg_qtd3 = (@mtg_qtd3),mtg_qtd4 = (@mtg_qtd4),mtg_qtd5 = (@mtg_qtd5),mtg_qtd6 = (@mtg_qtd6),mtg_qtd7 = (@mtg_qtd7)," +
            "mtg_qtd8 = (@mtg_qtd8),mtg_qtd9 = (@mtg_qtd9),mtg_qtd10 = (@mtg_qtd10),mtg_qtd11 = (@mtg_qtd11),mtg_qtd12 = (@mtg_qtd12),mtg_qtd13 = (@mtg_qtd13)," +
            "mtg_qtd14 = (@mtg_qtd14),mtg_qtd15 = (@mtg_qtd15),mtg_qtd16 = (@mtg_qtd16),mtg_qtd17 = (@mtg_qtd17),mtg_qtd18 = (@mtg_qtd18),mtg_qtd19 = (@mtg_qtd19)," +
            "mtg_qtd20 = (@mtg_qtd20),mtg_qtd21 = (@mtg_qtd21),mtg_qtd22 = (@mtg_qtd22),mtg_qtd23 = (@mtg_qtd23),mtg_qtd24 = (@mtg_qtd24)," +
            "mtg_foto = (@mtg_foto) where mtg_cod = (@mtg_cod)";
            cmd.Parameters.AddWithValue("@mtg_cod", modelo.mtgCod);
            cmd.Parameters.AddWithValue("@mtg_code", modelo.mtgCode);
            cmd.Parameters.AddWithValue("@mtg_desc", modelo.mtgDesc);
            cmd.Parameters.AddWithValue("@mtg_item0", modelo.mLsCod0);
            cmd.Parameters.AddWithValue("@mtg_item1", modelo.mLsCod1);
            cmd.Parameters.AddWithValue("@mtg_item2", modelo.mLsCod2);
            cmd.Parameters.AddWithValue("@mtg_item3", modelo.mLsCod3);
            cmd.Parameters.AddWithValue("@mtg_item4", modelo.mLsCod4);
            cmd.Parameters.AddWithValue("@mtg_item5", modelo.mLsCod5);
            cmd.Parameters.AddWithValue("@mtg_item6", modelo.mLsCod6);
            cmd.Parameters.AddWithValue("@mtg_item7", modelo.mLsCod7);
            cmd.Parameters.AddWithValue("@mtg_item8", modelo.mLsCod8);
            cmd.Parameters.AddWithValue("@mtg_item9", modelo.mLsCod9);
            cmd.Parameters.AddWithValue("@mtg_item10", modelo.mLsCod10);
            cmd.Parameters.AddWithValue("@mtg_item11", modelo.mLsCod11);
            cmd.Parameters.AddWithValue("@mtg_item12", modelo.mLsCod12);
            cmd.Parameters.AddWithValue("@mtg_item13", modelo.mLsCod13);
            cmd.Parameters.AddWithValue("@mtg_item14", modelo.mLsCod14);
            cmd.Parameters.AddWithValue("@mtg_item15", modelo.mLsCod15);
            cmd.Parameters.AddWithValue("@mtg_item16", modelo.mLsCod16);
            cmd.Parameters.AddWithValue("@mtg_item17", modelo.mLsCod17);
            cmd.Parameters.AddWithValue("@mtg_item18", modelo.mLsCod18);
            cmd.Parameters.AddWithValue("@mtg_item19", modelo.mLsCod19);
            cmd.Parameters.AddWithValue("@mtg_item20", modelo.mLsCod20);
            cmd.Parameters.AddWithValue("@mtg_item21", modelo.mLsCod21);
            cmd.Parameters.AddWithValue("@mtg_item22", modelo.mLsCod22);
            cmd.Parameters.AddWithValue("@mtg_item23", modelo.mLsCod23);
            cmd.Parameters.AddWithValue("@mtg_item24", modelo.mLsCod24);
            cmd.Parameters.AddWithValue("@mtg_qtd0", modelo.mLsQtd0);
            cmd.Parameters.AddWithValue("@mtg_qtd1", modelo.mLsQtd1);
            cmd.Parameters.AddWithValue("@mtg_qtd2", modelo.mLsQtd2);
            cmd.Parameters.AddWithValue("@mtg_qtd3", modelo.mLsQtd3);
            cmd.Parameters.AddWithValue("@mtg_qtd4", modelo.mLsQtd4);
            cmd.Parameters.AddWithValue("@mtg_qtd5", modelo.mLsQtd5);
            cmd.Parameters.AddWithValue("@mtg_qtd6", modelo.mLsQtd6);
            cmd.Parameters.AddWithValue("@mtg_qtd7", modelo.mLsQtd7);
            cmd.Parameters.AddWithValue("@mtg_qtd8", modelo.mLsQtd8);
            cmd.Parameters.AddWithValue("@mtg_qtd9", modelo.mLsQtd9);
            cmd.Parameters.AddWithValue("@mtg_qtd10", modelo.mLsQtd10);
            cmd.Parameters.AddWithValue("@mtg_qtd11", modelo.mLsQtd11);
            cmd.Parameters.AddWithValue("@mtg_qtd12", modelo.mLsQtd12);
            cmd.Parameters.AddWithValue("@mtg_qtd13", modelo.mLsQtd13);
            cmd.Parameters.AddWithValue("@mtg_qtd14", modelo.mLsQtd14);
            cmd.Parameters.AddWithValue("@mtg_qtd15", modelo.mLsQtd15);
            cmd.Parameters.AddWithValue("@mtg_qtd16", modelo.mLsQtd16);
            cmd.Parameters.AddWithValue("@mtg_qtd17", modelo.mLsQtd17);
            cmd.Parameters.AddWithValue("@mtg_qtd18", modelo.mLsQtd18);
            cmd.Parameters.AddWithValue("@mtg_qtd19", modelo.mLsQtd19);
            cmd.Parameters.AddWithValue("@mtg_qtd20", modelo.mLsQtd20);
            cmd.Parameters.AddWithValue("@mtg_qtd21", modelo.mLsQtd21);
            cmd.Parameters.AddWithValue("@mtg_qtd22", modelo.mLsQtd22);
            cmd.Parameters.AddWithValue("@mtg_qtd23", modelo.mLsQtd23);
            cmd.Parameters.AddWithValue("@mtg_qtd24", modelo.mLsQtd24);
            cmd.Parameters.Add("@mtg_foto", System.Data.SqlDbType.Image);
            if (modelo.mtgFoto == null)
            {
                cmd.Parameters["@mtg_foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@mtg_foto"].Value = modelo.mtgFoto;
            }
            connection.Connect();
            cmd.ExecuteNonQuery();
            connection.Disconnect();
        }

        public void ChangeMontagem(ModeloMontagem modelo, Boolean transacao)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "update montagem set mtg_code = (@mtg_code),mtg_desc = (@mtg_desc),mtg_item0 = (@mtg_item0),mtg_item1 = (@mtg_item1)," +
            "mtg_item2 = (@mtg_item2),mtg_item3 = (@mtg_item3),mtg_item4 = (@mtg_item4),mtg_item5 = (@mtg_item5),mtg_item6 = (@mtg_item6)," +
            "mtg_item7 = (@mtg_item7),mtg_item8 = (@mtg_item8),mtg_item9 = (@mtg_item9),mtg_item10 = (@mtg_item10),mtg_item11 = (@mtg_item11)," +
            "mtg_item12 = (@mtg_item12),mtg_item13 = (@mtg_item13),mtg_item14 = (@mtg_item14),mtg_item15 = (@mtg_item15),mtg_item16 = (@mtg_item16)," +
            "mtg_item17 = (@mtg_item17),mtg_item18 = (@mtg_item18),mtg_item19 = (@mtg_item19),mtg_item20 = (@mtg_item20),mtg_item21 = (@mtg_item21)," +
            "mtg_item22 = (@mtg_item22),mtg_item23 = (@mtg_item23),mtg_item24 = (@mtg_item24),mtg_qtd0 = (@mtg_qtd0),mtg_qtd1 = (@mtg_qtd1)," +
            "mtg_qtd2 = (@mtg_qtd2),mtg_qtd3 = (@mtg_qtd3),mtg_qtd4 = (@mtg_qtd4),mtg_qtd5 = (@mtg_qtd5),mtg_qtd6 = (@mtg_qtd6),mtg_qtd7 = (@mtg_qtd7)," +
            "mtg_qtd8 = (@mtg_qtd8),mtg_qtd9 = (@mtg_qtd9),mtg_qtd10 = (@mtg_qtd10),mtg_qtd11 = (@mtg_qtd11),mtg_qtd12 = (@mtg_qtd12),mtg_qtd13 = (@mtg_qtd13)," +
            "mtg_qtd14 = (@mtg_qtd14),mtg_qtd15 = (@mtg_qtd15),mtg_qtd16 = (@mtg_qtd16),mtg_qtd17 = (@mtg_qtd17),mtg_qtd18 = (@mtg_qtd18),mtg_qtd19 = (@mtg_qtd19)," +
            "mtg_qtd20 = (@mtg_qtd20),mtg_qtd21 = (@mtg_qtd21),mtg_qtd22 = (@mtg_qtd22),mtg_qtd23 = (@mtg_qtd23),mtg_qtd24 = (@mtg_qtd24)," +
            "mtg_foto = (@mtg_foto) where mtg_cod = (@mtg_cod)";
            cmd.Parameters.AddWithValue("@mtg_cod", modelo.mtgCod);
            cmd.Parameters.AddWithValue("@mtg_code", modelo.mtgCode);
            cmd.Parameters.AddWithValue("@mtg_desc", modelo.mtgDesc);
            cmd.Parameters.AddWithValue("@mtg_item0", modelo.mLsCod0);
            cmd.Parameters.AddWithValue("@mtg_item1", modelo.mLsCod1);
            cmd.Parameters.AddWithValue("@mtg_item2", modelo.mLsCod2);
            cmd.Parameters.AddWithValue("@mtg_item3", modelo.mLsCod3);
            cmd.Parameters.AddWithValue("@mtg_item4", modelo.mLsCod4);
            cmd.Parameters.AddWithValue("@mtg_item5", modelo.mLsCod5);
            cmd.Parameters.AddWithValue("@mtg_item6", modelo.mLsCod6);
            cmd.Parameters.AddWithValue("@mtg_item7", modelo.mLsCod7);
            cmd.Parameters.AddWithValue("@mtg_item8", modelo.mLsCod8);
            cmd.Parameters.AddWithValue("@mtg_item9", modelo.mLsCod9);
            cmd.Parameters.AddWithValue("@mtg_item10", modelo.mLsCod10);
            cmd.Parameters.AddWithValue("@mtg_item11", modelo.mLsCod11);
            cmd.Parameters.AddWithValue("@mtg_item12", modelo.mLsCod12);
            cmd.Parameters.AddWithValue("@mtg_item13", modelo.mLsCod13);
            cmd.Parameters.AddWithValue("@mtg_item14", modelo.mLsCod14);
            cmd.Parameters.AddWithValue("@mtg_item15", modelo.mLsCod15);
            cmd.Parameters.AddWithValue("@mtg_item16", modelo.mLsCod16);
            cmd.Parameters.AddWithValue("@mtg_item17", modelo.mLsCod17);
            cmd.Parameters.AddWithValue("@mtg_item18", modelo.mLsCod18);
            cmd.Parameters.AddWithValue("@mtg_item19", modelo.mLsCod19);
            cmd.Parameters.AddWithValue("@mtg_item20", modelo.mLsCod20);
            cmd.Parameters.AddWithValue("@mtg_item21", modelo.mLsCod21);
            cmd.Parameters.AddWithValue("@mtg_item22", modelo.mLsCod22);
            cmd.Parameters.AddWithValue("@mtg_item23", modelo.mLsCod23);
            cmd.Parameters.AddWithValue("@mtg_item24", modelo.mLsCod24);
            cmd.Parameters.AddWithValue("@mtg_qtd0", modelo.mLsQtd0);
            cmd.Parameters.AddWithValue("@mtg_qtd1", modelo.mLsQtd1);
            cmd.Parameters.AddWithValue("@mtg_qtd2", modelo.mLsQtd2);
            cmd.Parameters.AddWithValue("@mtg_qtd3", modelo.mLsQtd3);
            cmd.Parameters.AddWithValue("@mtg_qtd4", modelo.mLsQtd4);
            cmd.Parameters.AddWithValue("@mtg_qtd5", modelo.mLsQtd5);
            cmd.Parameters.AddWithValue("@mtg_qtd6", modelo.mLsQtd6);
            cmd.Parameters.AddWithValue("@mtg_qtd7", modelo.mLsQtd7);
            cmd.Parameters.AddWithValue("@mtg_qtd8", modelo.mLsQtd8);
            cmd.Parameters.AddWithValue("@mtg_qtd9", modelo.mLsQtd9);
            cmd.Parameters.AddWithValue("@mtg_qtd10", modelo.mLsQtd10);
            cmd.Parameters.AddWithValue("@mtg_qtd11", modelo.mLsQtd11);
            cmd.Parameters.AddWithValue("@mtg_qtd12", modelo.mLsQtd12);
            cmd.Parameters.AddWithValue("@mtg_qtd13", modelo.mLsQtd13);
            cmd.Parameters.AddWithValue("@mtg_qtd14", modelo.mLsQtd14);
            cmd.Parameters.AddWithValue("@mtg_qtd15", modelo.mLsQtd15);
            cmd.Parameters.AddWithValue("@mtg_qtd16", modelo.mLsQtd16);
            cmd.Parameters.AddWithValue("@mtg_qtd17", modelo.mLsQtd17);
            cmd.Parameters.AddWithValue("@mtg_qtd18", modelo.mLsQtd18);
            cmd.Parameters.AddWithValue("@mtg_qtd19", modelo.mLsQtd19);
            cmd.Parameters.AddWithValue("@mtg_qtd20", modelo.mLsQtd20);
            cmd.Parameters.AddWithValue("@mtg_qtd21", modelo.mLsQtd21);
            cmd.Parameters.AddWithValue("@mtg_qtd22", modelo.mLsQtd22);
            cmd.Parameters.AddWithValue("@mtg_qtd23", modelo.mLsQtd23);
            cmd.Parameters.AddWithValue("@mtg_qtd24", modelo.mLsQtd24);

            cmd.Parameters.Add("@us_foto", System.Data.SqlDbType.Image);
            if (modelo.mtgFoto == null)
            {
                cmd.Parameters["@mtg_foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@mtg_foto"].Value = modelo.mtgFoto;
            }
            if (transacao)
            {
                cmd.Transaction = connection.ObjetoTransacao;
                cmd.ExecuteNonQuery();
            }
            else
            {
                connection.Connect();
                cmd.ExecuteNonQuery();
                connection.Disconnect();
            }
        }

        public void DeleteMontagem(int code)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "delete from montagem where (mtg_cod) = (@mtg_cod)";
            cmd.Parameters.AddWithValue("@mtg_cod", code);
            connection.Connect();
            cmd.ExecuteNonQuery();
            connection.Disconnect();
        }

        public DataTable LocalizarMontagem(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from montagem where mtg_code like '%" +
                valor + "%'", connection.StringConnection);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarDescricaoMtg(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from montagem where mtg_desc like '%" +
                valor + "%'", connection.StringConnection);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloMontagem CarregaModeloMontagem(int codigo)
        {
            ModeloMontagem modelo = new ModeloMontagem();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "select * from montagem where mtg_cod =" + codigo.ToString();
            connection.Connect();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.mtgCod = Convert.ToInt32(registro["mtg_cod"]);
                modelo.mtgCode = Convert.ToString(registro["mtg_code"]);
                modelo.mtgDesc = Convert.ToString(registro["mtg_desc"]);
                modelo.mLsCod0 = Convert.ToInt32(registro["mtg_item0"]);
                modelo.mLsQtd0 = (float)(Convert.ToDouble(registro["mtg_qtd0"]));
                modelo.mLsCod1 = Convert.ToInt32(registro["mtg_item1"]);
                modelo.mLsQtd1 = (float)(Convert.ToDouble(registro["mtg_qtd1"]));
                modelo.mLsCod2 = Convert.ToInt32(registro["mtg_item2"]);
                modelo.mLsQtd2 = (float)(Convert.ToDouble(registro["mtg_qtd2"]));
                modelo.mLsCod3 = Convert.ToInt32(registro["mtg_item3"]);
                modelo.mLsQtd3 = (float)(Convert.ToDouble(registro["mtg_qtd3"]));
                modelo.mLsCod4 = Convert.ToInt32(registro["mtg_item4"]);
                modelo.mLsQtd4 = (float)(Convert.ToDouble(registro["mtg_qtd4"]));
                modelo.mLsCod5 = Convert.ToInt32(registro["mtg_item5"]);
                modelo.mLsQtd5 = (float)(Convert.ToDouble(registro["mtg_qtd5"]));
                modelo.mLsCod6 = Convert.ToInt32(registro["mtg_item6"]);
                modelo.mLsQtd6 = (float)(Convert.ToDouble(registro["mtg_qtd6"]));
                modelo.mLsCod7 = Convert.ToInt32(registro["mtg_item7"]);
                modelo.mLsQtd7 = (float)(Convert.ToDouble(registro["mtg_qtd7"]));
                modelo.mLsCod8 = Convert.ToInt32(registro["mtg_item8"]);
                modelo.mLsQtd8 = (float)(Convert.ToDouble(registro["mtg_qtd8"]));
                modelo.mLsCod9 = Convert.ToInt32(registro["mtg_item9"]);
                modelo.mLsQtd9 = (float)(Convert.ToDouble(registro["mtg_qtd9"]));
                modelo.mLsCod10 = Convert.ToInt32(registro["mtg_item10"]);
                modelo.mLsQtd10 = (float)(Convert.ToDouble(registro["mtg_qtd10"]));
                modelo.mLsCod11 = Convert.ToInt32(registro["mtg_item11"]);
                modelo.mLsQtd11 = (float)(Convert.ToDouble(registro["mtg_qtd11"]));
                modelo.mLsCod12 = Convert.ToInt32(registro["mtg_item12"]);
                modelo.mLsQtd12 = (float)(Convert.ToDouble(registro["mtg_qtd12"]));
                modelo.mLsCod13 = Convert.ToInt32(registro["mtg_item13"]);
                modelo.mLsQtd13 = (float)(Convert.ToDouble(registro["mtg_qtd13"]));
                modelo.mLsCod14 = Convert.ToInt32(registro["mtg_item14"]);
                modelo.mLsQtd14 = (float)(Convert.ToDouble(registro["mtg_qtd14"]));
                modelo.mLsCod15 = Convert.ToInt32(registro["mtg_item15"]);
                modelo.mLsQtd15 = (float)(Convert.ToDouble(registro["mtg_qtd15"]));
                modelo.mLsCod16 = Convert.ToInt32(registro["mtg_item16"]);
                modelo.mLsQtd16 = (float)(Convert.ToDouble(registro["mtg_qtd16"]));
                modelo.mLsCod17 = Convert.ToInt32(registro["mtg_item17"]);
                modelo.mLsQtd17 = (float)(Convert.ToDouble(registro["mtg_qtd17"]));
                modelo.mLsCod18 = Convert.ToInt32(registro["mtg_item18"]);
                modelo.mLsQtd18 = (float)(Convert.ToDouble(registro["mtg_qtd18"]));
                modelo.mLsCod19 = Convert.ToInt32(registro["mtg_item19"]);
                modelo.mLsQtd19 = (float)(Convert.ToDouble(registro["mtg_qtd19"]));
                modelo.mLsCod20 = Convert.ToInt32(registro["mtg_item20"]);
                modelo.mLsQtd20 = (float)(Convert.ToDouble(registro["mtg_qtd20"]));
                modelo.mLsCod21 = Convert.ToInt32(registro["mtg_item21"]);
                modelo.mLsQtd21 = (float)(Convert.ToDouble(registro["mtg_qtd21"]));
                modelo.mLsCod22 = Convert.ToInt32(registro["mtg_item22"]);
                modelo.mLsQtd22 = (float)(Convert.ToDouble(registro["mtg_qtd22"]));
                modelo.mLsCod23 = Convert.ToInt32(registro["mtg_item23"]);
                modelo.mLsQtd23 = (float)(Convert.ToDouble(registro["mtg_qtd23"]));
                modelo.mLsCod24 = Convert.ToInt32(registro["mtg_item24"]);
                modelo.mLsQtd24 = (float)(Convert.ToDouble(registro["mtg_qtd24"]));

                try
                {
                    modelo.mtgFoto = (byte[])registro["mtg_foto"];

                }
                catch { }
            }
            connection.Disconnect();
            return modelo;
        }

        public ModeloMontagem CarregaModeloMontagem(int codigo, Boolean transacao)
        {
            ModeloMontagem? modelo = new ModeloMontagem();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "select * from montagem where mtg_cod =" + codigo.ToString();
            cmd.Parameters.AddWithValue("@mtg_cod", codigo);
            connection.Connect();
            if (transacao == false)
            {
                connection.Connect();
            }
            else
            {
                cmd.Transaction = connection.ObjetoTransacao;
            }
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.mtgCod = Convert.ToInt32(registro["mtg_cod"]);
                modelo.mtgCode = Convert.ToString(registro["mtg_code"]);
                modelo.mtgDesc = Convert.ToString(registro["mtg_desc"]);

                modelo.mLsCod0 = Convert.ToInt32(registro["mtg_item0"]);
                modelo.mLsQtd0 = (float)(Convert.ToDouble(registro["mtg_qtd0"]));
                modelo.mLsCod1 = Convert.ToInt32(registro["mtg_item1"]);
                modelo.mLsQtd1 = (float)(Convert.ToDouble(registro["mtg_qtd1"]));
                modelo.mLsCod2 = Convert.ToInt32(registro["mtg_item2"]);
                modelo.mLsQtd2 = (float)(Convert.ToDouble(registro["mtg_qtd2"]));
                modelo.mLsCod3 = Convert.ToInt32(registro["mtg_item3"]);
                modelo.mLsQtd3 = (float)(Convert.ToDouble(registro["mtg_qtd3"]));
                modelo.mLsCod4 = Convert.ToInt32(registro["mtg_item4"]);
                modelo.mLsQtd4 = (float)(Convert.ToDouble(registro["mtg_qtd4"]));
                modelo.mLsCod5 = Convert.ToInt32(registro["mtg_item5"]);
                modelo.mLsQtd5 = (float)(Convert.ToDouble(registro["mtg_qtd5"]));
                modelo.mLsCod6 = Convert.ToInt32(registro["mtg_item6"]);
                modelo.mLsQtd6 = (float)(Convert.ToDouble(registro["mtg_qtd6"]));
                modelo.mLsCod7 = Convert.ToInt32(registro["mtg_item7"]);
                modelo.mLsQtd7 = (float)(Convert.ToDouble(registro["mtg_qtd7"]));
                modelo.mLsCod8 = Convert.ToInt32(registro["mtg_item8"]);
                modelo.mLsQtd8 = (float)(Convert.ToDouble(registro["mtg_qtd8"]));
                modelo.mLsCod9 = Convert.ToInt32(registro["mtg_item9"]);
                modelo.mLsQtd9 = (float)(Convert.ToDouble(registro["mtg_qtd9"]));
                modelo.mLsCod10 = Convert.ToInt32(registro["mtg_item10"]);
                modelo.mLsQtd10 = (float)(Convert.ToDouble(registro["mtg_qtd10"]));
                modelo.mLsCod11 = Convert.ToInt32(registro["mtg_item11"]);
                modelo.mLsQtd11 = (float)(Convert.ToDouble(registro["mtg_qtd11"]));
                modelo.mLsCod12 = Convert.ToInt32(registro["mtg_item12"]);
                modelo.mLsQtd12 = (float)(Convert.ToDouble(registro["mtg_qtd12"]));
                modelo.mLsCod13 = Convert.ToInt32(registro["mtg_item13"]);
                modelo.mLsQtd13 = (float)(Convert.ToDouble(registro["mtg_qtd13"]));
                modelo.mLsCod14 = Convert.ToInt32(registro["mtg_item14"]);
                modelo.mLsQtd14 = (float)(Convert.ToDouble(registro["mtg_qtd14"]));
                modelo.mLsCod15 = Convert.ToInt32(registro["mtg_item15"]);
                modelo.mLsQtd15 = (float)(Convert.ToDouble(registro["mtg_qtd15"]));
                modelo.mLsCod16 = Convert.ToInt32(registro["mtg_item16"]);
                modelo.mLsQtd16 = (float)(Convert.ToDouble(registro["mtg_qtd16"]));
                modelo.mLsCod17 = Convert.ToInt32(registro["mtg_item17"]);
                modelo.mLsQtd17 = (float)(Convert.ToDouble(registro["mtg_qtd17"]));
                modelo.mLsCod18 = Convert.ToInt32(registro["mtg_item18"]);
                modelo.mLsQtd18 = (float)(Convert.ToDouble(registro["mtg_qtd18"]));
                modelo.mLsCod19 = Convert.ToInt32(registro["mtg_item19"]);
                modelo.mLsQtd19 = (float)(Convert.ToDouble(registro["mtg_qtd19"]));
                modelo.mLsCod20 = Convert.ToInt32(registro["mtg_item20"]);
                modelo.mLsQtd20 = (float)(Convert.ToDouble(registro["mtg_qtd20"]));
                modelo.mLsCod21 = Convert.ToInt32(registro["mtg_item21"]);
                modelo.mLsQtd21 = (float)(Convert.ToDouble(registro["mtg_qtd21"]));
                modelo.mLsCod22 = Convert.ToInt32(registro["mtg_item22"]);
                modelo.mLsQtd22 = (float)(Convert.ToDouble(registro["mtg_qtd22"]));
                modelo.mLsCod23 = Convert.ToInt32(registro["mtg_item23"]);
                modelo.mLsQtd23 = (float)(Convert.ToDouble(registro["mtg_qtd23"]));
                modelo.mLsCod24 = Convert.ToInt32(registro["mtg_item24"]);
                modelo.mLsQtd24 = (float)(Convert.ToDouble(registro["mtg_qtd24"]));

                try
                {
                    modelo.mtgFoto = (byte[])registro["mtg_foto"];
                }
                catch { }
            }
            registro.Close();
            if (transacao == false) connection.Disconnect();
            return modelo;
        }

        #endregion

        #region Logs
        //Almoxarifado
        public void GenerateALog(ModeloALog modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection.ObjectConnection;
            cmd.CommandText = "insert into log_almoxarifado(alog_code,alog_desc,alog_unity," +
            "alog_qtd,alog_user,alog_dest,alog_day,alog_time,alog_inv,alog_dir) values (@alog_code,@alog_desc,@alog_unity," +
            "@alog_qtd,@alog_user,@alog_dest,@alog_day,@alog_time,@alog_inv,@alog_dir); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@alog_code", modelo.alogCode);
            cmd.Parameters.AddWithValue("@alog_desc", modelo.alogDesc);
            cmd.Parameters.AddWithValue("@alog_unity", modelo.alogUnity);
            cmd.Parameters.AddWithValue("@alog_qtd", modelo.alogQtd);
            cmd.Parameters.AddWithValue("@alog_user", modelo.alogUser);
            cmd.Parameters.AddWithValue("@alog_dest", modelo.alogDest);
            cmd.Parameters.AddWithValue("@alog_day", modelo.alogDayTime);
            cmd.Parameters.AddWithValue("@alog_time", modelo.alogDayTime);
            cmd.Parameters.AddWithValue("@alog_inv", modelo.alogInv);
            cmd.Parameters.AddWithValue("@alog_dir", modelo.alogDir);
            connection.Connect();
            modelo.alogCod = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Disconnect();
        }

        public DataTable LocalizarALog(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from log_almoxarifado where alog_code like '%" +
                valor + "%'", connection.StringConnection);
            da.Fill(tabela);
            return tabela;
        }

        #endregion
    }
}
