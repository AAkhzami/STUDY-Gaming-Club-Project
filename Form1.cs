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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlComputerGaming1_TableCompleted(object sender, ctrlComputerGaming.TableCompletedEventArgs e)
        {
            MessageBox.Show($"Table completed! Time: {e.TimeText}, Price per hour: {e.PricePerHour:C}, Total fees: {e.TotalFees:C}");
        }
        private void OnPlayerFinished(object sender, ctrlComputerGaming.TableCompletedEventArgs e)
        {
            ctrlComputerGaming gamingControl = sender as ctrlComputerGaming;
            ;
            MessageBox.Show($"Player : {gamingControl.PlayerName} on Table {gamingControl.TableTitle} has finished playing ! Time: {e.TimeText}, Price per hour: {e.PricePerHour:C}, Total fees: {e.TotalFees:C}");
        }
    }
}
