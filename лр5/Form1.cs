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
           
            // Листбокс: ДС - первоначально введённая строка запоминается
            // УС - очистка
            
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
            try
            {
                text = textBox1.Text;
                text2 = textBox1.Text;
                int a = int.Parse(textBox2.Text);
                int b = int.Parse(textBox3.Text);
                char[] bukvy = new char[text.Length];
                int k = 0;

            // Если в тексте нет пробелов, текстовое поле отображает сообщение
            
                if (textBox1.Text.Contains(' ') == false)
                {
                    throw new Exception("Ваш текст не содержит ни одного пробела");
                }

            
            // Заполнить массив и счёт пробелов

            int count = 0;
            foreach (char i in text)
            {
                if(i==' ')
                {
                    count++;
                }

                bukvy[k] = i;
                k++;
            }

                // Поменять местами индексы


                if (bukvy[a]==' ' || bukvy[b]==' ')
                {
                    throw new Exception("Нельзя менять буквы с пробелами");
                }
            char x = bukvy[a];
            bukvy[a] = bukvy[b];
            bukvy[b] = x;
               
            textBox1.Text = string.Concat(bukvy);
            textBox4.Text = Convert.ToString(count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
