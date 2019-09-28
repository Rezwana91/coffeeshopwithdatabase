using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class item : Form
    {
        public item()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            try
            {


                

                string connection = @"Server=DESKTOP-55FHBO2; Database=CoffeeShopA; integrated security=true";
                SqlConnection sqlconnection = new SqlConnection(connection);

                string command = "insert into item(iname,price) values ('" + nameTextBox.Text + "','" + priceTextBox.Text + "')";
                SqlCommand com = new SqlCommand(command, sqlconnection);

                sqlconnection.Open();

                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Added");
                }
                else
                {
                    MessageBox.Show("Not Added");
                }

                sqlconnection.Close();

                clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }


            
            
      }

        private void showButton_Click(object sender, EventArgs e)
        {

            try
            {
                string connection = @"Server=DESKTOP-55FHBO2; Database=CoffeeShopA; integrated security=true";
                SqlConnection sqlconnection = new SqlConnection(connection);

                string command = "select * from item";
                SqlCommand com = new SqlCommand(command, sqlconnection);

                sqlconnection.Open();

                SqlDataAdapter sqldataadapter = new SqlDataAdapter(com);
                DataTable datatable = new DataTable();
                sqldataadapter.Fill(datatable);
                showDataGridView.DataSource = datatable;

                sqlconnection.Close();

                clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }


            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            try
            {
                string connection = @"Server=DESKTOP-55FHBO2; Database=CoffeeShopA; integrated security=true";
                SqlConnection sqlconnection = new SqlConnection(connection);

                string command = "delete from item where iid =" + idTextBox.Text + "";
                SqlCommand com = new SqlCommand(command, sqlconnection);

                sqlconnection.Open();

                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Deleted");
                }
                else
                {
                    MessageBox.Show("Not Deleted");
                }

                sqlconnection.Close();

                clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }


            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            try
            {
                string connection = @"Server=DESKTOP-55FHBO2; Database=CoffeeShopA; integrated security=true";
                SqlConnection sqlconnection = new SqlConnection(connection);

                string command = "update item set iname = '" + nameTextBox.Text + "',price = '" + priceTextBox.Text + "' where iid =" + idTextBox.Text + "";
                SqlCommand com = new SqlCommand(command, sqlconnection);

                sqlconnection.Open();

                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Updated");
                }
                else
                {
                    MessageBox.Show("Not Updated");
                }

                sqlconnection.Close();

                clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }


            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            try
            {
                string connection = @"Server=DESKTOP-55FHBO2; Database=CoffeeShopA; integrated security=true";
                SqlConnection sqlconnection = new SqlConnection(connection);


                string command = "select * from item where iname = '" + searchTextBox.Text + "'";
                SqlCommand com = new SqlCommand(command, sqlconnection);


                sqlconnection.Open();

                SqlDataAdapter sqldataadapter = new SqlDataAdapter(com);
                DataTable datatable = new DataTable();
                sqldataadapter.Fill(datatable);
                showDataGridView.DataSource = datatable;

                sqlconnection.Close();

                clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }


            



        }

        private void clear()
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            searchTextBox.Text = "";
        }
    }
}
