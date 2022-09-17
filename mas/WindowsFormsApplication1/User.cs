using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    class User
    {
        Cdb db = new Cdb();


        public DataTable retern()
        {
            db.conTable = new SqlCommand("select id,username from userr", db.mydb);
            db.mydb.Open();
            SqlDataReader readandretrn = db.conTable.ExecuteReader();
            DataTable tab = new DataTable();
            tab.Columns.Add("id");
            tab.Columns.Add("username");

            tab.Load(readandretrn);
            db.mydb.Close();
            return tab;

        }



        public Boolean chek(int id, string paswerd)
        {
            Boolean chek = false;
            string pas= getpasswerd(id);
            if (pas.Equals(paswerd))
            {
                chek = true;
            }

            return chek;

        }

        public string getpasswerd(int id)
        {
            db.conTable = new SqlCommand("select passwerd from userr WHERE id="+id, db.mydb);
            db.mydb.Open();
            string a = db.conTable.ExecuteScalar() + "";
            db.mydb.Close();
            return a;
        }
        
    }
}
