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
        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
                // Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
                // В случая на правоъгълник - директно връщаме true
                return true;
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
            //Тая мацаница с тоя триъгълник трябва да я измисля
            // Това е само за тест
            // Голяма Боза стана 

            //Random rnd = new Random();
            //int x = rnd.Next(100, 1000);
            //int y = rnd.Next(100, 600);
            //int z = rnd.Next(100, 800);
            //int x1 = rnd.Next(100, 1000);
            //int y1 = rnd.Next(100, 600);
            //int z1 = rnd.Next(100, 800);



            //    Console.WriteLine("x {0} ,x1 {1}, y {2}, y1 {3} ,z {4}, z1 {5}", x, x1, y, y1, z, z1);
            //Point[] points = { new Point(x, x1), new Point(y, y1), new Point(z, z1) };
            //grfx.FillPolygon(new SolidBrush(FillColor), points);
            //grfx.DrawPolygon(new Pen(BorderColor), points);



            Point top = new Point((int)Rectangle.X + (int)Rectangle.Width / 2, (int)Rectangle.Y);
            Point right = new Point((int)Rectangle.X + (int)Rectangle.Width, (int)Rectangle.Y + (int)Rectangle.Height);
            Point left = new Point((int)Rectangle.X, (int)Rectangle.Y + (int)Rectangle.Height);

            Point[] points = { top, right, left };
            grfx.FillPolygon(new SolidBrush(FillColor), points);
            grfx.DrawPolygon(new Pen(BorderColor), points);

            //  grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            //  grfx.DrawRectangle(new Pen(BorderColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            //grfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //SolidBrush solidbrush = new SolidBrush(Color.Black);
            //Pen pen = new Pen(solidbrush);
            //TriangleShape t = new TriangleShape();
            // grfx.DrawPolygon(pen, new Point[] { p0, p1, p2 });

            //
        }
    }
}
