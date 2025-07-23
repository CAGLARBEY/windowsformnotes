using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace useruygulama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isUsernameCorrect = false;
            bool isPasswordCorrect = false;
            string isim = textBox1.Text;
            string parola = textBox2.Text;
            int usernamelinefound;
            int passwordlinefound;

            for (int i = 0; i < Form1.userIndex; i++)
            {

                if (isim == Form1.İsimler[i])
                {
                    richTextBox1.Text += "Kullanıcı bulundu. ";
                    usernamelinefound = i;
                    isUsernameCorrect = true;
                    break;
                }
                for (int j = 0; j < Form1.userIndex; j++)
                {

                    if (parola == Form1.Parolalar[j])
                    {
                        richTextBox1.Text += "Parola bulundu. ";
                        passwordlinefound = i;
     
                        isPasswordCorrect = false;
                        break;

                    }

                    if (isPasswordCorrect && isUsernameCorrect)
                    {
                        
                        
                            richTextBox1.Text = "Kullanıcı sistemde tanımlıdır";
                            MessageBox.Show("Kullanıcı sistemde bulunmaktadır.");

                        
                    }
                    else
                    {
                        richTextBox1.Text = "Kullanıcı sistemde tanımlı değildir.";
                        MessageBox.Show("Kullanıcı sistemde bulunmamaktadır.");
                    }
                }
            }
        }
    }
}
