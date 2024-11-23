using System;
using System.Collections.Generic;

namespace SimuladorDeUniverso2D
{
    public class Universo
    {
        // Lista de corpos no universo
        private List<Corpo> lstCorpos;
        // Constante gravitacional (em unidades apropriadas para o SI)
        private readonly double G = 6.67430e-11; // m³/kg/s²

        public Universo()
        {
            lstCorpos = new List<Corpo>();
        }

        // Método para adicionar um corpo ao universo
        public void AdicionarCorpo(Corpo corpo)
        {
            lstCorpos.Add(corpo);
        }

        // Método para obter todos os corpos
        public List<Corpo> GetCorpos()
        {
            return lstCorpos;
        }

        // Método para calcular a distância entre dois corpos
        public double DistanciaEntreCorpos(Corpo c1, Corpo c2)
        {
            double dx = c2.GetPosX() - c1.GetPosX();
            double dy = c2.GetPosY() - c1.GetPosY();
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Método para calcular a força gravitacional entre dois corpos
        private void CalcularForcaGravitacional(Corpo c1, Corpo c2)
        {
            double distancia = DistanciaEntreCorpos(c1, c2);
            if (distancia > 0)
            {
                double forca = G * ((c1.GetMassa() * c2.GetMassa()) / (distancia * distancia));
                double forcaX = (c2.GetPosX() - c1.GetPosX()) * forca / distancia;
                double forcaY = (c2.GetPosY() - c1.GetPosY()) * forca / distancia;

                c1.SetForcaX(c1.GetForcaX() + forcaX);
                c1.SetForcaY(c1.GetForcaY() + forcaY);

                c2.SetForcaX(c2.GetForcaX() - forcaX);
                c2.SetForcaY(c2.GetForcaY() - forcaY);
            }
        }

        // Método para verificar e tratar colisões
        private bool VerificarETratarColisao(Corpo c1, Corpo c2)
        {
            if (DistanciaEntreCorpos(c1, c2) <= (c1.GetRaio() + c2.GetRaio()))
            {
                double Px = (c1.GetMassa() * c1.GetVelX()) + (c2.GetMassa() * c2.GetVelX());
                double Py = (c1.GetMassa() * c1.GetVelY()) + (c2.GetMassa() * c2.GetVelY());
                double densidadeResultante = ((c1.GetMassa() * c1.GetDensidade()) + (c2.GetMassa() * c2.GetDensidade())) / (c1.GetMassa() + c2.GetMassa());

                if (c1.GetMassa() >= c2.GetMassa())
                {
                    c1.SetNome(c1.GetNome() + c2.GetNome());
                    c1.SetMassa(c1.GetMassa() + c2.GetMassa());
                    c1.SetDensidade(densidadeResultante);
                    c1.SetVelX(Px / c1.GetMassa());
                    c1.SetVelY(Py / c1.GetMassa());
                    c2.SetValido(false);
                }
                else
                {
                    c2.SetNome(c2.GetNome() + c1.GetNome());
                    c2.SetMassa(c2.GetMassa() + c1.GetMassa());
                    c2.SetDensidade(densidadeResultante);
                    c2.SetVelX(Px / c2.GetMassa());
                    c2.SetVelY(Py / c2.GetMassa());
                    c1.SetValido(false);
                }
                return true;
            }
            return false;
        }

        // Método para atualizar as interações dos corpos no universo
        public void InteracaoCorpos(double deltaTempo)
        {
            bool teveColisao = false;
            ZerarForcas();

            // Calcular forças gravitacionais
            for (int i = 0; i < lstCorpos.Count - 1; i++)
            {
                for (int j = i + 1; j < lstCorpos.Count; j++)
                {
                    CalcularForcaGravitacional(lstCorpos[i], lstCorpos[j]);
                }
            }

            // Atualizar velocidades e posições
            foreach (var corpo in lstCorpos)
            {
                if (corpo.GetValido())
                {
                    AtualizarVelocidadeEPosicao(corpo, deltaTempo);
                }
            }

            // Verificar e tratar colisões
            for (int i = 0; i < lstCorpos.Count - 1; i++)
            {
                for (int j = i + 1; j < lstCorpos.Count; j++)
                {
                    if (VerificarETratarColisao(lstCorpos[i], lstCorpos[j]))
                    {
                        teveColisao = true;
                    }
                }
            }

            // Remover corpos inválidos
            if (teveColisao)
            {
                lstCorpos.RemoveAll(c => !c.GetValido());
            }
        }

        // Método para zerar as forças em todos os corpos
        private void ZerarForcas()
        {
            foreach (var corpo in lstCorpos)
            {
                corpo.SetForcaX(0);
                corpo.SetForcaY(0);
            }
        }

        // Método para atualizar posição e velocidade de um corpo
        private void AtualizarVelocidadeEPosicao(Corpo corpo, double deltaTempo)
        {
            double acelX = corpo.GetForcaX() / corpo.GetMassa();
            double acelY = corpo.GetForcaY() / corpo.GetMassa();

            corpo.SetPosX(corpo.GetPosX() + (corpo.GetVelX() * deltaTempo) + (0.5 * acelX * deltaTempo * deltaTempo));
            corpo.SetVelX(corpo.GetVelX() + (acelX * deltaTempo));

            corpo.SetPosY(corpo.GetPosY() + (corpo.GetVelY() * deltaTempo) + (0.5 * acelY * deltaTempo * deltaTempo));
            corpo.SetVelY(corpo.GetVelY() + (acelY * deltaTempo));
        }
    }
}
