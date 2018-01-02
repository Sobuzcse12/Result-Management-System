using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Model
{
   public class Batch : connection
    {
         
            public string batchNumber = "";
            public string term = "";
            private OleDbDataAdapter DataAdapter;
            private DataSet batchDataSet;

            public Batch()
            {

            }

            public Batch(string number, string term)
            {
                this.batchNumber = number;
                this.term = term;
            }

            public Boolean create()
            {
                string dbQuery = "INSERT into Creat_batch values('" + batchNumber + "','" + term + "')";
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
                    return false;
                }
                return true;
            }

            public static Batch[] getAll()
            {
                List<Batch> batchs = new List<Batch>();
                string getQuery = "select * from Batch";
                OleDbConnection connect = new OleDbConnection(Connection);
                OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
                connect.Open();
                OleDbDataReader dr = dbCommand.ExecuteReader();
                if (dr.HasRows)
                    while (dr.Read())
                    {
                        Batch batch = new Batch();
                        batch.batchNumber = dr.GetString(0);
                        batch.term = dr.GetString(1);
                        batchs.Add(batch);

                    }
                connect.Close();
                return batchs.ToArray();
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