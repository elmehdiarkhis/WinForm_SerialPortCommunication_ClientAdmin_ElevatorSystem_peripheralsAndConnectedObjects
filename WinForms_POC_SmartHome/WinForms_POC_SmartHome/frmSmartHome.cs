using System.IO.Ports;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Button = System.Windows.Forms.Button;


namespace WinForms_POC_SmartHome
{
    public partial class frmSmartHome : Form
    {

        //Variable Globale================
        public static SerialPort myPort;
        string[] portsTab;
        Parity parity;
        StopBits stopBits;
        //================================

        public frmSmartHome()
        {
            InitializeComponent();
            this.f1.Click += SendMessage;
            this.f2.Click += SendMessage;
            this.f3.Click += SendMessage;
            this.p1.Click += SendMessage;
            this.p2.Click += SendMessage;
            this.p3.Click += SendMessage;
        }

        private void frmSmartHome_Load(object sender, EventArgs e)
        {
            //TAB PORT SETUP===================================
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
                lstPorts.Items.Add(portsTab[i]);
                cboPorts.Items.Add(portsTab[i]);
            }
            //====================================================
        }


        private void SendMessage(object sender, EventArgs e)
        {
            Button btnTemp = (Button) sender;

            int id = Convert.ToInt32(btnTemp.Text[btnTemp.Text.Length - 1].ToString())-1;

            int type=0;
            if (btnTemp.Text.Contains("F"))
            {
                type = 0;
                   
            }else if (btnTemp.Text.Contains("P"))
            {
                type = 1;
            }

            int etat = 0;
            if (btnTemp.BackColor == Color.Red)
            {
                btnTemp.BackColor = Color.Green;
                etat = 1;
            }
            else
            {
                btnTemp.BackColor = Color.Red;
                etat = 0;
            }

            //L'envoie du message===============
            try
            {
                if (frmPortSetup.myPort.IsOpen)
                {
                    byte[] myMessage = new byte[3];

                    myMessage[0] = Convert.ToByte(id); //fenetre id : 0 
                    myMessage[1] = Convert.ToByte(type); //type : 0 > fenetre 
                    myMessage[2] = Convert.ToByte(etat); //ouvert-fermer


                    //commence par la position 0 et envoie 3 bytes
                    frmPortSetup.myPort.Write(myMessage, 0, 3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void portsSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPortSetup fs = new frmPortSetup();
            fs.MdiParent = this;
            fs.Parent = groupBox1;

            fs.Show();
            fs.BringToFront();
            fs.Focus();
            fs.Activate();
            fs.TopMost = true;

        }




        //TAB PORT SETAUP==========================================================
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDataBits.Text.Length != 0)
                {
                    if (txtBaudRate.Text.Length != 0)
                    {
                        if (cboPorts.SelectedIndex > -1)
                        {
                            if (cboParity.SelectedIndex > -1)
                            {
                                //gestion de choix Parity=====
                                if (cboParity.SelectedItem == "None")
                                {
                                    parity = Parity.None;
                                }
                                else if (cboParity.SelectedItem == "Odd")
                                {
                                    parity = Parity.Odd;
                                }
                                else if (cboParity.SelectedItem == "Even")
                                {
                                    parity = Parity.Even;
                                }
                                else if (cboParity.SelectedItem == "Mark")
                                {
                                    parity = Parity.Mark;
                                }
                                else if (cboParity.SelectedItem == "Space")
                                {
                                    parity = Parity.Space;
                                }
                                //================================

                                //gestion de choix StopBits=====
                                if (cboStopBits.SelectedItem == "none")
                                {
                                    stopBits = StopBits.None;
                                }
                                else if (cboStopBits.SelectedItem == "One")
                                {
                                    stopBits = StopBits.One;
                                }
                                else if (cboStopBits.SelectedItem == "Two")
                                {
                                    stopBits = StopBits.Two;
                                }
                                else if (cboStopBits.SelectedItem == "OnePointFive")
                                {
                                    stopBits = StopBits.OnePointFive;
                                }
                                //==============================

                                //1-Configurer le Port
                                myPort = new SerialPort(portsTab[cboPorts.SelectedIndex], Convert.ToInt32(txtBaudRate.Text), parity, Convert.ToInt32(txtDataBits.Text), StopBits.One);
                                //myPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);


                                //2-Ouvrire le Port
                                if (!myPort.IsOpen)
                                {
                                    myPort.Open();
                                    MessageBox.Show("le port" + portsTab[cboPorts.SelectedIndex] + " est ouvert");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Veuillez choisir le : Parity");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Veuillez choisir le Port a Ouvrir");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veuillez choisir le : BaudRate");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez choisir le : DataBits");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Name,byteperSecond,marge derreur,nombre de byte,silence
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cboPorts.SelectedIndex > -1)
                {
                    if (myPort.IsOpen)
                    {
                        myPort.Close();
                        MessageBox.Show("le port" + portsTab[cboPorts.SelectedIndex] + " est fermer");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez choisir le Port a Fermer");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //==============================================================================





        //Corbeille===============================================================
        private void f1_Click(object sender, EventArgs e)
        {


        }


        private void f2_Click(object sender, EventArgs e)
        {


        }

        private void f3_Click(object sender, EventArgs e)
        {

        }

        private void p1_Click(object sender, EventArgs e)
        {

        }


        private void p2_Click(object sender, EventArgs e)
        {

        }


        private void p3_Click(object sender, EventArgs e)
        {

        }
        


        private void pct_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
    }
}