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
    public partial class Form2 : Form
    {

        double sonuc = 0;
        bool bosalt = true;
        string secim = "yok";
        bool deger = false;
        double sayi,c;
       double a, b;
        int sayac = 0;
        bool parantez = false;
        bool parantez1 = true;
        string islem;
        bool sayilar=false;
        public Form2()
          
        
        {
            InitializeComponent();
        }
        private void dortislem()
        {
            if (!bosalt)
            {
                switch (secim)
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
                   case "xusy":
                        sonuc = Convert.ToSingle(sayi);
                   break;
                    case "xkare":
                        sonuc = Convert.ToSingle(sayi*sonuc);
                        break;
                    case "yok":
                        sonuc = Convert.ToSingle(textBox1.Text);
                        break;
                    case "mod":
                        sonuc = Convert.ToSingle(sayi);
                        break;
                    case "lsh":
                        sonuc = Convert.ToSingle(sayi);
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
                parantez1 = true;
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
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!bosalt)
            {
                sayilar = false;
                parantez1 = true;
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
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!bosalt)
            {
                textBox1.Text += ",";
            }
            else
            {
                textBox1.Text = ",";
            }
            bosalt = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayilar = false;
            parantez1 = true;
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayilar = false;
            parantez1 = true;
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayilar = false;
            parantez1 = true;
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayilar = false;
            parantez1 = true;
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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayilar = false;
            parantez1 = true;
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
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sayilar = false;
            parantez1 = true;
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
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sayilar = false;
            parantez1 = true;
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
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sayilar = false;
            parantez1 = true;
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
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sayilar = false;
            parantez1 = true;
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
        }

        private void button13_Click(object sender, EventArgs e)
        {


            if (textBox1.Text != "0")
            {
                islem = "+";

                if (sayilar == false)
                {
                textBox2.Text = textBox2.Text + textBox1.Text + "+";
                    
                    sayilar = true;
                }
            }

            if (parantez1==false)
            {
                textBox2.Text = textBox2.Text + "+";
            }
            dortislem();
            secim = "topla";
            }
        
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

            if (parantez1==false)
            {
                textBox2.Text = textBox2.Text + "-";
            }
           
            dortislem();
            secim = "cıkart";
        }

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

            if (parantez1 == false)
            {
                textBox2.Text = textBox2.Text + "*";
            }
            dortislem();
            secim = "carp";
          
        }

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

            if (parantez1 == false)
            {
                textBox2.Text = textBox2.Text + "/";
            }
            dortislem();
            secim = "bol";
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (secim == "topla")
                textBox2.Text = textBox2.Text + "+" + textBox1.Text;
            else if (secim == "cıkart")
                textBox2.Text = textBox2.Text + "-" + textBox1.Text;
            else if (secim == "bol")
                textBox2.Text = textBox2.Text + "/" + textBox1.Text;
            else if (secim == "carp")
                textBox2.Text = textBox2.Text + "*" + textBox1.Text;
            else if (secim == "xusy")
            {
                b = Convert.ToInt32(textBox2.Text);
                c = Convert.ToInt32(textBox1.Text);
                sayi = Math.Pow(b, c);
                textBox2.Text = textBox2.Text + "^" + textBox1.Text;
                textBox1.Text = Convert.ToString(sayi);
            
                
            }
            else if (secim == "mod")
            {
                b = Convert.ToInt32(textBox2.Text);
                c = Convert.ToInt32(textBox1.Text);
                sayi =b%c;
                textBox2.Text = textBox2.Text + "mod" + textBox1.Text;
                textBox1.Text = Convert.ToString(sayi);
                

            }
            else if (secim == "lsh")
            {
                double d;
                b = Convert.ToInt32(textBox2.Text);
                c = Convert.ToInt32(textBox1.Text);
                d = Math.Pow(2, c);
                sayi = b * d;
                textBox2.Text = textBox2.Text + "lsh" + textBox1.Text;
                textBox1.Text = Convert.ToString(sayi);


            }
            else
                 textBox2.Text = "";

            bosalt = false;

            dortislem();
            secim = "esit";

            if (textBox2.Text == "")
                textBox2.Text = "";
            else if (textBox2.Text != "")
            {
                if(secim=="xusy")
                {
                textBox1.Text=Convert.ToString(sayi);
                textBox2.Text = textBox2.Text;
                }
                else
               textBox2.Text = textBox2.Text + "=" + textBox1.Text;
            }
               
            else
                textBox2.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                textBox2.Text = textBox2.Text + "1/ " + textBox1.Text + " =";

            dortislem();
            sonuc = 1 / sonuc;
            textBox1.Text = Convert.ToString(sonuc);
            secim = "1bolux";
            textBox2.Text = textBox2.Text + textBox1.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double b;
            dortislem();
            sonuc = Convert.ToDouble(textBox1.Text);
            b = sonuc / 100;
            textBox1.Text = Convert.ToString(b); 
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double a;
            dortislem();
            sonuc = Convert.ToInt32(textBox1.Text);
            a = Math.Sqrt(sonuc);
            textBox1.Text = Convert.ToString(a); 
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Text = "0";

            sonuc = 0;
            secim = "yok";
            bosalt = true;
            deger = false;
            parantez = false;
            parantez1 = true;
           
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Text = "0";
            sonuc = 0;
            secim = "yok";
            bosalt = true;
            deger = false;
            parantez = false;
            parantez1 = true;
         
        }

        private void button23_Click(object sender, EventArgs e)
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

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
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
           

        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
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

        private void button43_Click(object sender, EventArgs e)
        {
            if (!deger)
            {

                a = Convert.ToInt32(textBox1.Text);
                textBox2.Text = "cube(" + textBox1.Text + ")";
                sonuc = a * a * a;
                textBox1.Text = Convert.ToString(sonuc);
                textBox2.Text = textBox2.Text + "=" + textBox1.Text;
                deger = true;
                secim = "xkare";



            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            double a;
            dortislem();
            sonuc = Convert.ToInt32(textBox1.Text);
            a = Math.Ceiling(sonuc);
            textBox1.Text = Convert.ToString(a); 
           textBox2.Text = "dms("+ a +")"; 
           
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "," + "e+0";
            textBox2.Text = textBox1.Text ;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double a;
            dortislem();
            sonuc = Convert.ToInt32(textBox1.Text);
            a = Math.Log(sonuc,Math.E);
            textBox2.Text = "ln(" + textBox1.Text + ")"; 
            textBox1.Text = Convert.ToString(a);
            textBox2.Text = textBox2.Text + "=" + textBox1.Text;
         }

        private void button32_Click(object sender, EventArgs e)
        {
            double a;
            dortislem();
            sonuc = Convert.ToInt32(textBox1.Text);
            a = Math.Log(sonuc,10);
           
            textBox2.Text = "log("+ textBox1.Text + ")"; 
            textBox1.Text = Convert.ToString(a);
            textBox2.Text = textBox2.Text + "=" + textBox1.Text;
        }

        private void button38_Click(object sender, EventArgs e)
        {
         /*int i,a;
        double fact=1;
         a=Convert.ToInt32(textBox1.Text) ;  
            for (i=a;i<=a;i++)
                fact = i *fact;
            textBox1.Text =Convert.ToString( fact);*/
           int sayı, i;
          ushort fact=1;
            sayı = Convert.ToInt32(textBox1.Text);
           
            for (i = 1; i <= sayı; i++)
            {
                fact = (ushort)(fact * i);
            }
            textBox2.Text = "n!(" + textBox1.Text + ")"; 
            textBox1.Text = fact.ToString();
            textBox2.Text = textBox2.Text + "=" + textBox1.Text;
        }

        private void button31_Click(object sender, EventArgs e)
        {
          
         
            
            if (!deger)
            {
                            
                a = Convert.ToInt32(textBox1.Text);
                textBox2.Text = textBox1.Text ;
               deger = true;
               textBox1.Text = "";
               secim = "xusy";
            }

            
            
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (!deger)
            {

                a = Convert.ToInt32(textBox1.Text);
                textBox2.Text = "sqrt("+textBox1.Text+")";
                sonuc = a * a;
                textBox1.Text = Convert.ToString(sonuc);
                textBox2.Text = textBox2.Text+"="+textBox1.Text;
                deger = true;
                secim = "xkare";



            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (!deger)
            {

            textBox1.Text = Convert.ToString(Math.PI);
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
                if (!deger)
            {

                dortislem();
                a = Convert.ToInt32(textBox1.Text);
                sayi = Math.Pow(10, a);
                textBox2.Text = "10" + "^" + textBox1.Text;
                textBox1.Text = Convert.ToString(sayi);
                textBox2.Text = textBox2.Text + "=" + textBox1.Text;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        { 
            a = Convert.ToInt32(textBox1.Text);
            textBox2.Text ="sin("+ textBox1.Text +")";
            sonuc = Math.Sin(((a) * Math.PI) / 180);
            textBox1.Text = Convert.ToString(sonuc);
            textBox2.Text =textBox2.Text + "=" + textBox1.Text;
        }

        private void button30_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "90")
            {
                textBox1.Text = "0";
                textBox2.Text = "cos(90)=0";
            }
            else
            {
                a = Convert.ToInt32(textBox1.Text);
                textBox2.Text = "cos(" + textBox1.Text + ")";
                sonuc = Math.Cos(((a) * Math.PI) / 180);
                textBox1.Text = Convert.ToString(sonuc);
                textBox2.Text = textBox2.Text + "=" + textBox1.Text;
            }
        
        
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "90")
                textBox1.Text = "Tanımsız";
            else
            {
                a = Convert.ToInt32(textBox1.Text);
                textBox2.Text = "tan(" + textBox1.Text + ")";
                sonuc = Math.Tan(((a) * Math.PI) / 180);
                textBox1.Text = Convert.ToString(sonuc);
                textBox2.Text = textBox2.Text + "=" + textBox1.Text;
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            sayac += 1;
            textBox2.Text = textBox2.Text + "(";
            parantez = true;
            parantez1 = true;
        }

      
        private void button50_Click(object sender, EventArgs e)
        {
            sayac -= 1;
            //textBox2.Text = textBox2.Text + ")";

            if (parantez == true)
            {
                if (secim == "topla") 
                {
               textBox2.Text = textBox2.Text  + textBox1.Text+")";
                    dortislem();
                secim = "topla";
                
                }
                else if (secim=="cıkart")
                {
                    textBox2.Text = textBox2.Text + textBox1.Text + ")";
                    dortislem();
                secim = "cıkart";
                }
           
             else if (secim=="bol")
                {
                    textBox2.Text = textBox2.Text  + textBox1.Text + ")";
                 dortislem();
                secim = "bol";
                }
             else if (secim=="carp")
                {
                    textBox2.Text = textBox2.Text + textBox1.Text + ")";
                 dortislem();
                secim = "carp";
                }

               
                else if (secim == "cıkart")
                    textBox2.Text = textBox2.Text + "-" + textBox1.Text;
                else if (secim == "bol")
                    textBox2.Text = textBox2.Text + "/" + textBox1.Text;
                else if (secim == "carp")
                    textBox2.Text = textBox2.Text + "*" + textBox1.Text;
                sayilar = true;
                parantez1 = false;
               
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (!deger)
            {

                a = Convert.ToInt32(textBox1.Text);
                textBox2.Text = textBox1.Text;
                deger = true;
                textBox1.Text = "";
                secim = "lsh";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (!deger)
            {

                a = Convert.ToInt32(textBox1.Text);
                textBox2.Text = textBox1.Text;
                deger = true;
                textBox1.Text = "";
                secim = "mod";
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Int32 x;
            x = Convert.ToInt32(textBox1.Text);
           // textbox1.text = !x;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
         
           
        }

      
       
    }
}
