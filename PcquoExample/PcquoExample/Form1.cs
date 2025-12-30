using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.IO;



namespace PcquoExample
{
    public partial class Form1 : Form
    {
        /// <summary>
        ///  PCQUO Library name
        /// </summary>
        //private const string pcquoDll = @"..\..\..\..\dll\PcQuoDll.dll";
        private const string pcquoDll = @"PcQuoDll.dll";

        /// <summary>
        /// Channel ok. 
        /// </summary>
        private bool bOpenChannel = false;

        public bool BOpenChannel
        {
            get { return bOpenChannel; }
            set 
            { 
                bOpenChannel = value;
                if (bOpenChannel)
                {
                    lblStatus.Text = "Connected";
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblStatus.Text = "Not connected";
                    lblStatus.ForeColor = Color.Red;

                }

            }
        }


#region Dll Import 

        [DllImport(pcquoDll)]
        private extern static int openQuoChannel(string hostName);

        [DllImport(pcquoDll)]
        private extern static void closeQuoChannel();

        [DllImport(pcquoDll)]
        private extern static int sendQuoRowDstn(string row);

        [DllImport(pcquoDll)]
        private extern static int sendQuoProgDstn(string programName, string remark);

        [DllImport(pcquoDll)]
        private extern static int sendQuoDelRowDstn(int numRow);

        [DllImport(pcquoDll)]
        private extern static int sendQuoSetQntaCont(int numRow, int quantity, int counter);

        [DllImport(pcquoDll)]
        private extern static int sendQuoGetQntaCont(int numRow, ref int quantity, ref int counter);

        [DllImport(pcquoDll)]
        private extern static int setOpenQuoTenta(int waitingLoop);

        [DllImport(pcquoDll)]
        private extern static int sendQuoGetFlagsStato(ref int dstnActive, ref int autoatic, ref int macInRun);

        [DllImport(pcquoDll)]
        private extern static int sendQuoStartDstn();

        [DllImport(pcquoDll)]
        private extern static int sendQuoSetPosDstn(int numRow);

        [DllImport(pcquoDll)]
        private extern static int sendQuoGetInfDstn(ref string dstnName, ref int numRow);


#endregion


        #region   net_function

        /// <summary>
        /// Initialize Wrt communivation channel.
        /// </summary>
        /// <param name="hostName">  PC name or ip address to connect.</param>
        /// <param name="iNumTries"> waiting loop  (one  loop  = 250mSec).</param>
        /// <returns> 0-->Ok !=0-->Error.</returns>
        public int PcQuoOpenChannel(string hostName, int iNumTries)
        {
            setOpenQuoTenta(iNumTries);
            int iRet = openQuoChannel(hostName);
            BOpenChannel = iRet == 0 ? true : false;
            return (iRet);
        }


        /// <summary>
        /// Close   Wrt communivation channel.
        /// </summary>
        /// <returns> 0-->Ok !=0-->Errore.</returns>
        public void PcQuoCloseChannel()
        {
            closeQuoChannel();
            BOpenChannel = false;
        }


        /// <summary>
        /// Invia una riga completa di distinta come da "codice a barre".
        /// </summary>
        /// <remarks>
        /// Insert a program line at the end of the worklist.
        /// Row must contain   program name, amount(pieces to produce) , the piece counter (pieces products) and the comment;
        /// Row must be formatted in according to the bar code Configuration.
        /// Bar code configuration is defined in a wrt data table. Every field is located at fixed position in the string and has a fixed length. 
        /// (Use blank  to fill )
        /// </remarks>
        /// <param name="strRiga"> Row to append in worklist. </param>
        /// <returns> 0-->Ok !=0-->Errore.</returns>
        public int PcQuoSendRowDstn(string row)
        {
            int iRet = sendQuoRowDstn(row);
            return (iRet);
        }


        public int PcQuoSendProgDstn(string programName,string comment)
        {
            int iRet = sendQuoProgDstn( programName, comment);
            return (iRet);
        }

        public int PcQuoDelRowDstn(int numRow)
        {
            int iRet = sendQuoDelRowDstn(numRow);
            return (iRet);
        }

        public int PcQuoSetQntaCont(int numRow, int quantity, int counter)
        {
            int iRet = sendQuoSetQntaCont(numRow, quantity, counter);
            return (iRet);
        }

        public int PcQuoGetQntaCont(int numRow, out int quantity, out int counter)
        {
            quantity = -1; 
            counter = -1;
            int iRet = sendQuoGetQntaCont(numRow, ref quantity, ref counter);
            return (iRet);
        }

        public int PcQuoGetFlagsStato(out int dstnActive, out int automatic, out int mcInRun)
        {
            dstnActive = -1;
            automatic = -1;
            mcInRun = -1;
            int iRet = sendQuoGetFlagsStato(ref dstnActive, ref automatic, ref mcInRun);
            return (iRet);
        }

        public int PcQuoStartDstn()
        {
            int iRet = sendQuoStartDstn();
            return (iRet);
        }

        public int PcQuoSetPosDstn(int numRow)
        {
            int iRet = sendQuoSetPosDstn(numRow);
            return (iRet);
        }

        public int PcQuoGetInfoDstn(out int numRow, out string dstnName)
        {
            numRow = -1;
            dstnName = "";
            int iRet = sendQuoGetInfDstn(ref dstnName, ref numRow);
            return (iRet);
        }


        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (File.Exists(pcquoDll))
            {
                dllPath.Text = "Dll found";
                dllPath.ForeColor = Color.Green;
                PcQuoOpenChannel(txtHostName.Text, 5);
            }
            else
            {
                dllPath.Text = "Dll not found";
                dllPath.ForeColor = Color.Red;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (File.Exists(pcquoDll))
            {
                dllPath.Text = "Dll found";
                dllPath.ForeColor = Color.Green;
                PcQuoCloseChannel();
            }
            else
            {
                dllPath.Text = "Dll not found";
                dllPath.ForeColor = Color.Red;
            }
        }


        private void SetStringLength(string inString, int lenString, out string newValue,int type)
        {
            char padchar = (type == 0) ? ' ' : '0';

            if (inString.Length < lenString)
                newValue = inString.PadRight(lenString,padchar);
            else
                newValue = inString.Substring(0, lenString);
        }
        
        private void btSendRowDstn_Click(object sender, EventArgs e)
        {
            //StringBuilder sb = new StringBuilder();

            string  text;
            int nProg;

            for (nProg = 0; nProg < 2; ++nProg)
            {
                if ((nProg == 0 && txtProg.Text == "") || (nProg == 1 && txtProg2.Text == ""))
                    continue;

                text = "";

                StringBuilder sb = new StringBuilder();

                // Label 
                SetStringLength(txtLbl.Text, 4, out text, 0);
                sb.Append(text);

                //Prog
                if (nProg == 0)
                    SetStringLength(txtProg.Text, 211, out text, 0);
                else
                    SetStringLength(txtProg2.Text, 211, out text, 0);

                sb.Append(text);


                //Quantity
                SetStringLength(txtQt.Text, 4, out text, 0);
                sb.Append(text);


                // Piece count
                SetStringLength(txtPiece.Text, 4, out text, 0);
                sb.Append(text);

                //Comment
                SetStringLength(txtComment.Text, 20, out text, 0);
                sb.Append(text);

                //// Label 
                //SetStringLength(txtLbl.Text, 4, out text, 0);
                //sb.Append(text);

                ////Prog
                //if (nProg == 0)
                //    SetStringLength(txtProg.Text, 256, out text, 0);
                //else
                //    SetStringLength(txtProg2.Text, 256, out text, 0);

                //sb.Append(text);

                ////Quantity
                //SetStringLength(txtQt.Text, 4, out text, 0);
                //sb.Append(text);


                //// Piece count
                //SetStringLength(txtPiece.Text, 4, out text, 0);
                //sb.Append(text);

                ////Comment
                //SetStringLength(txtComment.Text, 4, out text, 0);
                //sb.Append(text);

                string tt = sb.ToString();

                if (File.Exists(pcquoDll))
                {
                    dllPath.Text = "Dll found";
                    dllPath.ForeColor = Color.Green;
                    int valRet = PcQuoSendRowDstn(tt);
                    if (valRet == 0)
                    {
                        label8.Text = "SUCCESS";
                        label8.ForeColor = Color.Green;
                    }
                    else
                    {
                        label8.Text = "Fail errorCode = " + valRet.ToString();
                        label8.ForeColor = Color.Red;

                    }
                }
                else
                {
                    dllPath.Text = "Dll not found";
                    dllPath.ForeColor = Color.Red;
                }
            }
        }

        private void btSendProg_Click(object sender, EventArgs e)
        {
            if (File.Exists(pcquoDll))
            {
                dllPath.Text = "Dll found";
                dllPath.ForeColor = Color.Green;
                int valRet = PcQuoSendProgDstn(txtPrg.Text, txtComm.Text);
                if (valRet == 0)
                {
                    label9.Text = "SUCCESS";
                    label9.ForeColor = Color.Green;
                }
                else
                {
                    label9.Text = "Fail errorCode = " + valRet.ToString();
                    label9.ForeColor = Color.Red;

                }
            }
            else
            {
                dllPath.Text = "Dll not found";
                dllPath.ForeColor = Color.Red;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(pcquoDll))
                PcQuoCloseChannel();
        }

        private void buttonDelRow_Click(object sender, EventArgs e)
        {
            textDelRowResult.ForeColor = Color.Black;
            if (File.Exists(pcquoDll))
            {
                int numRow = 0;

                /* Verifica numero di riga. */
                bool result = int.TryParse(textNumRow.Text, out numRow);
                if (result == false || numRow < -1)
                {
                    textDelRowResult.Text = "Numero di riga non corretto";
                    textDelRowResult.ForeColor = Color.Red;
                }
                else
                {
                    int valRit = PcQuoDelRowDstn(numRow);
                    textDelRowResult.Text = valRit.ToString();
                }
            }
            else
            {
                textDelRowResult.Text = "Dll not found";
                textDelRowResult.ForeColor = Color.Red;
            }
        }

        private void buttonSetRow_Click(object sender, EventArgs e)
        {
            textSetRowResult.ForeColor = Color.Black;
            if (File.Exists(pcquoDll))
            {
                int numRow = 0;
                int quantity = -1;
                int counter = -1;
                bool paramOk = true;

                /* Verifica numero di riga. */
                bool result = int.TryParse(textNRow.Text, out numRow);
                if (result == false || numRow < 0)
                {
                    textSetRowResult.Text = "Numero di riga non corretto";
                    textSetRowResult.ForeColor = Color.Red;
                    paramOk = false;
                }

                /* Verifica valore quantità. */
                result = int.TryParse(textQtyRow.Text, out quantity);
                if (result == false || quantity < -1)
                {
                    textSetRowResult.Text = "Valore quantità non corretto";
                    textSetRowResult.ForeColor = Color.Red;
                    paramOk = false;
                }

                /* Verifica valore contatore. */
                result = int.TryParse(textCountRow.Text, out counter);
                if (result == false || counter < -1)
                {
                    textSetRowResult.Text = "Valore contatorea non corretto";
                    textSetRowResult.ForeColor = Color.Red;
                    paramOk = false;
                }

                if (paramOk == true)
                {
                    int valRit = PcQuoSetQntaCont(numRow, quantity, counter);
                    textSetRowResult.Text = valRit.ToString();
                }
            }
            else
            {
                textSetRowResult.Text = "Dll not found";
                textSetRowResult.ForeColor = Color.Red;
            }
        }

        private void btGetInfoRiga_Click(object sender, EventArgs e)
        {
            InfoRowGet.ForeColor = Color.Black;
            if (File.Exists(pcquoDll))
            {
                int numRow = 0;
                int quantity = -1;
                int counter = -1;
                bool paramOk = true;

                /* Verifica numero di riga. */
                bool result = int.TryParse(RowNumberGet.Text, out numRow);
                if (result == false || numRow < 0)
                {
                    InfoRowGet.Text = "Numero di riga non corretto";
                    InfoRowGet.ForeColor = Color.Red;
                    paramOk = false;
                }

                if (paramOk == true)
                {
                    int valRit = PcQuoGetQntaCont(numRow, out quantity, out counter);
                    InfoRowGet.Text = valRit.ToString();
                }

                /* Scrittura valore quantità. */
                RowQtyGet.Text = quantity.ToString();
                
                /* Scrittura valore contatore. */
                RowCountGet.Text = counter.ToString();
            }
            else
            {
                textSetRowResult.Text = "Dll not found";
                textSetRowResult.ForeColor = Color.Red;
            }
        }

        private void btDstnSt_Click(object sender, EventArgs e)
        {
            textDstnSt.ForeColor = Color.Black;
            if (File.Exists(pcquoDll))
            {
                int dstnAct = -1;
                int autoMode = -1;
                int mcRun = -1;

                int valRit = PcQuoGetFlagsStato(out dstnAct, out autoMode, out mcRun);
                textDstnSt.Text = valRit.ToString();

                /* Scrittura flag di modo automatico. */
                textAuto.Text = autoMode.ToString();
                
                /* Scrittura stato distinta. */
                textDstnActive.Text = dstnAct.ToString();

                /* Scrittura flag macchina in run. */
                textMacInRun.Text = mcRun.ToString();
            }
            else
            {
                textDstnSt.Text = "Dll not found";
                textDstnSt.ForeColor = Color.Red;
            }
        }

        private void btStartDstn_Click(object sender, EventArgs e)
        {
            textStartDstn.ForeColor = Color.Black;
            if (File.Exists(pcquoDll))
            {
                int valRit = PcQuoStartDstn();
                textStartDstn.Text = valRit.ToString();
            }
            else
            {
                textStartDstn.Text = "Dll not found";
                textStartDstn.ForeColor = Color.Red;
            }
        }

        private void btSetPosDstn_Click(object sender, EventArgs e)
        {
            textSetPosResult.ForeColor = Color.Black;
            if (File.Exists(pcquoDll))
            {
                int numRow = 0;

                /* Verifica numero di riga. */
                bool result = int.TryParse(textSetPosRow.Text, out numRow);
                if (result == false || numRow < 0)
                {
                    textSetPosResult.Text = "Numero di riga non corretto";
                    textSetPosResult.ForeColor = Color.Red;
                }
                else
                {
                    int valRit = PcQuoSetPosDstn(numRow);
                    textSetPosResult.Text = valRit.ToString();
                }
            }
            else
            {
                textSetPosResult.Text = "Dll not found";
                textSetPosResult.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textInfoDstnResult.ForeColor = Color.Black;
            if (File.Exists(pcquoDll))
            {
                int numRow = -1;
                string dstnName;
                int valRit = PcQuoGetInfoDstn(out numRow, out dstnName);
                textDstnName.Text = dstnName.ToString();

                if (numRow >= 0)
                    textDstnInfoRow.Text = numRow.ToString();

                textInfoDstnResult.Text = valRit.ToString();
            }
            else
            {
                textInfoDstnResult.Text = "Dll not found";
                textInfoDstnResult.ForeColor = Color.Red;
            }
        }
    }
}