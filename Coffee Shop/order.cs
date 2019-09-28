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
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {

            try
            {
                string connection = @"Server=DESKTOP-55FHBO2; Database=CoffeeShopA; integrated security=true";
                SqlConnection sqlconnection = new SqlConnection(connection);

                string command = "select * from orders;";
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

        private void searchButton_Click(object sender, EventArgs e)
        {

            try
            {
                string connection = @"Server=DESKTOP-55FHBO2; Database=CoffeeShopA; integrated security=true";
                SqlConnection sqlconnection = new SqlConnection(connection);


                string command = "select * from orders where id = '" + searchTextBox.Text + "'";
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

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = @"Server=DESKTOP-55FHBO2; Database=CoffeeShopA; integrated security=true";
                SqlConnection sqlconnection = new SqlConnection(connection);


                string command = "insert into orders(quantity,totalprice,iid,cid) values (" + quantityTextBox.Text + ",'" + totalpriceTextBox.Text + "','" + itemidTextBox.Text + "','" + customeridTextBox.Text + "')";
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

        private void deleteButton_Click(object sender, EventArgs e)
        {

            try
            {
                string connection = @"Server=DESKTOP-55FHBO2; Database=CoffeeShopA; integrated security=true";
                SqlConnection sqlconnection = new SqlConnection(connection);

                string command = "delete from orders where id =" + idTextBox.Text + "";
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

                string command = "update orders set quantity = '" + quantityTextBox.Text + "',totalprice = '" + totalpriceTextBox.Text + "',iid = '" + itemidTextBox.Text + "' ,cid = '" + customeridTextBox.Text + "' where id = " + idTextBox.Text + "";
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
        private void clear()
        {
            idTextBox.Text = "";
            quantityTextBox.Text = "";
            totalpriceTextBox.Text = "";
            customeridTextBox.Text = "";
            itemidTextBox.Text = "";
            searchTextBox.Text = "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            try
            {
                string connection = @"Server=DESKTOP-55FHBO2; Database=CoffeeShopA; integrated security=true";
                SqlConnection sqlconnection = new SqlConnection(connection);

                SqlCommand cmd;
                string sql = "select price from item where iid = '" + itemidTextBox.Text + "'";

                sqlconnection.Open();

                cmd = new SqlCommand(sql, sqlconnection);
                SqlDataReader read = cmd.ExecuteReader();
                read.Read();
                if (read.HasRows)
                {

                    totalpriceTextBox.Text = read[0].ToString();
                    double totalprice = Convert.ToDouble(totalpriceTextBox.Text) * Convert.ToDouble(quantityTextBox.Text);
                    totalpriceTextBox.Text = totalprice.ToString();
                }
                else
                {
                    totalpriceTextBox.Text = "";
                }

                sqlconnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }


            
        }
    }
}
