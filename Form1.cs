using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, Woman!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, Man!");//(Vvod)Input message
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; //&
            if (checkBox.Checked == true)
            {
                MessageBox.Show("Flag" + checkBox.Text + "+");// флаг отмечен
            }
            else
            {
                MessageBox.Show("Flag" + checkBox.Text + "-");
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
               // MessageBox.Show("Choice(Выбор)" + checkBox.Text + "Флаг выбран");
                MessageBox.Show("Ок" + checkBox.Text + "Флаг выбран");
            }
            else
            {
                MessageBox.Show("Choice(Выбор)" + checkBox.Text + "Флаг не выбран");
            }
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Choice language C#(Marina)");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;// отправила к радиокнопке
            if (radioButton.Checked)
            {
                MessageBox.Show("Choice language C++");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Язык С");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //private void checkBox1_CheckedChanged(object sender, EventArgs e)
            //{
           /*     CheckBox checkBox = (CheckBox)sender; //&
                if (checkBox.Checked == true)
                {
                    MessageBox.Show("Flag" + checkBox.Text + "+");// флаг отмечен
                }
                else
                {
                    MessageBox.Show("Flag" + checkBox.Text + "-");
                }

           // }

           // private void checkBox2_CheckedChanged(object sender, EventArgs e)
           // {
               // CheckBox checkBox1 = (CheckBox)sender;
            /*    if (checkBox.Checked == true)
                {
                    MessageBox.Show("Choice(Выбор)" + checkBox.Text + "Флаг выбран");
                }
                else
                {
                    MessageBox.Show("Choice(Выбор)" + checkBox.Text + "Флаг не выбран");
                }
            }*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    

        /*    private void выходToolStripMenuItem_Click(object sender, EventArgs e)
            {
                DialogResult resultat = MessageBox.Show("Вы хотите выйти из приложения?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultat == DialogResult.Yes) ;// сравнение
                {//выходим из приложения
                    Application.Exit();

                }
            }*/

        /*  private void label2_Click(object sender, EventArgs e)
          {

          }*/

        /*    private void label2_Click(object sender, EventArgs e)
            {

            }
        */
        /*  private void panel1_Paint(object sender, PaintEventArgs e)
          {
              RadioButton radioButton4 = (RadioButton)sender;
              string dddRadioButton = radioButton4.Name;
              if (radioButton4.Checked == true)
              {
                  //if(RadioButton.)
                  switch (dddRadioButton)
                  {
                      case "R"
                  }
              }
          }*/
    }

      //  private void radioButton5_CheckedChanged(object sender, EventArgs e)
      //  {

       // }
    }
