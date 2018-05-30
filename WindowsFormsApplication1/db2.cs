using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/** This file contains MS Access (.mdb) CRUD operations
 *  Reference: https://www.codeproject.com/Tips/858771/MS-Access-mdb-plus-Csharp-SELECT-INSERT-DELETE-and
 */

using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    
    public partial class db2 : Form
    {
        private string dbpath="../../../../sem1r.mdb";
        private OleDbConnection conn;
            //= new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;" + "Data Source=" + path);
        //conn.Open();

        public db2()
        {
            InitializeComponent();
            Connect();
        }

        private void db2_Load(object sender, EventArgs e)
        {
            //OleDbDataAdapter adapter = new OleDbDataAdapter("select * from sem1r", conn);
            //adapter.Fill(dgv1.);
            selectData("select * from sem1r");
            
        }


        private bool selectData(String sql)
        {
            bool res = false;
            try
            {
                using (DataTable dt = new DataTable())
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn))
                    {
                        adapter.Fill(dt);
                    }
                    dgv1.DataSource = dt;

                    //dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    //dgv1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                    //set autosize mode
                    for (int i = 0; i < dgv1.Columns.Count - 1; i++)
                    {
                        dgv1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                    dgv1.Columns[dgv1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    for (int i = 0; i < dgv1.Columns.Count; i++)
                    {
                        int colw = dgv1.Columns[i].Width;
                        dgv1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dgv1.Columns[i].Width = colw;
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return res;
            }

        }



        private void Connect() //__________________________________________________________
        {
            //OleDbConnection conn = null;
            //OleDbDataReader reader = null;
            try
            {
                //conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; " + "Data Source=" + "../../../../sem1r.mdb");

                conn = new OleDbConnection(
                    "Provider=Microsoft.Jet.OLEDB.4.0; " +
                    "Data Source=" + dbpath);
                conn.Open();

                //OleDbCommand cmd = new OleDbCommand("Select * FROM sem1r", conn);
                //reader = cmd.ExecuteReader();

                //datagrid.DataSource = reader;
                //datagrid.DataBind();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show(e.ToString());
            //  Response.Write(e.Message);
            //  Response.End();
            }
            /*finally
            {
                if (reader != null) reader.Close();
                if (conn != null) conn.Close();
            }*/
        } //end of connect()___________________________________
    }
}
