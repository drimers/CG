using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Drawing2D;

namespace Draw
{
    /// <summary>
    /// Класът, който ще бъде използван при управляване на диалога.
    /// </summary>
    public class DialogProcessor : DisplayProcessor
    {
        #region Constructor

        public DialogProcessor()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Избран елемент.
        /// </summary>
        private List<Shape> selection = new List<Shape>();
        public List<Shape> Selection
        {
            get { return selection; }
            set { selection = value; }
        }

        /// <summary>
        /// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
        /// </summary>
        private bool isDragging;
        public bool IsDragging
        {
            get { return isDragging; }
            set { isDragging = value; }
        }

        /// <summary>
        /// Последна позиция на мишката при "влачене".
        /// Използва се за определяне на вектора на транслация.
        /// </summary>
        private PointF lastLocation;
        public PointF LastLocation
        {
            get { return lastLocation; }
            set { lastLocation = value; }
        }

        #endregion

        /// <summary>
        /// Добавя примитив - правоъгълник на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomRectangle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            RectangleShape rectangle = new RectangleShape(new Rectangle(x, y, 100, 200));

            rectangle.FillColor = Color.DeepSkyBlue;
            rectangle.BorderColor = Color.Green;
            ShapeList.Add(rectangle);
        }




        /// <summary>
        /// Проверява дали дадена точка е в елемента.
        /// Обхожда в ред обратен на визуализацията с цел намиране на
        /// "най-горния" елемент т.е. този който виждаме под мишката.
        /// </summary>
        /// <param name="point">Указана точка</param>
        /// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
        public Shape ContainsPoint(PointF point)
        {
            for (int i = ShapeList.Count - 1; i >= 0; i--)
            {
                if (ShapeList[i].Contains(point))
                {
                    //ShapeList[i].FillColor = Color.Red;

                    return ShapeList[i];
                }
            }
            return null;
        }

        /// <summary>
        /// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
        /// </summary>
        /// <param name="p">Вектор на транслация.</param>
        public void TranslateTo(PointF p)
        {
            //if (selection != null) {
            foreach (Shape item in Selection)
            {

                item.Location = new PointF(item.Location.X + p.X - lastLocation.X, item.Location.Y + p.Y - lastLocation.Y);
            }

            lastLocation = p;
        }

        public void AddRandomEllipse()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 200, 100));

            ellipse.FillColor = Color.Red;
            ellipse.BorderColor = Color.Green;

            ShapeList.Add(ellipse);

        }

        // added from me


        public void AddRandomSquare()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            SquareShape square = new SquareShape(new Rectangle(x, y, 200, 200));

            square.FillColor = Color.Yellow;
            square.BorderColor = Color.Red;
            ShapeList.Add(square);

        }


        public void AddRandomCircle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            CircleShape circle = new CircleShape(new Rectangle(x, y, 200, 200));

            circle.FillColor = Color.DarkCyan;
            circle.BorderColor = Color.LimeGreen;
            ShapeList.Add(circle);

        }


        //Тая мацаница с тоя триъгълник трябва да я измисля
        // Това е само за тест
        // Голяма Боза стана

        public void AddRandomTriangle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);
            // int z = rnd.Next(300, 800);

            //  TriangleShape elp = new TriangleShape(new Rectangle(x, y, 200, 100));
            TriangleShape triangle = new TriangleShape(new Rectangle(x, y, 300, 150));
            //TriangleShape tri = new TriangleShape(new Rectangle(x, y, 200, 100));
            // Point[] points = { new Point(x), new Point(y), new Point(z) };
            // Rectangle rectangle = new Rectangle(x, y, 100, 100);

            //    Point top = new Point(rectangle.Left + (rectangle.Width / 2), rectangle.Top);
            //    Point right = new Point(rectangle.Left, rectangle.Bottom);
            //    Point left = new Point(rectangle.Right, rectangle.Bottom);


            //    ShapeList.AddPolygon(new Point[]
            //{
            //    top,
            //    right,
            //    left
            //});
            //    return ShapeList;

            triangle.FillColor = Color.Lime;
            triangle.BorderColor = Color.Red;
            ShapeList.Add(triangle);

        }





        // end add from me

        internal void SetfillColor(Color color)
        {
            foreach (Shape item in Selection)
            {
                item.FillColor = color;
            }
        }

        public override void Draw(Graphics grfx)
        {


            base.Draw(grfx);
            foreach (Shape item in Selection)
            {
                grfx.DrawRectangle(Pens.Black, item.Location.X - 3,
                    item.Location.Y - 3, item.Width + 6, item.Height + 6);
            }

        }

        GroupShape group;

        public void Group()
        {
            if (Selection.Count < 2) return;

            float minX = float.PositiveInfinity;
            float minY = float.PositiveInfinity;
            float maxX = float.NegativeInfinity;
            float maxY = float.NegativeInfinity;
            foreach (Shape item in Selection)
            {
                if (minX > item.Location.X) minX = item.Location.X;
                if (minY > item.Location.Y) minY = item.Location.Y;
                if (maxX < item.Location.X + item.Width) maxX = item.Location.X + item.Width;
                if (maxY < item.Location.Y + item.Height) maxY = item.Location.Y + item.Height;
            }

            //GroupShape group = new GroupShape(new RectangleF(minX, minY, maxX - minX, maxY - minY));
            group = new GroupShape(new RectangleF(minX, minY, maxX - minX, maxY - minY));
            group.SubItems = Selection;
            Selection = new List<Shape>();
            Selection.Add(group);
            foreach (Shape item in group.SubItems)
                ShapeList.Remove(item);


            ShapeList.Add(group);

        }

        public void SaveAs(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, ShapeList);
            fs.Close();
        }


        public void OpenFile(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            ShapeList = (List<Shape>)bf.Deserialize(fs);
            fs.Close();
        }

        public void RemoveSelection()
        {

            if (Selection.Count < 1) return;


            Selection = new List<Shape>();

        }


        public void RemoveGroupSelection()
        {

            if (Selection.Count < 1) return;

            foreach (Shape item in Selection)
            {
                ShapeList.Remove(item);

            }
            Selection = new List<Shape>();

        }

        public void SelectAll()
        {

            Selection = new List<Shape>(ShapeList);


            foreach (Shape item in Selection)
            {
                ShapeList.Add(item);
            }
        }

        public void DeleteAll()
        {
            // if (Selection.Count < 1) return;
            Selection = new List<Shape>(ShapeList);
            foreach (Shape item in Selection)
            {
                ShapeList.Remove(item);

            }
            Selection = new List<Shape>();
        }

        public void ScaleUp()
        {
            //foreach (Shape item in group.SubItems)
            foreach (Shape item in Selection)
            {
                item.Height = item.Height * 2;
                item.Width = item.Width * 2;
            }

        }

        public void ScaleDown()
        {

            // foreach (Shape item in group.SubItems)
            foreach (Shape item in Selection)
            {
                item.Height = item.Height / 2;
                item.Width = item.Width / 2;
            }
        }
    }
}
