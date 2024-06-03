﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI_CCH
{
    public class CustomPanel : Panel
    {
        //Field
        private int borderRadius = 30;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.AliceBlue;
        private Color gradientBotColor = Color.SkyBlue;

        //Constructor
        public CustomPanel()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(350,300);
        }
        //Properties
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }
        public float GradientAngle
        {
            get => gradientAngle;
            set { gradientAngle = value; this.Invalidate(); }
        }
        public Color GradientTopColor
        {
            get => gradientTopColor;
            set { gradientTopColor = value; this.Invalidate(); }
        }
        public Color GradientBotColor
        {
            get => gradientBotColor;
            set { gradientBotColor = value; this.Invalidate(); }
        }

        //Method 
        private GraphicsPath GetArtanPath(RectangleF rect, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            graphicsPath.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            graphicsPath.CloseFigure();

            return graphicsPath;
        }
        //Overridden Method 
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //Gradient
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brushArtan = new LinearGradientBrush(this.ClientRectangle, this.gradientTopColor, this.gradientBotColor,this.gradientAngle);
            Graphics graphicsArtan = e.Graphics;
            graphicsArtan.FillRectangle(brushArtan, ClientRectangle);

            //BorderRadius
            RectangleF rectangleF = new RectangleF(0,0,this.Width,this.Height);
            if(borderRadius>2 )
            {
                using (GraphicsPath graphicsPath = GetArtanPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor,2))
                {
                    this.Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);
                }
            }
            else this.Region = new Region(rectangleF);    

        }


    }
}
