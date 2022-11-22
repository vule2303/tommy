namespace Lab3
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

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btStart_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);
            float c = float.Parse(txtC.Text);
            float dental = b * b - 4 * a * c;

            

            if (dental < 0)
            {
                MessageBox.Show("Phuong trinh vo nghiem");
            } else if (dental == 0) {
                MessageBox.Show("Phương trình có 1 nghiệm duy nhất");
              
                MessageBox.Show("x1 = x2 = " + -b / 2 * a);
            } else
            {
                MessageBox.Show("Phương trình có 2 nghiệm phân biệt");
                MessageBox.Show("x1 = " + (b + Math.Sqrt(dental) / 2 * a), "x2 = " + (-b + Math.Sqrt(dental) / 2 * a));
            }
        
        }

        private void btAgain_Click(object sender, EventArgs e)
        {
            this.txtA.Text = "";
            this.txtB.Text = "";
            this.txtC.Text = "";

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)

        {
            Type type = typeof(int);
             
            if (e.KeyChar.GetType() != type)
            {
                MessageBox.Show("Dữ liệu sai, hãy nhập số");
            }
        }
        private void txt_AKeyPress(object sender, KeyPressEventArgs e)
        {
            Type type = typeof(int);

            if (e.KeyChar.GetType() != type)
            {
                MessageBox.Show("Dữ liệu sai, hãy nhập số");
            }
        }
        private void txtC_KeyPress(object sender, KeyPressEventArgs e)

        {
            var type = typeof(int);

            if (e.KeyChar.GetType() != type)
            {
                MessageBox.Show("Dữ liệu sai, hãy nhập số");
            } else
            {
                
            }
        }
    }
}