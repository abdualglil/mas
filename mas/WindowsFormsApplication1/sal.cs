using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    class sal
    {
        
        Cdb db = new Cdb();
        Mov_accont moco = new Mov_accont();
        int id_accont;
        item item = new item();
        public void insert_new(int typ, int hd_accon, string detaa, string name)
        {

            db.conTable = new SqlCommand("insert into sall(typ,id_acc,name,deta)values(" + typ + "," + hd_accon + ",'" + name + "','" + detaa + "')", db.mydb);
          
            db.mydb.Open();
            db.conTable.ExecuteNonQuery();
            db.mydb.Close();
            int num = int.Parse(numper());
            moco.daen_new(hd_accon, 1, num, detaa, 0, "لكم فاتورف شراء");
            id_accont = hd_accon;
        }
        public string numper()
        {

            db.conTable = new SqlCommand("SELECT MAX(id_sal) from sall", db.mydb);

            db.mydb.Open();
            string a = db.conTable.ExecuteScalar()+"";
            db.mydb.Close();
            return a;
        }
        public void add_item(int id_item, int type_no, int id_operation, string deta, int Quantity_inside, int price)
        {
            item.add_item_movitem_sal(id_item, type_no, id_operation, deta, Quantity_inside, price);


            int sm = int.Parse(sum(id_operation));
            moco.ubdet_daen_new(id_accont, 1, id_operation, sm);
        }
        public DataTable tab_item(int id_bil)
        {
            db.conTable = new SqlCommand("select mov_item.id_item,mov_item.Quantity_inside,mov_item.price,item.name,mov_item.Quantity_inside*mov_item.price from mov_item,item WHERE mov_item.Operation_type_no = 1 AND  mov_item.id_operation=" + id_bil + " AND mov_item.id_item=item.id_item", db.mydb);
            db.mydb.Open();
            SqlDataReader readandretrn = db.conTable.ExecuteReader();
            DataTable tab = new DataTable();
            tab.Load(readandretrn);
            db.mydb.Close();
            return tab;

        }
        public string sum(int id_bil)
        {
            db.conTable = new SqlCommand("select SUM(mov_item.price*mov_item.Quantity_inside) from mov_item WHERE mov_item.Operation_type_no = 1 AND  mov_item.id_operation=" + id_bil + "", db.mydb);
            db.mydb.Open();
            string a = db.conTable.ExecuteScalar() + "";
            db.mydb.Close();
            return a;


        }

        public void ubdet_item(int id_item, int type_no, int id_operation, int Quantity_inside, int price)
        {
            item.Ubdet_item_movitem_qi(id_item, type_no, id_operation, Quantity_inside, price);

            int sm = int.Parse(sum(id_operation));
            moco.ubdet_daen_new(id_accont, 1, id_operation, sm);
        }
    }
    }

