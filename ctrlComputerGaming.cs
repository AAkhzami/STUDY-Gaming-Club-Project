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
    public partial class ctrlComputerGaming : UserControl
    {
        public ctrlComputerGaming()
        {
            InitializeComponent();

        }

        int _TimeInSeconds = 0;
        double _TimeInHours = 0;
        string _PlayerName = "Player";
        string _TableTitle = "Computer Gaming";
        float _PricePerHour = .5f;
        float _TotalFees = 0;


        public string PlayerName
        {
            get { return _PlayerName; }
            set { _PlayerName = value; lblPlayerName.Text = value; Invalidate(); }
        }
        public string TableTitle
        {
            get { return _TableTitle; }
            set { _TableTitle = value; gbPCTable.Text = value; Invalidate(); }
        }
        public float PricePerHour
        {
            get { return _PricePerHour; }
            set { _PricePerHour = value; Invalidate(); }
        }

    
        public void SetTimer(int timeInSeconds)
        {
            _TimeInSeconds = timeInSeconds;
            _TimeInHours = timeInSeconds / 3600.0;
            lblTime.Text = TimeSpan.FromSeconds(timeInSeconds).ToString(@"hh\:mm\:ss");
            Invalidate();
        }

        private void PlayTimer_Tick(object sender, EventArgs e)
        {
            ++_TimeInSeconds;
            SetTimer(_TimeInSeconds);
        }

        enum enTimerState
        {
            Start,
            Paused,
            Stopped
        }
        enTimerState _timerState = enTimerState.Stopped;
        private void btnStart_Click(object sender, EventArgs e)
        {
            switch(_timerState)
            {
                case enTimerState.Start:
                    PlayTimer.Stop();
                    _timerState = enTimerState.Paused;
                    btnStart.Text = "Resume";
                    break;
                case enTimerState.Paused:
                    PlayTimer.Start();
                    _timerState = enTimerState.Start;
                    btnEnd.Enabled = true;
                    btnStart.Text = "Pause";
                    break;
                case enTimerState.Stopped:
                    SetTimer(0);
                    PlayTimer.Start();
                    _timerState = enTimerState.Start;
                    btnStart.Text = "Pause";
                    break;
            }

        }

        public class TableCompletedEventArgs : EventArgs
        {
            public int TimeInSeconds { get; }
            public string TimeText { get; }
            public float PricePerHour { get; }
            public float TotalFees { get; }

            public TableCompletedEventArgs(int timeInSeconds, string timeText, float pricePerHour, float totalFees)
            {
                TimeInSeconds = timeInSeconds;
                TimeText = timeText;
                PricePerHour = pricePerHour;
                TotalFees = totalFees;
            }
        }
        public event EventHandler<TableCompletedEventArgs> TableCompleted;
        
        protected void OnTableCompleted(TableCompletedEventArgs e)
        {
            TableCompleted?.Invoke(this, e);

        }
        public void RaiseTableCompleted()
        {
            OnTableCompleted(new TableCompletedEventArgs(_TimeInSeconds, lblTime.Text, _PricePerHour, _TotalFees));
        }

        private void Reset()
        {
            _TimeInSeconds = 0;
            _TimeInHours = 0;
            _PricePerHour = 0;
            _TotalFees = 0;
            lblTime.Text = "00:00:00";
        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            if(_timerState != enTimerState.Stopped)
            {
                _timerState = enTimerState.Stopped;
                PlayTimer.Stop();
                _TotalFees = (float)(_TimeInHours * _PricePerHour);
                RaiseTableCompleted(); Reset();
            }

        }
    }
}
