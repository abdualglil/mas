using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    class Mov_accont{
    
        Cdb db = new Cdb();
        public void maden_new(int id_acc, int Operation_type_no, int id_operation, string deta, int maden_amont, string details)
        {
            db.conTable = new SqlCommand("insert into mov_accont(id_acc,Operation_type_no,id_operation,deta,maden_amont,details)values(" + id_acc + "," + Operation_type_no +","+ id_operation + ",'" + deta +"',"+ maden_amont + ",'" + details +"')", db.mydb);
            db.mydb.Open();
            db.conTable.ExecuteNonQuery();
            db.mydb.Close();
        }
        public void daen_new(int id_acc, int Operation_type_no, int id_operation, string deta, int daen_amont, string details)
        {
            db.conTable = new SqlCommand("insert into mov_accont(id_acc,Operation_type_no,id_operation,deta,daen_amont,details)values(" + id_acc + "," + Operation_type_no + "," + id_operation + ",'" + deta + "'," + daen_amont + ",'" + details + "')", db.mydb);
            db.mydb.Open();
            db.conTable.ExecuteNonQuery();
            db.mydb.Close();
        }
        public void udet_maden_new(int id_acc, int Operation_type_no, int id_operation, int maden_amont)
        {
            db.conTable = new SqlCommand("update  mov_accont set maden_amont=" + maden_amont + "where id_acc=" + id_acc + "AND  Operation_type_no=" + Operation_type_no + "AND id_operation="+id_operation, db.mydb);
            db.mydb.Open();
            db.conTable.ExecuteNonQuery();
            db.mydb.Close();
        }
        public void ubdet_daen_new(int id_acc, int Operation_type_no, int id_operation,  int daen_amont)
        {
            db.conTable = new SqlCommand("update  mov_accont set daen_amont=" + daen_amont + "where id_acc=" + id_acc + "AND  Operation_type_no=" + Operation_type_no + "AND id_operation=" + id_operation, db.mydb);
            db.mydb.Open();
            db.conTable.ExecuteNonQuery();
            db.mydb.Close();
        }
        public DataTable mov_con_tab(int id_accont)
        {
            db.conTable = new SqlCommand("select Operation_type_no,id_operation,deta,maden_amont,daen_amont,details from mov_accont where id_acc="+id_accont, db.mydb);
            db.mydb.Open();
            SqlDataReader readandretrn = db.conTable.ExecuteReader();
            DataTable tab = new DataTable();
         
            tab.Load(readandretrn);
            db.mydb.Close();
            return tab;

        }
        public string sum_daen(int id_bil)
        {
            db.conTable = new SqlCommand("select SUM(daen_amont) from mov_accont WHERE id_acc=" + id_bil + "", db.mydb);
            db.mydb.Open();
            string a = db.conTable.ExecuteScalar() + "";
            db.mydb.Close();
           // int b = int.Parse(a);
            return a;


        }
        public string sum_maden(int id_bil)
        {
            db.conTable = new SqlCommand("select SUM(maden_amont) from mov_accont WHERE id_acc=" + id_bil + "", db.mydb);
            db.mydb.Open();
            string a = db.conTable.ExecuteScalar() + "";
            db.mydb.Close();
        //    int b = int.Parse(a);
            return a ;


        }
     
    }
}
