using IndividualTask.Figures;

namespace IndividualTask
{
    public partial class Form1 : Form
    {
        private CEmblem cEmblem;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            cEmblem = new CEmblem(pMain.CreateGraphics(), new Point(pMain.Width/2,pMain.Height/2));
            cEmblem.Show();
        }
    }
}
