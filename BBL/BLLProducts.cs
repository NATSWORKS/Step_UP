//-----NATSWORKS & INTERLASER-----\\
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLProducts
    {
        public DALConnection connection;

        public BLLProducts(DALConnection cx)
        {
            this.connection = cx;
        }

        #region Produtos
        public void Include(ModeloProdutos modelo)
        {
            /*if (modelo.prodCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }*/

            //modelo.prodCode = modelo.prodCode.ToUpper();

            DALProducts DALobj = new DALProducts(connection);
            DALobj.Include(modelo);
        }

        public void Change(ModeloProdutos modelo)
        {
            if (modelo.prodCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }

            DALProducts DALobj = new DALProducts(connection);
            DALobj.Change(modelo);
        }

        public void Delete(int code)
        {
            DALProducts DALobj = new DALProducts(connection);
            DALobj.Delete(code);
        }

        public DataTable Localizar(String valor)
        {
            DALProducts DALobj = new DALProducts(connection);
            return DALobj.Localizar(valor); 
        }

        public DataTable LocalizarFornecedor(String valor)
        {
            DALProducts DALobj = new DALProducts(connection);
            return DALobj.LocalizarFornecedor(valor);
        }

        public DataTable LocalizarGrupo(String valor)
        {
            DALProducts DALobj = new DALProducts(connection);
            return DALobj.LocalizarGrupo(valor);
        }

        public DataTable LocalizarDescricao(String valor)
        {
            DALProducts DALobj = new DALProducts(connection);
            return DALobj.LocalizarDescricao(valor);
        }

        public ModeloProdutos CarregaModeloCategoria(int code)
        {
            DALProducts DALobj = new DALProducts(connection);
            return DALobj.CarregaModeloCategoria(code);
        }

        #endregion

        #region Fornecedor
        public void IncludeFornecedor(ModeloFornecedor modelo)
        {
            /*if (modelo.forCod <= 0)
            {
                throw new Exception("O código do fornecedor é obrigatório");
            }*/

            DALProducts DALobj = new DALProducts(connection);
            DALobj.IncludeFornecedor(modelo);
        }

        public void ChangeFornecedor(ModeloFornecedor modelo)
        {
            /*if (modelo.forNome.Trim().Length == 0)
            {
                throw new Exception("O nome do fornecedor é obrigatório");
            }*/

            DALProducts DALobj = new DALProducts(connection);
            DALobj.ChangeFornecedor(modelo);
        }

        public void DeleteFornecedor(int code)
        {
            DALProducts DALobj = new DALProducts(connection);
            DALobj.DeleteFornecedor(code);
        }

        public DataTable LocalizarForn(String valor)
        {
            DALProducts DALobj = new DALProducts(connection);
            return DALobj.LocalizarForn(valor);
        }

        public ModeloFornecedor CarregaModeloFornecedor(int code)
        {
            DALProducts DALobj = new DALProducts(connection);
            return DALobj.CarregaModeloFornecedor(code);
        }

        #endregion

        #region Usuário
        public void IncludeUser(ModeloUser modelo)
        {
            DALProducts DALobj = new DALProducts(connection);
            DALobj.IncludeUser(modelo);
        }

        public void ChangeUser(ModeloUser modelo)
        {
            DALProducts DALobj = new DALProducts(connection);
            DALobj.ChangeUser(modelo);
        }

        public void DeleteUser(int code)
        {
            DALProducts DALobj = new DALProducts(connection);
            DALobj.DeleteUser(code);
        }

        public DataTable LocalizarUser(String valor)
        {
            DALProducts DALobj = new DALProducts(connection);
            return DALobj.LocalizarUser(valor);
        }

        public DataTable LocalizarUserLog(String valor)
        {
            DALProducts DALobj = new DALProducts(connection);
            return DALobj.LocalizarUser(valor);
        }

        public ModeloUser CarregaModeloUser(int code)
        {
            DALProducts DALobj = new DALProducts(connection);
            return DALobj.CarregaModeloUser(code);
        }

        #endregion

        #region Compras
        public void IncludeCompra(ModeloCompra modelo)
        {
            DALProducts DALobj = new DALProducts(connection);
            DALobj.IncludeCompra(modelo);
        }

        public void ChangeCompra(ModeloCompra modelo)
        {
            DALProducts DALobj = new DALProducts(connection);
            DALobj.ChangeCompra(modelo);
        }

        public void DeleteCompra(int code)
        {
            DALProducts DALobj = new DALProducts(connection);
            DALobj.DeleteCompra(code);
        }

        public DataTable LocalizarCompra(String valor)
        {
            DALProducts DALobj = new DALProducts(connection);
            return DALobj.LocalizarCompra(valor);
        }

        public ModeloCompra CarregaModeloCompra(int code)
        {
            DALProducts DALobj = new DALProducts(connection);
            return DALobj.CarregaModeloCompra(code);
        }

        #endregion

        #region Assistência
        public void IncludeAssist(ModeloAssist modelo)
        {
            DALProducts DALobj = new DALProducts(connection);
            DALobj.IncludeAssist(modelo);
        }

        public void ChangeAssist(ModeloAssist modelo)
        {
            DALProducts DALobj = new DALProducts(connection);
            DALobj.ChangeAssist(modelo);
        }

        public void DeleteAssist(int code)
        {
            DALProducts DALobj = new DALProducts(connection);
            DALobj.DeleteAssist(code);
        }

        public DataTable LocalizarAssist(String valor)
        {
            DALProducts DALobj = new DALProducts(connection);
            return DALobj.LocalizarAssist(valor);
        }

        public ModeloAssist CarregaModeloAssist(int code)
        {
            DALProducts DALobj = new DALProducts(connection);
            return DALobj.CarregaModeloAssist(code);
        }

        #endregion

        #region Montagem
        public void IncludeMontagem(ModeloMontagem modelo)
        {
            DALProducts DALobj = new DALProducts(connection);
            DALobj.IncludeMontagem(modelo);
        }

        public void ChangeMontagem(ModeloMontagem modelo)
        {
            if (modelo.mtgCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório");
            }

            DALProducts DALobj = new DALProducts(connection);
            DALobj.ChangeMontagem(modelo);
        }

        public void DeleteMontagem(int code)
        {
            DALProducts DALobj = new DALProducts(connection);
            DALobj.DeleteMontagem(code);
        }

        public DataTable LocalizarMontagem(String valor)
        {
            DALProducts DALobj = new DALProducts(connection);
            return DALobj.LocalizarMontagem(valor);
        }

        public DataTable LocalizarDescricaoMtg(String valor)
        {
            DALProducts DALobj = new DALProducts(connection);
            return DALobj.LocalizarDescricaoMtg(valor);
        }

        public ModeloMontagem CarregaModeloMontagem(int code)
        {
            DALProducts DALobj = new DALProducts(connection);
            return DALobj.CarregaModeloMontagem(code);
        }

        #endregion

        #region Logs
        //Almoxarifado
        public void GenerateALog(ModeloALog modelo)
        {
            DALProducts DALobj = new DALProducts(connection);
            DALobj.GenerateALog(modelo);
        }

        public DataTable LocalizarALog(String valor)
        {
            DALProducts DALobj = new DALProducts(connection);
            return DALobj.LocalizarALog(valor);
        }

        #endregion
    }
}
