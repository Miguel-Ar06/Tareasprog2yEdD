using CorsaSimulator.src.classes;

namespace CorsaSimulator
{
    public partial class ventanaPrincipal : Form
    {
        Carro corsa;

        public ventanaPrincipal()
        {
            InitializeComponent();
            corsa = new Carro(this);

            // timer para disminuir la velocidad
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 100;
            timer1.Tick += timer1_Tick;
        }

        private async void botonEncendido_Click(object sender, EventArgs e)
        {
            corsa.ReproducirSonidoBoton();

            if (corsa.Encendido == false)
            {
                corsa.ReproducirSonidoEncendido();
                corsa.EncenderCarro();
                corsa.ReproducirSonidoMotor();

            }
            else
            {
                corsa.ApagarCarro();
                timer1.Start();
            }
        }

        private void botonLuces_Click(object sender, EventArgs e)
        {
            corsa.ReproducirSonidoBoton();

            if (corsa.Encendido == false)
            {
                return;
            }

            if (corsa.LucesEncendidas == false)
            {
                corsa.EncenderLuces();
            }
            else
            {
                corsa.ApagarLuces();

            }
        }

        private void botonLucesL_Click(object sender, EventArgs e)
        {
            corsa.ReproducirSonidoBoton();

            if (corsa.Encendido == false)
            {
                return;
            }

            if (corsa.LuzDeCruceIzq == false)
            {
                corsa.EncenderLuzDeCruceIzq();
                corsa.ReproducirSonidoCruce();
            }
        }

        private void botonLucesR_Click(object sender, EventArgs e)
        {
            corsa.ReproducirSonidoBoton();

            if (corsa.Encendido == false)
            {
                return;
            }

            if (corsa.LuzDeCruceDer == false)
            {
                corsa.EncenderLuzDeCruceDer();
                corsa.ReproducirSonidoCruce();
            }
        }

        private void ventanaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L)
            {
                corsa.ReproducirSonidoBoton();

                if (corsa.Encendido == false)
                {
                    return;
                }

                if (corsa.LucesEncendidas == false)
                {
                    corsa.EncenderLuces();
                }
                else
                {
                    corsa.ApagarLuces();

                }
            }
            if (e.KeyCode == Keys.C)
            {
                corsa.PisarCroche(true);
            }
            if (e.KeyCode == Keys.W)
            {
                if (corsa.CambiandoMarcha)
                {
                    corsa.ReproducirSonidoBoton();
                    if (corsa.Encendido == false)
                    {
                        return;
                    }
                    corsa.CambiarMarcha(true);
                }
            }
            if (e.KeyCode == Keys.S)
            {
                if (corsa.CambiandoMarcha)
                {
                    corsa.ReproducirSonidoBoton();
                    if (corsa.Encendido == false)
                    {
                        return;
                    }
                    corsa.CambiarMarcha(false);
                }
            }
            if (e.KeyCode == Keys.U)
            {
                corsa.PisarFreno(false);
                corsa.PisarAcelerador(true);

                if (corsa.Encendido && (corsa.Marcha > 0) && (corsa.Velocidad > 0))
                {
                    timer1.Stop();
                    corsa.ReproducirSonidoAvance();
                }
                if (corsa.Encendido && (corsa.Velocidad == 0) && (corsa.Marcha == 1))
                {
                    timer1.Stop();
                    corsa.ReproducirSonidoAvance();
                }
                if (corsa.Encendido && (corsa.Marcha == -1))
                {
                    timer1.Stop();
                    corsa.ReproducirSonidoRetroceso();
                }
            }
            if (e.KeyCode == Keys.K)
            {
                corsa.GirarALaDerecha();
            }
            if (e.KeyCode == Keys.H)
            {
                corsa.GirarALaIzquierda();
            }
            if (e.KeyCode == Keys.J)
            {
                corsa.PisarAcelerador(false);
                corsa.DetenerSonidoAvance();

                if (corsa.Velocidad > 0 && corsa.Encendido)
                {
                    corsa.ReproducirSonidoFreno();
                }

                corsa.PisarFreno(true);
            }
        }

        private void ventanaPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C)
            {
                corsa.PisarCroche(false);
            }
            if (e.KeyCode == Keys.U)
            {
                corsa.PisarAcelerador(false);
                corsa.DetenerSonidoAvance();
                corsa.DetenerSonidoRetroceso();

                if (corsa.Velocidad == 0)
                {
                    timer1.Stop();
                }
                else
                {
                    corsa.ReproducirSonidoFreno();
                    timer1.Start();
                }

            }
            if (e.KeyCode == Keys.K)
            {
                corsa.Enderezar();
            }
            if (e.KeyCode == Keys.H)
            {
                corsa.Enderezar();
            }
            if (e.KeyCode == Keys.J)
            {
                corsa.PisarFreno(false);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            corsa.DisminuirVelocidad();

            if (corsa.Velocidad == 0)
            {
                timer1.Stop(); // Stop the timer when the velocity reaches zero
            }
        }

        private void botonPlayPausa_Click(object sender, EventArgs e)
        {
            corsa.ReproducirSonidoBoton();

            if (corsa.Encendido == false)
            {
                return;
            }

            corsa.EncenderRadio();
            
        }

        private void botonAnterior_Click(object sender, EventArgs e)
        {
            corsa.ReproducirSonidoBoton();

            if (corsa.Encendido == false)
            {
                return;
            }

            corsa.CancionAnterior();
        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            corsa.ReproducirSonidoBoton();

            if (corsa.Encendido == false)
            {
                return;
            }

            corsa.SiguienteCancion();
        }
    }
}
