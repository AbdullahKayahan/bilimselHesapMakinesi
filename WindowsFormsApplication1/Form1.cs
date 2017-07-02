using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hesap
{
    public partial class Form1 : Form
    {
        double sonuc = 0;
        bool bosalt = true;
        string secim = "yok", islem;
        bool sayilar=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void dortislem()
        
        {
            if (!bosalt)
            { 
                switch(secim)
                    {
                            case "esit":
                                sonuc = Convert.ToDouble(textBox1.Text);
                                break;
                            case "topla":
                                sonuc += Convert.ToSingle(textBox1.Text);
                                break;
                            case "cıkart":
                                sonuc -= Convert.ToSingle(textBox1.Text);
                                break;
                            case "bol":
                                sonuc /= Convert.ToSingle(textBox1.Text);
                                break; 
                            case "carp":
                                sonuc *= Convert.ToSingle(textBox1.Text);
                                break;
                            
                            case "yok":
                                sonuc = Convert.ToSingle(textBox1.Text);
                                break;
                    }//switch
                textBox1.Text = Convert.ToString(sonuc);
                bosalt = true;

            }//if

        }//void

        private void button10_Click(object sender, EventArgs e)
        {
            if (!bosalt)
            {
                sayilar = false;
                if (textBox1.Text != "0")
                {
                    textBox1.Text += "0";
                    bosalt = false;
                }//if
                else
                {
                    textBox1.Text = "0";
                    bosalt = true;
                }//else
            }
            else { textBox1.Text = "0"; }
            if (secim == "esit")
                textBox2.Clear();
        }//void

        private void button11_Click(object sender, EventArgs e)
        {
            sayilar = false;
            if (!bosalt)
            {
                if (textBox1.Text != "0")
                {
                    textBox1.Text += "00";
                    bosalt = false;
                }//if
                else
                {
                    textBox1.Text = "0";
                    bosalt = true;
                }//else
            }
            else { textBox1.Text = "00"; }
            if (secim == "esit")
                textBox2.Clear();
        }//void

        private void button1_Click(object sender, EventArgs e)
        {
            sayilar = false;
            if (!bosalt)
            {
                textBox1.Text += "1";
            }//if
            else
            {
                textBox1.Text = "1";
            }//else
            bosalt = false;
            if (secim == "esit")
                textBox2.Clear();
        }//void

        private void button2_Click(object sender, EventArgs e)
        {
            sayilar = false;
            if (!bosalt)
            {
                textBox1.Text += "2";
            }//if
            else
            {
                textBox1.Text = "2";
            }//else
            bosalt = false;
            if (secim == "esit")
                textBox2.Clear();
        }//void

        private void button3_Click(object sender, EventArgs e)
        {
            sayilar = false;
            if (!bosalt)
            {
                textBox1.Text += "3";
            }//if
            else
            {
                textBox1.Text = "3";
            }//else
            bosalt = false;
            if (secim == "esit")
                textBox2.Clear();
        }//void

        private void button4_Click(object sender, EventArgs e)
        {
            sayilar = false;
            if (!bosalt)
            {
                textBox1.Text += "4";
            }//if
            else
            {
                textBox1.Text = "4";
            }//else
            bosalt = false;
            if (secim == "esit")
                textBox2.Clear();
        }//void

        private void button5_Click(object sender, EventArgs e)
        {
            sayilar = false;
            if (!bosalt)
            {
                textBox1.Text += "5";
            }//if
            else
            {
                textBox1.Text = "5";
            }//else
            bosalt = false;
            if (secim == "esit")
                textBox2.Clear();
        }//void

        private void button6_Click(object sender, EventArgs e)
        {
            sayilar = false;
            if (!bosalt)
            {
                textBox1.Text += "6";
            }//if
            else
            {
                textBox1.Text = "6";
            }//else
            bosalt = false;
            if (secim == "esit")
                textBox2.Clear();
        }//void

        private void button7_Click(object sender, EventArgs e)
        {
            sayilar = false;
            if (!bosalt)
            {
                textBox1.Text += "7";
            }//if
            else
            {
                textBox1.Text = "7";
            }//else
            bosalt = false;
            if (secim == "esit")
                textBox2.Clear();
        }//void

        private void button8_Click(object sender, EventArgs e)
        {
            sayilar = false;
            if (!bosalt)
            {
                textBox1.Text += "8";
            }//if
            else
            {
                textBox1.Text = "8";
            }//else
            bosalt = false;
            if (secim == "esit")
                textBox2.Clear();
        }//void

        private void button9_Click(object sender, EventArgs e)
        {
            sayilar = false;
            if (!bosalt)
            {
                textBox1.Text += "9";
            }//if
            else
            {
                textBox1.Text = "9";
            }//else
            bosalt = false;
            if (secim == "esit")
                textBox2.Clear();
        }//void

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                //islem = "+";

                if (sayilar == false)
                {
                    textBox2.Text = textBox2.Text +textBox1.Text+ "+";
                    sayilar = true;
                }
            }
           

           dortislem();
           secim = "topla";
        }//void

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                islem = "-";

                if (sayilar == false)
                {
                    textBox2.Text = textBox2.Text + textBox1.Text + "-";
                    sayilar = true;
                }
            }
           
            dortislem();
            secim = "cıkart";
        }//void


        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                islem = "*";

                if (sayilar == false)
                {
                    textBox2.Text = textBox2.Text + textBox1.Text + "*";
                    sayilar = true;
                }
            }
           
            dortislem();
            secim = "carp";
        }//void

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                islem = "/";

                if (sayilar == false)
                {
                    textBox2.Text = textBox2.Text + textBox1.Text + "/";
                    sayilar = true;
                }
            }
           
            dortislem();
            secim = "bol";

        }//void

        private void button20_Click(object sender, EventArgs e)
        {
            if (secim=="topla")
                textBox2.Text = textBox2.Text + "+" + textBox1.Text;
            else if (secim=="cıkart")
                textBox2.Text = textBox2.Text + "-" + textBox1.Text;
            else if (secim=="bol")
                 textBox2.Text = textBox2.Text + "/" + textBox1.Text;
            else if (secim=="carp")
                textBox2.Text = textBox2.Text + "*" + textBox1.Text;
            else
                textBox2.Text = "";

            dortislem();
            secim = "esit";
           
            if (textBox2.Text == "")
                textBox2.Text = "";
            else if (textBox2.Text !="")
                textBox2.Text = textBox2.Text + "=" + textBox1.Text;
            else 
                textBox2.Text = "";
        }//void

        private void button17_Click(object sender, EventArgs e)
        {
            double a;
            dortislem();
            sonuc = Convert.ToInt32(textBox1.Text);
            a = Math.Sqrt(sonuc);
            textBox1.Text = Convert.ToString(a); 
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double b;
            dortislem();
            sonuc = Convert.ToDouble(textBox1.Text);
            b = sonuc / 100;
            textBox1.Text = Convert.ToString(b); 

        }

        private void button19_Click(object sender, EventArgs e)
        {
           
            
            if (textBox2.Text == "")
               textBox2.Text = textBox2.Text + "1/ " + textBox1.Text + " =";
              
          dortislem();
            sonuc = 1 / sonuc;
            textBox1.Text = Convert.ToString(sonuc);
            secim = "1bolux";
            textBox2.Text = textBox2.Text +  textBox1.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!bosalt)
            {
                textBox1.Text += ",";
            }
            else
            {
                textBox1.Text = "0,";
            }
            bosalt = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Text = "0";

            sonuc = 0;
            secim = "yok";
            bosalt = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
            }
            else if(textBox1.Text.Length==1)
            { 
            textBox1.Text = "0";
            sonuc = 0;
            secim = "yok";
            bosalt = true;
            }
            else
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Text = "0";
            sonuc = 0;
            secim = "yok";
            bosalt = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
                button1.PerformClick();
            if (e.KeyChar == '2')
                button2.PerformClick();
            if (e.KeyChar == '3')
                button3.PerformClick();
            if (e.KeyChar == '4')
                button4.PerformClick();
            if (e.KeyChar == '5')
                button5.PerformClick();
            if (e.KeyChar == '6')
                button6.PerformClick();
            if (e.KeyChar == '7')
                button7.PerformClick();
            if (e.KeyChar == '8')
                button8.PerformClick();
            if (e.KeyChar == '9')
                button9.PerformClick();
            if (e.KeyChar == '0')
                button10.PerformClick();
            if (e.KeyChar == '+')
                button13.PerformClick();
            if (e.KeyChar == '-')
                button14.PerformClick();
            if (e.KeyChar == '*')
                button15.PerformClick();
            if (e.KeyChar == '/')
                button16.PerformClick();
            if (e.KeyChar == ',')
                button12.PerformClick();
           

            //if(ASCIIEncoding

        }
 
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (secim == "topla")
                    textBox2.Text = textBox2.Text + "+" + textBox1.Text;
                else if (secim == "cıkart")
                    textBox2.Text = textBox2.Text + "-" + textBox1.Text;
                else if (secim == "bol")
                    textBox2.Text = textBox2.Text + "/" + textBox1.Text;
                else if (secim == "carp")
                    textBox2.Text = textBox2.Text + "*" + textBox1.Text;
                else
                    textBox2.Text = "";

                dortislem();
                secim = "esit";

                if (textBox2.Text == "")
                    textBox2.Text = "";
                else if (textBox2.Text != "")
                    textBox2.Text = textBox2.Text + "=" + textBox1.Text;
                else
                    textBox2.Text = "";
            }

            if (e.KeyCode == Keys.Back)
            {
                if (textBox1.Text == "0")
                {
                }
                else if (textBox1.Text.Length == 1)
                {
                    textBox1.Text = "0";
                    sonuc = 0;
                    secim = "yok";
                    bosalt = true;
                }
                else
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        
     }

       
        

        private void bilimselToolStripMenuItem_Click(object sender, EventArgs e)
        {

        
         Form bilimsel = new Form2();
         bilimsel.Show();
         this.Hide();
           
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            if (secim == "topla")
                textBox2.Text = textBox2.Text   + textBox1.Text;
            else if (secim == "cıkart")
                textBox2.Text = textBox2.Text + textBox1.Text;
            else if (secim == "bol")
                textBox2.Text = textBox2.Text + textBox1.Text;
            else if (secim == "carp")
                textBox2.Text = textBox2.Text + textBox1.Text;
            else
                textBox2.Text = "";

            dortislem();
            secim = "esit";

            if (textBox2.Text == "")
                textBox2.Text = "";
            else if (textBox2.Text != "")
                textBox2.Text = textBox2.Text + "=" + textBox1.Text;
            else
                textBox2.Text = "";
        }

        private void görünümToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
      }

      

      

    }

