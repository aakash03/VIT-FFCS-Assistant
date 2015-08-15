using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private object control;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox25.BackColor = Color.LimeGreen;
            textBox35.BackColor = Color.LimeGreen;
            textBox63.BackColor = Color.LimeGreen;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox18.BackColor = Color.LimeGreen;
            textBox44.BackColor = Color.LimeGreen;
            textBox56.BackColor = Color.LimeGreen;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox38.BackColor = Color.LimeGreen;
            textBox48.BackColor = Color.LimeGreen;
            textBox76.BackColor = Color.LimeGreen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox23.BackColor = Color.LimeGreen;
            textBox51.BackColor = Color.LimeGreen;
            textBox61.BackColor = Color.LimeGreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox36.BackColor = Color.LimeGreen;
            textBox74.BackColor = Color.LimeGreen;
            textBox64.BackColor = Color.LimeGreen;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox22.BackColor = Color.LimeGreen;
            textBox49.BackColor = Color.LimeGreen;
            textBox77.BackColor = Color.LimeGreen;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox24.BackColor = Color.LimeGreen;
            textBox50.BackColor = Color.LimeGreen;
            textBox62.BackColor = Color.LimeGreen;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox37.BackColor = Color.LimeGreen;
            textBox47.BackColor = Color.LimeGreen;
            textBox75.BackColor = Color.LimeGreen;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox73.BackColor = Color.LimeGreen;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox21.BackColor = Color.LimeGreen;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox60.BackColor = Color.LimeGreen;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox34.BackColor = Color.LimeGreen;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox19.BackColor = Color.LimeGreen;
            textBox29.BackColor = Color.LimeGreen;
            textBox57.BackColor = Color.LimeGreen;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox32.BackColor = Color.LimeGreen;
            textBox42.BackColor = Color.LimeGreen;
            textBox70.BackColor = Color.LimeGreen;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox17.BackColor = Color.LimeGreen;
            textBox45.BackColor = Color.LimeGreen;
            textBox55.BackColor = Color.LimeGreen;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox30.BackColor = Color.LimeGreen;
            textBox58.BackColor = Color.LimeGreen;
            textBox68.BackColor = Color.LimeGreen;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox16.BackColor = Color.LimeGreen;
            textBox43.BackColor = Color.LimeGreen;
            textBox71.BackColor = Color.LimeGreen;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox31.BackColor = Color.LimeGreen;
            textBox41.BackColor = Color.LimeGreen;
            textBox69.BackColor = Color.LimeGreen;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox67.BackColor = Color.LimeGreen;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox15.BackColor = Color.LimeGreen;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox54.BackColor = Color.LimeGreen;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox28.BackColor = Color.LimeGreen;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Take Screenshot to save current TimeTable");
        }
        
        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By Aakash Malhotra \n       VIT University", "credits");
        }
     
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "L1")
                textBox25.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L2")
                textBox24.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L3")
                textBox23.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L4")
                textBox22.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L5")
                textBox21.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L6")
                textBox20.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L7")
                textBox38.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L8")
                textBox37.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L9")
                textBox36.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L10")
                textBox35.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L11")
                textBox34.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L12")
                textBox33.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L13")
                textBox51.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L14")
                textBox50.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L15")
                textBox49.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L16")
                textBox48.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L17")
                textBox47.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L18")
                textBox46.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L19")
                textBox64.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L20")
                textBox63.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L21")
                textBox62.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L22")
                textBox61.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L23")
                textBox60.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L24")
                textBox59.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L25")
                textBox77.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L26")
                textBox76.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L27")
                textBox75.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L28")
                textBox74.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L29")
                textBox73.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L30")
                textBox72.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L31")
                textBox19.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L32")
                textBox18.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L33")
                textBox17.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L34")
                textBox16.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L35")
                textBox15.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L36")
                textBox14.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L37")
                textBox32.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L38")
                textBox31.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L39")
                textBox30.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L40")
                textBox29.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L41")
                textBox28.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L42")
                textBox27.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L43")
                textBox45.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L44")
                textBox44.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L45")
                textBox43.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L46")
                textBox42.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L47")
                textBox41.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L48")
                textBox40.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L49")
                textBox58.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L50")
                textBox57.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L51")
                textBox56.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L52")
                textBox55.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L53")
                textBox54.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L54")
                textBox53.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L55")
                textBox71.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L56")
                textBox70.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L57")
                textBox69.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L58")
                textBox68.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L59")
                textBox67.BackColor = Color.LimeGreen;
            else if (comboBox1.Text == "L60")
                textBox66.BackColor = Color.LimeGreen;
            comboBox1.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "L1")
                textBox25.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L2")
                textBox24.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L3")
                textBox23.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L4")
                textBox22.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L5")
                textBox21.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L6")
                textBox20.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L7")
                textBox38.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L8")
                textBox37.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L9")
                textBox36.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L10")
                textBox35.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L11")
                textBox34.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L12")
                textBox33.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L13")
                textBox51.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L14")
                textBox50.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L15")
                textBox49.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L16")
                textBox48.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L17")
                textBox47.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L18")
                textBox46.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L19")
                textBox64.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L20")
                textBox63.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L21")
                textBox62.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L22")
                textBox61.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L23")
                textBox60.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L24")
                textBox59.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L25")
                textBox77.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L26")
                textBox76.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L27")
                textBox75.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L28")
                textBox74.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L29")
                textBox73.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L30")
                textBox72.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L31")
                textBox19.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L32")
                textBox18.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L33")
                textBox17.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L34")
                textBox16.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L35")
                textBox15.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L36")
                textBox14.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L37")
                textBox32.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L38")
                textBox31.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L39")
                textBox30.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L40")
                textBox29.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L41")
                textBox28.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L42")
                textBox27.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L43")
                textBox45.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L44")
                textBox44.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L45")
                textBox43.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L46")
                textBox42.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L47")
                textBox41.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L48")
                textBox40.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L49")
                textBox58.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L50")
                textBox57.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L51")
                textBox56.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L52")
                textBox55.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L53")
                textBox54.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L54")
                textBox53.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L55")
                textBox71.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L56")
                textBox70.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L57")
                textBox69.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L58")
                textBox68.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L59")
                textBox67.BackColor = Color.LimeGreen;
            else if (comboBox2.Text == "L60")
                textBox66.BackColor = Color.LimeGreen;
            comboBox2.Enabled = false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "L1")
                textBox25.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L2")
                textBox24.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L3")
                textBox23.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L4")
                textBox22.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L5")
                textBox21.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L6")
                textBox20.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L7")
                textBox38.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L8")
                textBox37.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L9")
                textBox36.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L10")
                textBox35.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L11")
                textBox34.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L12")
                textBox33.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L13")
                textBox51.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L14")
                textBox50.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L15")
                textBox49.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L16")
                textBox48.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L17")
                textBox47.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L18")
                textBox46.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L19")
                textBox64.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L20")
                textBox63.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L21")
                textBox62.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L22")
                textBox61.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L23")
                textBox60.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L24")
                textBox59.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L25")
                textBox77.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L26")
                textBox76.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L27")
                textBox75.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L28")
                textBox74.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L29")
                textBox73.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L30")
                textBox72.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L31")
                textBox19.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L32")
                textBox18.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L33")
                textBox17.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L34")
                textBox16.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L35")
                textBox15.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L36")
                textBox14.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L37")
                textBox32.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L38")
                textBox31.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L39")
                textBox30.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L40")
                textBox29.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L41")
                textBox28.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L42")
                textBox27.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L43")
                textBox45.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L44")
                textBox44.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L45")
                textBox43.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L46")
                textBox42.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L47")
                textBox41.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L48")
                textBox40.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L49")
                textBox58.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L50")
                textBox57.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L51")
                textBox56.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L52")
                textBox55.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L53")
                textBox54.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L54")
                textBox53.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L55")
                textBox71.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L56")
                textBox70.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L57")
                textBox69.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L58")
                textBox68.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L59")
                textBox67.BackColor = Color.LimeGreen;
            else if (comboBox3.Text == "L60")
                textBox66.BackColor = Color.LimeGreen;
            comboBox3.Enabled = false;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "L1")
                textBox25.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L2")
                textBox24.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L3")
                textBox23.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L4")
                textBox22.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L5")
                textBox21.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L6")
                textBox20.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L7")
                textBox38.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L8")
                textBox37.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L9")
                textBox36.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L10")
                textBox35.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L11")
                textBox34.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L12")
                textBox33.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L13")
                textBox51.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L14")
                textBox50.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L15")
                textBox49.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L16")
                textBox48.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L17")
                textBox47.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L18")
                textBox46.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L19")
                textBox64.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L20")
                textBox63.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L21")
                textBox62.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L22")
                textBox61.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L23")
                textBox60.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L24")
                textBox59.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L25")
                textBox77.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L26")
                textBox76.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L27")
                textBox75.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L28")
                textBox74.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L29")
                textBox73.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L30")
                textBox72.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L31")
                textBox19.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L32")
                textBox18.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L33")
                textBox17.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L34")
                textBox16.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L35")
                textBox15.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L36")
                textBox14.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L37")
                textBox32.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L38")
                textBox31.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L39")
                textBox30.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L40")
                textBox29.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L41")
                textBox28.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L42")
                textBox27.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L43")
                textBox45.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L44")
                textBox44.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L45")
                textBox43.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L46")
                textBox42.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L47")
                textBox41.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L48")
                textBox40.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L49")
                textBox58.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L50")
                textBox57.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L51")
                textBox56.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L52")
                textBox55.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L53")
                textBox54.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L54")
                textBox53.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L55")
                textBox71.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L56")
                textBox70.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L57")
                textBox69.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L58")
                textBox68.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L59")
                textBox67.BackColor = Color.LimeGreen;
            else if (comboBox4.Text == "L60")
                textBox66.BackColor = Color.LimeGreen;
            comboBox4.Enabled = false;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.Text == "L1")
                textBox25.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L2")
                textBox24.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L3")
                textBox23.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L4")
                textBox22.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L5")
                textBox21.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L6")
                textBox20.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L7")
                textBox38.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L8")
                textBox37.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L9")
                textBox36.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L10")
                textBox35.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L11")
                textBox34.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L12")
                textBox33.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L13")
                textBox51.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L14")
                textBox50.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L15")
                textBox49.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L16")
                textBox48.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L17")
                textBox47.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L18")
                textBox46.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L19")
                textBox64.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L20")
                textBox63.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L21")
                textBox62.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L22")
                textBox61.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L23")
                textBox60.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L24")
                textBox59.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L25")
                textBox77.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L26")
                textBox76.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L27")
                textBox75.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L28")
                textBox74.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L29")
                textBox73.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L30")
                textBox72.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L31")
                textBox19.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L32")
                textBox18.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L33")
                textBox17.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L34")
                textBox16.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L35")
                textBox15.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L36")
                textBox14.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L37")
                textBox32.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L38")
                textBox31.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L39")
                textBox30.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L40")
                textBox29.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L41")
                textBox28.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L42")
                textBox27.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L43")
                textBox45.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L44")
                textBox44.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L45")
                textBox43.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L46")
                textBox42.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L47")
                textBox41.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L48")
                textBox40.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L49")
                textBox58.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L50")
                textBox57.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L51")
                textBox56.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L52")
                textBox55.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L53")
                textBox54.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L54")
                textBox53.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L55")
                textBox71.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L56")
                textBox70.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L57")
                textBox69.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L58")
                textBox68.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L59")
                textBox67.BackColor = Color.LimeGreen;
            else if (comboBox6.Text == "L60")
                textBox66.BackColor = Color.LimeGreen;
            comboBox6.Enabled = false;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.Text == "L1")
                textBox25.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L2")
                textBox24.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L3")
                textBox23.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L4")
                textBox22.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L5")
                textBox21.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L6")
                textBox20.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L7")
                textBox38.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L8")
                textBox37.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L9")
                textBox36.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L10")
                textBox35.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L11")
                textBox34.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L12")
                textBox33.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L13")
                textBox51.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L14")
                textBox50.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L15")
                textBox49.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L16")
                textBox48.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L17")
                textBox47.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L18")
                textBox46.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L19")
                textBox64.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L20")
                textBox63.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L21")
                textBox62.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L22")
                textBox61.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L23")
                textBox60.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L24")
                textBox59.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L25")
                textBox77.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L26")
                textBox76.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L27")
                textBox75.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L28")
                textBox74.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L29")
                textBox73.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L30")
                textBox72.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L31")
                textBox19.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L32")
                textBox18.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L33")
                textBox17.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L34")
                textBox16.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L35")
                textBox15.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L36")
                textBox14.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L37")
                textBox32.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L38")
                textBox31.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L39")
                textBox30.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L40")
                textBox29.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L41")
                textBox28.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L42")
                textBox27.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L43")
                textBox45.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L44")
                textBox44.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L45")
                textBox43.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L46")
                textBox42.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L47")
                textBox41.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L48")
                textBox40.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L49")
                textBox58.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L50")
                textBox57.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L51")
                textBox56.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L52")
                textBox55.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L53")
                textBox54.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L54")
                textBox53.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L55")
                textBox71.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L56")
                textBox70.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L57")
                textBox69.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L58")
                textBox68.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L59")
                textBox67.BackColor = Color.LimeGreen;
            else if (comboBox5.Text == "L60")
                textBox66.BackColor = Color.LimeGreen;
            comboBox5.Enabled = false;
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox8.Text == "L1")
                textBox25.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L2")
                textBox24.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L3")
                textBox23.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L4")
                textBox22.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L5")
                textBox21.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L6")
                textBox20.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L7")
                textBox38.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L8")
                textBox37.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L9")
                textBox36.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L10")
                textBox35.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L11")
                textBox34.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L12")
                textBox33.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L13")
                textBox51.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L14")
                textBox50.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L15")
                textBox49.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L16")
                textBox48.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L17")
                textBox47.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L18")
                textBox46.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L19")
                textBox64.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L20")
                textBox63.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L21")
                textBox62.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L22")
                textBox61.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L23")
                textBox60.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L24")
                textBox59.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L25")
                textBox77.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L26")
                textBox76.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L27")
                textBox75.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L28")
                textBox74.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L29")
                textBox73.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L30")
                textBox72.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L31")
                textBox19.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L32")
                textBox18.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L33")
                textBox17.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L34")
                textBox16.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L35")
                textBox15.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L36")
                textBox14.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L37")
                textBox32.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L38")
                textBox31.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L39")
                textBox30.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L40")
                textBox29.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L41")
                textBox28.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L42")
                textBox27.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L43")
                textBox45.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L44")
                textBox44.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L45")
                textBox43.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L46")
                textBox42.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L47")
                textBox41.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L48")
                textBox40.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L49")
                textBox58.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L50")
                textBox57.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L51")
                textBox56.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L52")
                textBox55.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L53")
                textBox54.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L54")
                textBox53.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L55")
                textBox71.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L56")
                textBox70.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L57")
                textBox69.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L58")
                textBox68.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L59")
                textBox67.BackColor = Color.LimeGreen;
            else if (comboBox8.Text == "L60")
                textBox66.BackColor = Color.LimeGreen;
            comboBox8.Enabled = false;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox7.Text == "L1")
                textBox25.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L2")
                textBox24.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L3")
                textBox23.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L4")
                textBox22.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L5")
                textBox21.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L6")
                textBox20.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L7")
                textBox38.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L8")
                textBox37.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L9")
                textBox36.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L10")
                textBox35.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L11")
                textBox34.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L12")
                textBox33.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L13")
                textBox51.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L14")
                textBox50.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L15")
                textBox49.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L16")
                textBox48.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L17")
                textBox47.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L18")
                textBox46.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L19")
                textBox64.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L20")
                textBox63.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L21")
                textBox62.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L22")
                textBox61.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L23")
                textBox60.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L24")
                textBox59.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L25")
                textBox77.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L26")
                textBox76.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L27")
                textBox75.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L28")
                textBox74.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L29")
                textBox73.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L30")
                textBox72.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L31")
                textBox19.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L32")
                textBox18.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L33")
                textBox17.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L34")
                textBox16.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L35")
                textBox15.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L36")
                textBox14.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L37")
                textBox32.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L38")
                textBox31.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L39")
                textBox30.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L40")
                textBox29.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L41")
                textBox28.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L42")
                textBox27.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L43")
                textBox45.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L44")
                textBox44.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L45")
                textBox43.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L46")
                textBox42.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L47")
                textBox41.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L48")
                textBox40.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L49")
                textBox58.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L50")
                textBox57.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L51")
                textBox56.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L52")
                textBox55.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L53")
                textBox54.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L54")
                textBox53.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L55")
                textBox71.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L56")
                textBox70.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L57")
                textBox69.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L58")
                textBox68.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L59")
                textBox67.BackColor = Color.LimeGreen;
            else if (comboBox7.Text == "L60")
                textBox66.BackColor = Color.LimeGreen;
            comboBox7.Enabled = false;
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox13.Text == "L1")
                textBox25.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L2")
                textBox24.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L3")
                textBox23.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L4")
                textBox22.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L5")
                textBox21.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L6")
                textBox20.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L7")
                textBox38.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L8")
                textBox37.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L9")
                textBox36.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L10")
                textBox35.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L11")
                textBox34.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L12")
                textBox33.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L13")
                textBox51.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L14")
                textBox50.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L15")
                textBox49.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L16")
                textBox48.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L17")
                textBox47.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L18")
                textBox46.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L19")
                textBox64.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L20")
                textBox63.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L21")
                textBox62.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L22")
                textBox61.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L23")
                textBox60.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L24")
                textBox59.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L25")
                textBox77.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L26")
                textBox76.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L27")
                textBox75.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L28")
                textBox74.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L29")
                textBox73.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L30")
                textBox72.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L31")
                textBox19.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L32")
                textBox18.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L33")
                textBox17.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L34")
                textBox16.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L35")
                textBox15.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L36")
                textBox14.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L37")
                textBox32.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L38")
                textBox31.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L39")
                textBox30.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L40")
                textBox29.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L41")
                textBox28.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L42")
                textBox27.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L43")
                textBox45.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L44")
                textBox44.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L45")
                textBox43.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L46")
                textBox42.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L47")
                textBox41.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L48")
                textBox40.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L49")
                textBox58.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L50")
                textBox57.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L51")
                textBox56.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L52")
                textBox55.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L53")
                textBox54.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L54")
                textBox53.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L55")
                textBox71.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L56")
                textBox70.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L57")
                textBox69.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L58")
                textBox68.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L59")
                textBox67.BackColor = Color.LimeGreen;
            else if (comboBox13.Text == "L60")
                textBox66.BackColor = Color.LimeGreen;
            comboBox13.Enabled = false;
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox11.Text == "L1")
                textBox25.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L2")
                textBox24.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L3")
                textBox23.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L4")
                textBox22.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L5")
                textBox21.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L6")
                textBox20.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L7")
                textBox38.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L8")
                textBox37.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L9")
                textBox36.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L10")
                textBox35.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L11")
                textBox34.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L12")
                textBox33.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L13")
                textBox51.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L14")
                textBox50.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L15")
                textBox49.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L16")
                textBox48.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L17")
                textBox47.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L18")
                textBox46.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L19")
                textBox64.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L20")
                textBox63.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L21")
                textBox62.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L22")
                textBox61.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L23")
                textBox60.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L24")
                textBox59.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L25")
                textBox77.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L26")
                textBox76.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L27")
                textBox75.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L28")
                textBox74.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L29")
                textBox73.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L30")
                textBox72.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L31")
                textBox19.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L32")
                textBox18.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L33")
                textBox17.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L34")
                textBox16.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L35")
                textBox15.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L36")
                textBox14.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L37")
                textBox32.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L38")
                textBox31.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L39")
                textBox30.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L40")
                textBox29.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L41")
                textBox28.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L42")
                textBox27.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L43")
                textBox45.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L44")
                textBox44.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L45")
                textBox43.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L46")
                textBox42.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L47")
                textBox41.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L48")
                textBox40.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L49")
                textBox58.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L50")
                textBox57.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L51")
                textBox56.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L52")
                textBox55.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L53")
                textBox54.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L54")
                textBox53.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L55")
                textBox71.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L56")
                textBox70.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L57")
                textBox69.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L58")
                textBox68.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L59")
                textBox67.BackColor = Color.LimeGreen;
            else if (comboBox11.Text == "L60")
                textBox66.BackColor = Color.LimeGreen;
            comboBox11.Enabled = false;
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox9.Text == "L1")
                textBox25.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L2")
                textBox24.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L3")
                textBox23.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L4")
                textBox22.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L5")
                textBox21.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L6")
                textBox20.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L7")
                textBox38.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L8")
                textBox37.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L9")
                textBox36.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L10")
                textBox35.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L11")
                textBox34.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L12")
                textBox33.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L13")
                textBox51.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L14")
                textBox50.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L15")
                textBox49.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L16")
                textBox48.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L17")
                textBox47.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L18")
                textBox46.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L19")
                textBox64.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L20")
                textBox63.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L21")
                textBox62.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L22")
                textBox61.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L23")
                textBox60.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L24")
                textBox59.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L25")
                textBox77.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L26")
                textBox76.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L27")
                textBox75.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L28")
                textBox74.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L29")
                textBox73.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L30")
                textBox72.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L31")
                textBox19.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L32")
                textBox18.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L33")
                textBox17.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L34")
                textBox16.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L35")
                textBox15.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L36")
                textBox14.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L37")
                textBox32.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L38")
                textBox31.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L39")
                textBox30.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L40")
                textBox29.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L41")
                textBox28.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L42")
                textBox27.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L43")
                textBox45.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L44")
                textBox44.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L45")
                textBox43.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L46")
                textBox42.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L47")
                textBox41.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L48")
                textBox40.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L49")
                textBox58.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L50")
                textBox57.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L51")
                textBox56.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L52")
                textBox55.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L53")
                textBox54.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L54")
                textBox53.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L55")
                textBox71.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L56")
                textBox70.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L57")
                textBox69.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L58")
                textBox68.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L59")
                textBox67.BackColor = Color.LimeGreen;
            else if (comboBox9.Text == "L60")
                textBox66.BackColor = Color.LimeGreen;
            comboBox9.Enabled = false;
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox14.Text == "L1")
                textBox25.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L2")
                textBox24.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L3")
                textBox23.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L4")
                textBox22.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L5")
                textBox21.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L6")
                textBox20.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L7")
                textBox38.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L8")
                textBox37.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L9")
                textBox36.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L10")
                textBox35.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L11")
                textBox34.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L12")
                textBox33.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L13")
                textBox51.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L14")
                textBox50.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L15")
                textBox49.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L16")
                textBox48.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L17")
                textBox47.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L18")
                textBox46.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L19")
                textBox64.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L20")
                textBox63.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L21")
                textBox62.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L22")
                textBox61.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L23")
                textBox60.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L24")
                textBox59.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L25")
                textBox77.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L26")
                textBox76.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L27")
                textBox75.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L28")
                textBox74.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L29")
                textBox73.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L30")
                textBox72.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L31")
                textBox19.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L32")
                textBox18.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L33")
                textBox17.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L34")
                textBox16.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L35")
                textBox15.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L36")
                textBox14.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L37")
                textBox32.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L38")
                textBox31.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L39")
                textBox30.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L40")
                textBox29.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L41")
                textBox28.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L42")
                textBox27.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L43")
                textBox45.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L44")
                textBox44.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L45")
                textBox43.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L46")
                textBox42.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L47")
                textBox41.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L48")
                textBox40.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L49")
                textBox58.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L50")
                textBox57.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L51")
                textBox56.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L52")
                textBox55.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L53")
                textBox54.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L54")
                textBox53.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L55")
                textBox71.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L56")
                textBox70.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L57")
                textBox69.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L58")
                textBox68.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L59")
                textBox67.BackColor = Color.LimeGreen;
            else if (comboBox14.Text == "L60")
                textBox66.BackColor = Color.LimeGreen;
            comboBox14.Enabled = false;
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox12.Text == "L1")
                textBox25.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L2")
                textBox24.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L3")
                textBox23.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L4")
                textBox22.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L5")
                textBox21.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L6")
                textBox20.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L7")
                textBox38.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L8")
                textBox37.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L9")
                textBox36.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L10")
                textBox35.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L11")
                textBox34.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L12")
                textBox33.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L13")
                textBox51.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L14")
                textBox50.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L15")
                textBox49.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L16")
                textBox48.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L17")
                textBox47.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L18")
                textBox46.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L19")
                textBox64.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L20")
                textBox63.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L21")
                textBox62.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L22")
                textBox61.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L23")
                textBox60.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L24")
                textBox59.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L25")
                textBox77.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L26")
                textBox76.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L27")
                textBox75.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L28")
                textBox74.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L29")
                textBox73.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L30")
                textBox72.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L31")
                textBox19.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L32")
                textBox18.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L33")
                textBox17.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L34")
                textBox16.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L35")
                textBox15.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L36")
                textBox14.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L37")
                textBox32.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L38")
                textBox31.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L39")
                textBox30.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L40")
                textBox29.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L41")
                textBox28.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L42")
                textBox27.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L43")
                textBox45.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L44")
                textBox44.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L45")
                textBox43.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L46")
                textBox42.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L47")
                textBox41.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L48")
                textBox40.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L49")
                textBox58.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L50")
                textBox57.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L51")
                textBox56.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L52")
                textBox55.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L53")
                textBox54.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L54")
                textBox53.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L55")
                textBox71.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L56")
                textBox70.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L57")
                textBox69.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L58")
                textBox68.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L59")
                textBox67.BackColor = Color.LimeGreen;
            else if (comboBox12.Text == "L60")
                textBox66.BackColor = Color.LimeGreen;
            comboBox12.Enabled = false;
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox10.Text == "L1")
                textBox25.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L2")
                textBox24.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L3")
                textBox23.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L4")
                textBox22.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L5")
                textBox21.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L6")
                textBox20.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L7")
                textBox38.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L8")
                textBox37.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L9")
                textBox36.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L10")
                textBox35.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L11")
                textBox34.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L12")
                textBox33.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L13")
                textBox51.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L14")
                textBox50.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L15")
                textBox49.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L16")
                textBox48.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L17")
                textBox47.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L18")
                textBox46.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L19")
                textBox64.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L20")
                textBox63.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L21")
                textBox62.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L22")
                textBox61.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L23")
                textBox60.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L24")
                textBox59.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L25")
                textBox77.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L26")
                textBox76.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L27")
                textBox75.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L28")
                textBox74.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L29")
                textBox73.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L30")
                textBox72.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L31")
                textBox19.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L32")
                textBox18.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L33")
                textBox17.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L34")
                textBox16.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L35")
                textBox15.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L36")
                textBox14.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L37")
                textBox32.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L38")
                textBox31.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L39")
                textBox30.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L40")
                textBox29.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L41")
                textBox28.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L42")
                textBox27.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L43")
                textBox45.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L44")
                textBox44.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L45")
                textBox43.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L46")
                textBox42.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L47")
                textBox41.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L48")
                textBox40.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L49")
                textBox58.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L50")
                textBox57.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L51")
                textBox56.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L52")
                textBox55.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L53")
                textBox54.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L54")
                textBox53.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L55")
                textBox71.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L56")
                textBox70.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L57")
                textBox69.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L58")
                textBox68.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L59")
                textBox67.BackColor = Color.LimeGreen;
            else if (comboBox10.Text == "L60")
                textBox66.BackColor = Color.LimeGreen;
            comboBox10.Enabled = false;
        }
        void reset(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                {
                    if (((TextBox)c).BackColor == Color.LimeGreen)
                        ((TextBox)c).BackColor = SystemColors.Control;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                    ((ComboBox)c).Enabled = true;
                }

            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            reset(this);
        }

        private void textBox82_TextChanged(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
