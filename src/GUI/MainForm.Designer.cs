namespace Draw
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delEllipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delSquareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delRectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenFile = new System.Windows.Forms.ToolStripButton();
            this.SaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.Ellipse = new System.Windows.Forms.ToolStripButton();
            this.Circle = new System.Windows.Forms.ToolStripButton();
            this.Square = new System.Windows.Forms.ToolStripButton();
            this.Triangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.color = new System.Windows.Forms.ToolStripButton();
            this.Group = new System.Windows.Forms.ToolStripButton();
            this.GroupScaleUp = new System.Windows.Forms.ToolStripButton();
            this.GroupScaleDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ScaleUp = new System.Windows.Forms.ToolStripButton();
            this.ScaleDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAll = new System.Windows.Forms.ToolStripButton();
            this.RemoveSelection = new System.Windows.Forms.ToolStripButton();
            this.DeleteAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.GroupRemoveSelection = new System.Windows.Forms.ToolStripButton();
            this.borderSizeUp = new System.Windows.Forms.ToolStripButton();
            this.borderSizeDown = new System.Windows.Forms.ToolStripButton();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Tahoma", 10F);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(892, 25);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.triangleToolStripMenuItem,
            this.squareToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.DrawEllipsTeSpeedButtonClick);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.Circle_Click);
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.triangleToolStripMenuItem.Text = "Triangle";
            this.triangleToolStripMenuItem.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteAllToolStripMenuItem,
            this.delEllipseToolStripMenuItem,
            this.delCircleToolStripMenuItem,
            this.delTriangleToolStripMenuItem,
            this.delSquareToolStripMenuItem,
            this.delRectangleToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
            | System.Windows.Forms.Keys.E)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.deleteAllToolStripMenuItem.Text = "DeleteAll";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // delEllipseToolStripMenuItem
            // 
            this.delEllipseToolStripMenuItem.Name = "delEllipseToolStripMenuItem";
            this.delEllipseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
            | System.Windows.Forms.Keys.E)));
            this.delEllipseToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.delEllipseToolStripMenuItem.Text = "Del. Ellipse";
            this.delEllipseToolStripMenuItem.Click += new System.EventHandler(this.delEllipseToolStripMenuItem_Click);
            // 
            // delCircleToolStripMenuItem
            // 
            this.delCircleToolStripMenuItem.Name = "delCircleToolStripMenuItem";
            this.delCircleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
            | System.Windows.Forms.Keys.C)));
            this.delCircleToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.delCircleToolStripMenuItem.Text = "Del. Circle";
            this.delCircleToolStripMenuItem.Click += new System.EventHandler(this.delCircleToolStripMenuItem_Click);
            // 
            // delTriangleToolStripMenuItem
            // 
            this.delTriangleToolStripMenuItem.Name = "delTriangleToolStripMenuItem";
            this.delTriangleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
            | System.Windows.Forms.Keys.T)));
            this.delTriangleToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.delTriangleToolStripMenuItem.Text = "Del. Triangle";
            this.delTriangleToolStripMenuItem.Click += new System.EventHandler(this.delTriangleToolStripMenuItem_Click);
            // 
            // delSquareToolStripMenuItem
            // 
            this.delSquareToolStripMenuItem.Name = "delSquareToolStripMenuItem";
            this.delSquareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
            | System.Windows.Forms.Keys.S)));
            this.delSquareToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.delSquareToolStripMenuItem.Text = "Del. Square";
            this.delSquareToolStripMenuItem.Click += new System.EventHandler(this.delSquareToolStripMenuItem_Click);
            // 
            // delRectangleToolStripMenuItem
            // 
            this.delRectangleToolStripMenuItem.Name = "delRectangleToolStripMenuItem";
            this.delRectangleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
            | System.Windows.Forms.Keys.R)));
            this.delRectangleToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.delRectangleToolStripMenuItem.Text = "Del. Rectangle";
            this.delRectangleToolStripMenuItem.Click += new System.EventHandler(this.delRectangleToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 651);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(892, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 37);
            // 
            // OpenFile
            // 
            this.OpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("OpenFile.Image")));
            this.OpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(34, 34);
            this.OpenFile.Text = "OpenFile";
            this.OpenFile.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAs.Image = ((System.Drawing.Image)(resources.GetObject("SaveAs.Image")));
            this.SaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(34, 34);
            this.SaveAs.Text = "SaveAs";
            this.SaveAs.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(34, 34);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(34, 34);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // Ellipse
            // 
            this.Ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Ellipse.Image = ((System.Drawing.Image)(resources.GetObject("Ellipse.Image")));
            this.Ellipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(34, 34);
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.Click += new System.EventHandler(this.DrawEllipsTeSpeedButtonClick);
            // 
            // Circle
            // 
            this.Circle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Circle.Image = ((System.Drawing.Image)(resources.GetObject("Circle.Image")));
            this.Circle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(34, 34);
            this.Circle.Text = "Circle";
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Square
            // 
            this.Square.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Square.Image = ((System.Drawing.Image)(resources.GetObject("Square.Image")));
            this.Square.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(34, 34);
            this.Square.Text = "Square";
            this.Square.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // Triangle
            // 
            this.Triangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Triangle.Image = ((System.Drawing.Image)(resources.GetObject("Triangle.Image")));
            this.Triangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(34, 34);
            this.Triangle.Text = "Triangle";
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // color
            // 
            this.color.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.color.Image = ((System.Drawing.Image)(resources.GetObject("color.Image")));
            this.color.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(34, 34);
            this.color.Text = "Color";
            this.color.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Group
            // 
            this.Group.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Group.Image = ((System.Drawing.Image)(resources.GetObject("Group.Image")));
            this.Group.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Group.Name = "Group";
            this.Group.RightToLeftAutoMirrorImage = true;
            this.Group.Size = new System.Drawing.Size(34, 34);
            this.Group.Text = "Group";
            this.Group.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // GroupScaleUp
            // 
            this.GroupScaleUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GroupScaleUp.Image = ((System.Drawing.Image)(resources.GetObject("GroupScaleUp.Image")));
            this.GroupScaleUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GroupScaleUp.Name = "GroupScaleUp";
            this.GroupScaleUp.Size = new System.Drawing.Size(34, 34);
            this.GroupScaleUp.Text = "GroupScaleUp";
            this.GroupScaleUp.Click += new System.EventHandler(this.GroupScaleUp_Click);
            // 
            // GroupScaleDown
            // 
            this.GroupScaleDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GroupScaleDown.Image = ((System.Drawing.Image)(resources.GetObject("GroupScaleDown.Image")));
            this.GroupScaleDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GroupScaleDown.Name = "GroupScaleDown";
            this.GroupScaleDown.Size = new System.Drawing.Size(34, 34);
            this.GroupScaleDown.Text = "GroupScaleDown";
            this.GroupScaleDown.Click += new System.EventHandler(this.GroupScaleDown_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 37);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 37);
            // 
            // ScaleUp
            // 
            this.ScaleUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ScaleUp.Image = ((System.Drawing.Image)(resources.GetObject("ScaleUp.Image")));
            this.ScaleUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ScaleUp.Name = "ScaleUp";
            this.ScaleUp.Size = new System.Drawing.Size(34, 34);
            this.ScaleUp.Text = "ScaleUp";
            this.ScaleUp.Click += new System.EventHandler(this.ScaleUp_Click);
            // 
            // ScaleDown
            // 
            this.ScaleDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ScaleDown.Image = ((System.Drawing.Image)(resources.GetObject("ScaleDown.Image")));
            this.ScaleDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ScaleDown.Name = "ScaleDown";
            this.ScaleDown.Size = new System.Drawing.Size(34, 34);
            this.ScaleDown.Text = "ScaleDown";
            this.ScaleDown.Click += new System.EventHandler(this.ScaleDown_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 37);
            // 
            // SelectAll
            // 
            this.SelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SelectAll.Image = ((System.Drawing.Image)(resources.GetObject("SelectAll.Image")));
            this.SelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(34, 34);
            this.SelectAll.Text = "selectAll";
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // RemoveSelection
            // 
            this.RemoveSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveSelection.Image = ((System.Drawing.Image)(resources.GetObject("RemoveSelection.Image")));
            this.RemoveSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveSelection.Name = "RemoveSelection";
            this.RemoveSelection.Size = new System.Drawing.Size(34, 34);
            this.RemoveSelection.Text = "RemoveSelection";
            this.RemoveSelection.Click += new System.EventHandler(this.RemoveSelection_Click);
            // 
            // DeleteAll
            // 
            this.DeleteAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("DeleteAll.Image")));
            this.DeleteAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(34, 34);
            this.DeleteAll.Text = "DeleteAll";
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 37);
            // 
            // speedMenu
            // 
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator7,
            this.OpenFile,
            this.SaveAs,
            this.toolStripSeparator2,
            this.pickUpSpeedButton,
            this.drawRectangleSpeedButton,
            this.Ellipse,
            this.Circle,
            this.Square,
            this.Triangle,
            this.toolStripSeparator1,
            this.color,
            this.Group,
            this.GroupRemoveSelection,
            this.GroupScaleUp,
            this.GroupScaleDown,
            this.borderSizeUp,
            this.borderSizeDown,
            this.toolStripSeparator3,
            this.toolStripTextBox1,
            this.toolStripSeparator4,
            this.ScaleUp,
            this.ScaleDown,
            this.toolStripSeparator6,
            this.SelectAll,
            this.RemoveSelection,
            this.DeleteAll,
            this.toolStripSeparator5});
            this.speedMenu.Location = new System.Drawing.Point(0, 25);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(892, 37);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            // 
            // GroupRemoveSelection
            // 
            this.GroupRemoveSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GroupRemoveSelection.Image = ((System.Drawing.Image)(resources.GetObject("GroupRemoveSelection.Image")));
            this.GroupRemoveSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GroupRemoveSelection.Name = "GroupRemoveSelection";
            this.GroupRemoveSelection.Size = new System.Drawing.Size(34, 34);
            this.GroupRemoveSelection.Text = "GroupRemoveSelection";
            this.GroupRemoveSelection.Click += new System.EventHandler(this.GroupRemoveSelection_Click);
            // 
            // borderSizeUp
            // 
            this.borderSizeUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.borderSizeUp.Image = ((System.Drawing.Image)(resources.GetObject("borderSizeUp.Image")));
            this.borderSizeUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.borderSizeUp.Name = "borderSizeUp";
            this.borderSizeUp.Size = new System.Drawing.Size(34, 34);
            this.borderSizeUp.Text = "borderSizeUp";
            this.borderSizeUp.Click += new System.EventHandler(this.borderSizeUp_Click);
            // 
            // borderSizeDown
            // 
            this.borderSizeDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.borderSizeDown.Image = ((System.Drawing.Image)(resources.GetObject("borderSizeDown.Image")));
            this.borderSizeDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.borderSizeDown.Name = "borderSizeDown";
            this.borderSizeDown.Size = new System.Drawing.Size(34, 34);
            this.borderSizeDown.Text = "borderSizeDown";
            this.borderSizeDown.Click += new System.EventHandler(this.borderSizeDown_Click);
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 62);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(892, 589);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(892, 673);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Georgi && Stefan\'s Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
        private Draw.DoubleBufferedPanel viewPort;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton OpenFile;
        private System.Windows.Forms.ToolStripButton SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
        private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
        private System.Windows.Forms.ToolStripButton Ellipse;
        private System.Windows.Forms.ToolStripButton Circle;
        private System.Windows.Forms.ToolStripButton Square;
        private System.Windows.Forms.ToolStripButton Triangle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton color;
        private System.Windows.Forms.ToolStripButton Group;
        private System.Windows.Forms.ToolStripButton GroupScaleUp;
        private System.Windows.Forms.ToolStripButton GroupScaleDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton ScaleUp;
        private System.Windows.Forms.ToolStripButton ScaleDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton SelectAll;
        private System.Windows.Forms.ToolStripButton RemoveSelection;
        private System.Windows.Forms.ToolStripButton DeleteAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStrip speedMenu;
        private System.Windows.Forms.ToolStripButton GroupRemoveSelection;
        private System.Windows.Forms.ToolStripMenuItem delEllipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delCircleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delTriangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delSquareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delRectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton borderSizeUp;
        private System.Windows.Forms.ToolStripButton borderSizeDown;
    }
}
