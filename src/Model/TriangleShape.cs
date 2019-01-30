using System;
using System.Drawing;

namespace Draw
{
    /// <summary>
    /// Класът правоъгълник е основен примитив, който е наследник на базовия Shape.
    /// </summary>
    [Serializable]
    public class TriangleShape : Shape
    {

        #region Constructor

        public TriangleShape(RectangleF rect) : base(rect)
        {
        }

        public TriangleShape(RectangleShape rectangle) : base(rectangle)
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
        /// 
        Point top;
        Point right;
        Point left;


        public override bool Contains(PointF point)
        {
            if (base.Contains(point))

                // Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
                // В случая на правоъгълник - директно връщаме true


                return ((((right.Y - top.Y) * (point.X - top.X) - (right.X - top.X) * (point.Y - top.Y)) /
                ((left.Y - right.Y) * (point.X - right.X) - (left.X - right.X) * (point.Y - right.Y)) /
                ((top.Y - left.Y) * (point.X - left.X) - (top.X - left.X) * (point.Y - left.Y))) <= 0);



            //return true;

            else
                // Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
                return false;
        }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        /// 

        public override void DrawSelf(Graphics grfx)
        {

            base.DrawSelf(grfx);

            //Point top = new Point((int)Rectangle.X + (int)Rectangle.Width / 2, (int)Rectangle.Y);
            //Point right = new Point((int)Rectangle.X + (int)Rectangle.Width, (int)Rectangle.Y + (int)Rectangle.Height);
            //Point left = new Point((int)Rectangle.X, (int)Rectangle.Y + (int)Rectangle.Height);

            top = new Point((int)Rectangle.X + (int)Rectangle.Width / 2, (int)Rectangle.Y);
            right = new Point((int)Rectangle.X + (int)Rectangle.Width, (int)Rectangle.Y + (int)Rectangle.Height);
            left = new Point((int)Rectangle.X, (int)Rectangle.Y + (int)Rectangle.Height);


            Point[] points = { top, right, left };
            grfx.FillPolygon(new SolidBrush(FillColor), points);
            grfx.DrawPolygon(new Pen(BorderColor, BorderSize), points);

            FontFamily ff = new FontFamily("Arial");
            System.Drawing.Font font = new System.Drawing.Font(ff, 20);
            grfx.DrawString("Triangle", font, new SolidBrush(Color.Black), Rectangle.X + Rectangle.Width - 200, Rectangle.Y + Rectangle.Height - 50);

        }
    }
}
