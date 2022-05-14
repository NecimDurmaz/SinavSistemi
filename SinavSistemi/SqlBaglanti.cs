using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SinavSistemi
{
    public class SqlBaglanti
    {
      public SqlConnection baglanti()
        {
            SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-O30S5K7;Initial Catalog=SinavSistemi;Integrated Security=True");
            bgl.Open();
            return bgl;
        }
    }
}
