﻿using System;
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
    public partial class frmPortSetup : Form
    {

        //Variable Globale================
        public static SerialPort myPort;
        string[] portsTab;
        Parity parity;
        StopBits stopBits;
        //================================


        public frmPortSetup()
        {
            InitializeComponent();
        }

        private void frmPortSetup_Load(object sender, EventArgs e)
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
                lstPorts.Items.Add(portsTab[i]);
                cboPorts.Items.Add(portsTab[i]);
            }

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
    }
}
