using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HP_FILLING
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int petrol = 105;
            int diesel = 95;
            int oil = 5;
            int air = 5;
            int wheel = 0;
            int total = 0;
            listBox1.Items.Add("Welcome To PETROL BUNK");
            listBox1.Items.Add("Your Vehicle's Registration Number is : " + textBox1.Text);
            
            if (radioButton1.Checked)
            {
                wheel = 2;
                listBox1.Items.Add("Your Vehicle Type Is : " + radioButton1.Text);
                listBox1.Items.Add("Cost for AIR Filling Is : " + wheel * air);
            }
            else if (radioButton2.Checked)
            {
                wheel = 4;
                listBox1.Items.Add("Your Vehicle Type Is : " + radioButton2.Text);
                listBox1.Items.Add("Cost for AIR Filling Is : " + wheel * air);
            }

            if (comboBox1.Text == "PETROL")
            {
                int temp = 0;
                temp = (int)numericUpDown1.Value * petrol;
                total += temp;
            }
            if (comboBox1.Text == "DIESEL")
            {
                int temp = 0;
                temp = (int)numericUpDown1.Value * diesel;
                total += temp;
            }
            if (radioButton1.Checked && checkBox1.Checked)
            {
                total += 2 * air;
            }
            else if (radioButton2.Checked && checkBox1.Checked)
            {
                total += 4 * air;
            }
            if (checkBox3.Checked)
            {
                int temp = 0;
                temp = (int)numericUpDown2.Value * oil;
                total += temp;
            }

            listBox1.Items.Add("Total Bill Is : " + total);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           if (radioButton1.Checked)
           {
               comboBox1.Items.Clear();
               comboBox1.SelectedIndex = -1;
               comboBox1.Items.Add("PETROL");
           }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboBox1.Items.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox1.Items.Add("PETROL");
                comboBox1.Items.Add("DIESEL");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            comboBox1.SelectedIndex = -1 ;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;

        }

    }
}
