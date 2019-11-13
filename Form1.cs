using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktinis_2
{
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Stacio.mdb;";
        public static string connectString2 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Nesio.mdb;";


        private OleDbConnection myConnection;
        private OleDbConnection myConnection2;

        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            string isvedimas = "SELECT Pavadinimas, Kiekis, Kaina FROM Stacio ORDER BY ID";
            OleDbCommand command = new OleDbCommand(isvedimas, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox2.Items.Clear();
            while (reader.Read())
            {
                listBox2.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " ");
            }
            reader.Close();

            myConnection2 = new OleDbConnection(connectString2);
            myConnection2.Open();
            string isvedimas2 = "SELECT Pavadinimas, Kiekis, Kaina FROM Nesio ORDER BY ID";
            OleDbCommand command2 = new OleDbCommand(isvedimas2, myConnection2);
            OleDbDataReader reader2 = command2.ExecuteReader();
            listBox1.Items.Clear();
            while(reader2.Read())
            {
                listBox1.Items.Add(reader2[0].ToString() + " " + reader2[1].ToString() + " " + reader2[2].ToString() + " ");
            }
            reader2.Close();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = true;
            panel3.BringToFront();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
  
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = true;
            panel4.BringToFront();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
            myConnection2.Close();
        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
