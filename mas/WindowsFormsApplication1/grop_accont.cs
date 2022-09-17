using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class grop_accont
    {
     
        
        Cdb db = new Cdb();

        public void insert(string name)
        {
            db.conTable = new SqlCommand("insert into grop_acoont(name)values('" + name + "')", db.mydb);
            db.mydb.Open();

            db.conTable.ExecuteNonQuery();
            db.mydb.Close();
        }
     public DataTable refresh(){
         db.conTable = new SqlCommand("select *from grop_acoont", db.mydb);
            db.mydb.Open();
            SqlDataReader readandretrn = db.conTable.ExecuteReader();
            DataTable tab = new DataTable();
            tab.Load(readandretrn);
            db.mydb.Close();
        return tab;
   
    }
     public void udeit(int id,string name)
     {
         db.conTable = new SqlCommand("update grop_acoont set name='" + name + "'where id_grop=" + id + "", db.mydb);
         db.mydb.Open();
         db.conTable.ExecuteNonQuery();
         db.mydb.Close();

     }
     public void Delet(int id)
     {
 
         db.conTable = new SqlCommand("Delete from grop_acoont Where id_grop=" + id + "", db.mydb);
         db.mydb.Open();
         db.conTable.ExecuteNonQuery();
         db.mydb.Close();

     }

     public DataTable copepox()
     {
         db.conTable = new SqlCommand("select *from grop_acoont", db.mydb);
         db.mydb.Open();
         SqlDataReader readandretrn = db.conTable.ExecuteReader();
         DataTable tab = new DataTable();
         tab.Columns.Add("id_grop");
         tab.Columns.Add("name");

         tab.Load(readandretrn);
         db.mydb.Close();
         return tab;
     }
   
    }

} 






