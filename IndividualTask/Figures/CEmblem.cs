namespace IndividualTask.Figures
{
    internal class CEmblem
    {
        const int DefaultRadius = 50;

        private readonly Graphics graphics;
        private int _radius;

        public CEmblem(Graphics graphics, Point centerPoint) : this(graphics, DefaultRadius, centerPoint) { }

        public CEmblem(Graphics graphics, int radius, Point centerPoint)
        {
            this.graphics = graphics;
            Radius = radius;
            X = centerPoint.X;
            Y = centerPoint.Y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value >= 200 ? 200 : value;
                _radius = value <= 5 ? 5 : value;
            }
        }

        public int Diameter => Radius * 2;

        public int Gap => Radius / 5;

        private void Draw(Pen pen)
        {
            graphics.DrawEllipse(pen,
                new Rectangle(X - Radius - Diameter - Gap, Y, Diameter, Diameter));

            graphics.DrawRectangle(pen,
                new Rectangle(X + Radius + Gap, Y, Diameter, Diameter));

            graphics.DrawPolygon(pen, new Point[]
            {
                new Point(X - Radius, Y),// Top
                new Point(X - Radius, Y + Diameter), // Bottom
                new Point(X + Radius, Y + Radius), // Center left
            });
        }
        public void Show()
        {
            Draw(Pens.Red);
        }
        public void Hide()
        {
            Draw(Pens.White);
        }
        public void Expand()
        {
            Hide();
            Radius += 5;
            Show();
        }
        public void Collapse()
        {
            Hide();
            Radius -= 5;
            Show();
        }
        public void Move(int dx, int dy)
        {
            Hide();
            X += dx;
            Y += dy;
            Show();
        }
    }
}
