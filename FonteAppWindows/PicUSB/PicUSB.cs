using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics; //Clase para abrir página web

namespace PicUSB
{
    public partial class PicUSB : Form
    {
        PicUSBAPI usbapi = new PicUSBAPI();

        int R = 0, G = 0, B = 0;

        public PicUSB()
        {
            InitializeComponent();
            box_red.Text = "0";
            box_green.Text = "0";
            box_blue.Text = "0";
            back_color.BackColor = Color.FromArgb(R, G, B);
        }

        private void PICsuma_Click(object sender, EventArgs e)
        {
            usbapi.SumaPIC(uint.Parse(sumando1.Text), uint.Parse(sumando2.Text));

            resultado.Text = (usbapi.ResultadoPIC().ToString());

        }

        double time;

        int temperatura_ambiente_var;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            temperatura_ambiente_var =( usbapi.ADC());

            progressBar_temp_ambiente.Value = temperatura_ambiente_var;
            temp_ambiente_box.Text = "Temperatura Ambiente: " + temperatura_ambiente_var.ToString() + " ºC";
            temp_ambiente_box.ForeColor = Color.Red;           

            chart1.Series["Series1"].Points.AddXY(time, temperatura_ambiente_var);
            

            time = time + 1;    
                    
            if (time > 10)
            {
                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = time - 10;
            }
            back_color.BackColor = Color.FromArgb(R, G, B);
            Hora.Text =DateTime.Now.ToString();

            if (usbapi.Status_PIC() == 1)
            {
                Status.Text = "PIC Conectado!";
                Status.ForeColor = Color.Green;
            }
            else
            {
                Status.Text = "PIC Desconectado!";
                Status.ForeColor = Color.Red;
            }            

        }

        private void botao_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void bar_red_Scroll(object sender, EventArgs e)
        {
            box_red.Text = bar_red.Value.ToString();
            R = bar_red.Value;

        }

        private void bar_green_Scroll(object sender, EventArgs e)
        {
            box_green.Text = bar_green.Value.ToString();
            G = bar_green.Value;
        }

        private void bar_blue_Scroll(object sender, EventArgs e)
        {
            box_blue.Text = bar_blue.Value.ToString();
            B = bar_blue.Value;
        }

        private void box_green_TextChanged(object sender, EventArgs e)
        {
            if (box_green.Text == "")
            {
                box_green.Text = "0";
            }

            int max = int.Parse(box_green.Text);

            if (max > 255)
            {
                box_green.Text = "255";
            }

            bar_green.Value = int.Parse(box_green.Text);
            G = bar_green.Value;
        }

        private void box_red_TextChanged(object sender, EventArgs e)
        {
            if (box_red.Text == "")
            {
                box_red.Text = "0";
            }

            int max = int.Parse(box_red.Text);

            if (max > 255)
            {
                box_red.Text = "255";
            }

            bar_red.Value = int.Parse(box_red.Text);
            R = bar_red.Value;
        }

        private void box_blue_TextChanged(object sender, EventArgs e)
        {
            if (box_blue.Text == "")
            {
                box_blue.Text = "0";
            }

            int max = int.Parse(box_blue.Text);

            if (max > 255)
            {
                box_blue.Text = "255";
            }

            bar_blue.Value = int.Parse(box_blue.Text);
            B = bar_blue.Value;
        }

        
        private void button_UP_MouseHover_1(object sender, EventArgs e)
        {
            button_UP.Image = Properties.Resources.Arrow_Type_1_Yellow_N;
            texto_barra_status.Text = "Ir para Frente?";
        }

        private void button_right_MouseHover_1(object sender, EventArgs e)
        {
            button_right.Image = Properties.Resources.Arrow_Type_1_Yellow_E;
            texto_barra_status.Text = "Virar à Direita?";
        }

        private void button_down_MouseHover_1(object sender, EventArgs e)
        {
            button_down.Image = Properties.Resources.Arrow_Type_1_Yellow_S;
            texto_barra_status.Text = "Ir para Trás?";
        }

        private void button_left_MouseHover_1(object sender, EventArgs e)
        {
            button_left.Image = Properties.Resources.Arrow_Type_1_Yellow_W;
            texto_barra_status.Text = "Virar à Esquerda?";
        }

        private void button_UP_MouseDown(object sender, MouseEventArgs e)
        {
            button_UP.Image = Properties.Resources.Arrow_Type_1_Red_N;
            usbapi.Controle_Carro(0x00);    //codigo para o carrinho ir para frente
            carrinho_box.Text = "Andando para frente.";
        }

        private void button_right_MouseDown(object sender, MouseEventArgs e)
        {
            button_right.Image = Properties.Resources.Arrow_Type_1_Red_E;
            usbapi.ControleMP(0x01, 0x01, 0x01, 0x00);   //codigo para carrinho ir para direita
            carrinho_box.Text = "Virando a direita.";
        }

        private void button_down_MouseDown(object sender, MouseEventArgs e)
        {
            button_down.Image = Properties.Resources.Arrow_Type_1_Red_S;
            usbapi.Controle_Carro(0x02);    //codigo para carrinho ir para trás
            carrinho_box.Text = "Andando para trás.";
        }

        private void button_left_MouseDown(object sender, MouseEventArgs e)
        {
            button_left.Image = Properties.Resources.Arrow_Type_1_Red_W;
            usbapi.ControleMP(0x02, 0x01, 0x01, 0x00);
        }

        private void button_UP_MouseUp(object sender, MouseEventArgs e)
        {
            button_UP.Image = Properties.Resources.Arrow_Type_1_Yellow_N;
        }

        private void button_right_MouseUp(object sender, MouseEventArgs e)
        {
            button_right.Image = Properties.Resources.Arrow_Type_1_Yellow_E;
        }

        private void button_down_MouseUp(object sender, MouseEventArgs e)
        {
            button_down.Image = Properties.Resources.Arrow_Type_1_Yellow_S;
        }

        private void button_left_MouseUp(object sender, MouseEventArgs e)
        {
            button_left.Image = Properties.Resources.Arrow_Type_1_Yellow_W;
        }


        private void button_UP_MouseLeave(object sender, EventArgs e)
        {
            button_UP.Image = Properties.Resources.Arrow_Type_1_Blue_N;
        }

        private void button_right_MouseLeave(object sender, EventArgs e)
        {
            button_right.Image = Properties.Resources.Arrow_Type_1_Blue_E;
        }

        private void button_down_MouseLeave(object sender, EventArgs e)
        {
            button_down.Image = Properties.Resources.Arrow_Type_1_Blue_S;
        }

        private void button_left_MouseLeave(object sender, EventArgs e)
        {
            button_left.Image = Properties.Resources.Arrow_Type_1_Blue_W;
        }

        private void button_stop_MouseHover(object sender, EventArgs e)
        {
            button_stop.BackgroundImage = Properties.Resources.stop_by_camiloculpian;
            texto_barra_status.Text = "Parar?";
        }

        private void button_stop_MouseDown(object sender, MouseEventArgs e)
        {
            button_stop.BackgroundImage = Properties.Resources._21;
            usbapi.Controle_Carro(0x04);    //codigo para carrinho parar
            carrinho_box.Text = "Parado.";
        }

        private void button_stop_MouseUp(object sender, MouseEventArgs e)
        {
            button_stop.BackgroundImage = Properties.Resources.stop_by_camiloculpian;
        }

        private void button_stop_MouseLeave(object sender, EventArgs e)
        {
            button_stop.BackgroundImage = Properties.Resources._21;
        }

        private void button_pwm_Click(object sender, EventArgs e)
        {
            usbapi.Controle_PWM_ON (R, G, B);
        }

        private void button_pwm_on_Click(object sender, EventArgs e)
        {
            usbapi.Controle_PWM_ON(R, G, B);
        }       

        private void buttton_sobre_Click(object sender, EventArgs e)
        {
            Sobre a = new Sobre();

            a.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre a = new Sobre();

            a.ShowDialog();
        }

        private void botao_fechar_MouseHover(object sender, EventArgs e)
        {
            texto_barra_status.Text = "Sair";
        }

        private void buttton_sobre_MouseHover(object sender, EventArgs e)
        {
            texto_barra_status.Text = "Informações Sobre o Programa";
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            texto_barra_status.Text = "3 canais PWM";
        }

        private void chart1_MouseHover(object sender, EventArgs e)
        {
            texto_barra_status.Text = "Gráfico da Temperatura";
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            texto_barra_status.Text = "Controle do Carrinho";
        }

        private void PICsuma_MouseHover(object sender, EventArgs e)
        {
            texto_barra_status.Text = "Envia dois valores para o PIC e ele retorna a soma";
        }
    }
}
    
    