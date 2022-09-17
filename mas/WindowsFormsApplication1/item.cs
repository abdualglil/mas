using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApplication1
{

    class item
    {
          Cdb db = new Cdb();
          public void insert_new(string name, int i_quantity, int i_quantitys_price, int pric_sal)
        {// اضافه صنف جديد
            db.conTable = new SqlCommand("insert into item(name,i_quantity,i_quantitys_price,pric_Sale)values('" + name + "'," + i_quantity + "," + i_quantitys_price + "," + pric_sal + ")", db.mydb);
            db.mydb.Open();
            db.conTable.ExecuteNonQuery();
            db.mydb.Close();
        }
            public void udeit(int id,string name, int i_quantitys_price)
        {// تعديل بيانات الصنف
            db.conTable = new SqlCommand("update item set name='" + name + "',i_quantitys_price= " + i_quantitys_price + " where id_item=" + id + "", db.mydb);
            db.mydb.Open();
            db.conTable.ExecuteNonQuery();
            db.mydb.Close();

        }

        public DataTable refresh()
        {// يرجع جدول بيانات 
            db.conTable = new SqlCommand("select id_item,name,i_quantity,i_quantitys_price,pric_Sale from item", db.mydb);
            db.mydb.Open();
            SqlDataReader readandretrn = db.conTable.ExecuteReader();
            DataTable tab = new DataTable();
            tab.Load(readandretrn);
            db.mydb.Close();
            return tab;

        }

        public DataTable return_item()
        {//جدول اسم وارقام الاصناف من اجل COMPEBOX
            db.conTable = new SqlCommand("select id_item,name from item", db.mydb);
            db.mydb.Open();
            SqlDataReader readandretrn = db.conTable.ExecuteReader();
            DataTable tab = new DataTable();
            tab.Load(readandretrn);
            db.mydb.Close();
            return tab;

        }
        public void add_item_movitem(int id_item, int type_no, int id_operation, string deta, int Quantity_Outside, int price)
        {//اضاقه عنصر لفاتوره البيع في جدول عمليات الاصناف ناقص عنصر
            db.conTable = new SqlCommand("insert into mov_item(id_item,Operation_type_no,id_operation,deta,Quantity_Outside,price)values(" + id_item + "," + type_no + "," + id_operation + ",'" + deta + "'," + Quantity_Outside + "," + price + ")", db.mydb);

            db.mydb.Open();
            db.conTable.ExecuteNonQuery();
            db.mydb.Close();
            udetstor(id_item);
        }
        public void add_item_movitem_sal(int id_item, int type_no, int id_operation, string deta, int Quantity_inside, int price)
        {//اضاقه عنصر لفاتوره الشراء في جدول عمليات الاصناف زياده عنصر
            db.conTable = new SqlCommand("insert into mov_item(id_item,Operation_type_no,id_operation,deta,Quantity_inside,price)values(" + id_item + "," + type_no + "," + id_operation + ",'" + deta + "'," + Quantity_inside + "," + price + ")", db.mydb);

            db.mydb.Open();
            db.conTable.ExecuteNonQuery();
            db.mydb.Close();
            udetstor(id_item);
        }
        public int sum_quntete_outsid(int id_item)
        {
            int suq = 0;
            //-mov_item.Quantity_inside
            // جلب كميه المخزون وفق جدول العمليات
            db.conTable = new SqlCommand("select SUM(Quantity_Outside) from mov_item WHERE id_item=" + id_item + "", db.mydb);
            db.mydb.Open();
            string a = db.conTable.ExecuteScalar() + "";
            db.mydb.Close();
            try
            {
             suq = int.Parse(a);
            }
            catch
            {

            }
           
            return suq;

        }
        public int sum_quntete_inside(int id_item)
        {
            int suq = 0;
            //-mov_item.Quantity_inside
            // جلب كميه المخزون وفق جدول العمليات
            db.conTable = new SqlCommand("select SUM(Quantity_inside) from mov_item WHERE id_item=" + id_item + "", db.mydb);
            db.mydb.Open();
            string a = db.conTable.ExecuteScalar() + "";
            db.mydb.Close();
            try
            {
                suq = int.Parse(a);
            }
            catch
            {

            }

            return suq;

        }
        public void udetquntete(int id_item, int quntete)
        {// تعديل الكميه في جدول الاصناف
            db.conTable = new SqlCommand("update item set i_quantity=" + quntete + "where id_item=" + id_item + "", db.mydb);
            db.mydb.Open();
            db.conTable.ExecuteNonQuery();
            db.mydb.Close();
        }
        public DataTable getstoreg_on(int id_item)
        {// جلب مخزون صنف واحد من جدول الاصناف
            db.conTable = new SqlCommand("select id_item,name,i_quantity,i_quantity*i_quantitys_price from item WHERE id_item=" + id_item + "", db.mydb);
            db.mydb.Open();
            SqlDataReader readandretrn = db.conTable.ExecuteReader();
            DataTable tab = new DataTable();
            tab.Load(readandretrn);
            db.mydb.Close();
            return tab;
        }
        public DataTable getstoreg_all()
        {// جلب كمخزون كافه الاصناف
            db.conTable = new SqlCommand("select id_item,name,i_quantity,i_quantity*i_quantitys_price from item", db.mydb);
            db.mydb.Open();
            SqlDataReader readandretrn = db.conTable.ExecuteReader();
            DataTable tab = new DataTable();
            tab.Load(readandretrn);
            db.mydb.Close();
            return tab;
        }
        public void Ubdet_item_movitem_qq(int id_item, int type_no, int id_operation, int Quantity_Outside, int price)
        {//تعديل صنف في جدول حركه الاصناف لفاتوره البيع ناقص عنصر
            db.conTable = new SqlCommand("update mov_item set id_item = " + id_item + " , Quantity_Outside=" + Quantity_Outside + ", price = " + price + " WHERE Operation_type_no =" + type_no + " AND id_operation = " + id_operation + "AND id_item = " + id_item + "", db.mydb);
            db.mydb.Open();
            db.conTable.ExecuteNonQuery();
            db.mydb.Close();
            udetstor(id_item);
        }
        public void Ubdet_item_movitem_qi(int id_item, int type_no, int id_operation, int Quantity_inside, int price)
        {//تعديل صنف في جدول حركه الاصناف لفاتوره الشراء زياده عنصر
            db.conTable = new SqlCommand("update mov_item set id_item = " + id_item + " , Quantity_inside=" + Quantity_inside + ", price = " + price + " WHERE Operation_type_no =" + type_no + " AND id_operation = " + id_operation + "AND id_item = " + id_item + "", db.mydb);
            db.mydb.Open();
            db.conTable.ExecuteNonQuery();
            db.mydb.Close();
            udetstor(id_item);
        }
        public void udetstor(int id) {

            int sum1 = sum_quntete_outsid(id);
            int sum2 = sum_quntete_inside(id);
            int storeg = sum2 - sum1;
            udetquntete(id, storeg);

        }


    }
}
