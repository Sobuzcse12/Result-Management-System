using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
namespace Model
{
    public class Discipline : connection
    {
        public string Name = "";
        public string Session = "";
        OleDbDataAdapter DataAdapterTest;
        DataSet BooksDataSet;
        public Discipline()
        {

        }

        public Discipline(string name, string session)
        {
            this.Name = name;
            this.Session = session;
        }

        public Boolean create()
        {
            string dbcommand = "INSERT into Creat_Discipline values('" + Name + "','" + Session + "')";
            try
            {
                DataAdapterTest = new OleDbDataAdapter(dbcommand, Connection);
                BooksDataSet = new DataSet();
                DataAdapterTest.Fill(BooksDataSet);
                DataAdapterTest.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        public static Discipline getDiscipline()
        {
            string getQuery = "select * from Creat_Discipline";
            Discipline batch = new Discipline();
            OleDbConnection connect = new OleDbConnection(Connection);
            OleDbCommand dbCommand = new OleDbCommand(getQuery, connect);
            connect.Open();
            OleDbDataReader dr = dbCommand.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                batch.Name = dr.GetString(0);
                batch.Session = dr.GetString(1);

            }

            connect.Close();
            return batch;
        }
        public Discipline update()
        {

            return null;
        }

        public Boolean delete()
        {
            return true;
        }
    }
}
