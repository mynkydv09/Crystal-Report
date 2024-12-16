using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Microsoft.VisualBasic;

namespace GetSingleRecordFromDB
{
    public partial class Form1 : Form
    {
        string connnectionstring = @"Data Source=.;Initial Catalog=practise;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connnectionstring);
            string query = "SELECT * FROM ORDERS";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            data.Load(reader);

            if (data.Rows.Count>0)
            {
                ReportViewFrom1 reportView = new ReportViewFrom1();
                string apppath = Application.StartupPath;
                string reportpath = @"CrystalReport.rpt";
                string fulllpath = Path.Combine(apppath, reportpath);
                reportView.ReportName = fulllpath;
                reportView.ReportData = data;
                reportView.Show();
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ordno = Convert.ToInt32(Interaction.InputBox("Enter Ord no. between 70001-70015", "Order number"));
            if (ordno != 0)
            {
                SqlConnection connection = new SqlConnection(connnectionstring);
                string query = "SELECT * FROM ORDERS where ordno="+ordno;
                SqlCommand command = new SqlCommand(query, connection);
                DataTable data = new DataTable();
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                data.Load(reader);

                if (data.Rows.Count > 0)
                {
                    ReportViewFrom1 reportView = new ReportViewFrom1();
                    string apppath = Application.StartupPath;
                    string reportpath = @"CrystalReport.rpt";
                    string fulllpath = Path.Combine(apppath, reportpath);
                    reportView.ReportName = fulllpath;
                    reportView.ReportData = data;
                    reportView.Show();
                }
                else
                {
                    MessageBox.Show("Record not found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Please enter Order Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int customerid = Convert.ToInt32(Interaction.InputBox("Enter Customer ID between 3001-3015", "Customer ID"));
            if(customerid != 0)
            {
                SqlConnection connection = new SqlConnection(connnectionstring);
                string query = "SELECT * FROM ORDERS where customerid=" + customerid;
                SqlCommand command = new SqlCommand(query, connection);
                DataTable data = new DataTable();
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                data.Load(reader);

                if (data.Rows.Count > 0)
                {
                    ReportViewFrom1 reportView = new ReportViewFrom1();
                    string apppath = Application.StartupPath;
                    string reportpath = @"CrystalReport.rpt";
                    string fulllpath = Path.Combine(apppath, reportpath);
                    reportView.ReportName = fulllpath;
                    reportView.ReportData = data;
                    reportView.Show();
                }
                else
                {
                    MessageBox.Show("Record not found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Please enter Customer ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int salesmanid = Convert.ToInt32(Interaction.InputBox("Enter Salesman ID between 5001-5015", "Salesman ID"));
            if (salesmanid != 0)
            {
                SqlConnection connection = new SqlConnection(connnectionstring);
                string query = "SELECT * FROM ORDERS where salesmanid=" + salesmanid;
                SqlCommand command = new SqlCommand(query, connection);
                DataTable data = new DataTable();
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                data.Load(reader);

                if (data.Rows.Count > 0)
                {
                    ReportViewFrom1 reportView = new ReportViewFrom1();
                    string apppath = Application.StartupPath;
                    string reportpath = @"CrystalReport.rpt";
                    string fulllpath = Path.Combine(apppath, reportpath);
                    reportView.ReportName = fulllpath;
                    reportView.ReportData = data;
                    reportView.Show();
                }
                else
                {
                    MessageBox.Show("Record not found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Please enter Salesman ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
