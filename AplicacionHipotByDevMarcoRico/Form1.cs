using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms.VisualStyles;

namespace AplicacionHipotByDevMarcoRico
{
    public partial class Form1 : Form
    {

        private SerialPort rs232Hipot;
        private int resultado;
        private bool hipotStatus = false;
        private StringBuilder rs232ResponseHipot;
        private String portNameHipot = "COM3";
        private StringBuilder cmd = new StringBuilder("");
        private StringBuilder etiResult = new StringBuilder("");
        private StringBuilder hipotValues01 = new StringBuilder("");
        private int interlockValue = 0;
        private bool interlock;
        private String serialNumber = "FLG233550108";

        public void mensajeAlerta(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje,titulo);
        }

        public string ValidarHipot(){
            try
            {
                string validarPuerto = "";

                // Aqui configuramos el SerialPort y abrimos el serial
                rs232Hipot = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
                rs232Hipot.Open();

                // Validar si el HIPOT esta conectado
                validarPuerto = rs232Hipot.IsOpen.ToString();
                Thread.Sleep(100);
                rs232Hipot.Close();
                return validarPuerto;   
 
            }catch(Exception ex)
            {
                mensajeAlerta(ex.ToString(), "Error");
                return "ERROR EN LA FUNCION ==> ValidarHipot";
            }
            
;       }

        public string obtenerIdHipot()
        {
            string id = "";
            try
            {
                rs232Hipot = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
                rs232Hipot.Open();

                resultado = rs232Hipot.BytesToRead;
                rs232ResponseHipot = new StringBuilder(rs232Hipot.ReadExisting());
                rs232Hipot.WriteLine("*IDN?\n");
                id = rs232Hipot.ReadLine();
                rs232ResponseHipot = new StringBuilder(rs232Hipot.ReadExisting());

                // Cerramos el puerto
                Thread.Sleep(500);
                resultado = rs232Hipot.BytesToRead;
                rs232ResponseHipot = new StringBuilder(rs232Hipot.ReadExisting());
                Thread.Sleep(500);
                rs232Hipot.Close();

                return id;

            }catch (Exception ex) {
                mensajeAlerta(ex.ToString(), "Error");
                return "ERROR EN LA FUNCION ==> obtenerIdHipot";
            }
        }

        public bool Interlock()
        {
            bool interlock = false;
            rs232ResponseHipot = new StringBuilder(rs232Hipot.ReadExisting());
            cmd = new StringBuilder(":SYSTem:KLOCk?\n");
            Thread.Sleep(100);
            
            rs232Hipot.WriteLine(cmd.ToString());
            Thread.Sleep(250);

            resultado = rs232Hipot.BytesToRead;
            rs232ResponseHipot = new StringBuilder(rs232Hipot.ReadExisting());
            Console.WriteLine($"Este es el resultado de klock ==> {rs232ResponseHipot.ToString().Trim()}");
            Thread.Sleep(100);

            interlockValue = Convert.ToInt32(rs232ResponseHipot.ToString());
            interlock = interlockValue == 0;
            Console.WriteLine(interlockValue);
            return interlock;
        }

        public void iniciarHipot(){
            try
            {
                rs232Hipot = new SerialPort(portNameHipot, 9600, Parity.None, 8, StopBits.One);
                rs232Hipot.Open();
                resultado = rs232Hipot.BytesToRead;

                // Aqui nos comunicamos con el hipot atraves por medio de una consola
                cmd = new StringBuilder("*RST\n");
                Thread.Sleep(100);
                rs232Hipot.WriteLine(cmd.ToString());
                Thread.Sleep(6000);

                resultado = rs232Hipot.BytesToRead;
                rs232ResponseHipot = new StringBuilder(rs232Hipot.ReadExisting());
                Thread.Sleep(100);

            }
            catch (Exception ex) { mensajeAlerta(ex.ToString(), "Error"); }
        }

        public void cargarTest(string prueba)
        {
            // Cargar las pruebas que se realizaran
            Thread.Sleep(100);
            cmd = new StringBuilder(prueba);
            Thread.Sleep(100);
            rs232Hipot.WriteLine(cmd.ToString());
            Thread.Sleep(500);
            rs232ResponseHipot = new StringBuilder(rs232Hipot.ReadExisting());
            Thread.Sleep(100);
        }

        public void starTest()
        {
            Thread.Sleep(1000);
            cmd = new StringBuilder(":SAFEty:STARt\n");
            Thread.Sleep(100);
            rs232Hipot.WriteLine(cmd.ToString());
            Thread.Sleep(24000);
            rs232ResponseHipot = new StringBuilder(rs232Hipot.ReadExisting());   
        }

        public string getResults(string prueba)
        {
            String resultados = "";
            
            rs232ResponseHipot = new StringBuilder(rs232Hipot.ReadExisting()); 
            Thread.Sleep(100);
            cmd = new StringBuilder(prueba);
            Thread.Sleep(100);
            rs232Hipot.WriteLine(cmd.ToString());
            Thread.Sleep(250);
            
            Console.WriteLine("Arroja resultados");
            rs232ResponseHipot = new StringBuilder(rs232Hipot.ReadExisting());
            hipotValues01 = rs232ResponseHipot;
            Console.Write(hipotValues01.ToString());   
            Thread.Sleep(100);

            return hipotValues01.ToString();
        }

        public void Stop()
        {
            hipotStatus = hipotValues01.ToString().Contains("116");
            cmd = new StringBuilder(":SAFEty:STOP\n");
            Thread.Sleep(100);
            rs232Hipot.WriteLine(cmd.ToString());
            Thread.Sleep(250);
        }

        public int calcularTurnoHora()
        {
            string hourThis = DateTime.Now.ToShortTimeString();
            string amOrpm = DateTime.Now.ToShortTimeString();
            string[] horario = hourThis.Split(' ');
            string[] horaActual = hourThis.Split(':');
            int numEntero = int.Parse(horaActual[0]);
            string[] minutosString = horaActual[1].Split(' ');
            int numMinutos = int.Parse(minutosString[0].Trim());
           
            // int numDecimal = int.Parse(horaActual[1]);
            string xm = horario[1].Trim();
            Console.WriteLine(numEntero);
            Console.WriteLine(numMinutos);
            Console.WriteLine(xm);
            return numEntero;
        }

        public string calcularTurnoHorario()
        {
            string hourThis = DateTime.Now.ToShortTimeString();
            string amOrpm = DateTime.Now.ToShortTimeString();
            string[] horario = hourThis.Split(' ');
            string[] horaActual = hourThis.Split(':');
            int numEntero = int.Parse(horaActual[0]);
            string[] minutosString = horaActual[1].Split(' ');
            int numMinutos = int.Parse(minutosString[0].Trim());

            // int numDecimal = int.Parse(horaActual[1]);
            string xm = horario[1].Trim();
            //Console.WriteLine(numEntero);
            //Console.WriteLine(numMinutos);
            //Console.WriteLine(xm);
            return xm;
        }

        public string turnoActual()
        {
            string turno = "";
            string[] turnos1 = {"7a.", "8a.", "9a.", "10a.", "11a.", "120.", "1p.", "2p.", "3p."};
            string[] turnos2 = {"4p.", "5p.", "6p.", "7p.", "8p.", "9p.", "10p.", "10p.","11p."};
            string[] turnos3 = {"12a.", "1a.", "2a.", "3a.", "4a.", "5a.", "6a."};
            int hora = calcularTurnoHora();
            string horario = calcularTurnoHorario();
            turno = $"{hora}{horario}";

            for (int i=0; i < turnos1.Length; i++)
            {
                if (turno == turnos1[i])
                {
                    turno = "Turno 1";
                    return turno;
                }

                if (turno == turnos2[i])
                {
                    turno = "Turno 2";
                    return turno;
                }

                if (turno == turnos3[i])
                {
                    turno = "Turno 3";
                    return turno;
                    
                }
            }
            return turno;
        }

        public void crearArchivoCvs(string serialNumber, string status, string voltage, string current, string rampUp)
        {
            string datetime = DateTime.Now.ToString("hh:mm:ss tt");
            string thisDay = DateTime.Today.ToString();
            string turnoActualArchivo = turnoActual();

            try
            {
                // Aqui se define los datos que vamos almacenar en el csv 
                string datos_file = $"{serialNumber},PASS,{status},VOLTAGE = {voltage},CURRENT = {current}, RAMP UP= {rampUp},{datetime},{thisDay},{turnoActualArchivo}";
                string nombreArchivo = "HipotCheck.csv";
                StreamWriter archivo = File.AppendText(nombreArchivo);
                archivo.WriteLine(datos_file);
                archivo.Close();

                // MessageBox funciono correctamente
                string mensaje = "Archivo Creado Correctamente";
                string titulo_mensaje = $"Archivo {nombreArchivo}";
                MessageBox.Show(mensaje, titulo_mensaje);
            }
            catch (Exception ex)
            {
                string mensajeError = "Hubo un error al crear el archivo";
                string tituloMensajeError = "Error al crear el archivo";
                MessageBox.Show(mensajeError, tituloMensajeError);
            }
        }

        public Form1()
        {
            InitializeComponent();
            panelMain.Hide();
            panelDeveloper.Hide();
            panelManualTest.Hide();
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            string serialNumber = txtSerialNumber.Text;

            if (serialNumber.Length > 1)
            {
                // Labels
                lblHipotStatus.Text = "";
                btnStar.Enabled = false;
                txtSerialNumber.Enabled = false;

                // Procces 1: Validar Hipot  
                String EstadoHipot = ValidarHipot();
                Console.WriteLine(EstadoHipot);

                // Procces 2: Obtener ID hipot
                String EstadoID = obtenerIdHipot();
                Console.WriteLine(EstadoID);
                lblHipotStatus.Text = EstadoID;

                // Procces 3: Reiniciamos el Hipot
                iniciarHipot();

                // Procces 4: Comprobar Interlock
                bool InterlockSeguridad = Interlock();
                Console.WriteLine(InterlockSeguridad);

                // Procces 5: Configurar pruebas del Hipot
                cargarTest(":SAFEty:STEP 1:DC707");
                cargarTest(":SAFEty:STEP 1:DC:TIME:RAMP 8");
                cargarTest(":SAFEty:STEP1:DC:LIMit 0.0015");

                // Procces 6: Iniciar Hipot 
                starTest();

                // Procces 7: Obtener Resultados
                string HipotValuesVoltage = getResults(":SAFEty:RESult:ALL?\n");
                string HipotValuesCurrent = getResults(":SAFEty:RESult:ALL:OMET?\n");
                string HipotValuesRampUp = getResults(":SAFEty:RESult:ALL:MMET?\n");

                // Procces 8: Validar Resultados
                Stop();
                Console.WriteLine($"Resultado de Voltage {HipotValuesVoltage}");
                Console.WriteLine($"Resultado de Current {HipotValuesCurrent}");
                Console.WriteLine($"Resultado de Ramp UP {HipotValuesRampUp}");

                // Cerrar RS232 
                rs232Hipot.Close();

                // Procces 9: Guardar registros en un archivo cvs y en un txt 

                // Colocar un if realizando evaluacion de los datos que arroja
                if (int.Parse(HipotValuesVoltage) != 116 & HipotValuesCurrent.Trim() != "" & HipotValuesRampUp.Trim() != "") {
                    Console.WriteLine("Los resultados de las pruebas son distintas, LA UNIDAD FALLO");
                }

                crearArchivoCvs(serialNumber.ToUpper(), "PASS", HipotValuesVoltage.Trim(), HipotValuesCurrent.Trim(), HipotValuesRampUp.Trim());

                // Procces 10: Mensaje de exito

                // Cambiar el estado de Labels
                btnStar.Enabled = true;
                txtSerialNumber.Enabled = true;

                // PENDIENTE CAMBIAR EL COLOR DEL TEXTO
                lblstatus.Text = $"{serialNumber} PASS";
                txtSerialNumber.Text = "";
                lblstatus.ForeColor = Color.Green;
                Console.WriteLine("Termino de ejecutarse");
            }
            else
            {
                string mensajeError = "No se ah ingreaso un numero de serie";
                string tituloMensajeError = "Error en el Numero Serie";
                MessageBox.Show(mensajeError, tituloMensajeError);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            panelDeveloper.Show();
            panelMain.Hide();
            panelManualTest.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            panelMain.Show();
            panelDeveloper.Hide();
            panelManualTest.Hide();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            panelManualTest.Show();
            panelMain.Hide();
            panelDeveloper.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
