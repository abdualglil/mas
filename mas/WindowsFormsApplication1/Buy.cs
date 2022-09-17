using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Buy
    {
        Cdb db = new Cdb();
        item item = new item();

        Mov_accont moco = new Mov_accont();
        int id_accont;
        public void insert_new(int typ, int hd_accon, string detaa, string name)
        {

            db.conTable = new SqlCommand("insert into bauy(typ,hd_accon,name,deta)values(" + typ + "," + hd_accon + ",'" + name + "','" + detaa + "')", db.mydb);
          
            db.mydb.Open();
            db.conTable.ExecuteNonQuery();
            db.mydb.Close();
            int num =int.Parse( numper());
            moco.maden_new(hd_accon, 2, num, detaa, 0, "عليكم فاتورف بيع");
            id_accont = hd_accon;
        }
        public string numper()
        {

            db.conTable = new SqlCommand("SELECT MAX(id_bauy) from bauy", db.mydb);

            db.mydb.Open();
            string a = db.conTable.ExecuteScalar()+"";
            db.mydb.Close();
            return a;
        }
        public void add_item(int id_item, int type_no, int id_operation, string deta, int Quantity_Outside, int price)
        {
            item.add_item_movitem(id_item, type_no, id_operation, deta, Quantity_Outside, price);
     
            int sm=int.Parse(sum(id_operation));
            moco.udet_maden_new(id_accont, 2, id_operation, sm);
        }
        public DataTable tab_item(int id_bil)
        {
            db.conTable = new SqlCommand("select mov_item.id_item,mov_item.Quantity_Outside,mov_item.price,item.name,mov_item.Quantity_Outside*mov_item.price from mov_item,item WHERE mov_item.Operation_type_no = 2 AND  mov_item.id_operation=" + id_bil + " AND mov_item.id_item=item.id_item", db.mydb);
            db.mydb.Open();
            SqlDataReader readandretrn = db.conTable.ExecuteReader();
            DataTable tab = new DataTable();
            tab.Load(readandretrn);
            db.mydb.Close();
            return tab;

        }
        public string sum(int id_bil)
        {
            db.conTable = new SqlCommand("select SUM(mov_item.price*mov_item.Quantity_Outside) from mov_item WHERE mov_item.Operation_type_no = 2 AND  mov_item.id_operation=" + id_bil + "", db.mydb);
            db.mydb.Open();
            string a = db.conTable.ExecuteScalar() + "";
            db.mydb.Close();
            return a;


        }


        public void ubdet_item(int id_item, int type_no, int id_operation, int Quantity_Outside, int price)
        {
            item.Ubdet_item_movitem_qq(id_item, type_no, id_operation, Quantity_Outside, price);

            int sm = int.Parse(sum(id_operation));
            moco.udet_maden_new(id_accont, 2, id_operation, sm);
        }
    }
}
