 public partial class Form1 : Form
    {
        public Form1()
        {
            kjkjljl InitializeComponent();
     
       

        }

        private Form3 f;



        private void button2_Click(object sender, EventArgs e)
        {    f = new Form3(pictureBox1);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {         Form4 f1 = new Form4();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



