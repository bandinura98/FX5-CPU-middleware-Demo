using fx5_demo.Interfaces;
using fx5_demo.Managers;
using fx5_demo.Models;
using fx5_demo.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace fx5_demo
{
    public partial class Form1 : Form
    {
        private PlcManager _plcManager;

        public Form1()
        {
            InitializeComponent();
            InitializePlcManager();
        }

        private void InitializePlcManager()
        {
            IPLCService plcService = new ActUtlTypeService(1); // logical station 1
            IDataLogger dataLogger = new CsvDataLogger("plc_log.csv");

            _plcManager = new PlcManager(plcService, dataLogger);
            _plcManager.OnDataUpdated += PlcManager_OnDataUpdated;

            // Arka plan görevini başlat
            _plcManager.Start();
        }

        // Veri güncellendiğinde UI'ı güncellemek için
        private void PlcManager_OnDataUpdated(PlcData data)
        {
            // Background thread'den geldiği için Invoke yapmamız gerekli
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<PlcData>(UpdateUI), new object[] { data });
            }
            else
            {
                UpdateUI(data);
            }
        }

        private void UpdateUI(PlcData data)
        {
            if (data.IsConnected)
            {
                lblStatus.Text = "Connected";
                lblStatus.ForeColor = Color.MediumSeaGreen;

                lblTemperatureValue.Text = string.Format("{0} °C", data.Temperature);
                lblProductionValue.Text = data.ProductionCount.ToString();
                
                lblSpeedValue.Text = data.Speed.ToString();
                
                // Hız değerini 0-1000 arası varsaydık, pbSpeed.Maximum=1000 Designer'da
                int speedFixed = Math.Max(0, Math.Min(data.Speed, pbSpeed.Maximum));
                pbSpeed.Value = speedFixed;
            }
            else
            {
                lblStatus.Text = "Connection Lost...";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnSetTarget_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(txtTargetCount.Text, out value))
            {
                bool success = _plcManager.WriteCommand("D200", value);
                if (success)
                {
                    MessageBox.Show("The target quantity was successfully sent to the PLC.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTargetCount.Clear();
                }
                else
                {
                    MessageBox.Show("The command could not be sent. Check your PLC connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_plcManager != null)
            {
                _plcManager.Stop();
            }
        }
    }
}
