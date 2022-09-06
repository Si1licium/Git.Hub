

using Timer = System.Windows.Forms.Timer;

namespace vika
{
    public partial class Form1 : Form
    {
        Timer timer1 = new Timer();
        Timer timer2 = new Timer();
        Timer timer3 = new Timer();
        Timer timer4 = new Timer();
        Timer timer5 = new Timer();
        int timerCounter1 = 10;
        int timerCounter2 = 10;
        int timerCounter3 = 10;
        int timerCounter4 = 10;
        int timerCounter5 = 10;
        int a = 0;
       
        
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer3.Tick += new EventHandler(timer3_Tick);
            timer2.Tick += new EventHandler(timer2_Tick);
            timer4.Tick += new EventHandler(timer4_Tick);
            timer5.Tick += new EventHandler(timer5_Tick);
            




        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label4.Text = ("Осталось " + --timerCounter1 + " сек").ToString();
            if (timerCounter1 == 0)
            {
                timer1.Stop();
                this.label4.Visible = false;
                this.groupBox1.Visible = false;
                this.groupBox2.Visible = true;
                this.button5.Visible = true;
                MessageBox.Show("Время вышло");
                this.button5.Visible = false;
                this.Controls.Remove(button5);
                

            }
            

        }
        private void timer2_Tick(object sender, EventArgs e)
        {

            this.label5.Text = ("Осталось " + --timerCounter2 + "  сек").ToString();
            if (timerCounter2 == 0)
            {
                timer2.Stop();
                this.label5.Visible = false;
                
                this.groupBox2.Visible = false;
                this.groupBox3.Visible = true;
                MessageBox.Show("Время вышло");
                this.button6.Visible = false;


            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            timer1.Start();
            groupBox1.Visible = true;
            this.Controls.Remove(button1);
            this.Controls.Remove(button2);
            this.Controls.Remove(label1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            timer1.Stop();
            this.label4.Visible = false;
            if (groupBox2.Visible == true)
            {
                timer2.Interval = 1000;
                timer2.Start();
            }
            this.label5.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.groupBox4.Visible = false;
            this.groupBox3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.groupBox3.Visible=true;
            this.groupBox2.Visible=false;
            if (groupBox3.Visible == true)
            {
                timer3.Interval = 1000;
                timer3.Start();
                timer2.Stop();
            }
            this.label5.Visible = false;
            this.label6.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true ;
            this.groupBox2.Visible = false ;
            timer1.Start();
            this.label4.Visible = true;
            if (groupBox2.Visible == false)
            {
                timer2.Stop();
            }
            this.label5.Visible = false;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.groupBox4.Visible = true;
            this.groupBox3.Visible = false;
            {
                timer4.Interval = 1000;
                timer4.Start();
                timer3.Stop();
            }
            this.label6.Visible = false;
            this.label9.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.groupBox2.Visible = true;
            this.groupBox3.Visible = false;
            timer2.Start();
            this.label5.Visible= true;
            if (groupBox3.Visible == false)
            { timer3.Stop();}
            this.label6.Visible = false;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.groupBox3.Visible = true;
            this.groupBox4.Visible =false;
            timer3.Start();
            if (groupBox4.Visible == false)
            {
                timer4.Stop();
            }
            this.label9.Visible = false;
            this.label6.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {

           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.groupBox4.Visible =false;
            this.groupBox5.Visible = true;
            if (groupBox4.Visible == false)
            {
                timer5.Interval = 1000;
                timer5.Start();
                timer4.Stop();
            }
            this.label9.Visible = false;
            this.label10.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.groupBox5.Visible=false;
            this.groupBox4.Visible=true;
            timer4.Start();
            if (groupBox5.Visible == false)
            { timer5.Stop();}
            this.label10.Visible=false;
            this.label9.Visible=true;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (timerCounter5 == 0)
            {
                if (checkBox1.Checked == true && checkBox3.Checked == true)
                {
                    a++;
                }
                if (textBox1.Text == "Планкалкюль")
                {
                    a++;
                }

                if (radioButton3.Checked == true)
                {
                    a++;
                }
                if (radioButton4.Checked == true)
                {
                    a++;
                }
                if (radioButton8.Checked == true)
                {
                    a++;
                }
                MessageBox.Show("Количество правильных ответов: " + a);
                Application.Exit();
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            this.label6.Text = ("Осталось " + --timerCounter3 + "  сек").ToString();
            if (timerCounter3 == 0)
            {
                timer3.Stop();
                this.label6.Visible = false;

                this.groupBox3.Visible = false;
                this.groupBox4.Visible = true;
                
                MessageBox.Show("Время вышло");
                this.button8.Visible = false;
                

            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            this.label9.Text = ("Осталось " + --timerCounter4 + "  сек").ToString();
            if (timerCounter4 == 0)
            {
                timer4.Stop();
                this.label9.Visible = false;

                this.groupBox4.Visible = false;
                this.groupBox5.Visible = true;

                MessageBox.Show("Время вышло");
                this.button11.Visible = false;


            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            this.label10.Text = ("Осталось " + --timerCounter5 + " сек").ToString();
            if(timerCounter5 == 0)
            {
                timer5.Stop();
                this.label10.Visible = false;

                this.groupBox5.Visible = false;

                MessageBox.Show("Время вышло");
                this.button12.Visible = true;
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            timer5.Stop();
                if (checkBox1.Checked == true && checkBox3.Checked == true)
                {
                    a++;
                }
                if (textBox1.Text == "Планкалкюль")
                {
                    a++;
                }

                if (radioButton3.Checked == true)
                {
                    a++;
                }
                if (radioButton4.Checked == true)
                {
                    a++;
                }
                if (radioButton8.Checked == true)
                {
                    a++;
                }
                MessageBox.Show("Количество правильных ответов: " + a);
                Application.Exit();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }