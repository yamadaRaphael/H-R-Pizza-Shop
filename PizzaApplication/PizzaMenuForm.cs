using PizzaApplication.EF_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApplication
{
    public partial class PizzaMenuForm : Form
    {

        private PizzaApplicationEntities context; //Save db context here

        public PizzaMenuForm()
        {
            InitializeComponent();
            context = new PizzaApplicationEntities();

            //Event add into specifics buttons
            this.Load += PizzaMenuForm_Load;
            comboBoxPizzaSize.SelectedIndexChanged += ComboBoxPizzaSize_SelectedIndexChanged;
            buttonAddToOrder.Click += ButtonAddToOrder_Click;
            dataGridViewPizzaMenu.SelectionChanged += DataGridViewPizzaMenu_SelectionChanged;
            buttonProceedToCheckout.Click  += ButtonProceedToCheckout_Click;
        }

        private void ButtonProceedToCheckout_Click(object sender, EventArgs e)
        {
            //Linq statement
            var orderdetail = from detail in context.OrderDetails
                              select detail;

            //Check if order is zero
            if (orderdetail.Count() == 0)
            {
                MessageBox.Show("Please add Pizza to cart!");
            }

            //If not close
            else
            {
                CustomerForm obj = new CustomerForm();
                obj.Show();
                this.Close();
            }
        }

        private void PizzaMenuForm_Load(object sender, EventArgs e)
        {
            SeedPizzaDataTables();
        }

        private void SeedPizzaDataTables()
        {
            // set up database log to write to output window in VS
            context.Database.Log = (s => Debug.Write(s));

            //Set the dataGridView
            dataGridViewPizzaMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Delete and create the database
            context.Database.Delete();
            context.Database.Create();

            //Clear and save any changes into database
            context.Pizzas.Local.Clear();
            context.PizzaSizes.Local.Clear();
            context.SaveChanges();

            //List of types of pizzas and the descriptions
            List<Pizza> pizzas = new List<Pizza>()
            {
                //Pizza name and description
                new Pizza{ PizzaName="Hawaiian", PizzaDescription="The amazing and classic combination of ham and pineapple on a base of your choice with extra pizza mozzarella." },
                new Pizza{ PizzaName="Meat Lover's", PizzaDescription="Pepperoni, Italian sausage, mild sausage, beef topping, ham, bacon crumble and pizza mozzarella." },
                new Pizza{ PizzaName="Pepperoni Lover's", PizzaDescription="Double pepperoni and extra pizza mozzarella."},
                new Pizza{ PizzaName="Veggie Lover's", PizzaDescription="Mushrooms, green pepper, red onion, ripe tomato and pizza mozzarella."},
                new Pizza{ PizzaName="Triple Crown", PizzaDescription="Pepperoni, mushrooms, crisp green peppers and crowned with 100% pizza."},
                new Pizza{ PizzaName="Smokey Maple Bacon", PizzaDescription="Creamy alfredo sauce, maple bacon strips, bacon strips, bacon crumble, sliced mushroom, smoked aged cheddar and pizza mozzarella."},
                new Pizza{ PizzaName="Creamy Butter Chicken", PizzaDescription="Creamy butter chicken sauce, grilled chicken strips, roasted red pepper, red onion and pizza mozzarella."},
                new Pizza{ PizzaName="Grilled Chicken Arrabbiata", PizzaDescription="Grilled chicken breast, crisp green peppers, grilled red peppers, red onions, pesto marinated tomatoes, chili flakes & pizza mozzarella."},
                new Pizza{ PizzaName="Grilled Chicken Rustico", PizzaDescription="Grilled chicken breast , grilled red peppers, marinated pesto tomatoes and pizza mozzarella."},
                new Pizza{ PizzaName="Chicken Caesar", PizzaDescription="Hail Caesar! The classic salad inspired this pizza with grilled chicken, bacon, roasted garlic, creamy alfredo sauce and 100% pizza mozzarella and parmesan cheeses."}
            };
            //Add the list into database.
            context.Pizzas.AddRange(pizzas);

            //List of pizza sizes and prices
            List<PizzaSize> sizes = new List<PizzaSize>()
            {
                //Pizza name and price
                new PizzaSize{ SizePizzaId=1, Size="Small", PizzaPrice = 11},
                new PizzaSize{ SizePizzaId=1, Size="Medium", PizzaPrice = 13},
                new PizzaSize{ SizePizzaId=1, Size="Large", PizzaPrice = 16},
                new PizzaSize{ SizePizzaId=2, Size="Small", PizzaPrice = 12},
                new PizzaSize{ SizePizzaId=2, Size="Medium", PizzaPrice = 14},
                new PizzaSize{ SizePizzaId=2, Size="Large", PizzaPrice = 17},
                new PizzaSize{ SizePizzaId=3, Size="Small", PizzaPrice = 11},
                new PizzaSize{ SizePizzaId=3, Size="Medium", PizzaPrice = 13},
                new PizzaSize{ SizePizzaId=3, Size="Large", PizzaPrice = 16},
                new PizzaSize{ SizePizzaId=4, Size="Small", PizzaPrice = 10},
                new PizzaSize{ SizePizzaId=4, Size="Medium", PizzaPrice = 13},
                new PizzaSize{ SizePizzaId=4, Size="Large", PizzaPrice = 16},
                new PizzaSize{ SizePizzaId=5, Size="Small", PizzaPrice = 12},
                new PizzaSize{ SizePizzaId=5, Size="Medium", PizzaPrice = 16},
                new PizzaSize{ SizePizzaId=5, Size="Large", PizzaPrice = 19},
                new PizzaSize{ SizePizzaId=6, Size="Small", PizzaPrice = 12},
                new PizzaSize{ SizePizzaId=6, Size="Medium", PizzaPrice = 15},
                new PizzaSize{ SizePizzaId=6, Size="Large", PizzaPrice = 18},
                new PizzaSize{ SizePizzaId=7, Size="Small", PizzaPrice = 12},
                new PizzaSize{ SizePizzaId=7, Size="Medium", PizzaPrice = 14},
                new PizzaSize{ SizePizzaId=7, Size="Large", PizzaPrice = 18},
                new PizzaSize{ SizePizzaId=8, Size="Small", PizzaPrice = 12},
                new PizzaSize{ SizePizzaId=8, Size="Medium", PizzaPrice = 14},
                new PizzaSize{ SizePizzaId=8, Size="Large", PizzaPrice = 17},
                new PizzaSize{ SizePizzaId=9, Size="Small", PizzaPrice = 13},
                new PizzaSize{ SizePizzaId=9, Size="Medium", PizzaPrice = 16},
                new PizzaSize{ SizePizzaId=9, Size="Large", PizzaPrice = 19},
                new PizzaSize{ SizePizzaId=10, Size="Small", PizzaPrice = 14},
                new PizzaSize{ SizePizzaId=10, Size="Medium", PizzaPrice = 17},
                new PizzaSize{ SizePizzaId=10, Size="Large", PizzaPrice = 20},
            };
            //Add the pizza sizes into database
            context.PizzaSizes.AddRange(sizes);
            context.SaveChanges();

            //Linq statement
            var pizzaMenu =
              (
              from pizza in context.Pizzas
              orderby pizza.PizzaId
              select new PizzaMenuDescription
              {
                  PizzaId = pizza.PizzaId,
                  PizzaName = pizza.PizzaName,
                  PizzaDescription = pizza.PizzaDescription
              }).ToList();

            // Set gridview datasource to the query result
            dataGridViewPizzaMenu.DataSource = pizzaMenu;
            dataGridViewPizzaMenu.Refresh();

            //Set dataGridView columns width
            dataGridViewPizzaMenu.Columns[2].Width = 850;

            //Call methods to reset controls
            ResetAndIntilizePizzaSizeComboBox();
            ResetAndIntilizeQuantityComboBox();
        }

        private void ResetAndIntilizePizzaSizeComboBox()
        {
            //Reset pizza size comboBox
            comboBoxPizzaSize.Items.Clear();
            comboBoxQuantity.Items.Clear();
            comboBoxPizzaSize.Text = "Select Pizza Size";
            comboBoxPizzaSize.Items.Add("Small");
            comboBoxPizzaSize.Items.Add("Medium");
            comboBoxPizzaSize.Items.Add("Large");
        }

        private void ResetAndIntilizeQuantityComboBox()
        {
            //Reset pizza quantity.
            comboBoxQuantity.Items.Clear();
            comboBoxQuantity.Text = "1";
            for (int i = 1; i < 10; i++)
            {
                comboBoxQuantity.Items.Add(i);
            }
        }

        private void ComboBoxPizzaSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check if selected Small
            if (comboBoxPizzaSize.SelectedItem.Equals("Small"))
            {
                //Try parse and calling the function to get the selected pizza's id 
                Int32.TryParse(getSelectedRow(), out int pizzaId);

                //Linq statement
                var pizzaPrice = from price in context.PizzaSizes
                                 where price.Size.Equals("Small")
                                 where price.SizePizzaId == pizzaId
                                 select price.PizzaPrice;

                //Add the query into label pizza
                foreach (var z in pizzaPrice)
                {
                    labelPizzaPrice.Text = z.ToString();
                }
            }
            //Check if selected Medium
            else if (comboBoxPizzaSize.SelectedItem.Equals("Medium"))
            {
                //Try parse and calling the function to get the selected pizza's id 
                Int32.TryParse(getSelectedRow(), out int pizzaId);

                //Linq statement
                var pizzaPrice = from price in context.PizzaSizes
                                 where price.Size.Equals("Medium")
                                 where price.SizePizzaId == pizzaId
                                 select price.PizzaPrice;

                //Add the query into label pizza
                foreach (var z in pizzaPrice)
                {
                    labelPizzaPrice.Text = z.ToString();
                }
            }
            //Check if selected Large
            else if (comboBoxPizzaSize.SelectedItem.Equals("Large"))
            {
                //Try parse and calling the function to get the selected pizza's id 
                Int32.TryParse(getSelectedRow(), out int pizzaId);

                //Linq statement
                var pizzaPrice = from price in context.PizzaSizes
                                 where price.Size.Equals("Large")
                                 where price.SizePizzaId == pizzaId
                                 select price.PizzaPrice;

                //Add the query into label pizza
                foreach (var z in pizzaPrice)
                {
                    labelPizzaPrice.Text = z.ToString();
                }
            }

            //Any results
            else
            {
                labelPizzaPrice.Text = "not found";
            }
        }

        private String getSelectedRow()
        {
            string selectedPizzaID = "";

            //Check if there are more than 0 selections
            if (dataGridViewPizzaMenu.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewPizzaMenu.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewPizzaMenu.Rows[selectedrowindex];
                selectedPizzaID = Convert.ToString(selectedRow.Cells[0].Value);
            }
            return selectedPizzaID;
        }
        private void ButtonAddToOrder_Click(object sender, EventArgs e)
        {
            //Check if is empty
            if (labelPizzaPrice.Text.Equals(""))
            {
                MessageBox.Show("Please select pizza size!");
                return;
            }
            //If not is not empyt get selections
            //Pizza ID 
            Int32.TryParse(getSelectedRow(), out int pizzaId);
            //Pizza Quantity
            Int32.TryParse(comboBoxPizzaSize.SelectedItem.ToString(), out int pizzaQty);
            //pizza price
            Int32.TryParse(labelPizzaPrice.Text, out int pizzaPrice);

            //Add all the selections into a list
            List<OrderDetail> order_detail = new List<OrderDetail>()
            {
                //Pizza order to detail
                new OrderDetail
                {
                    DetailOrderId = 1,
                    DetailPizzaId =  pizzaId,
                    DetailPizzaSize = comboBoxPizzaSize.SelectedItem.ToString(),
                    PizzaQty = pizzaQty,
                    DetailPizzaPrice = pizzaPrice * pizzaQty
                }
            };
            //Add the list into database
            context.OrderDetails.AddRange(order_detail);
            context.SaveChanges();
        }      

        private void DataGridViewPizzaMenu_SelectionChanged(object sender, EventArgs e)
        {
            //Reset controls
            ResetAndIntilizePizzaSizeComboBox();
            labelPizzaPrice.Text = "";
        }

        private class PizzaMenuDescription
        {
            //Display Pizza Id into database
            [DisplayName("Pizza Id")]
            public int PizzaId { get; set; }

            //Display Pizza Name into database
            [DisplayName("Pizza Name")]
            public string PizzaName { get; set; }

            //Display Pizza description into database
            [DisplayName("Pizza Description")]
            public string PizzaDescription { get; set; }
        }
    }
}