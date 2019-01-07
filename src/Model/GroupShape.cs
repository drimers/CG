using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{

    [Serializable]
    public class GroupShape : Shape
    {
        #region Constructor

        public GroupShape(RectangleF rect) : base(rect)
        {
        }

        public GroupShape(RectangleShape rectangle) : base(rectangle)
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

        public List<Shape> SubItems { get; set; }




        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
            {
                foreach (Shape item in SubItems)
                {
                    if (item.Contains(point)) return true;
                }


                return false;
            }
            else

                return false;
        }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            foreach (Shape item in SubItems)
            {
                item.DrawSelf(grfx);
            }

        }

        public override PointF Location
        {
            get { return Rectangle.Location; }
            set
            {
                float dx = value.X - Location.X;
                float dy = value.Y - Location.Y;

                foreach (Shape item in SubItems)
                    item.Location = new PointF(item.Location.X + dx, item.Location.Y + dy);
                base.Location = value;

            }

        }


        public override Color FillColor
        {

            set
            {
                foreach (Shape item in SubItems)
                    item.FillColor = value;
            }
        }

    }
}


