using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDeUniverso2D
{
    public class Corpo
    {
        // Atributos classe Corpo
        private bool eValido; // Indica se o corpo é válido ou não
        private string nome; // Nome do corpo
        private double massa; // Massa do corpo (em kg)
        private double densidade; // Densidade do corpo (em kg/m³)
        private double posX; // Posição X (em metros)
        private double posY; // Posição Y (em metros)
        private double velX; // Velocidade em X (em m/s)
        private double velY; // Velocidade em Y (em m/s)
        private double forcaX; // Força atuando no eixo X (em N)
        private double forcaY; // Força atuando no eixo Y (em N)

        // Sobrecarga do operador +
        public static Corpo operator +(Corpo c1, Corpo c2)
        {
            double massaTotal = c1.massa + c2.massa;
            double px = (c1.massa * c1.velX) + (c2.massa * c2.velX);
            double py = (c1.massa * c1.velY) + (c2.massa * c2.velY);
            double densidadeResultante = (c1.massa * c1.densidade + c2.massa * c2.densidade) / massaTotal;

            return new Corpo(
                c1.nome + c2.nome,
                massaTotal,
                (c1.posX + c2.posX) / 2,
                (c1.posY + c2.posY) / 2,
                px / massaTotal,
                py / massaTotal,
                densidadeResultante
            );
        }

        // Construtor padrão
        public Corpo()
        {
            this.eValido = true;
            this.nome = "";
            this.massa = 0;
            this.densidade = 1;
            this.posX = 0;
            this.posY = 0;
            this.velX = 0;
            this.velY = 0;
            this.forcaX = 0;
            this.forcaY = 0;
        }

        // Construtor sobrecarregado
        public Corpo(string n, double m, double pX, double pY,
                     double vX, double vY, double d)
        {
            this.eValido = true;
            this.nome = n;
            this.massa = m;
            this.posX = pX;
            this.posY = pY;
            this.velX = vX;
            this.velY = vY;
            this.forcaX = 0;
            this.forcaY = 0;
            this.densidade = d;
        }

        // Métodos get e set
        public bool GetValido() { return this.eValido; } // Retorna se o corpo é válido
        public void SetValido(bool v) { this.eValido = v; } // Define se o corpo é válido

        public String GetNome() { return this.nome; } // Retorna o nome do corpo
        public void SetNome(string nome) { this.nome = nome; } // Define o nome do corpo

        public double GetMassa() { return this.massa; } // Retorna a massa do corpo
        public void SetMassa(double m) { this.massa = m; } // Define a massa do corpo

        public double GetDensidade() { return this.densidade; } // Retorna a densidade do corpo
        public void SetDensidade(double dens) { this.densidade = dens; } // Define a densidade do corpo

        public double GetPosX() { return this.posX; } // Retorna a posição X do corpo
        public void SetPosX(double x) { this.posX = x; } // Define a posição X do corpo

        public double GetPosY() { return this.posY; } // Retorna a posição Y do corpo
        public void SetPosY(double y) { this.posY = y; } // Define a posição Y do corpo

        public double GetVelX() { return this.velX; } // Retorna a velocidade em X
        public void SetVelX(double x) { this.velX = x; } // Define a velocidade em X

        public double GetVelY() { return this.velY; } // Retorna a velocidade em Y
        public void SetVelY(double y) { this.velY = y; } // Define a velocidade em Y

        public double GetForcaX() { return this.forcaX; } // Retorna a força no eixo X
        public void SetForcaX(double forca) { this.forcaX = forca; } // Define a força no eixo X

        public double GetForcaY() { return this.forcaY; } // Retorna a força no eixo Y
        public void SetForcaY(double forca) { this.forcaY = forca; } // Define a força no eixo Y


        // Método que calcula e retorna o raio com base na densidade e massa
        public double GetRaio()
        {
            double raio = Math.Pow((3 * Math.PI * this.massa) / (4 * this.densidade), ((double)1 / 3));

            return raio / 5; // Retorna o raio ajustado conforme a lógica fornecida
        }

        // Método que copia os valores de outro objeto Corpo para o objeto atual
        public void CopiarCorpo(Corpo outro)
        {
            this.nome = outro.GetNome();
            this.massa = outro.GetMassa();
            this.posX = outro.GetPosX();
            this.posY = outro.GetPosY();
            this.velX = outro.GetVelX();
            this.velY = outro.GetVelY();
        }
    }
}