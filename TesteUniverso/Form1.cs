using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimuladorDeUniverso2D
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private Universo universo;
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        public static extern bool AllocConsole();

        public Form1()
        {
            InitializeComponent();
            AllocConsole(); // Isso abrirá um console
            System.Console.WriteLine("Console alocado");
            universo = new Universo();
            universo.AdicionarCorpo(new Corpo("Corpo 1", 1000, 100, 100, 0, 0, 5000));
            universo.AdicionarCorpo(new Corpo("Corpo 2", 2000, 200, 200, 0, 0, 4000));
            timer = new System.Windows.Forms.Timer
            {
                Interval = 100 // 100 ms
            };
            timer.Tick += Timer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuração inicial
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Botão Start pressionado");
            timer.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Timer está rodando");
                universo.AtualizarInteracoes(0.1);
                displayPanel.Invalidate();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro no Timer_Tick: {ex.Message}");
            }
        }

        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            foreach (var corpo in universo.GetCorpos())
            {
                float x = (float)corpo.GetPosX();
                float y = (float)corpo.GetPosY();
                float raio = (float)corpo.GetRaio();
                g.FillEllipse(Brushes.Blue, x - raio / 2, y - raio / 2, raio, raio);
            }
        }
    }
}
