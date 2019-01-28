using System;
using System.Drawing;

namespace Draw
{
    /// <summary>
    /// Класът правоъгълник е основен примитив, който е наследник на базовия Shape.
    /// </summary>
    [Serializable]
    public class CircleShape : Shape
    {
        #region Constructor

        public CircleShape(RectangleF rect) : base(rect)
        {
        }

        public CircleShape(RectangleShape rectangle) : base(rectangle)
        {
        }

        #endregion

        /// <summary>
        /// Проверка за принадлежност на точка point към правоъгълника.
        /// В случая на правоъгълник този метод може да не бъде пренаписван, защото
        /// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
        /// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
        /// елемента в този случай).
        /// </summary>
        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
            {

                // Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
                // В случая на правоъгълник - директно връщаме true
                float a = Width / 2;
                float b = Height / 2;

                return Math.Pow((point.X - (Location.X + a)) / a, 2) +
                    (Math.Pow((point.Y - (Location.Y + b)) / b, 2)) - 1 <= 0;
            }
            else
                // Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
                return false;
        }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawEllipse(new Pen(BorderColor, BorderSize), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            //// |
            /// / \
            //PointF point = new PointF(Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 2);
            //grfx.DrawLine(new Pen(Color.Black), point, new PointF(Rectangle.X + Rectangle.Width / 2, Rectangle.Y));
            //grfx.DrawLine(new Pen(Color.Black), point, new PointF(Rectangle.X + Rectangle.Width - 6, Rectangle.Y + Rectangle.Height - 70));
            //grfx.DrawLine(new Pen(Color.Black), point, new PointF(Rectangle.X + 6, Rectangle.Y + Rectangle.Height - 70));

            //// |
            //grfx.DrawLine(new Pen(new SolidBrush(Color.Black)), Rectangle.X + Height / 2, Rectangle.Y, Rectangle.X + Height / 2, Rectangle.Y + Width);


            FontFamily ff = new FontFamily("Arial");
            System.Drawing.Font font = new System.Drawing.Font(ff, 20);
            grfx.DrawString("Circle", font, new SolidBrush(Color.Black), Rectangle.X + Rectangle.Width - 140, Rectangle.Y + Rectangle.Height - 120);

            //just for test (drawing Line)
            // grfx.DrawLine(new Pen(Color.Black), Rectangle.X, Rectangle.Y, Rectangle.X + Rectangle.Width - 100, Rectangle.Y + Rectangle.Height - 50);



        }
    }
}
