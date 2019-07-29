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

namespace OtoSeraCalisma2
{
    public partial class makineler_form : Form
    {
        public makineler_form()
        {
            InitializeComponent();
        }

        //DC MOTOR KONTROLÜ
        private void makineler_form_Load(object sender, EventArgs e)
        {
            foreach (string ports in SerialPort.GetPortNames())
            {
                ports_combobox.Items.Add(ports);
            }//Port Arama Ekleme

            //Groupboxlar Kapalı
            dcmotoryon_groupbox.Enabled = false;
            dcmotorhiz_groupbox.Enabled = false;
            servomotor_groupbox.Enabled = false;

            motorhiz_ibresi.Text = Convert.ToSingle(hiz_trackbar.Value) + "%"; // Motor Hız Göstergesi
        } //Groupbox ve Hız Göstergesi Bildirimleri

        private void motorBaglan_butonu_Click(object sender, EventArgs e)
        {
            try
            {
                MotorPort.PortName = ports_combobox.Text;
                MotorPort.BaudRate = 9600;
                MotorPort.Open();
            }
            catch (Exception)
            {
                port_label.Text = "Port Pasif!";
                port_label.ForeColor = Color.Red;
            }//Motora bağlanmak için Arduinoya İstek Yollama
            if (MotorPort.IsOpen)
            {
                dcmotoryon_groupbox.Enabled = true;
                dcmotorhiz_groupbox.Enabled = true;
                servomotor_groupbox.Enabled = true;
                port_label.Text = "Port Aktif!";
                port_label.ForeColor = Color.Green;
            } // Motorun Açık olması durumunda Groupboxları aktif etme
        } // Motor Bağlantısı Aktif Etme

        private void hiz_trackbar_Scroll(object sender, EventArgs e)
        {
            int trackBarValue = hiz_trackbar.Value;
            byte[] outData;

            if (sagyon_butonu.Checked == true)
            {
                outData = BitConverter.GetBytes(trackBarValue);
                MotorPort.Write(outData, 0, 4);
            }
            else if (solyon_butonu.Checked == true)
            {
                outData = BitConverter.GetBytes(trackBarValue + 20);
                MotorPort.Write(outData, 0, 4);
            }

            motorhiz_ibresi.Text = Convert.ToString(hiz_trackbar.Value * 10) + "%";

        }//Sağ veya Sol butonlarına göre hız arttırma

        private void sagyon_butonu_CheckedChanged(object sender, EventArgs e)
        {
            int trackBarValue2 = hiz_trackbar.Value;
            byte[] outData2 = BitConverter.GetBytes(trackBarValue2);
            MotorPort.Write(outData2, 0, 4);
        } // Sağ Yön Dönüş İsteği

        private void solyon_butonu_CheckedChanged(object sender, EventArgs e)
        {
            int trackBarValue3 = hiz_trackbar.Value;
            byte[] outData3 = BitConverter.GetBytes(trackBarValue3 + 20);
            MotorPort.Write(outData3, 0, 4);
        } // Sol Yön Dönüş İsteği

        private void makineler_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MotorPort.IsOpen)
            {
                byte[] outData4 = BitConverter.GetBytes(20);
                MotorPort.Write(outData4, 0, 4);
                byte[] outData5 = BitConverter.GetBytes(240);
                MotorPort.Write(outData5, 0, 4);
                MotorPort.Close();
            }
        } // Motoru Kapatma

        //DC MOTOR KONTROLÜ

        //SERVO MOTOR KONTROLÜ

        private void servo_ac_butonu_Click(object sender, EventArgs e)
        {
            int servoMotorValue = 250;
            byte[] outData3 = BitConverter.GetBytes(servoMotorValue);
            MotorPort.Write(outData3, 0, 4);
            Console.Write("ABC");
        }

        private void servo_kapat_butonu_Click(object sender, EventArgs e)
        {
            int servoMotorValue2 = 240;
            byte[] outData30 = BitConverter.GetBytes(servoMotorValue2);
            MotorPort.Write(outData30, 0, 4);
            Console.Write("xyC");
        }
    }
}
