using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerForm
{
    public partial class PizzaCustomerForm : Form
    {
        public PizzaCustomerForm()
        {
            InitializeComponent();
            buttonSubmit.Click += ButtonSubmit_Click;
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            Validation();
        }

        public void Validation()
        {
            string firstName, lastName, address;
            double number;

            if (String.IsNullOrEmpty(textBoxFirstName.Text))
            {
                MessageBox.Show("Please enter a valid first name");
            }
            else
            {
                firstName = textBoxFirstName.Text;
                if (String.IsNullOrEmpty(textBoxLastName.Text))
                {
                    MessageBox.Show("Please enter a valid last name");
                }
                else
                {
                    lastName = textBoxLastName.Text;
                    if (String.IsNullOrEmpty(textBoxAddress.Text))
                    {
                        MessageBox.Show("Please enter a valid address");
                    }
                    else
                    {
                        address = textBoxAddress.Text;
                        double.TryParse(textBoxPhone.Text, out number);
                        if (number == 0)
                        {
                            MessageBox.Show("Please enter a valid phone number");
                        }
                    }
                }
            }
        }
    }
}
