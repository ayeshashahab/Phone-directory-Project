using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categery = comboBox1.SelectedItem.ToString();
            textBox1.Text = categery;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "image filter(*.jpg,*.jpeg,*.gif,*.png)|*.jpg;*.jpeg;*.gif;*.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(fileDialog.FileName);

            }
        }
             private void add_data(string fname,string fcategory,string fnote){ 
            
                DataGridViewRow new_Row = new DataGridViewRow();
                new_Row.CreateCells (dataGridView1);
                new_Row.Cells[0].Value = fname;
                new_Row.Cells[1].Value = fcategory;
                new_Row.Cells[2].Value = fnote;
               
                dataGridView1.Rows.Add(new_Row);
            }

        private void button2_Click(object sender, EventArgs e)
        {
            add_data(textBox1.Text, textBox2.Text, richTextBox1.Text);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();

            richTextBox1.Clear();
        }
    }

        
    }


