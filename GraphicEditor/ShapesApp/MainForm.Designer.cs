namespace ShapesApp
{
    partial class ShapesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelControl = new System.Windows.Forms.Panel();
            this.ButtonEllipse = new System.Windows.Forms.Button();
            this.ButtonClircle = new System.Windows.Forms.Button();
            this.ButtonTriangle = new System.Windows.Forms.Button();
            this.ButtonSquare = new System.Windows.Forms.Button();
            this.ButtonPolygon = new System.Windows.Forms.Button();
            this.ButtonRect = new System.Windows.Forms.Button();
            this.ButtonJoggedLine = new System.Windows.Forms.Button();
            this.ButtonSegment = new System.Windows.Forms.Button();
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.PanelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControl
            // 
            this.PanelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelControl.Controls.Add(this.ButtonEllipse);
            this.PanelControl.Controls.Add(this.ButtonClircle);
            this.PanelControl.Controls.Add(this.ButtonTriangle);
            this.PanelControl.Controls.Add(this.ButtonSquare);
            this.PanelControl.Controls.Add(this.ButtonPolygon);
            this.PanelControl.Controls.Add(this.ButtonRect);
            this.PanelControl.Controls.Add(this.ButtonJoggedLine);
            this.PanelControl.Controls.Add(this.ButtonSegment);
            this.PanelControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelControl.Location = new System.Drawing.Point(771, 0);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.Size = new System.Drawing.Size(219, 396);
            this.PanelControl.TabIndex = 1;
            // 
            // ButtonEllipse
            // 
            this.ButtonEllipse.Location = new System.Drawing.Point(5, 206);
            this.ButtonEllipse.Name = "ButtonEllipse";
            this.ButtonEllipse.Size = new System.Drawing.Size(109, 23);
            this.ButtonEllipse.TabIndex = 7;
            this.ButtonEllipse.Text = "Ellipse";
            this.ButtonEllipse.UseVisualStyleBackColor = true;
            this.ButtonEllipse.Click += new System.EventHandler(this.ButtonEllipse_Click);
            // 
            // ButtonClircle
            // 
            this.ButtonClircle.Location = new System.Drawing.Point(5, 177);
            this.ButtonClircle.Name = "ButtonClircle";
            this.ButtonClircle.Size = new System.Drawing.Size(109, 23);
            this.ButtonClircle.TabIndex = 6;
            this.ButtonClircle.Text = "Circle";
            this.ButtonClircle.UseVisualStyleBackColor = true;
            this.ButtonClircle.Click += new System.EventHandler(this.ButtonClircle_Click);
            // 
            // ButtonTriangle
            // 
            this.ButtonTriangle.Location = new System.Drawing.Point(5, 148);
            this.ButtonTriangle.Name = "ButtonTriangle";
            this.ButtonTriangle.Size = new System.Drawing.Size(109, 23);
            this.ButtonTriangle.TabIndex = 5;
            this.ButtonTriangle.Text = "Triangle";
            this.ButtonTriangle.UseVisualStyleBackColor = true;
            this.ButtonTriangle.Click += new System.EventHandler(this.ButtonTriangle_Click);
            // 
            // ButtonSquare
            // 
            this.ButtonSquare.Location = new System.Drawing.Point(5, 119);
            this.ButtonSquare.Name = "ButtonSquare";
            this.ButtonSquare.Size = new System.Drawing.Size(109, 23);
            this.ButtonSquare.TabIndex = 4;
            this.ButtonSquare.Text = "Square";
            this.ButtonSquare.UseVisualStyleBackColor = true;
            this.ButtonSquare.Click += new System.EventHandler(this.ButtonSquare_Click);
            // 
            // ButtonPolygon
            // 
            this.ButtonPolygon.Location = new System.Drawing.Point(5, 90);
            this.ButtonPolygon.Name = "ButtonPolygon";
            this.ButtonPolygon.Size = new System.Drawing.Size(109, 23);
            this.ButtonPolygon.TabIndex = 3;
            this.ButtonPolygon.Text = "Polygon";
            this.ButtonPolygon.UseVisualStyleBackColor = true;
            this.ButtonPolygon.Click += new System.EventHandler(this.ButtonPolygon_Click);
            // 
            // ButtonRect
            // 
            this.ButtonRect.Location = new System.Drawing.Point(5, 61);
            this.ButtonRect.Name = "ButtonRect";
            this.ButtonRect.Size = new System.Drawing.Size(109, 23);
            this.ButtonRect.TabIndex = 2;
            this.ButtonRect.Text = "Rectangle";
            this.ButtonRect.UseVisualStyleBackColor = true;
            this.ButtonRect.Click += new System.EventHandler(this.ButtonRect_Click);
            // 
            // ButtonJoggedLine
            // 
            this.ButtonJoggedLine.Location = new System.Drawing.Point(3, 32);
            this.ButtonJoggedLine.Name = "ButtonJoggedLine";
            this.ButtonJoggedLine.Size = new System.Drawing.Size(111, 23);
            this.ButtonJoggedLine.TabIndex = 1;
            this.ButtonJoggedLine.Text = "Jogged line";
            this.ButtonJoggedLine.UseVisualStyleBackColor = true;
            this.ButtonJoggedLine.Click += new System.EventHandler(this.ButtonJoggedLine_Click);
            // 
            // ButtonSegment
            // 
            this.ButtonSegment.Location = new System.Drawing.Point(3, 3);
            this.ButtonSegment.Name = "ButtonSegment";
            this.ButtonSegment.Size = new System.Drawing.Size(111, 23);
            this.ButtonSegment.TabIndex = 0;
            this.ButtonSegment.Text = "Segment";
            this.ButtonSegment.UseVisualStyleBackColor = true;
            this.ButtonSegment.Click += new System.EventHandler(this.ButtonSegment_Click);
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = true;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnT.Location = new System.Drawing.Point(0, 0);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(771, 396);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 2;
            this.AnT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseClick);
            // 
            // ShapesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 396);
            this.Controls.Add(this.AnT);
            this.Controls.Add(this.PanelControl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShapesForm";
            this.Text = "Shapes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PanelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelControl;
        private System.Windows.Forms.Button ButtonSegment;
        private System.Windows.Forms.Button ButtonJoggedLine;
        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Button ButtonRect;
        private System.Windows.Forms.Button ButtonPolygon;
        private System.Windows.Forms.Button ButtonSquare;
        private System.Windows.Forms.Button ButtonTriangle;
        private System.Windows.Forms.Button ButtonClircle;
        private System.Windows.Forms.Button ButtonEllipse;


    }
}

