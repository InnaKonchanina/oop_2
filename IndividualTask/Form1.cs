using IndividualTask.Figures;

namespace IndividualTask
{
    public partial class Form1 : Form
    {
        private CEmblem cEmblem;

        public Form1()
        {
            InitializeComponent();
            KeyDown += Form1_KeyDown;
        }

        private void Draw()
        {
            cEmblem?.Hide();
            cEmblem = new CEmblem(pMain.CreateGraphics(),
                new Point(pMain.Width / 2, pMain.Height / 2));
            cEmblem.Show();
        }

        private void pMain_Resize(object sender, EventArgs e)
        {
            Draw();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            cEmblem?.Hide();
        }

        private void SizeUpButton_Click(object sender, EventArgs e)
        {
            cEmblem.Expand();
        }

        private void SizeDownButton_Click(object sender, EventArgs e)
        {
            cEmblem.Collapse();
        }

        private void MoveUpButton_Click(object sender, EventArgs e)
        {
            cEmblem.Move(0, -GetHeightMoveDif());
        }

        private void MoveDownButton_Click(object sender, EventArgs e)
        {
            cEmblem.Move(0, GetHeightMoveDif());
        }

        private void MoveRightButton_Click(object sender, EventArgs e)
        {
            cEmblem.Move(GetWidthMoveDif(), 0);
        }

        private void MoveLeftButton_Click(object sender, EventArgs e)
        {
            cEmblem.Move(-GetWidthMoveDif(), 0);
        }

        private int GetWidthMoveDif()
        {
            return pMain.Width / 10;
        }

        private int GetHeightMoveDif()
        {
            return pMain.Height / 10;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        MoveUpButton_Click(sender, EventArgs.Empty);
                        break;
                    }
                case Keys.Down:
                    {
                        MoveDownButton_Click(sender, EventArgs.Empty);
                        break;
                    }
                case Keys.Left:
                    {
                        MoveLeftButton_Click(sender, EventArgs.Empty);
                        break;
                    }
                case Keys.Right:
                    {
                        MoveRightButton_Click(sender, EventArgs.Empty);
                        break;
                    }
                case Keys.Add:
                    {
                        SizeUpButton_Click(sender, EventArgs.Empty);
                        break;
                    }
                case Keys.Subtract:
                    {
                        SizeDownButton_Click(sender, EventArgs.Empty);
                        break;
                    }
            }
        }
    }
}
