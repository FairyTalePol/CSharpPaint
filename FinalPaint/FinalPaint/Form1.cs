using FinalPaint.Classes;
using FinalPaint.DependencyInversion;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalPaint
{

    public partial class MainForm : Form
    {
       
        RastrSaveHelper saveLoad;
        BuisnessLogic bl;
        MyGraphics _myGraphics;

        public void Setup()
        {
            Action act = GetImage;
            _myGraphics = MyGraphics.Create(mainDrawingSurface.Width, mainDrawingSurface.Height,act);
            bl = BuisnessLogic.Create();
            bl.Initialize(_myGraphics);
            btnColorDialog.BackColor = Config.pen.Color;
            dropdownPenWidth.SelectedIndex = Config.dropDownSelectedIndex;
            
        }

        public void GetImage()
        {
            mainDrawingSurface.Image= _myGraphics.GetBitmap();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Setup();
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            _myGraphics.pen.Color = ((Button)sender).BackColor;
            btnColorDialog.BackColor = _myGraphics.pen.Color;
        }

        private void PenChangeSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            _myGraphics.SetPenWidth(penChangeSizeTrackBar.Value);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = dropdownPenWidth.SelectedIndex;

           _myGraphics.SetPenWidth(_myGraphics.penWidth[index]);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            _myGraphics.ClearSurface(mainDrawingSurface.BackColor);
            mainDrawingSurface.Image = _myGraphics.bitmap;
        }




        private void MainDrawingSurface_MouseClick(object sender, MouseEventArgs e)
        {
            //storage = Storage.Create();
            //storage.AddFigure(new Ellipse(e.Location, _pen));
            //storage.AddFigure(new Line(e.Location, _pen));
            //if(storage._figures.Equals(storage._archive.Last()))
            //{
            //    MessageBox.Show("true");
            //}
            //else
            //{
            //    MessageBox.Show("false");
            //}

        }

        private void MainDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
          
                
            if (bl._currentMode == EButtonDrawingType.Polygon)
            {
                string errorMsg = "";
                if (!bl.ValidatePolygon(textBox.Text, out errorMsg))
                {
                    MessageBox.Show(errorMsg);
                    textBox.Text = Convert.ToString(Config.DefaultAngelsForPolegon);
                    bl.SelectFigure(e.X, e.Y, Config.DefaultAngelsForPolegon);
                }
                else
                {
                    bl.SelectFigure(e.X, e.Y, Int32.Parse(textBox.Text));
                }
            }
            else
            {
                bl.SelectFigure(e.X, e.Y);
            }
            
            if (bl._currentFigure.Pullable)
            {
                _myGraphics.SwitchBitmap();
            }

        }

       
        private void MainDrawingSurface_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Image img = mainDrawingSurface.Image;

             
                bl.DrawFigure(e.X, e.Y);
                //mainDrawingSurface.Image = img;
            }
        }

        private void MainDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            //Image img = mainDrawingSurface.Image;
            //bl.FinishFigure(new Point(e.X, e.Y), ref img);
            //mainDrawingSurface.Image = img;
            if (bl._currentFigure!=null)
            {
                if (bl._currentFigure.Pullable)
                {
                    _myGraphics.SwitchBitmap();
                }
                bl.DrawFigure(e.X, e.Y);
            }
           
        }

        private void BtnLine_Click(object sender, EventArgs e)
        {
            bl.SetCurrentMode(EButtonDrawingType.Line);
        }


        private void BtnRectangle_Click(object sender, EventArgs e)
        {
            bl.SetCurrentMode(EButtonDrawingType.Rectangle);
        }

        private void BtnEllipse_Click(object sender, EventArgs e)
        {
            bl.SetCurrentMode(EButtonDrawingType.Ellipse);
        }

        private void BtnPencil_Click(object sender, EventArgs e)
        {
            bl.SetCurrentMode(EButtonDrawingType.Curve);

        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            bl.SetCurrentMode(EButtonDrawingType.Point);

        }

      
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            

        }

        private void BtnColorDialog_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _myGraphics.pen.Color = colorDialog1.Color;
                btnColorDialog.BackColor = _myGraphics.pen.Color;
            }
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            Action save = Save;
            bl.Save(save);

        }

        private void Save()
        {
            _myGraphics.Save();
        }

        private void Load_()
        {
            mainDrawingSurface.Image = (Image)_myGraphics.Load();
        }

        private void Button_open_Click(object sender, EventArgs e)
        {
            Action act = Load_;
            bl.Load(act);
         
        }


        private void BtnHexagon_Click(object sender, EventArgs e)
        {
         
            bl.SetCurrentMode(EButtonDrawingType.Polygon6);
        }

        private void NGon_button_Click(object sender, EventArgs e)
        {
            bl.SetCurrentMode(EButtonDrawingType.Polygon);
        }

        private void btnRoundedRectangle_Click(object sender, EventArgs e)
        {
            bl.SetCurrentMode(EButtonDrawingType.RoundedRectangle);
        }

        public MainForm()
        {

            InitializeComponent();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            bl.Undo();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            bl.Redo();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
