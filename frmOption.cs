using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaming_Club_Project
{
    public partial class frmOptions : Form
    {
        private string _PlayerName = "Player";
        private string _TableTitle = "Computer Gaming";
        private float _PricePerHour = 5f;

        public delegate void OptionsUpdatedEventHandler(string PlayerName, string TableTitle, float PricePerHour);
        public frmOptions()
        {
            InitializeComponent();
        }
        public event OptionsUpdatedEventHandler OptionsUpdated;
        protected void OnOptionsUpdated(string PlayerName, string TableTitle, float PricePerHour)
        {
            OptionsUpdated?.Invoke(PlayerName, TableTitle, PricePerHour);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _PlayerName = txbPlayerName.Text;
            _TableTitle = txbTableTitle.Text;
            _PricePerHour = (float)nudPricePerHours.Value;

            OnOptionsUpdated(_PlayerName, _TableTitle, _PricePerHour);
        }
    }
}
