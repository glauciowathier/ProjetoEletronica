namespace PicUSB
{
    partial class PicUSB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicUSB));
            this.PICsuma = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.sumando2 = new System.Windows.Forms.TextBox();
            this.sumando1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar_temp_ambiente = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.temp_ambiente_box = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.botao_fechar = new System.Windows.Forms.Button();
            this.box_red = new System.Windows.Forms.TextBox();
            this.box_green = new System.Windows.Forms.TextBox();
            this.box_blue = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bar_red = new System.Windows.Forms.TrackBar();
            this.bar_green = new System.Windows.Forms.TrackBar();
            this.bar_blue = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.back_color = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_UP = new System.Windows.Forms.PictureBox();
            this.button_stop = new System.Windows.Forms.PictureBox();
            this.button_left = new System.Windows.Forms.PictureBox();
            this.button_right = new System.Windows.Forms.PictureBox();
            this.button_down = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.carrinho_box = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_pwm_on = new System.Windows.Forms.Button();
            this.Hora = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.buttton_sobre = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.texto_barra_status = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_color)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_UP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_down)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PICsuma
            // 
            this.PICsuma.Location = new System.Drawing.Point(886, 655);
            this.PICsuma.Name = "PICsuma";
            this.PICsuma.Size = new System.Drawing.Size(75, 25);
            this.PICsuma.TabIndex = 30;
            this.PICsuma.Text = "PIC Soma!";
            this.PICsuma.Click += new System.EventHandler(this.PICsuma_Click);
            this.PICsuma.MouseHover += new System.EventHandler(this.PICsuma_MouseHover);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(977, 658);
            this.resultado.MaxLength = 3;
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(29, 20);
            this.resultado.TabIndex = 29;
            // 
            // sumando2
            // 
            this.sumando2.Location = new System.Drawing.Point(840, 658);
            this.sumando2.MaxLength = 2;
            this.sumando2.Name = "sumando2";
            this.sumando2.Size = new System.Drawing.Size(29, 20);
            this.sumando2.TabIndex = 27;
            this.sumando2.Text = "0";
            // 
            // sumando1
            // 
            this.sumando1.Location = new System.Drawing.Point(790, 658);
            this.sumando1.MaxLength = 2;
            this.sumando1.Name = "sumando1";
            this.sumando1.Size = new System.Drawing.Size(29, 20);
            this.sumando1.TabIndex = 26;
            this.sumando1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(825, 660);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 14);
            this.label1.TabIndex = 35;
            this.label1.Text = "+";
            // 
            // progressBar_temp_ambiente
            // 
            this.progressBar_temp_ambiente.BackColor = System.Drawing.Color.Red;
            this.progressBar_temp_ambiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar_temp_ambiente.Location = new System.Drawing.Point(203, 462);
            this.progressBar_temp_ambiente.MarqueeAnimationSpeed = 10;
            this.progressBar_temp_ambiente.Maximum = 150;
            this.progressBar_temp_ambiente.Name = "progressBar_temp_ambiente";
            this.progressBar_temp_ambiente.Size = new System.Drawing.Size(341, 36);
            this.progressBar_temp_ambiente.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "Temperatura";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temp_ambiente_box
            // 
            this.temp_ambiente_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.temp_ambiente_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temp_ambiente_box.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_ambiente_box.Location = new System.Drawing.Point(203, 420);
            this.temp_ambiente_box.Name = "temp_ambiente_box";
            this.temp_ambiente_box.Size = new System.Drawing.Size(341, 36);
            this.temp_ambiente_box.TabIndex = 39;
            this.temp_ambiente_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(203, 32);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(341, 382);
            this.chart1.TabIndex = 40;
            this.chart1.Text = "chart1";
            this.chart1.MouseHover += new System.EventHandler(this.chart1_MouseHover);
            // 
            // botao_fechar
            // 
            this.botao_fechar.Location = new System.Drawing.Point(391, 693);
            this.botao_fechar.Name = "botao_fechar";
            this.botao_fechar.Size = new System.Drawing.Size(75, 23);
            this.botao_fechar.TabIndex = 41;
            this.botao_fechar.Text = "Fechar";
            this.botao_fechar.UseVisualStyleBackColor = true;
            this.botao_fechar.Click += new System.EventHandler(this.botao_fechar_Click);
            this.botao_fechar.MouseHover += new System.EventHandler(this.botao_fechar_MouseHover);
            // 
            // box_red
            // 
            this.box_red.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_red.Location = new System.Drawing.Point(6, 423);
            this.box_red.MaxLength = 3;
            this.box_red.Name = "box_red";
            this.box_red.Size = new System.Drawing.Size(51, 20);
            this.box_red.TabIndex = 44;
            this.box_red.TextChanged += new System.EventHandler(this.box_red_TextChanged);
            // 
            // box_green
            // 
            this.box_green.AcceptsReturn = true;
            this.box_green.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_green.Location = new System.Drawing.Point(66, 423);
            this.box_green.MaxLength = 3;
            this.box_green.Name = "box_green";
            this.box_green.Size = new System.Drawing.Size(59, 20);
            this.box_green.TabIndex = 48;
            this.box_green.TextChanged += new System.EventHandler(this.box_green_TextChanged);
            // 
            // box_blue
            // 
            this.box_blue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_blue.Location = new System.Drawing.Point(134, 423);
            this.box_blue.MaxLength = 3;
            this.box_blue.Name = "box_blue";
            this.box_blue.Size = new System.Drawing.Size(60, 20);
            this.box_blue.TabIndex = 47;
            this.box_blue.TextChanged += new System.EventHandler(this.box_blue_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 347F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.box_blue, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.box_green, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bar_red, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bar_green, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.box_red, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bar_blue, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.back_color, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.temp_ambiente_box, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.progressBar_temp_ambiente, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.carrinho_box, 4, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.232558F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.18421F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.114035F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1002, 582);
            this.tableLayoutPanel1.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(134, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 42);
            this.label5.TabIndex = 51;
            this.label5.Text = "B";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(66, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 42);
            this.label4.TabIndex = 50;
            this.label4.Text = "G";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.label6, 3);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 504);
            this.label6.Name = "label6";
            this.tableLayoutPanel1.SetRowSpan(this.label6, 2);
            this.label6.Size = new System.Drawing.Size(188, 75);
            this.label6.TabIndex = 52;
            this.label6.Text = "Controlador PWM";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.MouseHover += new System.EventHandler(this.label6_MouseHover);
            // 
            // bar_red
            // 
            this.bar_red.BackColor = System.Drawing.SystemColors.Control;
            this.bar_red.Cursor = System.Windows.Forms.Cursors.Default;
            this.bar_red.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_red.Location = new System.Drawing.Point(6, 32);
            this.bar_red.Maximum = 255;
            this.bar_red.Name = "bar_red";
            this.bar_red.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bar_red.Size = new System.Drawing.Size(51, 382);
            this.bar_red.TabIndex = 43;
            this.bar_red.Scroll += new System.EventHandler(this.bar_red_Scroll);
            // 
            // bar_green
            // 
            this.bar_green.Cursor = System.Windows.Forms.Cursors.Default;
            this.bar_green.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_green.Location = new System.Drawing.Point(66, 32);
            this.bar_green.Maximum = 255;
            this.bar_green.Name = "bar_green";
            this.bar_green.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bar_green.Size = new System.Drawing.Size(59, 382);
            this.bar_green.TabIndex = 45;
            this.bar_green.Scroll += new System.EventHandler(this.bar_green_Scroll);
            // 
            // bar_blue
            // 
            this.bar_blue.Cursor = System.Windows.Forms.Cursors.Default;
            this.bar_blue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_blue.Location = new System.Drawing.Point(134, 32);
            this.bar_blue.Maximum = 255;
            this.bar_blue.Name = "bar_blue";
            this.bar_blue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.bar_blue.Size = new System.Drawing.Size(60, 382);
            this.bar_blue.TabIndex = 46;
            this.bar_blue.Scroll += new System.EventHandler(this.bar_blue_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 42);
            this.label3.TabIndex = 49;
            this.label3.Text = "R";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back_color
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.back_color, 3);
            this.back_color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_color.Location = new System.Drawing.Point(6, 6);
            this.back_color.Name = "back_color";
            this.back_color.Size = new System.Drawing.Size(188, 17);
            this.back_color.TabIndex = 53;
            this.back_color.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(553, 32);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 3);
            this.panel1.Size = new System.Drawing.Size(443, 466);
            this.panel1.TabIndex = 52;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.button_UP, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_stop, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_left, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_right, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_down, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(419, 411);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // button_UP
            // 
            this.button_UP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_UP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_UP.Image = global::PicUSB.Properties.Resources.Arrow_Type_1_Blue_N;
            this.button_UP.Location = new System.Drawing.Point(142, 3);
            this.button_UP.Name = "button_UP";
            this.button_UP.Size = new System.Drawing.Size(133, 131);
            this.button_UP.TabIndex = 0;
            this.button_UP.TabStop = false;
            this.button_UP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_UP_MouseDown);
            this.button_UP.MouseLeave += new System.EventHandler(this.button_UP_MouseLeave);
            this.button_UP.MouseHover += new System.EventHandler(this.button_UP_MouseHover_1);
            this.button_UP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_UP_MouseUp);
            // 
            // button_stop
            // 
            this.button_stop.BackgroundImage = global::PicUSB.Properties.Resources._21;
            this.button_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_stop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_stop.Location = new System.Drawing.Point(142, 140);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(133, 131);
            this.button_stop.TabIndex = 1;
            this.button_stop.TabStop = false;
            this.button_stop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_stop_MouseDown);
            this.button_stop.MouseLeave += new System.EventHandler(this.button_stop_MouseLeave);
            this.button_stop.MouseHover += new System.EventHandler(this.button_stop_MouseHover);
            this.button_stop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_stop_MouseUp);
            // 
            // button_left
            // 
            this.button_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_left.Image = global::PicUSB.Properties.Resources.Arrow_Type_1_Blue_W;
            this.button_left.Location = new System.Drawing.Point(3, 140);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(133, 131);
            this.button_left.TabIndex = 2;
            this.button_left.TabStop = false;
            this.button_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_left_MouseDown);
            this.button_left.MouseLeave += new System.EventHandler(this.button_left_MouseLeave);
            this.button_left.MouseHover += new System.EventHandler(this.button_left_MouseHover_1);
            this.button_left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_left_MouseUp);
            // 
            // button_right
            // 
            this.button_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_right.Image = global::PicUSB.Properties.Resources.Arrow_Type_1_Blue_E;
            this.button_right.Location = new System.Drawing.Point(281, 140);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(135, 131);
            this.button_right.TabIndex = 3;
            this.button_right.TabStop = false;
            this.button_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_right_MouseDown);
            this.button_right.MouseLeave += new System.EventHandler(this.button_right_MouseLeave);
            this.button_right.MouseHover += new System.EventHandler(this.button_right_MouseHover_1);
            this.button_right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_right_MouseUp);
            // 
            // button_down
            // 
            this.button_down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_down.Image = global::PicUSB.Properties.Resources.Arrow_Type_1_Blue_S;
            this.button_down.Location = new System.Drawing.Point(142, 277);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(133, 131);
            this.button_down.TabIndex = 4;
            this.button_down.TabStop = false;
            this.button_down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_down_MouseDown);
            this.button_down.MouseLeave += new System.EventHandler(this.button_down_MouseLeave);
            this.button_down.MouseHover += new System.EventHandler(this.button_down_MouseHover_1);
            this.button_down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_down_MouseUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(553, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(443, 23);
            this.label9.TabIndex = 55;
            this.label9.Text = "Controle";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.MouseHover += new System.EventHandler(this.label9_MouseHover);
            // 
            // carrinho_box
            // 
            this.carrinho_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carrinho_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carrinho_box.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carrinho_box.Location = new System.Drawing.Point(553, 541);
            this.carrinho_box.Name = "carrinho_box";
            this.carrinho_box.Size = new System.Drawing.Size(443, 38);
            this.carrinho_box.TabIndex = 56;
            this.carrinho_box.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 26);
            this.label7.TabIndex = 51;
            this.label7.Text = "Status:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_pwm_on
            // 
            this.button_pwm_on.AutoSize = true;
            this.button_pwm_on.Location = new System.Drawing.Point(69, 655);
            this.button_pwm_on.Name = "button_pwm_on";
            this.button_pwm_on.Size = new System.Drawing.Size(75, 24);
            this.button_pwm_on.TabIndex = 53;
            this.button_pwm_on.Text = "Enviar";
            this.button_pwm_on.UseVisualStyleBackColor = true;
            this.button_pwm_on.Click += new System.EventHandler(this.button_pwm_on_Click);
            // 
            // Hora
            // 
            this.Hora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Hora.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(789, 689);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(224, 28);
            this.Hora.TabIndex = 55;
            this.Hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Status
            // 
            this.Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Status.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(88, 37);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(213, 28);
            this.Status.TabIndex = 56;
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttton_sobre
            // 
            this.buttton_sobre.Location = new System.Drawing.Point(506, 693);
            this.buttton_sobre.Name = "buttton_sobre";
            this.buttton_sobre.Size = new System.Drawing.Size(75, 23);
            this.buttton_sobre.TabIndex = 57;
            this.buttton_sobre.Text = "Sobre";
            this.buttton_sobre.UseVisualStyleBackColor = true;
            this.buttton_sobre.Click += new System.EventHandler(this.buttton_sobre_Click);
            this.buttton_sobre.MouseHover += new System.EventHandler(this.buttton_sobre_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.texto_barra_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 718);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1018, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 59;
            // 
            // texto_barra_status
            // 
            this.texto_barra_status.Name = "texto_barra_status";
            this.texto_barra_status.Size = new System.Drawing.Size(0, 17);
            // 
            // PicUSB
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1018, 740);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttton_sobre);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.botao_fechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PICsuma);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.sumando2);
            this.Controls.Add(this.sumando1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button_pwm_on);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "PicUSB";
            this.Text = "Teste PIC USB by Matheus Lopes (KOALA)";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_color)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button_UP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_down)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PICsuma;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.TextBox sumando2;
        private System.Windows.Forms.TextBox sumando1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar_temp_ambiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label temp_ambiente_box;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button botao_fechar;
        private System.Windows.Forms.TextBox box_red;
        private System.Windows.Forms.TextBox box_green;
        private System.Windows.Forms.TextBox box_blue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar bar_red;
        private System.Windows.Forms.TrackBar bar_green;
        private System.Windows.Forms.TrackBar bar_blue;
        private System.Windows.Forms.PictureBox back_color;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox button_UP;
        private System.Windows.Forms.PictureBox button_stop;
        private System.Windows.Forms.PictureBox button_left;
        private System.Windows.Forms.PictureBox button_right;
        private System.Windows.Forms.PictureBox button_down;
        private System.Windows.Forms.Button button_pwm_on;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button buttton_sobre;
        private System.Windows.Forms.Label carrinho_box;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel texto_barra_status;


    }
}

