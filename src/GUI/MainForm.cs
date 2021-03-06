﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Draw
{
    /// <summary>
    /// Върху главната форма е поставен потребителски контрол,
    /// в който се осъществява визуализацията
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
        /// </summary>
        private DialogProcessor dialogProcessor = new DialogProcessor();
        // private TriangleShape triangle = new TriangleShape();


        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        /// <summary>
        /// Изход от програмата. Затваря главната форма, а с това и програмата.
        /// </summary>
        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
        /// </summary>
        void ViewPortPaint(object sender, PaintEventArgs e)
        {
            dialogProcessor.ReDraw(sender, e);
        }

        /// <summary>
        /// Бутон, който поставя на произволно място правоъгълник със зададените размери.
        /// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
        /// </summary>
        void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomRectangle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

            viewPort.Invalidate();
        }

        /// <summary>
        /// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
        /// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
        /// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
        /// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
        /// </summary>
        void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (pickUpSpeedButton.Checked)
            {
                Shape sel = dialogProcessor.ContainsPoint(e.Location);
                if (sel == null) return;

                if (dialogProcessor.Selection.Contains(sel))
                {
                    dialogProcessor.Selection.Remove(sel);
                }
                else
                {
                    dialogProcessor.Selection.Add(sel);

                    statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
                    dialogProcessor.IsDragging = true;
                    dialogProcessor.LastLocation = e.Location;
                    viewPort.Invalidate();
                }
            }
        }

        /// <summary>
        /// Прихващане на преместването на мишката.
        /// Ако сме в режм на "влачене", то избрания елемент се транслира.
        /// </summary>
        void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (dialogProcessor.IsDragging)
            {
                if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
                dialogProcessor.TranslateTo(e.Location);
                viewPort.Invalidate();
            }
        }

        /// <summary>
        /// Прихващане на отпускането на бутона на мишката.
        /// Излизаме от режим "влачене".
        /// </summary>
        void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            dialogProcessor.IsDragging = false;
        }

        void DrawEllipsTeSpeedButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomEllipse();

            statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

            viewPort.Invalidate();
        }


        //Color Button
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dialogProcessor.SetfillColor(colorDialog1.Color);
                viewPort.Invalidate();
            }
        }


        //Group Button
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            dialogProcessor.Group();
            viewPort.Invalidate();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.SelectAll();
            viewPort.Invalidate();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dialogProcessor.SaveAs(saveFileDialog1.FileName);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomSquare();

            statusBar.Items[0].Text = "Последно действие: Рисуване на квадрат";

            viewPort.Invalidate();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomTriangle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на триъгълник";

            viewPort.Invalidate();

        }

        private void Circle_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomCircle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на окръжност";

            viewPort.Invalidate();
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            dialogProcessor.SelectAll();
            statusBar.Items[0].Text = "Последно действие: Селектиране на всички фигури";

            viewPort.Invalidate();
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            dialogProcessor.DeleteAll();
            statusBar.Items[0].Text = "Последно действие: Изтриване на всички фигури";

            viewPort.Invalidate();
        }

        private void ScaleUp_Click(object sender, EventArgs e)
        {
            dialogProcessor.ScaleUp();
            statusBar.Items[0].Text = "Последно действие: Увеличаване размера на селектираните фигури";

            viewPort.Invalidate();
        }

        private void ScaleDown_Click(object sender, EventArgs e)
        {
            dialogProcessor.ScaleDown();
            statusBar.Items[0].Text = "Последно действие: Намаляване размера на селектираните фигури";

            viewPort.Invalidate();
        }

        private void RemoveSelection_Click(object sender, EventArgs e)
        {
            dialogProcessor.RemoveSelection();
            statusBar.Items[0].Text = "Последно действие: Размаркиране на селектираните фигури";

            viewPort.Invalidate();
        }


        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dialogProcessor.OpenFile(openFileDialog1.FileName);
            }
            viewPort.Invalidate();
        }

        private void GroupScaleUp_Click(object sender, EventArgs e)
        {
            dialogProcessor.GroupScaleUp();
            statusBar.Items[0].Text = "Последно действие: Увеличаване размера на група фигури";

            viewPort.Invalidate();
        }

        private void GroupScaleDown_Click(object sender, EventArgs e)
        {
            dialogProcessor.GroupScaleDown();
            statusBar.Items[0].Text = "Последно действие: Намаляване размера на група фигури";

            viewPort.Invalidate();
        }

        private void GroupRemoveSelection_Click(object sender, EventArgs e)
        {
            dialogProcessor.GroupRemoveSelection();
            statusBar.Items[0].Text = "Последно действие: Размаркиране на група";

            viewPort.Invalidate();
        }



        private void delEllipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.DeleteEllipse();
            statusBar.Items[0].Text = "Последно действие: Изтриване на елипси";

            viewPort.Invalidate();
        }

        private void delCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.DeleteCircle();
            statusBar.Items[0].Text = "Последно действие: Изтриване на окръжности";

            viewPort.Invalidate();
        }

        private void delTriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.DeleteTriangle();
            statusBar.Items[0].Text = "Последно действие: Изтриване на триъгълници";

            viewPort.Invalidate();
        }

        private void delSquareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.DeleteSquare();
            statusBar.Items[0].Text = "Последно действие: Изтриване на квадрати";

            viewPort.Invalidate();
        }

        private void delRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.DeleteRectangle();
            statusBar.Items[0].Text = "Последно действие: Изтриване на правоъгълник";

            viewPort.Invalidate();
        }

        private void borderSizeUp_Click(object sender, EventArgs e)
        {
            dialogProcessor.GroupBorderSizeUp();
            statusBar.Items[0].Text = "Последно действие: Промяна дебелина на бордер";

            viewPort.Invalidate();
        }

        private void borderSizeDown_Click(object sender, EventArgs e)
        {
            dialogProcessor.GroupBorderSizeDown();
            statusBar.Items[0].Text = "Последно действие: Промяна дебелина на бордер";

            viewPort.Invalidate();
        }

        //private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}



        private void groupAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.Group();
            statusBar.Items[0].Text = "Последно действие: Групиране на всички елементи";

            viewPort.Invalidate();
        }

        private void BorderSizeUp1_Click(object sender, EventArgs e)
        {
            dialogProcessor.BorderSizeUp();
            statusBar.Items[0].Text = "Последно действие: Промяна дебелина на бордер";

            viewPort.Invalidate();
        }

        private void BorderSizeDown1_Click(object sender, EventArgs e)
        {
            dialogProcessor.BorderSizeDown();
            statusBar.Items[0].Text = "Последно действие: Промяна дебелина на бордер";

            viewPort.Invalidate();
        }
    }
}