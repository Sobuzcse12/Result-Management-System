using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace Model
{
   public class Student : connection
    {
        string ID = "";
        string name = "";
        string batch = "";
        float credit;
        static OleDbDataAdapter DataAdapter;
        static DataSet batchDataSet;

        public Student(string ID, string name, string batch, float credit)
        {
            this.ID = ID;
            this.name = name;
            this.batch = batch;
            this.credit = credit;
        }

        public Boolean create()
        {
            string dbQuery = "INSERT into Student values('" + ID + "','" + name + "'," + credit + ",'" + batch + "')";
            try
            {
                DataAdapter = new OleDbDataAdapter(dbQuery, Connection);
                batchDataSet = new DataSet();
                DataAdapter.Fill(batchDataSet);
                DataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DataAdapter.Dispose();
                return false;
            }
            return true;
        }

        public static DataTable findByBatch(string batch)
        {
            string getQuery = "select ID, Name, Credit from Student where BatchNumber = '" + batch + " ' ";

            DataAdapter = new OleDbDataAdapter(getQuery, Connection);
            // batchDataSet = new DataSet();
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);
            DataAdapter.Dispose();
            return dt;

        }
        public Batch update()
        {

            return null;
        }

        public Boolean delete()
        {
            return true;
        }
         
    }
}
