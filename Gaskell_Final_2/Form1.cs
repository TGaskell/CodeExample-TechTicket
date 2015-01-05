using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gaskell_Final_2
{
    public partial class frmAddIncident : Form
    {
        public frmAddIncident()
        {
            InitializeComponent();
        }

        DateTime currentDate = DateTime.Today;

        private void fillByCustomerIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //variable to get the integer entered into the
                //customer ID toolstrip text box
                int customerID = Convert.ToInt32(customerIDToolStripTextBox.Text);
                

                //fills the form with the customer information
                this.customersTableAdapter.FillByCustomerID(
                    this.techSupportDataSet.Customers, customerID);

                //if the customer ID is valid then fill the date textbox
                //with information for the corresponding customer ID
                if (customersBindingSource.Count > 0)
                {
                    this.registrationsTableAdapter.FillByRegDate(
                        this.techSupportDataSet.Registrations, customerID);
                    
                    //load date opened field with current date
                    txtDateOpened.Text = currentDate.ToShortDateString();
                    
                }
                else
                    //if customer ID not found show message
                    MessageBox.Show("No customer found with this ID. "
                        + "Please try again.", "Customer Not Found");
            }
            //if customer ID not an integer show message
            catch (FormatException)
            {
                MessageBox.Show("Customer ID must be an integer.", "Entry Error");
            }
            //if there is a problem with the sql database show message
            catch (SqlException ex) 
            {
                MessageBox.Show("Database error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }

        }

        
        private void frmAddIncident_Load(object sender, EventArgs e)
        {
            
        }

        //close the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        //cancel update and clear fields using method
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ClearControls();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                //saves data
                this.incidentsBindingSource.EndEdit();
                //updates changes to dataset
                this.incidentsTableAdapter.Update(this.techSupportDataSet.Incidents);

                MessageBox.Show("Update successful");

                this.ClearControls();

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Update failed");
                }
        
        }

        private void ClearControls()
        {
            customerIDToolStripTextBox.Text = "";
            txtCustID.Text = "";
            txtName.Text = "";
            txtDateOpened.Text = "";
            cboProduct.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
        }

     }   
}
