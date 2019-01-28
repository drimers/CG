using System;
using System.Drawing;

namespace Draw
{
    /// <summary>
    /// Класът правоъгълник е основен примитив, който е наследник на базовия Shape.
    /// </summary>
    [Serializable]
    public class RectangleShape : Shape
    {
        #region Constructor

        public RectangleShape(RectangleF rect) : base(rect)
        {
        }

        public RectangleShape(RectangleShape rectangle) : base(rectangle)
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
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);



            grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawRectangle(new Pen(BorderColor, BorderSize), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);



            //// diagonali
            //grfx.DrawLine(new Pen(new SolidBrush(Color.Black)), Rectangle.X, Rectangle.Y, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height);
            //grfx.DrawLine(new Pen(new SolidBrush(Color.Black)), Rectangle.X, Rectangle.Y + Rectangle.Height, Rectangle.X + Rectangle.Width, Rectangle.Y);



            //// rotated 90
            //grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Height, Rectangle.Width);
            //grfx.DrawRectangle(new Pen(BorderColor, BorderSize), Rectangle.X, Rectangle.Y, Rectangle.Height, Rectangle.Width);
            ////  
            ////  
            ////  \/plik
            //PointF point1 = new PointF(Rectangle.X + Rectangle.Width * 2, Rectangle.Y);
            //grfx.DrawLine(new Pen(Color.Black), point1, new PointF(Rectangle.X + 100, Rectangle.Y + Rectangle.Height / 5));
            //PointF point2 = new PointF(Rectangle.X, Rectangle.Y);
            //grfx.DrawLine(new Pen(Color.Black), point2, new PointF(Rectangle.X + 100, Rectangle.Y + Rectangle.Height / 5));




            FontFamily ff = new FontFamily("Arial");
            System.Drawing.Font font = new System.Drawing.Font(ff, 15);
            grfx.DrawString("Rectangle", font, new SolidBrush(Color.Black), Rectangle.X + Rectangle.Width - 95, Rectangle.Y + Rectangle.Height - 120);


            //grfx.FillRectangle(new SolidBrush(FillColor), 50, 150, 300, 500);
            //grfx.DrawRectangle(new Pen(BorderColor), 50, 150, 300, 500);





        }
    }
}
