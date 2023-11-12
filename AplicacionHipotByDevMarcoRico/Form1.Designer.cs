namespace AplicacionHipotByDevMarcoRico
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serialPort7 = new System.IO.Ports.SerialPort(this.components);
            this.btnStar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelManualTest = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblManualTest = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblFlexFlow = new System.Windows.Forms.Label();
            this.lblHipotStatus = new System.Windows.Forms.Label();
            this.panelDeveloper = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelManualTest.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelDeveloper.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(190)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 33);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(826, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "HipoTest";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enclosures Automation ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(176)))));
            this.panel2.Location = new System.Drawing.Point(11, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 60);
            this.panel2.TabIndex = 3;
            // 
            // serialPort7
            // 
            this.serialPort7.PortName = "COM7";
            // 
            // btnStar
            // 
            this.btnStar.BackColor = System.Drawing.Color.Transparent;
            this.btnStar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStar.Location = new System.Drawing.Point(326, 207);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(120, 37);
            this.btnStar.TabIndex = 1;
            this.btnStar.Text = "INICIAR TEST";
            this.btnStar.UseVisualStyleBackColor = false;
            this.btnStar.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.panelManualTest);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblManualTest);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(1, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 430);
            this.panel3.TabIndex = 4;
            // 
            // panelManualTest
            // 
            this.panelManualTest.Controls.Add(this.button1);
            this.panelManualTest.Location = new System.Drawing.Point(181, 160);
            this.panelManualTest.Name = "panelManualTest";
            this.panelManualTest.Size = new System.Drawing.Size(255, 91);
            this.panelManualTest.TabIndex = 13;
            this.panelManualTest.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(68, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "INICIAR TEST";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Test Vanilla";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Developer";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblManualTest
            // 
            this.lblManualTest.AutoSize = true;
            this.lblManualTest.BackColor = System.Drawing.Color.Transparent;
            this.lblManualTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblManualTest.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManualTest.ForeColor = System.Drawing.Color.White;
            this.lblManualTest.Location = new System.Drawing.Point(23, 173);
            this.lblManualTest.Name = "lblManualTest";
            this.lblManualTest.Size = new System.Drawing.Size(119, 22);
            this.lblManualTest.TabIndex = 6;
            this.lblManualTest.Text = "Manual Test";
            this.lblManualTest.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Cyan;
            this.panel6.ForeColor = System.Drawing.Color.Transparent;
            this.panel6.Location = new System.Drawing.Point(2, 387);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 22);
            this.panel6.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Cyan;
            this.panel5.ForeColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(2, 173);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 23);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Cyan;
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(2, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 24);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(630, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "HIPOT TEST";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNumber.Location = new System.Drawing.Point(232, 129);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(312, 44);
            this.txtSerialNumber.TabIndex = 1;
            this.txtSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerialNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Silver;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 373);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(395, 29);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rubik", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(207, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(376, 44);
            this.label7.TabIndex = 11;
            this.label7.Text = "TEST ENGINEERING";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.BackColor = System.Drawing.Color.Transparent;
            this.lblstatus.Font = new System.Drawing.Font("Rubik", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.ForeColor = System.Drawing.Color.Gray;
            this.lblstatus.Location = new System.Drawing.Point(270, 279);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(254, 42);
            this.lblstatus.TabIndex = 12;
            this.lblstatus.Text = "TEST STATUS";
            this.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblstatus.Click += new System.EventHandler(this.label8_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lblFlexFlow);
            this.panelMain.Controls.Add(this.lblHipotStatus);
            this.panelMain.Controls.Add(this.btnStar);
            this.panelMain.Controls.Add(this.dateTimePicker1);
            this.panelMain.Controls.Add(this.lblstatus);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.txtSerialNumber);
            this.panelMain.Location = new System.Drawing.Point(216, 37);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(739, 407);
            this.panelMain.TabIndex = 13;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // lblFlexFlow
            // 
            this.lblFlexFlow.AutoSize = true;
            this.lblFlexFlow.BackColor = System.Drawing.Color.Transparent;
            this.lblFlexFlow.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlexFlow.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFlexFlow.Location = new System.Drawing.Point(619, 373);
            this.lblFlexFlow.Name = "lblFlexFlow";
            this.lblFlexFlow.Size = new System.Drawing.Size(107, 25);
            this.lblFlexFlow.TabIndex = 14;
            this.lblFlexFlow.Text = "FlexFlow";
            this.lblFlexFlow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHipotStatus
            // 
            this.lblHipotStatus.AutoSize = true;
            this.lblHipotStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblHipotStatus.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHipotStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblHipotStatus.Location = new System.Drawing.Point(322, 93);
            this.lblHipotStatus.Name = "lblHipotStatus";
            this.lblHipotStatus.Size = new System.Drawing.Size(123, 19);
            this.lblHipotStatus.TabIndex = 13;
            this.lblHipotStatus.Text = "Hipot - Status";
            // 
            // panelDeveloper
            // 
            this.panelDeveloper.Controls.Add(this.webBrowser1);
            this.panelDeveloper.Location = new System.Drawing.Point(186, 37);
            this.panelDeveloper.Name = "panelDeveloper";
            this.panelDeveloper.Size = new System.Drawing.Size(759, 423);
            this.panelDeveloper.TabIndex = 14;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(759, 423);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://theofsystem.github.io/Portafolio-/", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(957, 456);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelDeveloper);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Aplicacion Test Hipot by Marco Rico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelManualTest.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelDeveloper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.IO.Ports.SerialPort serialPort7;
        private System.Windows.Forms.Button btnStar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblManualTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelDeveloper;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panelManualTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHipotStatus;
        private System.Windows.Forms.Label lblFlexFlow;
    }
}

