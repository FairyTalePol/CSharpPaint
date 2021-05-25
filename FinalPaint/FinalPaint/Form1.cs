using FinalPaint.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPaint
{
    enum EButtons
    {
        Point,
        Line,
        Curve,
        Rectangle,
        Ellipse,
        Polygon,
        Polygon6
    }

    

    public partial class MainForm : Form
    {
        EButtons _currentMode;
        Bitmap _bitmap;
        Bitmap _bitmapTemp;
        int maxWidth;
        int maxHeight;
        Pen _pen;
        Brush _brush;
        Graphics _graphics;
        Graphics _graphicsTemp;
        bool isCalledfirstTime = true;
        Figure _currentFigure;
        Dictionary<int, int> penWidth;
        RastrSaveHelper saveLoad;
    
        
       // int prevX = 0, prevY = 0;
        int startX, startY;
   
        public void Setup()
        {
            penWidth = new Dictionary<int, int>();
            penWidth.Add(0, 1);
            penWidth.Add(1, 5);
            penWidth.Add(2, 10);
            penWidth.Add(3, 20);


            _bitmap = new Bitmap(mainDrawingSurface.Width, mainDrawingSurface.Height);
            _bitmapTemp = new Bitmap(mainDrawingSurface.Width, mainDrawingSurface.Height);
            _pen = new Pen(Color.Black, 3);
            _brush = new SolidBrush(Color.Black);
            _graphics = Graphics.FromImage(_bitmap);
            _graphicsTemp = Graphics.FromImage(_bitmapTemp);
            btnColorDialog.BackColor = _pen.Color;
            dropdownPenWidth.SelectedIndex = 0;
            _currentMode = EButtons.Curve;
            _pen.StartCap = LineCap.Round;
            _pen.EndCap = LineCap.Round;
            maxWidth = mainDrawingSurface.Width;
            maxHeight = mainDrawingSurface.Height;
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //lkjhgfdsdfghjkl;
            //bla bla

            //Form load ne nuzen
            Setup();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            _pen.Color = ((Button)sender).BackColor;
            _brush = new SolidBrush(_pen.Color);
            btnColorDialog.BackColor = _pen.Color;
        }

        private void penChangeSizeTrackBar_Scroll(object sender, EventArgs e)
        {

            //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
            _pen.Width = penChangeSizeTrackBar.Value;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = dropdownPenWidth.SelectedIndex;
            _pen.Width = penWidth[index];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _graphics.Clear(mainDrawingSurface.BackColor);
            _graphicsTemp.Clear(mainDrawingSurface.BackColor);
            _graphicsTemp.DrawImage(_bitmap, 0, 0);
            mainDrawingSurface.Image = _bitmap;
        }


        private void mainDrawingSurface_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void mainDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            startX = e.X;
            startY = e.Y;
            SelectFigure(e);


        }

        public void SelectFigure(MouseEventArgs e)
        {
            switch (_currentMode)
            {
                case EButtons.Line:
                    _currentFigure = new Line(new Point(e.X, e.Y), _pen);
                    break;
                case EButtons.Rectangle:
                    _currentFigure = new Classes.Rectangle(new Point(e.X, e.Y), _pen);
                    break;
                case EButtons.Ellipse:
                    _currentFigure = new Ellipse(new Point(e.X, e.Y), _pen);
                    break;
                case EButtons.Curve:
                    _currentFigure = new Curve(new Point(e.X, e.Y), _pen);
                    break;
                case EButtons.Point:
                    _currentFigure = new CustomPoint(new Point(e.X, e.Y), _pen);
                    break;
                case EButtons.Polygon6:
                    _currentFigure = new Polygon(new Point(e.X, e.Y), _pen, 6);
                    break;
                case EButtons.Polygon:
                    _currentFigure = new Polygon(new Point(e.X, e.Y), _pen, Int32.Parse(textBox.Text));
                    break;
                default:
                    _currentFigure = new Polygon(new Point(e.X, e.Y), _pen, 6);
                    break;
            }
        }

        private void mainDrawingSurface_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left&& _currentFigure!=null)
            {
                if (_currentFigure.Pullable==true)
                {
                    _graphicsTemp = Graphics.FromImage(_bitmapTemp);
                    _graphicsTemp.Clear(Color.White);
                    _graphicsTemp.DrawImage(_bitmap, 0, 0);
                    _currentFigure.Draw(_graphicsTemp, new Point(e.X, e.Y));
                    mainDrawingSurface.Image = _bitmapTemp;
                }
                else
                {
                 
                    _currentFigure.Draw(_graphics, new Point(e.X, e.Y));
                    mainDrawingSurface.Image = _bitmap;
                }
            }

            


            //if (e.Button == MouseButtons.Left)
            //{
            //    if (_currentMode == EButtons.Line)
            //    {
            //        _graphicsTemp = Graphics.FromImage(_bitmapTemp);
            //        _graphicsTemp.Clear(Color.White);
            //        _graphicsTemp.DrawImage(_bitmap, 0, 0);

            //        _graphicsTemp.DrawLine(_pen, startX, startY, e.X, e.Y);

            //        mainDrawingSurface.Image = _bitmapTemp;
            //    }
            //    if (_currentMode == EButtons.Rectangle)
            //    {
            //        _graphicsTemp = Graphics.FromImage(_bitmapTemp);
            //        _graphicsTemp.Clear(Color.White);
            //        _graphicsTemp.DrawImage(_bitmap, 0, 0);

            //        int xCorner, yCorner, width, height;
            //        xCorner = e.X - startX < 0 ? e.X : startX;
            //        yCorner = e.Y - startY < 0 ? e.Y : startY;
            //        width = e.X - startX < 0 ? startX - e.X : e.X - startX;
            //        height = e.Y - startY < 0 ? startY - e.Y : e.Y - startY;

            //        _graphicsTemp.DrawRectangle(_pen, xCorner, yCorner, width, height);

            //        mainDrawingSurface.Image = _bitmapTemp;
            //    }
            //    if (_currentMode == EButtons.Ellipse)
            //    {
            //        _graphicsTemp = Graphics.FromImage(_bitmapTemp);
            //        _graphicsTemp.Clear(Color.White);
            //        _graphicsTemp.DrawImage(_bitmap, 0, 0);



            //        //_graphicsTemp.DrawEllipse(_pen, startX, startY, e.X, e.Y);
            //        _graphicsTemp.DrawEllipse(_pen, startX, startY, e.X - startX, e.Y - startY);

            //        mainDrawingSurface.Image = _bitmapTemp;
            //    }
            //    if (_currentMode == EButtons.Curve)
            //    {
            //        _graphics.DrawLine(_pen, prevX, prevY, e.X, e.Y);

            //        mainDrawingSurface.Image = _bitmap;
            //    }
            //}

            //prevX = e.X;
            //prevY = e.Y;
        }

        private void mainDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            if (_currentFigure!=null)
            {
                _currentFigure.Draw(_graphics, new Point(e.X, e.Y));
                mainDrawingSurface.Image = _bitmap;
            }
          

            //if (_currentMode == EButtons.Line)
            //{            
            //    _graphics.DrawLine(_pen, startX, startY, e.X, e.Y);

            //    mainDrawingSurface.Image = _bitmap;
            //}
            //if (_currentMode == EButtons.Rectangle)
            //{
            //    int xCorner, yCorner, width, height;
            //    xCorner = e.X - startX < 0 ? e.X : startX;
            //    yCorner = e.Y - startY < 0 ? e.Y : startY;
            //    width = e.X - startX < 0 ? startX - e.X : e.X - startX;
            //    height = e.Y - startY < 0 ? startY - e.Y : e.Y - startY;

            //    _graphics.DrawRectangle(_pen, xCorner, yCorner, width, height);

            //    mainDrawingSurface.Image = _bitmap;
            //}
            //if (_currentMode == EButtons.Ellipse)
            //{
            //    _graphics.DrawEllipse(_pen, startX, startY, e.X - startX, e.Y - startY);

            //    mainDrawingSurface.Image = _bitmap;
            //}
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            _currentMode = EButtons.Line;
        }


        private void btnRectangle_Click(object sender, EventArgs e)
        {
            _currentMode = EButtons.Rectangle;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            _currentMode = EButtons.Ellipse;
        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            _currentMode = EButtons.Curve;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            _currentMode = EButtons.Point;
        }

      
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (!isCalledfirstTime)
            {

                mainDrawingSurface.Width = MainForm.ActiveForm.Width;
                mainDrawingSurface.Height = MainForm.ActiveForm.Height - panel1.Height;
                if (MainForm.ActiveForm.Width > maxWidth || MainForm.ActiveForm.Height - panel1.Height > maxHeight)
                {
                    Bitmap temp = (Bitmap)_bitmap.Clone();

                    _bitmap = new Bitmap(maxWidth, maxHeight);
                    _bitmapTemp = new Bitmap(maxWidth, maxHeight);

                    _graphics = Graphics.FromImage(_bitmap);
                    _graphicsTemp = Graphics.FromImage(_bitmapTemp);

                    _graphics.DrawImage(temp, new System.Drawing.Rectangle(0, 0, maxWidth, maxHeight), new System.Drawing.Rectangle(0, 0, maxWidth, maxHeight), GraphicsUnit.Pixel);

                    mainDrawingSurface.Image = _bitmap;

                    if (MainForm.ActiveForm.Width > maxWidth)
                        maxWidth = MainForm.ActiveForm.Width;
                    if (MainForm.ActiveForm.Height - panel1.Height > maxHeight)
                        maxHeight = MainForm.ActiveForm.Height - panel1.Height;
                }
            }
            isCalledfirstTime = false;

        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _pen.Color = colorDialog1.Color;
                btnColorDialog.BackColor = _pen.Color;
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            saveLoad = RastrSaveHelper.Create();
            saveLoad.Save(ref mainDrawingSurface);


        }

        private void button_open_Click(object sender, EventArgs e)
        {
            _currentFigure = null;
            

            saveLoad = RastrSaveHelper.Create();
            saveLoad.Load(ref openFileDialog1,ref _graphics,ref _bitmap,ref mainDrawingSurface);
         
        }

    
        private void btnHexagon_Click(object sender, EventArgs e)
        {
            _currentMode = EButtons.Polygon6;
        }

        private void nGon_button_Click(object sender, EventArgs e)
        {
            _currentMode = EButtons.Polygon;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if(byte.TryParse(textBox.Text, out byte pointsAmount))
            {
                if(pointsAmount>2)
                {
                    _currentMode = EButtons.Polygon;
                }
                else
                {
                    MessageBox.Show("Your polygon must have at least 3 points!");
                }
            }
            else
            {
                MessageBox.Show("The input text must be 2>integer<257");
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }
    }
}
