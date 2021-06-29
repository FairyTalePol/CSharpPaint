using FinalPaint.Classes;
using FinalPaint.DependencyInversion;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalPaint
{

    public partial class MainForm : Form
    {
        BuisnessLogic bl;
        MyGraphics _myGraphics;
        int mouseDownX;
        int mouseDownY;
        private static MainForm _mainForm;

        public void Setup()
        {
            Action act = GetImage;
            _myGraphics = MyGraphics.Create(mainDrawingSurface.Width, mainDrawingSurface.Height,act);
            bl = BuisnessLogic.Create(/*_myGraphics*/);
            bl.Initialize(_myGraphics);
            btnColorDialog.BackColor = Config.pen.Color;
            dropdownPenWidth.SelectedIndex = Config.dropDownSelectedIndex;
            Action UndoRedo = SetDisabledUndoRedo;
            bl.SetDisableUndoRedo(UndoRedo);
        }

        private MainForm()
        {

            InitializeComponent();
        }
        public static MainForm CreateMainForm()
        {
            if (_mainForm == null)
            {
                _mainForm = new MainForm();
            }
            return _mainForm;
        }

        public void SetDisabledUndoRedo()
        {
            if (bl.EnableUndoRedo)
            {
                undoButton.Enabled = true;
                redoButton.Enabled = true;
            }
            else
            {
                undoButton.Enabled = false;
                redoButton.Enabled = false;
            }
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
            dropdownPenWidth.Text = Convert.ToString(penChangeSizeTrackBar.Value) + "px";

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = dropdownPenWidth.SelectedIndex;

           _myGraphics.SetPenWidth(_myGraphics.penWidth[index]);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            _myGraphics.ClearSurface(mainDrawingSurface.BackColor);
            bl.Clear();
            mainDrawingSurface.Image = _myGraphics.bitmap;
        }




        private void MainDrawingSurface_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void MainDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownX = e.X;
            mouseDownY = e.Y;
            if (bl.currentMode==EButtonDrawingType.Selection)
            {
                bl.SetSelection(e.X, e.Y);
            }
            else if (bl.currentMode == EButtonDrawingType.Polygon)
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

                if (bl.currentFigure.Pullable)
                {
                    _myGraphics.SwitchBitmap();
                }
            }
            else
            {
                bl.SelectFigure(e.X, e.Y);

                if (bl.currentFigure.Pullable)
                {
                    _myGraphics.SwitchBitmap();
                }
            }
           

        }

       
        private void MainDrawingSurface_MouseMove(object sender, MouseEventArgs e)
        {
            if (bl.currentMode == EButtonDrawingType.Selection)
            {
                
            }
            else if (e.Button == MouseButtons.Left)
            {      
                bl.DrawFigure(e.X, e.Y);              
            }
        }

        private void MainDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            if (bl.currentMode == EButtonDrawingType.Selection)
            {
                bl.MoveSelectedFigure(e.X - mouseDownX, e.Y - mouseDownY);
            }
            else if (bl.currentFigure!=null)
            {
                if (bl.currentFigure.Pullable)
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

        //private void Button_save_Click(object sender, EventArgs e)
        //{
        //    Action save = Save;
        //    bl.Save(save);

        //}

        private void Save()
        {
            _myGraphics.Save();
        }

        private void Load_()
        {
            mainDrawingSurface.Image = (Image)_myGraphics.GetBitmap();
        }

        //private void Button_open_Click(object sender, EventArgs e)
        //{
        //    Action act = Load_;
        //    bl.Load(act);
         
        //}


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


        private void undoButton_Click(object sender, EventArgs e)
        {
            bl.Undo();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            bl.Redo();
            GetImage();
        }

        private void button7_Click(object sender, EventArgs e)
        {
          //  bl.TestRestApi();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            bl.SetCurrentMode(EButtonDrawingType.Selection);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //bl.ClearUserId();
            //_mainForm = null;
            //AuthorithationForm.CreateAuthorithationForm().Show();
            Application.Restart();
        }

        //1350  1050 15 100 грн 100 час 40 кг угля
        private void btn_saveServer_Click(object sender, EventArgs e)
        {
            Action save = SaveServer;
            bl.Save(save);
        }

        private void SaveServer()
        {
            string serialized = _myGraphics.SaveServer();
            bl.SaveServer(serialized, "testName1", PictureType.JSON);
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action act = Load_;
            bl.Load(act);
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action save = Save;
            bl.Save(save);

        }

        private void saveFileOnServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action save = SaveServer;
            bl.Save(save);
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = bl.GetUserStatistics();
            var s = new StatisticPage(user);
            s.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            //bl.ClearMyGraphics();
            //_mainForm.Close();
            //bl.ClearBL();
            //_mainForm = null;
            //AuthorithationForm.CreateAuthorithationForm().Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userPassword = bl.GetUserPassword();
            var changePassword = new ChangePasswordForm(userPassword);
            changePassword.Show();

        }
    }
}
