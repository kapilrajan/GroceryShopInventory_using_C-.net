
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryShopInventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double sum = 0.0;
            double price;
            double qty;
            double cal = 0.0;

            if (RiceBox1.Checked)
            {
                string rice = RiceBox1.Text;
                string msg = comboBox1.SelectedItem.ToString();
                price = 140;
                qty = int.Parse(textrice.Text);

                if (msg.Equals("KG"))
                {
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(rice,price,qty,cal);
                }else
                {
                    cal = (qty / 1000 * price);
                    this.dataGridView1.Rows.Add(rice, price, qty, cal);

                }
            }
            if (SaltBox2.Checked)
            {
                string salt = SaltBox2.Text;
                string msg = comboBox2.SelectedItem.ToString();
                price = 50;
                qty = int.Parse(textsalt.Text);

                if (msg.Equals("KG"))
                {
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(salt, price, qty, cal);
                }
                else
                {
                    cal = (qty / 1000 * price);
                    this.dataGridView1.Rows.Add(salt, price, qty, cal);

                }
            }
            if (SugarBox3.Checked)
            {
                string sugar = SugarBox3.Text;
                string msg = comboBox3.SelectedItem.ToString();
                price = 140;
                qty = int.Parse(textsugar.Text);

                if (msg.Equals("KG"))
                {
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(sugar, price, qty, cal);
                }
                else
                {
                    cal = (qty / 1000 * price);
                    this.dataGridView1.Rows.Add(sugar, price, qty, cal);

                }
            }
            if (WheetBox4.Checked)
            {
                string wheet = WheetBox4.Text;
                string msg = comboBox4.SelectedItem.ToString();
                price = 140;
                qty = int.Parse(textwheet.Text);

                if (msg.Equals("KG"))
                {
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(wheet, price, qty, cal);
                }
                else
                {
                    cal = (qty / 1000 * price);
                    this.dataGridView1.Rows.Add(wheet, price, qty, cal);

                }
            }
            if (OilBox5.Checked)
            {
                string oil = OilBox5.Text;
                string msg = comboBox5.SelectedItem.ToString();
                price = 200;
                qty = int.Parse(textoil.Text);

                if (msg.Equals("LT"))
                {
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(oil, price, qty, cal);
                }
                else
                {
                    cal = (qty / 1000 * price);
                    this.dataGridView1.Rows.Add(oil, price, qty, cal);

                }
            }

            for (int row=0; row<dataGridView1.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);

            }

            label3.Text = sum.ToString();
        }
    }
}
