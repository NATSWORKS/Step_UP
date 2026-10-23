using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataConnection
    {
        public static String stringConnection
        {
            get
            {
                return "Data Source=INTERLASER06;Initial Catalog=ControleGeral;Persist Security Info=True;User ID=sa;Password=102030";
            }
        }
    }
}