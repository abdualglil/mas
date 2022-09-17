using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    class acoont
    {
        Cdb db = new Cdb();

        public void insert_new(int id_grop,string name_aco)
        {
            db.conTable = new SqlCommand("insert into accont(id_grop,nema)values(" + id_grop + ",'" + name_aco + "')", db.mydb);
            db.mydb.Open();
            db.conTable.ExecuteNonQuery();
            db.mydb.Close();
        }
        public void udeit(int id,int idgrop ,string name)
        {
            db.conTable = new SqlCommand("update accont set nema='" + name + "',id_grop= " + idgrop + " where id_accont=" + id + "", db.mydb);
            db.mydb.Open();
            db.conTable.ExecuteNonQuery();
            db.mydb.Close();

        }

        public DataTable refresh()
        {
            db.conTable = new SqlCommand("select accont.id_accont,accont.nema,grop_acoont.name from accont,grop_acoont WHERE accont.id_grop=grop_acoont.id_grop", db.mydb);
            db.mydb.Open();
            SqlDataReader readandretrn = db.conTable.ExecuteReader();
            DataTable tab = new DataTable();
            tab.Load(readandretrn);
            db.mydb.Close();
            return tab;

        }
        public DataTable reternaccont()
        {
            db.conTable = new SqlCommand("select id_accont,nema from accont", db.mydb);
            db.mydb.Open();
            SqlDataReader readandretrn = db.conTable.ExecuteReader();
            DataTable tab = new DataTable();
            tab.Columns.Add("id_accont");
            tab.Columns.Add("nema");

            tab.Load(readandretrn);
            db.mydb.Close();
            return tab;

        }
        public DataTable get_acont_waer(int id)
        {
            db.conTable = new SqlCommand("select id_accont,nema from accont WHERE id_grop="+id, db.mydb);
            db.mydb.Open();
            SqlDataReader readandretrn = db.conTable.ExecuteReader();
            DataTable tab = new DataTable();
            tab.Columns.Add("id_accont");
            tab.Columns.Add("nema");

            tab.Load(readandretrn);
            db.mydb.Close();
            return tab;

        }
     
    }
}
