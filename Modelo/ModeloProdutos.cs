//-----NATSWORKS & INTERLASER-----\\
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Modelo
{
    public class ModeloProdutos
    {
        //Variáveis
        private int prod_cod;
        private String? prod_code;
        private String? prod_for;
        private String? prod_group;
        private String? prod_desc;
        private String? prod_unity;
        private float prod_price;
        private DateTime prod_day;
        private float prod_inv;
        private float prod_min;
        private bool prod_alert;
        private byte[]? _pro_foto;

        /*
        prod_cod
        prod_code
        for_code
        prod_group
        prod_desc
        prod_unity
        prod_price
        prod_day
        prod_inv
        prod_min
        prod_alert
        _pro_foto

        prodCod
        prodCode
        forCode
        prodGroup
        prodDesc
        prodUnity
        prodPrice
        prodDay
        prodInv
        prodMin
        prodAlert
        ProFoto
        */

        public int prodCod
        {
            get { return this.prod_cod; }
            set { this.prod_cod = value; }
        }

        public String? prodCode
        {
            get { return this.prod_code; }
            set { this.prod_code = value; }
        }

        public String? prodFor
        {
            get { return this.prod_for; }
            set { this.prod_for = value; }
        }

        public String? prodGroup
        {
            get { return this.prod_group; }
            set { this.prod_group = value; }
        }

        public String? prodDesc
        {
            get { return this.prod_desc; }
            set { this.prod_desc = value; }
        }

        public String? prodUnity
        {
            get { return this.prod_unity; }
            set { this.prod_unity = value; }
        }

        public float prodPrice
        {
            get { return this.prod_price; }
            set { this.prod_price = value; }
        }

        public DateTime prodDay
        {
            get { return this.prod_day; }
            set { this.prod_day = value; }
        }

        public float prodInv
        {
            get { return this.prod_inv; }
            set { this.prod_inv = value; }
        }

        public float prodMin
        {
            get { return this.prod_min; }
            set { this.prod_min = value; }
        }

        public bool prodAlert
        {
            get { return this.prod_alert; }
            set { this.prod_alert = value; }
        }

        public byte[]? ProFoto
        {
            get { return this._pro_foto; }
            set { this._pro_foto = value; }
        }

        public ModeloProdutos()
        {
            this.prodCod = 0;
            this.prodCode = "";
            this.prodFor = "";
            this.prodGroup = "";
            this.prodDesc = "";
            this.prodUnity = "";
            this.prodPrice = 0;
            this.prodInv = 0;
        }

        public ModeloProdutos(int pro_cod, String pro_code, String fo_code,String pro_foto, String pro_group,
           String pro_desc, String pro_unity,float pro_price, DateTime pro_day, float pro_inv)
        {
            this.prodCod = pro_cod;
            this.prodCode = pro_code;
            this.prodFor = fo_code;
            this.prodGroup = pro_group;
            this.prodDesc = pro_desc;
            this.prodUnity = pro_unity;
            this.prodPrice = pro_price;
            this.prodDay = pro_day;
            this.prodInv = pro_inv;
            this.CarregaImagem(pro_foto);
        }

        public ModeloProdutos(int pro_cod, String pro_code, String fo_code,Byte[] pro_foto, String pro_group,
            String pro_desc, String pro_unity,float pro_price, DateTime pro_day, float pro_inv)
        {
            this.prodCod = pro_cod;
            this.prodCode = pro_code;
            this.prodFor = fo_code;
            this.prodGroup = pro_group;
            this.prodDesc = pro_desc;
            this.prodUnity = pro_unity;
            this.prodPrice = pro_price;
            this.prodDay = pro_day;
            this.prodInv = pro_inv;
            this.ProFoto = pro_foto;
        }

        public void CarregaImagem(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;
                //fornece propriedadese métodos de instância para criar, copiar,
                //excluir, mover, e abrir arquivos, e ajuda na criação de objetos FileStream
                FileInfo arqImagem = new FileInfo(imgCaminho);
                //Expõe um Stream ao redor de um arquivo de suporte
                //síncrono e assíncrono operações de leitura e gravar.
                FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                //aloca memória para o vetor
                this.ProFoto = new byte[Convert.ToInt32(arqImagem.Length)];
                //Lê um bloco de bytes do fluxo e grava osdados em um buffer fornecido.
                int iBytesRead = fs.Read(this.ProFoto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }

    public class ModeloFornecedor
    {
        public int for_cod;
        public String? for_nome;
        public String? for_rsocial;
        public String? for_cnpj;
        public String? for_cep;
        public String? for_endereco;
        public String? for_bairro;
        public String? for_fone;
        public String? for_cel;
        public String? for_email;
        public String? for_endnumero;
        public String? for_cidade;
        public String? for_estado;
        public String? for_contato;

        /*
        for_cod;
        for_nome;
        for_rsocial;
        for_cnpj;
        for_cep;
        for_endereco;
        for_bairro;
        for_fone;
        for_cel;
        for_email;
        for_endnumero;
        for_cidade;
        for_estado;
        for_contato;
        
        forCod
        forNome
        forRsocial
        forCNPJ
        forCEP
        forEnd
        forBairro
        forFone
        forCel
        forEmail
        forNumero
        forCidade
        forEstado
        forContato
        */

        public int forCod
        {
            get { return this.for_cod; }
            set { this.for_cod = value; }
        }

        public String? forNome
        {
            get { return this.for_nome; }
            set { this.for_nome = value; }
        }

        public String? forRsocial
        {
            get { return this.for_rsocial; }
            set { this.for_rsocial = value; }
        }

        public String? forCNPJ
        {
            get { return this.for_cnpj; }
            set { this.for_cnpj = value; }
        }

        public String? forCEP
        {
            get { return this.for_cep; }
            set { this.for_cep = value; }
        }

        public String? forEnd
        {
            get { return this.for_endereco; }
            set { this.for_endereco = value; }
        }

        public String? forBairro
        {
            get { return this.for_bairro; }
            set { this.for_bairro = value; }
        }

        public String? forFone
        {
            get { return this.for_fone; }
            set { this.for_fone = value; }
        }

        public String? forCel
        {
            get { return this.for_cel; }
            set { this.for_cel = value; }
        }

        public String? forEmail
        {
            get { return this.for_email; }
            set { this.for_email = value; }
        }

        public String? forNumero
        {
            get { return this.for_endnumero; }
            set { this.for_endnumero = value; }
        }

        public String? forCidade
        {
            get { return this.for_cidade; }
            set { this.for_cidade = value; }
        }

        public String? forEstado
        {
            get { return this.for_estado; }
            set { this.for_estado = value; }
        }

        public String? forContato
        {
            get { return this.for_contato; }
            set { this.for_contato = value; }
        }
    }

    public class ModeloUser
    {
        public int us_cod;
        public String? us_login;
        public String? us_senha;
        public String? us_name;
        public String? us_nivel;
        public String? us_area;
        public String? us_estado;
        private byte[]? us_foto;

        /*
        
        us_cod
        us_login
        us_senha
        us_name
        us_nivel
        us_area
        us_estado
        us_foto

        usCod
        usLogin
        usSenha
        usName
        usNivel
        usArea
        usEstado
        usFoto
         */

        public ModeloUser()
        {
            this.us_cod = 0;
            this.us_login = "";
            this.us_senha = "";
            this.us_name = "";
            this.us_nivel = "";
            this.us_area = "";
            this.us_estado = "";
        }

        public int usCod
        {
            get { return this.us_cod; }
            set { this.us_cod = value; }
        }

        public String? usLogin
        {
            get { return this.us_login; }
            set { this.us_login = value; }
        }

        public String? usSenha
        {
            get { return this.us_senha; }
            set { this.us_senha = value; }
        }

        public String? usName
        {
            get { return this.us_name; }
            set { this.us_name = value; }
        }

        public String? usNivel
        {
            get { return this.us_nivel; }
            set { this.us_nivel = value; }
        }

        public String? usArea
        {
            get { return this.us_area; }
            set { this.us_area = value; }
        }

        public String? usEstado
        {
            get { return this.us_estado; }
            set { this.us_estado = value; }
        }

        public byte[]? usFoto
        {
            get { return this.us_foto; }
            set { this.us_foto = value; }
        }

        public ModeloUser(int _us_cod, String _us_login, String _us_senha,
           String _us_name, String _us_nivel, String _us_area, String _us_estado,String _us_foto)
        {
            this.us_cod = _us_cod;
            this.us_login = _us_login;
            this.us_senha = _us_senha;
            this.us_name = _us_name;
            this.us_nivel = _us_nivel;
            this.us_area = _us_area;
            this.us_estado = _us_estado;
            this.CarregaImagem(_us_foto);
        }

        public ModeloUser(int _us_cod, String _us_login, String _us_senha,
            String _us_name, String _us_nivel, String _us_area, String _us_estado, Byte[] _us_foto)
        {
            this.us_cod = _us_cod;
            this.us_login = _us_login;
            this.us_senha = _us_senha;
            this.us_name = _us_name;
            this.us_nivel = _us_nivel;
            this.us_area = _us_area;
            this.us_estado = _us_estado;
            this.usFoto = _us_foto;
        }

        public void CarregaImagem(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;
                FileInfo arqImagem = new FileInfo(imgCaminho);
                FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                this.usFoto = new byte[Convert.ToInt32(arqImagem.Length)];
                int iBytesRead = fs.Read(this.usFoto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }

    public class ModeloCompra
    {
        private int com_cod;
        private DateTime com_data;
        private int com_nfiscal;
        private String? prod_cod;
        private float com_qtd;
        private String? com_unity;
        private float com_total;
        private String? for_cod;
        private String? com_entrega;
        private String? com_status;

        /*
        com_cod;
        com_data;
        com_nfiscal;
        prod_cod;
        com_qtd;
        com_unity;
        com_total;
        for_cod;
        com_entrega;
        com_status;

        comCod
        comData
        comNfiscal
        prodCod
        comQtd
        comUnity
        comTotal
        forCod
        comEntrega
        comStatus
        */

        public int comCod
        {
            get { return this.com_cod; }
            set { this.com_cod = value; }
        }

        public DateTime comData
        {
            get { return this.com_data; }
            set { this.com_data = value; }
        }

        public int comNfiscal
        {
            get { return this.com_nfiscal; }
            set { this.com_nfiscal = value; }
        }

        public String? prodCod
        {
            get { return this.prod_cod; }
            set { this.prod_cod = value; }
        }

        public float comQtd
        {
            get { return this.com_qtd; }
            set { this.com_qtd = value; }
        }

        public String? comUnity
        {
            get { return this.com_unity; }
            set { this.com_unity = value; }
        }

        public float comTotal
        {
            get { return this.com_total; }
            set { this.com_total = value; }
        }

        public String? forCod
        {
            get { return this.for_cod; }
            set { this.for_cod = value; }
        }

        public String? comEntrega
        {
            get { return this.com_entrega; }
            set { this.com_entrega = value; }
        }

        public String? comStatus
        {
            get { return this.com_status; }
            set { this.com_status = value; }
        }
    }

    public class ModeloAssist
    {
        private int as_cod;
        private String? as_nome;
        private String? as_cidade;
        private String? as_estado;
        private String? as_maquina;
        private String? as_defeito;
        private String? as_tecnico;
        private DateTime as_day;

        /*
        as_cod;
        as_nome;
        as_cidade;
        as_estado;
        as_maquina;
        as_defeito;
        as_tecnico;
        as_day;

        asCod
        asNome
        asCidade
        asEstado
        asMaquina
        asDefeito
        asTecnico
        asDay
        */

        public int asCod
        {
            get { return this.as_cod; }
            set { this.as_cod = value; }
        }

        public String? asNome
        {
            get { return this.as_nome; }
            set { this.as_nome = value; }
        }

        public String? asCidade
        {
            get { return this.as_cidade; }
            set { this.as_cidade = value; }
        }

        public String? asEstado
        {
            get { return this.as_estado; }
            set { this.as_estado = value; }
        }

        public String? asMaquina
        {
            get { return this.as_maquina; }
            set { this.as_maquina = value; }
        }

        public String? asDefeito
        {
            get { return this.as_defeito; }
            set { this.as_defeito = value; }
        }

        public String? asTecnico
        {
            get { return this.as_tecnico; }
            set { this.as_tecnico = value; }
        }

        public DateTime asDay
        {
            get { return this.as_day; }
            set { this.as_day = value; }
        }
    }

    public class ModeloMontagem
    {
        private int mtg_cod;
        private String? mtg_code;
        private String? mtg_desc;
        private byte[]? _mtg_foto;
        private int lsCod0;
        private int lsCod1;
        private int lsCod2;
        private int lsCod3;
        private int lsCod4;
        private int lsCod5;
        private int lsCod6;
        private int lsCod7;
        private int lsCod8;
        private int lsCod9;
        private int lsCod10;
        private int lsCod11;
        private int lsCod12;
        private int lsCod13;
        private int lsCod14;
        private int lsCod15;
        private int lsCod16;
        private int lsCod17;
        private int lsCod18;
        private int lsCod19;
        private int lsCod20;
        private int lsCod21;
        private int lsCod22;
        private int lsCod23;
        private int lsCod24;

        private float lsQtd0;
        private float lsQtd1;
        private float lsQtd2;
        private float lsQtd3;
        private float lsQtd4;
        private float lsQtd5;
        private float lsQtd6;
        private float lsQtd7;
        private float lsQtd8;
        private float lsQtd9;
        private float lsQtd10;
        private float lsQtd11;
        private float lsQtd12;
        private float lsQtd13;
        private float lsQtd14;
        private float lsQtd15;
        private float lsQtd16;
        private float lsQtd17;
        private float lsQtd18;
        private float lsQtd19;
        private float lsQtd20;
        private float lsQtd21;
        private float lsQtd22;
        private float lsQtd23;
        private float lsQtd24;

        /*
        mtg_cod
        mtg_code
        mtg_desc

        mtgCod
        mtgCode
        mtgDesc
        mLsCod
        mLsQtd
        mtgFoto
        */

        public int mtgCod
        {
            get { return this.mtg_cod; }
            set { this.mtg_cod = value; }
        }

        public String? mtgCode
        {
            get { return this.mtg_code; }
            set { this.mtg_code = value; }
        }

        public String? mtgDesc
        {
            get { return this.mtg_desc; }
            set { this.mtg_desc = value; }
        }

        public byte[]? mtgFoto
        {
            get { return this._mtg_foto; }
            set { this._mtg_foto = value; }
        }

        public int mLsCod0
        {
            get { return lsCod0; }
            set { lsCod0 = value; }
        }

        public int mLsCod1
        {
            get { return lsCod1; }
            set { lsCod1 = value; }
        }

        public int mLsCod2
        {
            get { return lsCod2; }
            set { lsCod2 = value; }
        }

        public int mLsCod3
        {
            get { return lsCod3; }
            set { lsCod3 = value; }
        }

        public int mLsCod4
        {
            get { return lsCod4; }
            set { lsCod4 = value; }
        }

        public int mLsCod5
        {
            get { return lsCod5; }
            set { lsCod5 = value; }
        }

        public int mLsCod6
        {
            get { return lsCod6; }
            set { lsCod6 = value; }
        }

        public int mLsCod7
        {
            get { return lsCod7; }
            set { lsCod7 = value; }
        }

        public int mLsCod8
        {
            get { return lsCod8; }
            set { lsCod8 = value; }
        }

        public int mLsCod9
        {
            get { return lsCod9; }
            set { lsCod9 = value; }
        }

        public int mLsCod10
        {
            get { return lsCod10; }
            set { lsCod10 = value; }
        }

        public int mLsCod11
        {
            get { return lsCod11; }
            set { lsCod11 = value; }
        }

        public int mLsCod12
        {
            get { return lsCod12; }
            set { lsCod12 = value; }
        }

        public int mLsCod13
        {
            get { return lsCod13; }
            set { lsCod13 = value; }
        }

        public int mLsCod14
        {
            get { return lsCod14; }
            set { lsCod14 = value; }
        }

        public int mLsCod15
        {
            get { return lsCod15; }
            set { lsCod15 = value; }
        }

        public int mLsCod16
        {
            get { return lsCod16; }
            set { lsCod16 = value; }
        }

        public int mLsCod17
        {
            get { return lsCod17; }
            set { lsCod17 = value; }
        }

        public int mLsCod18
        {
            get { return lsCod18; }
            set { lsCod18 = value; }
        }

        public int mLsCod19
        {
            get { return lsCod19; }
            set { lsCod19 = value; }
        }

        public int mLsCod20
        {
            get { return lsCod20; }
            set { lsCod20 = value; }
        }

        public int mLsCod21
        {
            get { return lsCod21; }
            set { lsCod21 = value; }
        }

        public int mLsCod22
        {
            get { return lsCod22; }
            set { lsCod22 = value; }
        }

        public int mLsCod23
        {
            get { return lsCod23; }
            set { lsCod23 = value; }
        }

        public int mLsCod24
        {
            get { return lsCod24; }
            set { lsCod24 = value; }
        }

        public float mLsQtd0
        {
            get { return this.lsQtd0; }
            set { this.lsQtd0 = value; }
        }

        public float mLsQtd1
        {
            get { return this.lsQtd1; }
            set { this.lsQtd1 = value; }
        }

        public float mLsQtd2
        {
            get { return this.lsQtd2; }
            set { this.lsQtd2 = value; }
        }

        public float mLsQtd3
        {
            get { return this.lsQtd3; }
            set { this.lsQtd3 = value; }
        }

        public float mLsQtd4
        {
            get { return this.lsQtd4; }
            set { this.lsQtd4 = value; }
        }

        public float mLsQtd5
        {
            get { return this.lsQtd5; }
            set { this.lsQtd5 = value; }
        }

        public float mLsQtd6
        {
            get { return this.lsQtd6; }
            set { this.lsQtd6 = value; }
        }

        public float mLsQtd7
        {
            get { return this.lsQtd7; }
            set { this.lsQtd7 = value; }
        }

        public float mLsQtd8
        {
            get { return this.lsQtd8; }
            set { this.lsQtd8 = value; }
        }

        public float mLsQtd9
        {
            get { return this.lsQtd9; }
            set { this.lsQtd9 = value; }
        }

        public float mLsQtd10
        {
            get { return this.lsQtd10; }
            set { this.lsQtd10 = value; }
        }

        public float mLsQtd11
        {
            get { return this.lsQtd11; }
            set { this.lsQtd11 = value; }
        }

        public float mLsQtd12
        {
            get { return this.lsQtd12; }
            set { this.lsQtd12 = value; }
        }

        public float mLsQtd13
        {
            get { return this.lsQtd13; }
            set { this.lsQtd13 = value; }
        }

        public float mLsQtd14
        {
            get { return this.lsQtd14; }
            set { this.lsQtd14 = value; }
        }

        public float mLsQtd15
        {
            get { return this.lsQtd15; }
            set { this.lsQtd15 = value; }
        }

        public float mLsQtd16
        {
            get { return this.lsQtd16; }
            set { this.lsQtd16 = value; }
        }

        public float mLsQtd17
        {
            get { return this.lsQtd17; }
            set { this.lsQtd17 = value; }
        }

        public float mLsQtd18
        {
            get { return this.lsQtd18; }
            set { this.lsQtd18 = value; }
        }

        public float mLsQtd19
        {
            get { return this.lsQtd19; }
            set { this.lsQtd19 = value; }
        }

        public float mLsQtd20
        {
            get { return this.lsQtd20; }
            set { this.lsQtd20 = value; }
        }

        public float mLsQtd21
        {
            get { return this.lsQtd21; }
            set { this.lsQtd21 = value; }
        }

        public float mLsQtd22
        {
            get { return this.lsQtd22; }
            set { this.lsQtd22 = value; }
        }

        public float mLsQtd23
        {
            get { return this.lsQtd23; }
            set { this.lsQtd23 = value; }
        }

        public float mLsQtd24
        {
            get { return this.lsQtd24; }
            set { this.lsQtd24 = value; }
        }

        public ModeloMontagem()
        {
            this.mtgCod = 0;
            this.mtgCode = "";
            this.mtgDesc = "";

            /*mLsCod[0] = 0;
            mLsCod[1] = 0;
            mLsCod[2] = 0;
            mLsCod[3] = 0;
            mLsCod[4] = 0;
            mLsCod[5] = 0;
            mLsCod[6] = 0;
            mLsCod[7] = 0;
            mLsCod[8] = 0;
            mLsCod[9] = 0;
            mLsCod[10] = 0;
            mLsCod[11] = 0;
            mLsCod[12] = 0;
            mLsCod[13] = 0;
            mLsCod[14] = 0;
            mLsCod[15] = 0;
            mLsCod[16] = 0;
            mLsCod[17] = 0;
            mLsCod[18] = 0;
            mLsCod[19] = 0;
            mLsCod[20] = 0;
            mLsCod[21] = 0;
            mLsCod[22] = 0;
            mLsCod[23] = 0;
            mLsCod[24] = 0;

            mLsQtd[0] = 0;
            mLsQtd[1] = 0;
            mLsQtd[2] = 0;
            mLsQtd[3] = 0;
            mLsQtd[4] = 0;
            mLsQtd[5] = 0;
            mLsQtd[6] = 0;
            mLsQtd[7] = 0;
            mLsQtd[8] = 0;
            mLsQtd[9] = 0;
            mLsQtd[10] = 0;
            mLsQtd[11] = 0;
            mLsQtd[12] = 0;
            mLsQtd[13] = 0;
            mLsQtd[14] = 0;
            mLsQtd[15] = 0;
            mLsQtd[16] = 0;
            mLsQtd[17] = 0;
            mLsQtd[18] = 0;
            mLsQtd[19] = 0;
            mLsQtd[20] = 0;
            mLsQtd[21] = 0;
            mLsQtd[22] = 0;
            mLsQtd[23] = 0;
            mLsQtd[24] = 0;*/

        }

        public ModeloMontagem(int _mtg_cod, String _mtg_code, String _mtg_desc, String mtg_foto)// int[] _mLsCod, float[] _mLsQtd,
        {
            this.mtgCod = _mtg_cod;
            this.mtgCode = _mtg_code;
            this.mtgDesc = _mtg_desc;
            this.CarregaImagem(mtg_foto);
            /*mLsCod[0] = _mLsCod[0];
            mLsCod[1] = _mLsCod[1];
            mLsCod[2] = _mLsCod[2];
            mLsCod[3] = _mLsCod[3];
            mLsCod[4] = _mLsCod[4];
            mLsCod[5] = _mLsCod[5];
            mLsCod[6] = _mLsCod[6];
            mLsCod[7] = _mLsCod[7];
            mLsCod[8] = _mLsCod[8];
            mLsCod[9] = _mLsCod[9];
            mLsCod[10] = _mLsCod[10];
            mLsCod[11] = _mLsCod[11];
            mLsCod[12] = _mLsCod[12];
            mLsCod[13] = _mLsCod[13];
            mLsCod[14] = _mLsCod[14];
            mLsCod[15] = _mLsCod[15];
            mLsCod[16] = _mLsCod[16];
            mLsCod[17] = _mLsCod[17];
            mLsCod[18] = _mLsCod[18];
            mLsCod[19] = _mLsCod[19];
            mLsCod[20] = _mLsCod[20];
            mLsCod[21] = _mLsCod[21];
            mLsCod[22] = _mLsCod[22];
            mLsCod[23] = _mLsCod[23];
            mLsCod[24] = _mLsCod[24];

            mLsQtd[0] = _mLsQtd[0];
            mLsQtd[1] = _mLsQtd[1];
            mLsQtd[2] = _mLsQtd[2];
            mLsQtd[3] = _mLsQtd[3];
            mLsQtd[4] = _mLsQtd[4];
            mLsQtd[5] = _mLsQtd[5];
            mLsQtd[6] = _mLsQtd[6];
            mLsQtd[7] = _mLsQtd[7];
            mLsQtd[8] = _mLsQtd[8];
            mLsQtd[9] = _mLsQtd[9];
            mLsQtd[10] = _mLsQtd[10];
            mLsQtd[11] = _mLsQtd[11];
            mLsQtd[12] = _mLsQtd[12];
            mLsQtd[13] = _mLsQtd[13];
            mLsQtd[14] = _mLsQtd[14];
            mLsQtd[15] = _mLsQtd[15];
            mLsQtd[16] = _mLsQtd[16];
            mLsQtd[17] = _mLsQtd[17];
            mLsQtd[18] = _mLsQtd[18];
            mLsQtd[19] = _mLsQtd[19];
            mLsQtd[20] = _mLsQtd[20];
            mLsQtd[21] = _mLsQtd[21];
            mLsQtd[22] = _mLsQtd[22];
            mLsQtd[23] = _mLsQtd[23];
            mLsQtd[24] = _mLsQtd[24];*/
        }

        public ModeloMontagem(int _mtg_cod, String _mtg_code, String _mtg_desc, Byte[] mtg_foto)
        {
            this.mtgCod = _mtg_cod;
            this.mtgCode = _mtg_code;
            this.mtgDesc = _mtg_desc;
            this.mtgFoto = mtg_foto;
            /*mLsCod[0] = _mLsCod[0];
            mLsCod[1] = _mLsCod[1];
            mLsCod[2] = _mLsCod[2];
            mLsCod[3] = _mLsCod[3];
            mLsCod[4] = _mLsCod[4];
            mLsCod[5] = _mLsCod[5];
            mLsCod[6] = _mLsCod[6];
            mLsCod[7] = _mLsCod[7];
            mLsCod[8] = _mLsCod[8];
            mLsCod[9] = _mLsCod[9];
            mLsCod[10] = _mLsCod[10];
            mLsCod[11] = _mLsCod[11];
            mLsCod[12] = _mLsCod[12];
            mLsCod[13] = _mLsCod[13];
            mLsCod[14] = _mLsCod[14];
            mLsCod[15] = _mLsCod[15];
            mLsCod[16] = _mLsCod[16];
            mLsCod[17] = _mLsCod[17];
            mLsCod[18] = _mLsCod[18];
            mLsCod[19] = _mLsCod[19];
            mLsCod[20] = _mLsCod[20];
            mLsCod[21] = _mLsCod[21];
            mLsCod[22] = _mLsCod[22];
            mLsCod[23] = _mLsCod[23];
            mLsCod[24] = _mLsCod[24];

            mLsQtd[0] = _mLsQtd[0];
            mLsQtd[1] = _mLsQtd[1];
            mLsQtd[2] = _mLsQtd[2];
            mLsQtd[3] = _mLsQtd[3];
            mLsQtd[4] = _mLsQtd[4];
            mLsQtd[5] = _mLsQtd[5];
            mLsQtd[6] = _mLsQtd[6];
            mLsQtd[7] = _mLsQtd[7];
            mLsQtd[8] = _mLsQtd[8];
            mLsQtd[9] = _mLsQtd[9];
            mLsQtd[10] = _mLsQtd[10];
            mLsQtd[11] = _mLsQtd[11];
            mLsQtd[12] = _mLsQtd[12];
            mLsQtd[13] = _mLsQtd[13];
            mLsQtd[14] = _mLsQtd[14];
            mLsQtd[15] = _mLsQtd[15];
            mLsQtd[16] = _mLsQtd[16];
            mLsQtd[17] = _mLsQtd[17];
            mLsQtd[18] = _mLsQtd[18];
            mLsQtd[19] = _mLsQtd[19];
            mLsQtd[20] = _mLsQtd[20];
            mLsQtd[21] = _mLsQtd[21];
            mLsQtd[22] = _mLsQtd[22];
            mLsQtd[23] = _mLsQtd[23];
            mLsQtd[24] = _mLsQtd[24];*/
        }

        public void CarregaImagem(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;
                FileInfo arqImagem = new FileInfo(imgCaminho);
                FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                this.mtgFoto = new byte[Convert.ToInt32(arqImagem.Length)];
                int iBytesRead = fs.Read(this.mtgFoto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }

    public class ModeloALog
    {
        public int alog_cod;
        public String? alog_code;
        public String? alog_desc;
        public String? alog_unity;
        public float alog_qtd;
        public String? alog_user;
        public String? alog_dest;
        public DateTime alog_dayTime;
        public float alog_inv;
        public bool alog_dir;//0 = out - 1 = in

        /*
        alog_cod
        alog_code
        alog_desc
        alog_unity
        alog_qtd
        alog_user
        alog_dest
        alog_dayTime
        alog_inv
        alog_dir

        alogCod
        alogCode
        alogDesc
        alogUnity
        alogQtd
        alogUser
        alogDest
        alogDayTime
        alogInv
        alogDir
         */

        public int alogCod
        {
            get { return this.alog_cod; }
            set { this.alog_cod = value; }
        }

        public String? alogCode
        {
            get { return this.alog_code; }
            set { this.alog_code = value; }
        }

        public String? alogDesc
        {
            get { return this.alog_desc; }
            set { this.alog_desc = value; }
        }

        public String? alogUnity
        {
            get { return this.alog_unity; }
            set { this.alog_unity = value; }
        }

        public float alogQtd
        {
            get { return this.alog_qtd; }
            set { this.alog_qtd = value; }
        }

        public String? alogUser
        {
            get { return this.alog_user; }
            set { this.alog_user = value; }
        }

        public String? alogDest
        {
            get { return this.alog_dest; }
            set { this.alog_dest = value; }
        }

        public DateTime alogDayTime
        {
            get { return this.alog_dayTime; }
            set { this.alog_dayTime = value; }
        }

        public float alogInv
        {
            get { return this.alog_inv; }
            set { this.alog_inv = value; }
        }

        public bool alogDir
        {
            get { return this.alog_dir; }
            set { this.alog_dir = value; }
        }
    }
}
