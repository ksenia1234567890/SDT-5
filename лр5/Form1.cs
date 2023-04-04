using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string text;
        public string text2;
        
        
        public void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Удаление строки");
            listBox1.Items.Add("Добавление строки");
        }

        public void listBox1_Click(object sender, EventArgs e)
        {
            string line = (string)listBox1.Items[listBox1.SelectedIndex];
            if(line=="Удаление строки")
            {
                textBox1.Text = " ";
            }
            if(line=="Добавление строки")
            {
                textBox1.Text = text2;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            text2 = textBox1.Text;
            string a = textBox2.Text;
            string b = textBox3.Text;
            int numb = 0;
            int count = 0;
            foreach (char i in text)
            {
                if (i == Convert.ToChar(a))
                {
                    text = text.Remove(numb, 1);
                    text = text.Insert(numb, b);
                }
                if (i == Convert.ToChar(b))
                {
                    text = text.Remove(numb, 1);
                    text = text.Insert(numb, a);
                }
                if(i==' ')
                {
                    count++;

                }
                numb++;
                
            }
            if(count==0)
            {
                textBox1.Text = "Ваш текст не содержит ни одного пробела";
            }
            else
            {
                textBox1.Text = text;
                textBox4.Text = Convert.ToString(count);
            }
            
        }
    }
}
