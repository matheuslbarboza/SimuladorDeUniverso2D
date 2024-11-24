using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimuladorDeUniverso2D
{
    public partial class Form1 : Form
    {
        private Universo universo;
        private double escala = 1; 
        private int numInteracoes = 10000;
        private double deltaTempo = 0.01;

        public Form1()
        {
            InitializeComponent();
            universo = new Universo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuração inicial
        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            // Verificar se todos os campos são válidos
            string nome = nomeTextBox.Text;
            if (!double.TryParse(massaTextBox.Text, out double massa) ||
                !double.TryParse(posXTextBox.Text, out double posX) ||
                !double.TryParse(posYTextBox.Text, out double posY) ||
                !double.TryParse(velXTextBox.Text, out double velX) ||
                !double.TryParse(velYTextBox.Text, out double velY) ||
                !double.TryParse(densidadeTextBox.Text, out double densidade))
            {
                MessageBox.Show("Por favor, insira valores válidos.");
                return;
            }

            // Criar e adicionar um novo corpo ao universo
            Corpo novoCorpo = new Corpo(nome, massa, posX, posY, velX, velY,densidade);
            universo.AdicionarCorpo(novoCorpo);

            // Limpar campos após adicionar
            nomeTextBox.Clear();
            massaTextBox.Clear();
            posXTextBox.Clear();
            posYTextBox.Clear();
            velXTextBox.Clear();
            velYTextBox.Clear();
            densidadeTextBox.Clear();

            // Atualizar a tela
            displayPanel.Invalidate();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Executar a simulação em um loop
            for (int i = 0; i < numInteracoes; i++)
            {
                universo.InteracaoCorpos(deltaTempo);

                // Atualizar a tela a cada 10 interações
                if (i % 10 == 0)
                {
                    displayPanel.Invalidate();
                    Application.DoEvents(); // Permite que a interface responda
                    System.Threading.Thread.Sleep(10);
                }
            }
        }

        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            float prop = 1, propX = 1, propY = 1;
            float deslocX = 0;
            float deslocY = 0;
            float maxX = 0, maxY = 0;

            // Cálculo dos deslocamentos e proporções
            foreach (var corpo in universo.GetCorpos())
            {
                if (corpo != null)
                {
                    double posX = corpo.GetPosX();
                    double posY = corpo.GetPosY();

                    if (posX < deslocX) deslocX = (float)posX;
                    if (posY < deslocY) deslocY = (float)posY;
                    if (posX > maxX) maxX = (float)posX;
                    if (posY > maxY) maxY = (float)posY;
                }
            }

            float W = displayPanel.Width - 50;
            float H = displayPanel.Height - 50;

            if ((maxX - deslocX) > W) propX = (maxX - deslocX) / W;
            if ((maxY - deslocY) > H) propY = (maxY - deslocY) / H;

            prop = Math.Max(propX, propY);

            // Desenho dos corpos
            foreach (var corpo in universo.GetCorpos())
            {
                if (corpo != null)
                {
                    float posX = (float)(corpo.GetPosX() - deslocX) / prop;
                    float posY = (float)(corpo.GetPosY() - deslocY) / prop;
                    float raio = (float)(corpo.GetRaio() * 2) / prop;

                    g.FillEllipse(Brushes.Blue, posX - raio / 2, posY - raio / 2, raio, raio);

                    // Desenhar vetores de força (opcional)
                    g.DrawLine(Pens.Red, posX, posY, posX + (float)(corpo.GetForcaX() * 50), posY);
                    g.DrawLine(Pens.Green, posX, posY, posX, posY + (float)(corpo.GetForcaY() * 50));
                }
            }
        }
    }
}
