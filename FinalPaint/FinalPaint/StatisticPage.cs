using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPaint
{
    public partial class StatisticPage : Form
    {
        public StatisticPage(SingleUserStatistics user)
        {
            InitializeComponent();
            SetStatistics(user);
        }
        public void SetStatistics(SingleUserStatistics user)
        {
           // userValue_lbl.Text = user.Id;
            activityValue_lbl.Text = user.LastActivity;
            jpgValue_lbl.Text = user.AmountJPG;
            bmpValue_lbl.Text = user.AmountBMP;
            jsonValue_lbl.Text = user.AmountJson;
            totalValue_lbl.Text = user.AmountTotal;
            registrValue_lbl.Text = user.RegistrationDate;
        }
        public void ClearStatistics()
        {
            userValue_lbl.Text = "";
            activityValue_lbl.Text = "";
            jpgValue_lbl.Text = "";
            bmpValue_lbl.Text = "";
            jsonValue_lbl.Text = "";
            totalValue_lbl.Text = "";
            registrValue_lbl.Text = "";
        }
    

        private void goBack_btn_Click(object sender, EventArgs e)
        {
            ClearStatistics();
            this.Close();
        }

        
    }
}
