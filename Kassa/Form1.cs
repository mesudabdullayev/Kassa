using System.Numerics;

namespace Kassa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        decimal tot = 0;

        private void Siyahi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"

kod: 101 | Kurassan
kod: 102 | Sud
kod: 103 | Corek
kod: 104 | Alma
kod: 105 | Simit


");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] code = { "101", "102", "103", "104", "105" };
            string[] name = { "kurassan", "sud", "corek", "alma", "simit" };
            decimal[] price = { 2.7M, 2.9M, 0.55M, 1.6M, 0.7M };

            if (textBox1.Text == code[0])
            {
                listBox1.Items.Add($" Kod: {code[0]} | Ad: {name[0]} | Qiymet: {price[0]} Azn");
                tot = tot + price[0];
            }


            else if (textBox1.Text == code[1])
            {
                listBox1.Items.Add($" Kod: {code[1]} | Ad: {name[1]} | Qiymet: {price[1]} Azn");
                tot = tot + price[1];
            }

            else if (textBox1.Text == code[2])
            {
                listBox1.Items.Add($" Kod: {code[2]} | Ad: {name[2]} | Qiymet: {price[2]} Azn");
                tot = tot + price[2];
            }

            else if (textBox1.Text == code[3])
            {
                listBox1.Items.Add($" Kod: {code[3]} | Ad: {name[3]} | Qiymet: {price[3]} Azn");
                tot = tot + price[3];
            }

            else if (textBox1.Text == code[4])
            {
                listBox1.Items.Add($" Kod: {code[4]} | Ad: {name[4]} | Qiymet: {price[4]} Azn");
                tot = tot + price[4];
            }

            label7.Text = tot.ToString() + " " + "Azn";


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            decimal py= Convert.ToDecimal (textBox2.Text);  
            
            if (py < tot)
            {
                label8.Visible = true; 
            }
            else 
            {
            label8.Visible = false;
                decimal ret = py - tot;
                label6.Text = py.ToString() + " " + "Azn";
                label5.Text = ret.ToString() + " " + "azn";
            }
        }
    }
}




