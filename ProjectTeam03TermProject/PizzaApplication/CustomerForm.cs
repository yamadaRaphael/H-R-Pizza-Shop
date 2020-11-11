using PizzaApplication.EF_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApplication
{
    public partial class CustomerForm : Form
    {
        private PizzaApplicationEntities context; //Save db context here

        public CustomerForm()
        {
            InitializeComponent();

            context = new PizzaApplicationEntities();

            //Event add into specifics buttons
            buttonSubmit.Click += ButtonSubmit_Click;
            buttonOrderDetails.Click += ButtonOrderDetails_Click;
        }

        private void ButtonOrderDetails_Click(object sender, EventArgs e)
        {
            OrderDetailsForm obj = new OrderDetailsForm();
            obj.Show();
            this.Close();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            //Check the validation using method Validation
            if (Validation())
            {
                //Add all the customer information into a list
                List<Customer> customer_detail = new List<Customer>()
                {
                    new Customer
                    {
                        CustomerFirstName = textBoxFirstName.Text.ToString(),
                        CustomerLastName =  textBoxLastName.Text.ToString(),
                        CustomerAddress = textBoxAddress.Text.ToString(),
                        CustomerPhoneNumber = textBoxPhone.Text.ToString()
                    }
                };

                //Add into database
                context.Customers.AddRange(customer_detail);
                context.SaveChanges();
            }
        }

        public Boolean Validation()
        {
            //Validation all the text fields
            string firstName, lastName, address;
            double number;

            //Check the first name
            if (String.IsNullOrEmpty(textBoxFirstName.Text))
            {
                MessageBox.Show("Please enter a valid first name");
                return false;
            }
            else
            {
                firstName = textBoxFirstName.Text;
                //Check the last name
                if (String.IsNullOrEmpty(textBoxLastName.Text))
                {
                    MessageBox.Show("Please enter a valid last name");
                    return false;
                }
                else
                {
                    lastName = textBoxLastName.Text;
                    //Check the address
                    if (String.IsNullOrEmpty(textBoxAddress.Text))
                    {
                        MessageBox.Show("Please enter a valid address");
                        return false;
                    }
                    else
                    {
                        address = textBoxAddress.Text;
                        //Check the phone
                        double.TryParse(textBoxPhone.Text, out number);
                        if (number == 0)
                        {
                            MessageBox.Show("Please enter a valid phone number");
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
