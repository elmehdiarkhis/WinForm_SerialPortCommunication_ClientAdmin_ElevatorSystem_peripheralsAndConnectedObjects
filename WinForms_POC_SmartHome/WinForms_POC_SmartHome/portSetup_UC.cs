using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_POC_SmartHome
{
    public partial class portSetup_UC : UserControl
    {

        //Variable Globale================
        private SerialPort myPort;
        //============================
        string[] portsTab;
        Parity parity;
        StopBits stopBits;
        //================================


        public portSetup_UC()
        {
            InitializeComponent();
        }

        private void portSetup_UC_Load(object sender, EventArgs e)
        {
            //initial infos==============
            cboParity.Items.Add("None");
            cboParity.Items.Add("Odd");
            cboParity.Items.Add("Even");
            cboParity.Items.Add("Mark");
            cboParity.Items.Add("Space");
            //=====
            cboStopBits.Items.Add("None");
            cboStopBits.Items.Add("One");
            cboStopBits.Items.Add("Two");
            cboStopBits.Items.Add("OnePointFive");
            //===========================
            portsTab = SerialPort.GetPortNames();
            Array.Sort(portsTab);

            for (int i = 0; i < portsTab.Length; i++)
            {
                cboPorts.Items.Add(portsTab[i]);
            }
        }

    }
}
