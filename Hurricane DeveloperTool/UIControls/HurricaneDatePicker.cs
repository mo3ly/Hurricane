using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace Hurricane_DeveloperTool.HurricaneControls
{
    public class HurricaneDatePicker : DateTimePicker
    {
        private Color skinColor = Color.MediumSlateBlue;
        private Color textColor = Color.White;
        private Color borderColor = Color.PaleVioletRed;
        private int borderSize = 0;

        private bool droppedDown = false;
        private Image calendarIcon = Properties.Resources.calendarWhite;
        private RectangleF iconButtonArea;
        private const int calendarIconWidth = 34;
        private const int arrowIconWidth = 17;

        public Color SkinColor
        {
            get { return skinColor; }
            set
            {
                skinColor = value;
                if (skinColor.GetBrightness() >= 0.6F)
                    calendarIcon = Properties.Resources.calendarDark;
                else calendarIcon = Properties.Resources.calendarWhite;
                Invalidate();
            }
        }

        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                Invalidate();
            }
        }

        public HurricaneDatePicker()
        {
            SetStyle(ControlStyles.UserPaint, true);
            MinimumSize = new Size(0, 35);
            Font = new Font(Font.Name, 9.5F);
        }

        //Overridden methods
        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            droppedDown = true;
        }

        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            droppedDown = false;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var rectBorderSmooth = ClientRectangle;
            var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
            int smoothSize = 1;//borderSize > 0 ? borderSize : 1;

            using (Graphics graphics = CreateGraphics())
            using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
            using (Pen penBorderSmooth = new Pen(Parent.BackColor, smoothSize))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            using (SolidBrush skinBrush = new SolidBrush(skinColor))
            using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (StringFormat textFormat = new StringFormat())
            {
                RectangleF clientArea = new RectangleF(0, 0, Width - 0.5F, Height - 0.0F);
                RectangleF iconArea = new RectangleF(clientArea.Width - calendarIconWidth, 0, calendarIconWidth, clientArea.Height);
                textFormat.LineAlignment = StringAlignment.Center;

                //Draw surface
                graphics.FillRectangle(skinBrush, clientArea);
                //Draw text
                graphics.DrawString("   " + Text, Font, textBrush, clientArea, textFormat);
                //Draw open calendar icon highlight
                if (droppedDown == true) graphics.FillRectangle(openIconBrush, iconArea);
                //Draw border 
                if (borderSize >= 1 && borderRadius >= 1)
                {
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = PenAlignment.Center;


                    Region = new Region(pathBorderSmooth);
                    graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
                    //Draw border
                    graphics.DrawPath(penBorder, pathBorder);
                } else if (borderSize >= 1)
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                }
                //Draw icon
                graphics.DrawImage(calendarIcon, Width - calendarIcon.Width - 9, (Height - calendarIcon.Height) / 2);

            }
        }

        int borderRadius = 4;

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int iconWidth = GetIconButtonWidth();
            iconButtonArea = new RectangleF(Width - iconWidth, 0, iconWidth, Height);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (iconButtonArea.Contains(e.Location))
                Cursor = Cursors.Hand;
            else Cursor = Cursors.Default;
        }

        //Private methods
        private int GetIconButtonWidth()
        {
            int textWidh = TextRenderer.MeasureText(Text, Font).Width;
            if (textWidh <= Width - (calendarIconWidth + 20))
                return calendarIconWidth;
            else return arrowIconWidth;
        }
    }
}
