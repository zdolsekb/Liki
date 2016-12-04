using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liki_PokaziKajZnas
{
    public partial class Form1 : Form
    {
        Kvadrat kv;
        Pravokotnik p;
        Paralelogram pa;
        Romb r;
        Trikotnik t;
        EnakostranicniTrikotnik eT;
        Krog k;
        public Form1()
        {
            

            InitializeComponent();

            radioButtonKvadrat.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButtonPravokotnik.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButtonRomb.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButtonTrikotnik.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButtonEnakostranicniTrikotnik.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButtonKrog.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButtonParalelogram.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);

            textBox1.TextChanged += new EventHandler(textBoxes_TextChanged);
            textBox2.TextChanged += new EventHandler(textBoxes_TextChanged);
            textBox3.TextChanged += new EventHandler(textBoxes_TextChanged);
            textBox4.TextChanged += new EventHandler(textBoxes_TextChanged);



            if (radioButtonKvadrat.Checked)
            {
                label1.Text = "Stranica a:";
                label1.Show();
                label2.Hide();
                textBox2.Hide();
                label3.Hide();
                textBox3.Hide();
                label4.Hide();
                textBox4.Hide();

            }
            buttonPotrdi.Enabled = false;


        }
        private void textBoxes_TextChanged(object sender, EventArgs e) {
            TextBox textBox =sender as TextBox;
            if (radioButtonKvadrat.Checked && textBox1 != null)
            {
                buttonPotrdi.Enabled = true;


            }
            if (radioButtonPravokotnik.Checked && textBox2.Text!="" &&textBox1.Text!="")
            {
                buttonPotrdi.Enabled = true;
            }
            if (radioButtonRomb.Checked && textBox2.Text != "" && textBox1.Text != "")
            {
                buttonPotrdi.Enabled = true;
            }
            if (radioButtonParalelogram.Checked && textBox3.Text != "" && textBox2.Text != "" && textBox1.Text != "")
            {
                buttonPotrdi.Enabled = true;
            }
            if (radioButtonTrikotnik.Checked && textBox4.Text != "" && textBox3.Text != "" && textBox2.Text != "" && textBox1.Text != "")
            {
                buttonPotrdi.Enabled = true;
            }
            if (radioButtonEnakostranicniTrikotnik.Checked && textBox2.Text != "" && textBox1.Text != "")
            {
                buttonPotrdi.Enabled = true;
            }
            if (radioButtonKrog.Checked && textBox1.Text != "")
            {
                buttonPotrdi.Enabled = true;
            }
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            buttonOLiku.Enabled = false;
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            richTextBox1.Hide();
            textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = richTextBox1.Text = "";

            if (radioButtonKvadrat.Checked)
            {
                buttonPotrdi.Enabled = false;
                textBox1.Text="";
                textBox2.Text="";
                textBox3.Text="";
                textBox4.Text="";
                label1.Text = "Stranica a:";
                label1.Show();
                label2.Hide();
                textBox2.Hide();
                label3.Hide();
                textBox3.Hide();
                label4.Hide();
                textBox4.Hide();
                

            }
            if (radioButtonPravokotnik.Checked)
            {
                buttonPotrdi.Enabled = false;
                textBox1.Text="";
                textBox2.Text="";
                textBox3.Text="";
                textBox4.Text="";
                label1.Text = "Stranica a:";
                label1.Show();
                label2.Text = "Stranica b:";
                label2.Show();
                textBox2.Show();
                label3.Hide();
                textBox3.Hide();
                label4.Hide();
                textBox4.Hide();
                
            }
            if (radioButtonRomb.Checked)
            {
                buttonPotrdi.Enabled = false;
                textBox1.Text="";
                textBox2.Text="";
                textBox3.Text="";
                textBox4.Text="";
                label1.Text = "Stranica a:";
                label1.Show();
                label2.Text = "Visina:";
                label2.Show();
                textBox2.Show();
                label3.Hide();
                textBox3.Hide();
                label4.Hide();
                textBox4.Hide();
                
            }
            if (radioButtonParalelogram.Checked)
            {
                buttonPotrdi.Enabled = false;
                textBox1.Text="";
                textBox2.Text="";
                textBox3.Text="";
                textBox4.Text="";
                label1.Text = "Stranica a:";
                label1.Show();
                label2.Text = "Stranica b:";
                label2.Show();
                textBox2.Show();
                label3.Text = "Visina:";
                label3.Show();
                textBox3.Show();
                label4.Hide();
                textBox4.Hide();
                
            }
            if (radioButtonEnakostranicniTrikotnik.Checked)
            {
                buttonPotrdi.Enabled = false;
                textBox1.Text="";
                textBox2.Text="";
                textBox3.Text="";
                textBox4.Text="";
                label1.Text = "Stranica a:";
                label1.Show();
                label2.Text = "Visina:";
                label2.Show();
                textBox2.Show();
                label3.Hide();
                textBox3.Hide();
                label4.Hide();
                textBox4.Hide();
                
            }
            if (radioButtonTrikotnik.Checked)
            {
                buttonPotrdi.Enabled = false;
                textBox1.Text="";
                textBox2.Text="";
                textBox3.Text="";
                textBox4.Text = "";
                label1.Text = "Stranica a:";
                label1.Show();
                label2.Text = "Stranica b:";
                label2.Show();
                textBox2.Show();
                label3.Text = "Stranica c:";
                label3.Show();
                textBox3.Show();
                label4.Text = "Visina na a:";
                label4.Show();
                textBox4.Show();
                
            }
            if (radioButtonKrog.Checked)
            {
                buttonPotrdi.Enabled = false;
                textBox1.Text="";
                textBox2.Text="";
                textBox3.Text="";
                textBox4.Text="";
                label1.Text = "Polmer:";
                label1.Show();
                label2.Hide();
                textBox2.Hide();
                label3.Hide();
                textBox3.Hide();
                label4.Hide();
                textBox4.Hide();
                
            }

        }

        private void buttonPotrdi_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonKvadrat.Checked)
                {   
                    kv = new Kvadrat(Convert.ToDouble(textBox1.Text));
                    
                    MessageBox.Show("Ustvarjen je bil kvadrat!");
                    panel1.Refresh();
                    SolidBrush sb = new SolidBrush(Color.PaleVioletRed);
                    Graphics g = panel1.CreateGraphics();
                    int x = Convert.ToInt32(kv.StranicaA);
                    if (x < 30) {
                        x = 30;
                    }
                    if (x > 200)
                    {
                        x = 200;
                    }
                    g.FillRectangle(sb, 0, 0, x, x);
                    buttonOLiku.Enabled = true;
                }
                if (radioButtonPravokotnik.Checked)
                {
                    p = new Pravokotnik(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                    MessageBox.Show("Ustvarjen je bil Pravokotnik!");
                    panel1.Refresh();
                    SolidBrush sb = new SolidBrush(Color.PaleVioletRed);
                    Graphics g = panel1.CreateGraphics();
                    int x = Convert.ToInt32(p.StranicaA);
                    int y= Convert.ToInt32(p.StranicaB);
                    if (x < 30)
                    {
                        x = 30;
                    }
                    if (y < 30)
                    {
                        y = 30;
                    }
                    if (x > 200)
                    {
                        x = 200;
                    }
                    if (y > 200)
                    {
                        y = 200;
                    }

                    g.FillRectangle(sb, 0, 0, x, y);
                    buttonOLiku.Enabled = true;
                }
                if (radioButtonRomb.Checked)
                {
                    r= new Romb(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                    MessageBox.Show("Ustvarjen je bil Romb!");

                    panel1.Refresh();
                    SolidBrush sb = new SolidBrush(Color.PaleVioletRed);
                    Graphics g = panel1.CreateGraphics();
                    int x = Convert.ToInt32(r.StranicaA);
                    if (x < 30)
                    {
                        x = 30;
                    }
                    if (x > 200)
                    {
                        x = 200;
                    }

                    Point[] points = {new Point(0,0), new Point(x, 0), new Point(x+20, x), new Point(20,x) };
                    g.FillPolygon(sb, points);
                    buttonOLiku.Enabled = true;

                }
                if (radioButtonParalelogram.Checked)
                {
                    pa= new Paralelogram(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                    MessageBox.Show("Ustvarjen je bil Paralelogram!");
                    panel1.Refresh();
                    SolidBrush sb = new SolidBrush(Color.PaleVioletRed);
                    Graphics g = panel1.CreateGraphics();
                    int x = Convert.ToInt32(pa.StranicaA);
                    int y = Convert.ToInt32(pa.StranicaB);
                    if (x < 30)
                    {
                        x = 30;
                    }
                    if (x > 200)
                    {
                        x = 200;
                    }
                    if (y < 30)
                    {
                        y = 30;
                    }
                    if (y > 200)
                    {
                        y = 200;
                    }

                    Point[] points = { new Point(0, 0), new Point(x, 0), new Point(x + 20, y), new Point(20, y) };
                    g.FillPolygon(sb, points);
                    buttonOLiku.Enabled = true;
                }
                if (radioButtonEnakostranicniTrikotnik.Checked)
                {
                    eT = new EnakostranicniTrikotnik(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                    MessageBox.Show("Ustvarjen je bil Enakostranični Trikotnik!");
                    panel1.Refresh();
                    SolidBrush sb = new SolidBrush(Color.PaleVioletRed);
                    Graphics g = panel1.CreateGraphics();
                    int x = Convert.ToInt32(eT.StranicaA);
                    if (x < 30)
                    {
                        x = 30;
                    }
                    if (x > 200)
                    {
                        x = 200;
                    }
                    Point[] points = { new Point(0, 0), new Point(x,0), new Point(x / 2, x) };
                    g.FillPolygon(sb, points);
                    buttonOLiku.Enabled = true;
                }
                if (radioButtonTrikotnik.Checked)
                {
                     t = new Trikotnik(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
                     MessageBox.Show("Ustvarjen je bil Trikotnik!");
                    panel1.Refresh();
                    SolidBrush sb = new SolidBrush(Color.PaleVioletRed);
                    Graphics g = panel1.CreateGraphics();
                    int x = Convert.ToInt32(t.StranicaA);
                    int y= Convert.ToInt32(t.StranicaB);
                    int z = Convert.ToInt32(t.StranicaC);
                    if (x < 30)
                    {
                        x = 30;
                    }
                    if (x > 200)
                    {
                        x = 200;
                    }
                    if (y < 30)
                    {
                        y= 30;
                    }
                    if (y > 200)
                    {
                        y= 200;
                    }
                    if (z < 30)
                    {
                        z = 30;
                    }
                    if (z > 200)
                    {
                        z= 200;
                    }
                    Point[] points = { new Point(0, 0), new Point(x, z), new Point(0, z) };
                    g.FillPolygon(sb, points);
                    buttonOLiku.Enabled = true;
                }
                if (radioButtonKrog.Checked) {
                    k = new Krog(Convert.ToDouble(textBox1.Text));
                    MessageBox.Show("Ustvarjen je bil Krog!");

                    panel1.Refresh();
                    SolidBrush sb = new SolidBrush(Color.PaleVioletRed);
                    Graphics g = panel1.CreateGraphics();
                    int x = Convert.ToInt32(k.Polmer);
                    if (x<30)
                    {
                        x = 30;
                    }
                    if (x>200)
                    {
                        x = 200;
                    }
                    g.FillEllipse(sb,0,0,x,x);
                    buttonOLiku.Enabled = true;
                }


                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                buttonPotrdi.Enabled = false;
            }
            catch (Exception EX)
            {

               MessageBox.Show("Prosim, da vsa potrebna polja izpolnite s številkami!") ;
            }
            


        }

        private void buttonOLiku_Click(object sender, EventArgs e)
        {
            buttonOLiku.Enabled = false;
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            textBox5.Show();
            textBox6.Show();
            textBox7.Show();
            textBox8.Show();
            richTextBox1.Show();

            if (radioButtonKvadrat.Checked)
             {
                 textBox5.Text = (kv.StOgljisc).ToString();
                 textBox6.Text = (kv.StStranic).ToString();
                 textBox7.Text = (kv.Obseg).ToString();
                 textBox8.Text = (kv.Ploscina).ToString();
                richTextBox1.Text = "P=a*a\nO=4*a";
             }
            if (radioButtonPravokotnik.Checked)
            {
                textBox5.Text = (p.StOgljisc).ToString();
                textBox6.Text = (p.StStranic).ToString();
                textBox7.Text = (p.Obseg).ToString();
                textBox8.Text = (p.Ploscina).ToString();
                richTextBox1.Text = "P=a*b\nO=2*a+2*b";
            }
            if (radioButtonRomb.Checked)
            {
                textBox5.Text = (r.StOgljisc).ToString();
                textBox6.Text = (r.StStranic).ToString();
                textBox7.Text = (r.Obseg).ToString();
                textBox8.Text = (r.Ploscina).ToString();
                richTextBox1.Text = "P=a*Va\nO=4*a";
            }
            if (radioButtonParalelogram.Checked)
            {
                textBox5.Text = (pa.StOgljisc).ToString();
                textBox6.Text = (pa.StStranic).ToString();
                textBox7.Text = (pa.Obseg).ToString();
                textBox8.Text = (pa.Ploscina).ToString();
                richTextBox1.Text = "P=a*Va\nO=2*a+2*b";
            }
            if (radioButtonTrikotnik.Checked)
            {
                textBox5.Text = (t.StOgljisc).ToString();
                textBox6.Text = (t.StStranic).ToString();
                textBox7.Text = (t.Obseg).ToString();
                textBox8.Text = (t.Ploscina).ToString();
                richTextBox1.Text = "P=(a*Va)/2\nO=a+b+c";
            }
            if (radioButtonEnakostranicniTrikotnik.Checked)
            {
                textBox5.Text = (eT.StOgljisc).ToString();
                textBox6.Text = (eT.StStranic).ToString();
                textBox7.Text = (eT.Obseg).ToString();
                textBox8.Text = (eT.Ploscina).ToString();
                richTextBox1.Text = "P=(a*Va)/2\nO=3*a";
            }
            if (radioButtonKrog.Checked)
            {
                textBox5.Text = (k.StOgljisc).ToString();
                textBox6.Text = (k.StStranic).ToString();
                textBox7.Text = (k.Obseg).ToString();
                textBox8.Text = (k.Ploscina).ToString();
                richTextBox1.Text = "P=pi*r^2\nO=2*r*pi";
            }


        }


    }


        

    }

