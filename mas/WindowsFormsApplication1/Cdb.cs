using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Cdb
    {

     public   SqlConnection mydb = new SqlConnection(@"Data Source=DESKTOP-IFFGKN1\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True");
    public      SqlCommand conTable;


    }
}
