using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            Random ran = new Random();
            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                int mul = (int)numericUpDown1.Value;
                Arrays a = new Arrays(n);
                Arrays resArray = new Arrays(n);
                a = Arrays.generateRandomArray(a);
                dataGridView1.ColumnCount = n;
                dataGridView2.ColumnCount = n;
                resArray = a * mul;
                for (int i = 0; i < a.Length; i++)
                {
                    dataGridView1.Rows[0].Cells[i].Value = a[i];
                    dataGridView2.Rows[0].Cells[i].Value = resArray[i];
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }
    }
}
