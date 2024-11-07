namespace Practica3_1
{
    public partial class SUMAR_NUMEROS : Form
    {
        public SUMAR_NUMEROS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            int sum = num1 + num2;
            label3.Text = "Sum = " + sum;
        }
    }
}
