using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string ChoixSignal;
        string Frequence = "F=0020";
        string Amplitude = "A=00000";
        string Offset = "O=0000";
        string Start = "!";
        string Save = "WP=0";
        string Stop = "#";

        bool flagSave = false;

        delegate void UpdateReceivedDataDelegate(string data);

        public Form1()
        {
            InitializeComponent();

            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();
            cboPortNames.Items.Clear();
            cboPortNames.Items.AddRange(ports);
            if (cboPortNames.Items.Count > 0)
                cboPortNames.SelectedIndex = 0;
        }

        private void bntOpen_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                // Configuration du port
                serialPort1.PortName = (string)cboPortNames.SelectedItem;
                serialPort1.BaudRate = 57600;
                serialPort1.Parity = Parity.None;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.RequestToSend;

                serialPort1.Open();
            }
        }

        private void bntSend_Click(object sender, EventArgs e)
        {
            // Construire la chaîne de message à envoyer
            string[] messages = { Start, ChoixSignal, Frequence, Amplitude, Offset, Save, Stop };
            string mess = string.Join("", messages);

            txtemission.Text = mess;
            serialPort1.Write(mess);

            flagSave = false;
        }

        private void rbSinus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSinus.Enabled)
            {
                ChoixSignal = "S=S";
            }
        }
        private void rbTriangle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTriangle.Enabled)
            {
                ChoixSignal = "S=T";
            }
        }

        private void rbCarre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCarre.Enabled)
            {
                ChoixSignal = "S=C";
            }
        }

        private void rbDentScie_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDentScie.Enabled)
            {
                ChoixSignal = "S=D";
            }
        }

        private void Btnrefresh_Click(object sender, EventArgs e)
        {
            //Obtention de la liste des ports disponibles
            string[] ports = SerialPort.GetPortNames();
            // Effacer les éléments actuels de la liste déroulante
            cboPortNames.Items.Clear();
            // Ajouter les ports à la liste déroulante
            cboPortNames.Items.AddRange(ports);
            // Sélectionner le premier port s'il y en a au moins un
            if (cboPortNames.Items.Count > 0)
                cboPortNames.SelectedIndex = 0;
        }

        public void Reception()
        {
            int i;
            byte[] RxMess = new byte[30];

            // Attendre le caractère '!'
            do
            {
                RxMess[0] = (byte)serialPort1.ReadByte();
            } while (RxMess[0] != Convert.ToByte('!'));

            if (serialPort1.BytesToRead >= 29)
            {
                // Lire les données restantes
                for (i = 1; i < 29; i++)
                {
                    RxMess[i] = (byte)serialPort1.ReadByte();
                }

                // Traiter les données reçues
                string receivedData = Encoding.ASCII.GetString(RxMess, 0, 29);

                txtReception.Text = receivedData;
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            // Lire les données reçues
            string receivedData = serialPort1.ReadExisting();

            // Appeler la méthode de mise à jour de l'interface utilisateur en utilisant Invoke
            txtReception.Invoke(new UpdateReceivedDataDelegate(UpdateReceivedData), receivedData);

        }

        private void UpdateReceivedData(string data)
        {
            // Mettre à jour le texte de txtReception avec les données reçues
            txtReception.Text = data;
        }

        private void Sauvegarde_CheckedChanged(object sender, EventArgs e)
        {
            //Quittance de sauvegarde
            flagSave =! flagSave;

            if (flagSave)
            {
                Save = "W=1";
            }
           else
            {
                Save = "W=0";
            }
        }

        //Construction de la chaîne de caractère 
        private void NumOffset_ValueChanged(object sender, EventArgs e)
        {
            if (numOffset.Value > 0)
            {
                Offset = "O=+" + numOffset.Value.ToString("0000");
            }
            else if (numOffset.Value < 0)
            {
                Offset = "O=" + numOffset.Value.ToString("0000");
            }
        }

        private void NumAmpli_ValueChanged(object sender, EventArgs e)
        {
            Amplitude = "A=" + numAmplitude.Value.ToString("00000");
        }

        private void NumFreq_ValueChanged(object sender, EventArgs e)
        {
            Frequence = "F=" + numFrequence.Value.ToString("0000");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }
    }
}
