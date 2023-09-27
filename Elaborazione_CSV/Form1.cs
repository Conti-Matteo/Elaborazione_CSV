using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Elaborazione_CSV
{
    public partial class Form1 : Form
    {
        ElaborazioneCSV tab;
        public Form1()
        {
            InitializeComponent();
            tab= new ElaborazioneCSV();

        }

        #region form

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region label
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region textbox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region button

        private void button1_Click(object sender, EventArgs e)
        {
            tab.Azione1();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tab.Azione2();
            int count = tab.Azione2();
            MessageBox.Show("il numero dei campi è:" + count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tab.Azione3();
            int lunghezzaMax = tab.Azione3();
            MessageBox.Show("la lunghezza massima è:" + lunghezzaMax);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tab.Azione4();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tab.Azione5(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, int.Parse(textBox7.Text), textBox8.Text, int.Parse(textBox9.Text), int.Parse(textBox10.Text), textBox11.Text, textBox12.Text, int.Parse(textBox13.Text), int.Parse(textBox14.Text), int.Parse(textBox15.Text), int.Parse(textBox16.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tab.Azione7(textBox17.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tab.Azione8(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, int.Parse(textBox7.Text), textBox8.Text, int.Parse(textBox9.Text), int.Parse(textBox10.Text), textBox11.Text, textBox12.Text, int.Parse(textBox13.Text), int.Parse(textBox14.Text), int.Parse(textBox15.Text), int.Parse(textBox16.Text),int.Parse(textBox17.Text));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tab.Azione9(textBox19.Text);
        }
        #endregion
    }
}