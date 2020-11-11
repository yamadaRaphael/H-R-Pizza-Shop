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
    public partial class OrderDetailsForm : Form
    {
        private PizzaApplicationEntities context; //Save db context here

        public OrderDetailsForm()
        {
            InitializeComponent();
            context = new PizzaApplicationEntities();
        }
    }
}
