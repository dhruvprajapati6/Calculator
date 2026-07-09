namespace Ex_3_WidForm
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            labresult.Text = "Result = " + (a + b);
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            labresult.Text = "Result = " + (a - b);
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            labresult.Text = "Result = " + (a * b);
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            if (b != 0)
            {
                labresult.Text = "Result = " + ((double)a / b);
            }
            else
            {
                MessageBox.Show("Not To Divide 0!!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();

            labresult.Text = "Result = 0";

            textBox1.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "You Are Exit The Form??",
        "Exit",
        MessageBoxButtons.YesNo
    );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labresult_Click(object sender, EventArgs e)
        {

        }
    }
}
