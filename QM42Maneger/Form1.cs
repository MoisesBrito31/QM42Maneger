using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace QM42Maneger
{
    public partial class Form1 : Form
    {
        modbus md = new modbus();
        IList<float> bufferVibracao = new List<float>();
        IList<float> bufferTemperatura = new List<float>();
        IList<DateTime> bufferDate = new List<DateTime>();

        int univelsalcontTarget = 0;
        int universalCont = 0;
        int tempo = 0;
        int tempoAlvo = 0;
        int Fileconter = 0;

        short[] values;
        short[] values2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxBound.SelectedIndex = 1;
            verificaPortas();
            cbxVT.SelectedIndex = 0;

        }

        private void verificaPortas()
        {
            cbxPorta.Items.Clear();
            for (int x = 1; x < 30; x++)
            {
                try
                {                    
                    SerialPort p = new SerialPort(string.Format("COM{0}", x));
                    p.Open();                   
                    cbxPorta.Items.Add(p.PortName);
                    p.Close();

                }
                catch { }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bufferVibracao.Clear();
                bufferTemperatura.Clear();
                bufferDate.Clear();

                universalCont = 0;
                univelsalcontTarget = (int)numRateLog.Value;
                Fileconter = 0;
                tempoAlvo = Convert.ToInt16(txtDatalogPoll.Text);
                gfVibracao.Series[0].Points.Clear();
                graficoTemp.Series[0].Points.Clear();
                gfVibracao.Series[1].Points.Clear();
                graficoTemp.Series[1].Points.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string nome = cbxPorta.SelectedItem.ToString();
                int bound = Convert.ToInt32(cbxBound.SelectedItem.ToString());
                if (md.Open(nome, bound, 8, System.IO.Ports.Parity.None, System.IO.Ports.StopBits.One))
                {
                    short[] grava = new short[1];
                    ushort reg = (ushort)Convert.ToInt16(txtalerm.Text);
                    grava[0] = 1;
                    byte id = Convert.ToByte(txtModbusID.Text);

                    md.SendFc16(id, reg, 1, grava);

                    md.Close();

                }

               
                timer1.Interval = Convert.ToInt16(txtTime.Text);
                timer1.Enabled = true;
                timer2.Enabled = true;
                timerTemp.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //lblVibracao.Text = "";
                string nome = cbxPorta.SelectedItem.ToString();
                int bound = Convert.ToInt32(cbxBound.SelectedItem.ToString());
                if (md.Open(nome, bound, 8, System.IO.Ports.Parity.None, System.IO.Ports.StopBits.One))
                {
                    values = new short[3];
                    
                    ushort pollStart = (ushort)Convert.ToInt16(txtRegistro.Text);                   

                    md.SendFc3(Convert.ToByte(txtModbusID.Text), pollStart, 3, ref values);

                    lblVibracao.Text = Convert.ToString((float)values[0]/1000);       

                    vibracaoGrafico(values);                                     

                    lblStatus.Text = md.modbusStatus;
                    md.Close();                   

                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "";
                lblStatus.Text = md.modbusStatus;
                MessageBox.Show(ex.Message);
            }
        }

        private void timerTemp_Tick(object sender, EventArgs e)
        {
            try
            {
                //lblVibracao.Text = "";
                string nome = cbxPorta.SelectedItem.ToString();
                int bound = Convert.ToInt32(cbxBound.SelectedItem.ToString());
                if (md.Open(nome, bound, 8, System.IO.Ports.Parity.None, System.IO.Ports.StopBits.One))
                {
                   
                    values2 = new short[3];
                   
                    ushort pollStart2 = (ushort)Convert.ToInt16(txtRegTemp.Text);  

                    md.SendFc3(Convert.ToByte(txtModbusID.Text), pollStart2, 1, ref values2);

                    if (cbxVT.SelectedIndex > 0)
                    {
                        lblTemp.Text = Convert.ToString((float)values2[0] / 20);
                    }
                    else
                    {
                        lblTemp.Text = Convert.ToString((float)values2[0] / 100);
                    }
                                        
                    temperaturaGrafico(values2);

                    lblStatus.Text = md.modbusStatus;
                    md.Close();

                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "";
                lblStatus.Text = md.modbusStatus;
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timerTemp.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;
            desligaluz((ushort)Convert.ToInt16(txtalerm.Text));
        }

        private void vibracaoGrafico(short[] values)
        {         
           
            string hora = string.Format("{0}:{1}", DateTime.Now.Hour.ToString(), DateTime.Now.Minute.ToString());
            gfVibracao.Series[0].Points.AddXY(hora, (Decimal)values[0] / 1000);
            gfVibracao.Series[1].Points.AddXY(hora, Convert.ToInt32(numVibracao.Text));
        }

        private void temperaturaGrafico(short[] values)
        {
           
           
            string hora = string.Format("{0}:{1}", DateTime.Now.Hour.ToString(), DateTime.Now.Minute.ToString());
            if (cbxVT.SelectedIndex > 0)
            {
                graficoTemp.Series[0].Points.AddXY(hora, (Decimal)values[0] / 100);
            }
            else
            {
                graficoTemp.Series[0].Points.AddXY(hora, (Decimal)values[0] / 20);
            }
            
            graficoTemp.Series[1].Points.AddXY(hora, Convert.ToInt32(numTempLimite.Text));

            

           
        }

        private void bufferDatalog(short[] values)
        {

            bufferVibracao.Insert(universalCont,(float)Convert.ToDouble(values[0]) / 1000);
            bufferTemperatura.Insert(universalCont,(float)values[2] / 20);
            bufferDate.Insert(universalCont, DateTime.Now);

            universalCont++;
            if (universalCont >= univelsalcontTarget)
            {
                txtpainel.Text = "";
                for (int x = 0; x < univelsalcontTarget; x++)
                {
                    txtpainel.Text = string.Format("{0}{1}:{2}\r\n", txtpainel.Text, x, bufferVibracao.ElementAt<float>(x));
                }

                string data = string.Format("{0}-{1}-{2}", DateTime.Now.Day.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());
                string nome = string.Format(@"{1}_{0}_{2}.CSV", txtMotor.Text, data,Fileconter);
                
                while(File.Exists(nome))
                { 
                    Fileconter++;
                    nome = string.Format(@"{1}_{0}_{2}.CSV", txtMotor.Text, data, Fileconter);
                }

                StreamWriter grava = new StreamWriter(nome, false, Encoding.GetEncoding(28591));              
                               
                
                for (int x=0;x<= univelsalcontTarget-1; x++)
                 {
                     if (x == 0)
                     {
                         grava.WriteLine("tempo do registro;vibração(mm/s);Temperatura(C°)");
                     }
                     else
                     {
                         grava.WriteLine(string.Format("{0};{1};{2}", bufferDate.ElementAt<DateTime>(x), bufferVibracao.ElementAt<float>(x), bufferTemperatura.ElementAt<float>(x)));                 
                     }

                 }
                grava.Close();
                
                
                universalCont = 0;
                bufferDate.Clear();
                bufferVibracao.Clear();
                bufferTemperatura.Clear();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {           
            if(tempo>=tempoAlvo)
           {
                tempo = 0;
                bufferDatalog(values);
           }
           tempo++;
            try
            {
                if (values[0] / 1000 > Convert.ToInt32(numVibracao.Value))
                {
                    string nome = cbxPorta.SelectedItem.ToString();
                    int bound = Convert.ToInt32(cbxBound.SelectedItem.ToString());
                    if (md.Open(nome, bound, 8, System.IO.Ports.Parity.None, System.IO.Ports.StopBits.One))
                    {
                        short[] grava = new short[2];
                        grava[0] = 0;
                        grava[1] = 1;
                        ushort reg = (ushort)Convert.ToInt16(txtalerm.Text);
                        byte id = Convert.ToByte(txtModbusID.Text);
                        ushort registro = (ushort)Convert.ToInt16(txtRegistro.Text);
                        md.SendFc16(id, reg, 2, grava);

                        md.Close();

                    }
                }
                else
                {
                    string nome = cbxPorta.SelectedItem.ToString();
                    int bound = Convert.ToInt32(cbxBound.SelectedItem.ToString());
                    if (md.Open(nome, bound, 8, System.IO.Ports.Parity.None, System.IO.Ports.StopBits.One))
                    {
                        short[] grava = new short[2];
                        grava[0] = 1;
                        grava[1] = 0;
                        ushort reg = (ushort)Convert.ToInt16(txtalerm.Text);
                        byte id = Convert.ToByte(txtModbusID.Text);
                        ushort registro = (ushort)Convert.ToInt16(txtRegistro.Text);

                        md.SendFc16(id, reg, 2, grava);

                        md.Close();

                    }
                }
            }
            catch { }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            desligaluz((ushort)Convert.ToInt16(txtalerm.Text));
        }

        private void cbxPorta_MouseClick(object sender, MouseEventArgs e)
        {
            verificaPortas();
        }

        private void cbxVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxVT.SelectedIndex>0)
            {
                txtRegistro.Text = "33";
                txtRegTemp.Text = "35";
            }
            else
            {
                txtRegistro.Text = "2403";
                txtRegTemp.Text = "43";
            }
            
        }

        public void desligaluz(ushort reg)
        {
            try
            {
                string nome = cbxPorta.SelectedItem.ToString();
                int bound = Convert.ToInt32(cbxBound.SelectedItem.ToString());
                if (md.Open(nome, bound, 8, System.IO.Ports.Parity.None, System.IO.Ports.StopBits.One))
                {
                    short[] grava = new short[2];
                    grava[0] = 0;
                    grava[1] = 0;
                    byte id = Convert.ToByte(txtModbusID.Text);                    
                    string test = md.modbusStatus;
                    md.SendFc16(id, reg, 2, grava);
                    test = md.modbusStatus;
                    md.Close();

                }
            }
            catch { }
        }
        
    }


}
