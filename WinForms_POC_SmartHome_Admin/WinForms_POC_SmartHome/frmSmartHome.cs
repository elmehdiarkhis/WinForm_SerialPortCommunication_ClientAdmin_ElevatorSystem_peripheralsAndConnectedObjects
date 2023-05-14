using System.IO.Ports;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;


namespace WinForms_POC_SmartHome
{
    public partial class frmSmartHome : Form
    {
        //Variable Globale================
        private SerialPort myPort;

        //treath--comme le AsyncTask==
        private delegate void msgDelegate(byte[] b);
        private msgDelegate showReveivedMessage;
        //============================
        string[] portsTab;
        Parity parity;
        StopBits stopBits;
        int counter = 1;
        //================================




        public frmSmartHome()
        {
            InitializeComponent();
        }

        private void portsSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPortSetup fs = new frmPortSetup();
            fs.MdiParent = this;
            fs.TopMost = true;
            fs.Parent = pct;
            fs.BringToFront();
            fs.Show();
            fs.Activate();
        }

        private void frmSmartHome_Load(object sender, EventArgs e)
        {

        }


       

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
                                //myPort = new SerialPort(portsTab[cboPorts.SelectedIndex], 9600, Parity.None, 8, StopBits.One);

                                //2 - RECEVOIRE LES BYTES ENVOYER par LE PREMIER PORT ==========================================
                                //apres combien de byte recu, je genere l'evennement Datareceived
                                myPort.ReceivedBytesThreshold = 3;

                                //apres avoir recu 3 byte > On appel DataReceived > qui lui appel myPort_DataReceived 
                                myPort.DataReceived += myPort_DataReceived;
                                // += est une maniere de s'enregistrer a un eventListner
                                //========================================================================================

                                //3-Ouvrire le Port
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


        //Cette fonction est appeler apres avoir recu 3 bytes ===================================
        private void myPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Recuperer le message
            Byte[] msgRecu = new byte[3];
            for (int i = 0; i < msgRecu.Length; i++)
            {
                msgRecu[i] = Convert.ToByte(myPort.ReadByte());
            }

            //afficher le mesage en treath > en Async Task
            showReveivedMessage = new msgDelegate(ShowMsg);
            Invoke(showReveivedMessage, msgRecu);

        }

        private void ShowMsg(byte[] b)
        {


           
            string historique = "";

            int id = b[0];

            int type = b[1];

            int etat = b[2];

            if (type == 0) //FENETRE=========================================================================
            {   
                historique += "\r\nLa Fenetre numero " + (id+1) ;

                if (etat == 1) //Etat Ouvert
                {
                    historique += " a ete Ouverte at : ";

                    //ID======
                    if (id == 0)
                    {
                        f1.BackColor = Color.Green;
                    }
                    else if (id == 1)
                    {
                        btnF2.BackColor = Color.Green;
                    }
                    else if (id == 2)
                    {
                        f3.BackColor = Color.Green;
                    }
                    //=======
                }
                else //Etat Fermer
                {
                    historique += " a ete Fermer at : ";

                    //ID=====
                    if (id == 0)
                    {
                        f1.BackColor = Color.Red;
                    }
                    else if (id == 1)
                    {
                        btnF2.BackColor = Color.Red;
                    }
                    else if (id == 2)
                    {
                        f3.BackColor = Color.Red;
                    }
                    //======
                }

            }
            else if (type == 1) //PORTE=========================================================================
            {
                historique += "\r\nLa Porte numero " + id;

                if (etat == 1) //Etat Ouvert
                {
                    historique += " a ete Ouverte at : ";

                    //ID======
                    if (id == 0)
                    {
                        p1.BackColor = Color.Green;
                    }
                    else if (id == 1)
                    {
                        p2.BackColor = Color.Green;
                    }
                    else if (id == 2)
                    {
                        p3.BackColor = Color.Green;
                    }
                    //=======
                }
                else //Etat Fermer
                {
                    historique += " a ete Fermer at : ";

                    //ID=====
                    if (id == 0)
                    {
                        p1.BackColor = Color.Red;
                    }
                    else if (id == 1)
                    {
                        p2.BackColor = Color.Red;
                    }
                    else if (id == 2)
                    {
                        p3.BackColor = Color.Red;
                    }
                    //======
                }
            }
            //====================


            //Mouvement m1 = new Mouvement
            //{
            //    type = b[0],
            //    idElement = id,
            //    etat = b[2],
            //    jour = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
            //    heure = Convert.ToDateTime(DateTime.Now.ToLongTimeString())
            //};

            //myDataBase.Mouvements.InsertInSubmit(m1);
            //myDataBase.SubmitChanges();



            txtHistorique.Text +=  historique + DateTime.Now.ToShortDateString() +" "+ DateTime.Now.ToLongTimeString();


        }
        //=======================================================================================



        //FERMER LE PORT=======================================================
        private void button1_Click(object sender, EventArgs e)
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
        //====================================================================










        private void f1_Click(object sender, EventArgs e)
        {

        }

        private void pct_Click(object sender, EventArgs e)
        {

        }

        private void btnF2_Click(object sender, EventArgs e)
        {

        }
    }
}