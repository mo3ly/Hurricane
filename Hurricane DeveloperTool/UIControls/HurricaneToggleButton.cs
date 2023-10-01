using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Hurricane_DeveloperTool.HurricaneControls
{
    public class HurricaneToggleButton : CheckBox
    {
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private Color customBackColor = Color.Transparent;

        private bool solidStyle = true;

        //Properties
        [Category("Hurricane Controls")]
        public Color OnBackColor
        {
            get { return onBackColor; }
            set
            {
                onBackColor = value;
                Invalidate();
            }
        }

        [Category("Hurricane Controls")]
        public Color OnToggleColor
        {
            get { return onToggleColor; }
            set
            {
                onToggleColor = value;
                Invalidate();
            }
        }

        [Category("Hurricane Controls")]
        public Color OffBackColor
        {
            get { return offBackColor; }
            set
            {
                offBackColor = value;
                Invalidate();
            }
        }

        [Category("Hurricane Controls")]
        public Color OffToggleColor
        {
            get { return offToggleColor; }
            set
            {
                offToggleColor = value;
                Invalidate();
            }
        }

        [Category("Hurricane Controls")]
        public Color CustomBackColor
        {
            get { return customBackColor; }
            set
            {
                customBackColor = value;
                Invalidate();
            }
        }
        
        [Browsable(false)]
        public override string Text
        {
            get { return base.Text; }
            set { }
        }

        [Category("Hurricane Controls")]
        [DefaultValue(true)]
        public bool SolidStyle
        {
            get { return solidStyle; }
            set
            {
                solidStyle = value;
                Invalidate();
            }
        }


        public HurricaneToggleButton()
        {
            MinimumSize = new Size(45, 22);
        }

        private GraphicsPath GetFigurePath()
        {
            int arcSize = Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if(CustomBackColor == Color.Transparent)
                pevent.Graphics.Clear(Parent.BackColor);
            else
                pevent.Graphics.Clear(CustomBackColor);

            if (Checked)
            {
                //Draw the control surface
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                else 
                    pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetFigurePath());

                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor),
                  new Rectangle(Width - Height + 1, 2, toggleSize, toggleSize));
            }
            else
            {
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                else 
                    pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetFigurePath());

                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor),
                  new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
