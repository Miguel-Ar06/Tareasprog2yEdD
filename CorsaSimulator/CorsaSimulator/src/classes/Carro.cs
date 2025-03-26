using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CorsaSimulator;
using NAudio;
using NAudio.Wave;

namespace CorsaSimulator.src.classes
{
    internal class Carro
    {
        #region  //Atributos

        // Funcionalidad y estados
        private bool encendido;
        private int velocidad;
        private int marcha;
        private bool neutro;
        private bool reversa;

        private bool lucesEncendidas;
        private bool luzDeCruceIzq;
        private bool luzDeCruceDer;

        private bool avanzando;
        private bool retrocediendo;
        private bool girandoIzquierda;
        private bool girandoDerecha;
        private bool moviendose;
        private bool estaEncendiendo;
        private bool estaCambiandoMarcha;
        private bool estaEncendiendoLuz;

        private bool radioEncendido;
        private bool radioReproduciendo;
        private string? cancionSeleccionada;
        private string[]? canciones;

        // Emisores de audio
        private WaveOutEvent? radio;
        private WaveOutEvent? sonidoDeEncendido;
        private WaveOutEvent? sonidoDelMotor;
        private WaveOutEvent? sonidoDeBotones;
        private WaveOutEvent? sonidoLucesDeCruce;
        private WaveOutEvent? sonidoDeAvance;
        private WaveOutEvent? sonidoDeRetroceso;
        private WaveOutEvent? sonidoDeFreno;
        //private WaveOutEvent? sonidoDePedal;

        // Lectores de archivo de audio
        private AudioFileReader? radioReader;
        private AudioFileReader? sonidoDeEncendidoReader;
        private AudioFileReader? sonidoDelMotorReader;
        private AudioFileReader? sonidosDeBotonesReader;
        private AudioFileReader? sonidosLucesDeCruceReader;
        private AudioFileReader? sonidoDeAvanceReader;
        private AudioFileReader? sonidoDeRetrocesoReader;
        private AudioFileReader? sonidoDeFrenoReader;
        //private AudioFileReader? sonidoDePedalReader;
        private bool sonidoMotorEnBucle;
        private bool sonidoAvanceEnBucle;
        private bool sonidoRetrocesoEnBucle;


        // Referencia a la ventana principal para poder modificarla desde la clase
        private ventanaPrincipal _ventanaPrincipal;

        #endregion

        #region //Constructor

        public Carro(ventanaPrincipal ventanaPrincipal)
        {
            encendido = false;
            velocidad = 0;
            marcha = 0;
            neutro = true;

            lucesEncendidas = false;
            luzDeCruceIzq = false;
            luzDeCruceDer = false;

            avanzando = false;
            retrocediendo = false;
            girandoIzquierda = false;
            girandoDerecha = false;
            moviendose = false;
            estaCambiandoMarcha = false;
            estaEncendiendo = false;
            estaEncendiendoLuz = false;

            radioEncendido = false;
            radioReproduciendo = false;
            cancionSeleccionada = "";

            radio = new WaveOutEvent();
            sonidoDeEncendido = new WaveOutEvent();
            sonidoDelMotor = new WaveOutEvent();
            sonidoDeBotones = new WaveOutEvent();
            sonidoLucesDeCruce = new WaveOutEvent();
            sonidoDeAvance = new WaveOutEvent();
            sonidoDeRetroceso = new WaveOutEvent();
            sonidoDeFreno = new WaveOutEvent();
            //sonidoDePedal = new WaveOutEvent();

            _ventanaPrincipal = ventanaPrincipal;

            canciones = new string[] 
            { 
                "El ALFA - gogo dance.wav", 
                "El ALFA - sientate en ese deo.wav", 
                "Plan B - Guatauba.wav" 
            };

        }

        #endregion

        #region //Propiedades

        public bool Encendido { get; set; }
        public int Velocidad { get; set; }
        public int Marcha { get; set; }
        public bool Neutro { get; set; }
        public bool Reversa { get; set; }
        public bool LucesEncendidas { get; set; }
        public bool LuzDeCruceIzq { get; set; }
        public bool LuzDeCruceDer { get; set; }
        public bool Avanzando { get; set; }
        public bool Retrocediendo { get; set; }
        public bool GirandoIzquierda { get; set; }
        public bool GirandoDerecha { get; set; }
        public bool Moviendose { get; set; }
        public bool CambiandoMarcha { get; set; }
        public bool RadioEncendido { get; set; }
        public bool RadioReproduciendo { get; set; }
        public string CancionSeleccionada { get; set; }
        #endregion

        #region //Metodos

        // Encendidos, apagados y funcionalidad
        public void EncenderCarro()
        {
            if (estaEncendiendo)
            {
                return;
            }

            estaEncendiendo = true;
            _ventanaPrincipal.SetColorBotonEncendido(Color.IndianRed);
            _ventanaPrincipal.SetColorBotonLuces(Color.Goldenrod);
            _ventanaPrincipal.SetColorFondoTextoRadio(Color.PaleGreen);
            _ventanaPrincipal.SetColorPanelInfoRadio(Color.PaleGreen);
            _ventanaPrincipal.SetTextoRadio("Ninguna cancion sonando");

            Encendido = true;
            estaEncendiendo = false;

            _ventanaPrincipal.SetVisibleHumo(true);
        }
        public void ApagarCarro()
        {
            // Reestablecer a estado base
            sonidoMotorEnBucle = false;
            sonidoDeEncendido.Stop();
            radio.Stop();
            sonidoDeBotones.Stop();
            sonidoDelMotor.Stop();
            sonidoLucesDeCruce.Stop();
            ReproducirSonidoBoton();
            ApagarLuces();
            ApagarLuzDeCruceIzq();
            ApagarLuzDeCruceDer();
            PisarAcelerador(false);
            Marcha = 0;

            if (Velocidad > 0)
            {
                ReproducirSonidoFreno();
            }

            // Reestablecer interfaz
            _ventanaPrincipal.SetColorBotonEncendido(Color.FromArgb(64, 64, 64));
            _ventanaPrincipal.SetColorBotonLuces(Color.FromArgb(64, 64, 64));
            _ventanaPrincipal.SetColorFondoTextoRadio(Color.DarkOliveGreen);
            _ventanaPrincipal.SetColorPanelInfoRadio(Color.DarkOliveGreen);
            _ventanaPrincipal.SetTextoRadio("");
            _ventanaPrincipal.SetVisibleHumo(false);
            _ventanaPrincipal.SetActivadoLuzCruceDer(true);
            _ventanaPrincipal.SetActivadoLuzCruceIzq(true);
            _ventanaPrincipal.SetVisibilidadesPalanca(false, true, false, false, false, false, false); 
            _ventanaPrincipal.MostrarIndicadorReversa(false);

            Encendido = false;
        }
        public void EncenderLuces()
        {
            _ventanaPrincipal.SetVisibleLucesFrontales(true);
            LucesEncendidas = true;
        }
        public void ApagarLuces()
        {
            _ventanaPrincipal.SetVisibleLucesFrontales(false);
            LucesEncendidas = false;
        }
        public void EncenderLuzDeCruceIzq()
        {
            _ventanaPrincipal.SetVisibleLuzDeCurceIzq(true);
            _ventanaPrincipal.SetActivadoLuzCruceIzq(false);
            LuzDeCruceIzq = true;
        }
        public void EncenderLuzDeCruceDer()
        {
            _ventanaPrincipal.SetVisibleLuzDeCurceDer(true);
            _ventanaPrincipal.SetActivadoLuzCruceDer(false);
            LuzDeCruceDer = true;
        }
        public void ApagarLuzDeCruceIzq()
        {
            _ventanaPrincipal.SetColorTextoLuzCruceIzq(Color.WhiteSmoke);
            _ventanaPrincipal.SetVisibleLuzDeCurceIzq(false);
            LuzDeCruceIzq = false;
        }
        public void ApagarLuzDeCruceDer()
        {
            _ventanaPrincipal.SetColorTextoLuzCruceDer(Color.WhiteSmoke);
            _ventanaPrincipal.SetVisibleLuzDeCurceDer(false);
            LuzDeCruceDer = false;
        }
        public void CambiarMarcha(bool aumentando)
        {
            if (aumentando && (Marcha < 5))
            {
                Marcha++;

            }
            if (!aumentando && (Marcha > 0))
            {
                Marcha--;
            }
            else if (!aumentando && (Marcha == 0) && (Velocidad == 0))
            {
                Marcha--;
            }


                switch (Marcha)
            {
                case -1:
                    Neutro = false;
                    Reversa = true;
                    _ventanaPrincipal.SetVisibilidadesPalanca(true, false, false, false, false, false, false);
                    break;
                case 0:
                    Neutro = true;
                    Reversa = false;
                    _ventanaPrincipal.SetVisibilidadesPalanca(false, true, false, false, false, false, false);
                    break;
                case 1:
                    Neutro = false;
                    Reversa = false;
                    _ventanaPrincipal.SetVisibilidadesPalanca(false, false, true, false, false, false, false);
                    break;
                case 2:
                    Neutro = false;
                    Reversa = false;
                    _ventanaPrincipal.SetVisibilidadesPalanca(false, false, false, true, false, false, false);
                    break;
                case 3:
                    Neutro = false;
                    Reversa = false;
                    _ventanaPrincipal.SetVisibilidadesPalanca(false, false, false, false, true, false, false);
                    break;
                case 4:
                    Neutro = false;
                    Reversa = false;
                    _ventanaPrincipal.SetVisibilidadesPalanca(false, false, false, false, false, true, false);
                    break;
                case 5:
                    Neutro = false;
                    Reversa = false;
                    _ventanaPrincipal.SetVisibilidadesPalanca(false, false, false, false, false, false, true);
                    break;
            }
            _ventanaPrincipal.MostrarIndicadorReversa(Reversa);
        }
        public void AumentarVelocidad()
        {
            if (Marcha == 0)
            {
                return;
            }
            if (Marcha == -1 && Velocidad < 20)
            {
                Velocidad++;
            }
            if (Marcha == 1 && Velocidad < 30)
            {
                Velocidad++;
            }
            if (Marcha == 2 && Velocidad < 60)
            {
                Velocidad++;
            }
            if (Marcha == 3 && Velocidad < 90)
            {
                Velocidad++;
            }
            if (Marcha == 4 && Velocidad < 120)
            {
                Velocidad++;
            }
            if (Marcha == 5 && Velocidad < 180)
            {
                Velocidad++;
            }

            _ventanaPrincipal.SetValorProgressBarVelocidad(Velocidad);
            _ventanaPrincipal.SetVelocimetroValor(Velocidad.ToString());
        }
        public void DisminuirVelocidad()
        {
            if (Velocidad > 0)
            {
                Velocidad--;
            }
            
            _ventanaPrincipal.SetValorProgressBarVelocidad(Velocidad);
            _ventanaPrincipal.SetVelocimetroValor(Velocidad.ToString());

            if (velocidad == 0)
            {
                Moviendose = false;
                sonidoDeAvance.Stop();
            }
        }
        public void Avanzar()
        {
            if (Marcha == 0)
            {
                return;
            }
            if (Marcha == -1)
            {
                Retrocediendo = true;
                Avanzando = false;
            }
            else
            {
                Retrocediendo = false;
                Avanzando = true;
            }
            
            Moviendose = true;
            AumentarVelocidad();
        }
        public void PisarCroche(bool pisado)
        {
            CambiandoMarcha = pisado;
            _ventanaPrincipal.SetActivadoCroche(!pisado);

            if (pisado)
            {
                _ventanaPrincipal.SetColorCroche(Color.FromArgb(64, 64, 64));
            }
            else
            {
                _ventanaPrincipal.SetColorCroche(Color.DarkGray);
            }
        }
        public void PisarAcelerador(bool pisado)
        {
            _ventanaPrincipal.SetActivadoAcelerado(!pisado);

            if (pisado)
            {
                sonidoDeFreno.Stop();
                _ventanaPrincipal.SetColorAcelerador(Color.FromArgb(64, 64, 64));
                if ((Encendido && Velocidad == 0 && Marcha == 1) || (Encendido && Velocidad > 0 && Marcha >= 1))
                {
                    Avanzar();
                }
                if ((Encendido && Marcha == -1))
                {
                    Avanzar();
                }
            }
            else
            {
                _ventanaPrincipal.SetColorAcelerador(Color.DarkGray);
                DisminuirVelocidad();
            }
        }
        public void GirarALaIzquierda()
        {
            if (Velocidad > 0)
            {
                GirandoIzquierda = true;
                GirandoDerecha = false;
                _ventanaPrincipal.TraerParabrisasIZquieroAlFrente();
            }
        }
        public void GirarALaDerecha()
        {
            if (Velocidad > 0)
            {
                GirandoIzquierda = false;
                GirandoDerecha = true;
                _ventanaPrincipal.TraerParabrisasDerechoAlFrente();
            }
        }
        public void Enderezar()
        {
            GirandoIzquierda = false;
            GirandoDerecha = false;
            _ventanaPrincipal.TraerParabrisasCentroAlFrente();
        }
        public void PisarFreno(bool pisado)
        {
            _ventanaPrincipal.SetActivadoFreno(!pisado);

            if (pisado)
            {
                _ventanaPrincipal.SetColorFreno(Color.FromArgb(64, 64, 64));
                while (Velocidad > 0)
                {
                    DisminuirVelocidad();
                }
            }
            else
            {
                _ventanaPrincipal.SetColorFreno(Color.DarkGray);
            }
        }

        // Reproductores de sonido (llamados desde la ventana principal)
        public void ReproducirSonidoEncendido()
        {
            string rutaDeAplicacion = AppDomain.CurrentDomain.BaseDirectory;
            string rutaDelAudio = Path.Combine(rutaDeAplicacion, "res", "audio", "carroEncendiendo.wav");

            if (File.Exists(rutaDelAudio))
            {
                sonidoDeEncendidoReader = new AudioFileReader(rutaDelAudio);
                sonidoDeEncendido.Init(sonidoDeEncendidoReader);
                sonidoDeEncendido.Play();
            }
            else
            {
                MessageBox.Show("Audio de encendido no encontrado: " + rutaDelAudio);
            }
        }
        public void ReproducirSonidoMotor()
        {
            string rutaDeAplicacion = AppDomain.CurrentDomain.BaseDirectory;
            string rutaDelAudio = Path.Combine(rutaDeAplicacion, "res", "audio", "carroEstatico.wav");

            if (File.Exists(rutaDelAudio))
            {
                sonidoDelMotorReader = new AudioFileReader(rutaDelAudio);
                sonidoDelMotor.Init(sonidoDelMotorReader);
                sonidoMotorEnBucle = true;

                // asignar el event handler a este audio para loopearlo
                sonidoDelMotor.PlaybackStopped += FinalizadoSonidoMotor;

                // reproduccion inicial
                sonidoDelMotor.Play();
            }
            else
            {
                MessageBox.Show("Audio de encendido no encontrado: " + rutaDelAudio);
            }
        }
        public void ReproducirSonidoBoton()
        {
            string rutaDeAplicacion = AppDomain.CurrentDomain.BaseDirectory;
            string rutaDelAudio = Path.Combine(rutaDeAplicacion, "res", "audio", "sonidoBotonLuces.wav");

            if (File.Exists(rutaDelAudio))
            {
                if (sonidoDeBotones != null)
                {
                    sonidoDeBotones.Stop();
                    sonidoDeBotones.Dispose();
                }

                sonidosDeBotonesReader = new AudioFileReader(rutaDelAudio);
                sonidoDeBotones.Init(sonidosDeBotonesReader);
                sonidoDeBotones.Play();
            }
            else
            {
                MessageBox.Show("Audio de encendido no encontrado: " + rutaDelAudio);
            }
        }
        public void ReproducirSonidoCruce()
        {
            string rutaDeAplicacion = AppDomain.CurrentDomain.BaseDirectory;
            string rutaDelAudio = Path.Combine(rutaDeAplicacion, "res", "audio", "lucesDeCruce.wav");

            if (sonidoLucesDeCruce.PlaybackState == PlaybackState.Playing)
            {
                return;
            }

            if (File.Exists(rutaDelAudio))
            {
                if (sonidoLucesDeCruce != null)
                {
                    sonidoLucesDeCruce.Stop();
                    sonidoLucesDeCruce.Dispose();
                }

                sonidosLucesDeCruceReader = new AudioFileReader(rutaDelAudio);
                sonidoLucesDeCruce.Init(sonidosLucesDeCruceReader);
                sonidoLucesDeCruce.PlaybackStopped += FinalizadoSonidoLuzDeCruce;
                sonidoLucesDeCruce.Play();
            }
            else
            {
                MessageBox.Show("Audio de encendido no encontrado: " + rutaDelAudio);
            }
        }
        public void ReproducirSonidoAvance()
        {
            if (sonidoDeAvance.PlaybackState == PlaybackState.Playing)
            {
                return;
            }

            string rutaDeAplicacion = AppDomain.CurrentDomain.BaseDirectory;
            string rutaDelAudio = Path.Combine(rutaDeAplicacion, "res", "audio", "carroAcelerando.wav");

            if (File.Exists(rutaDelAudio))
            {
                if (sonidoDeAvance != null)
                {
                    sonidoDeAvance.Stop();
                    sonidoDeAvance.Dispose();
                }
                sonidoAvanceEnBucle = true;
                sonidoDeAvanceReader = new AudioFileReader(rutaDelAudio);
                sonidoDeAvance.Init(sonidoDeAvanceReader);
                sonidoDeAvance.PlaybackStopped += FinalizadoSonidoAcelerador;
                sonidoDeAvance.Play();
            }
            else
            {
                MessageBox.Show("Audio de encendido no encontrado: " + rutaDelAudio);
            }
        }
        public void ReproducirSonidoRetroceso()
        {
            if (sonidoDeRetroceso.PlaybackState == PlaybackState.Playing)
            {
                return;
            }

            string rutaDeAplicacion = AppDomain.CurrentDomain.BaseDirectory;
            string rutaDelAudio = Path.Combine(rutaDeAplicacion, "res", "audio", "carroRetrocediendo.wav");

            if (File.Exists(rutaDelAudio))
            {
                if (sonidoDeRetroceso != null)
                {
                    sonidoDeRetroceso.Stop();
                    sonidoDeRetroceso.Dispose();
                }
                sonidoRetrocesoEnBucle = true;
                sonidoDeRetrocesoReader = new AudioFileReader(rutaDelAudio);
                sonidoDeRetroceso.Init(sonidoDeRetrocesoReader);
                sonidoDeRetroceso.PlaybackStopped += FinalizadoSonidoReversa;
                sonidoDeRetroceso.Play();
            }
            else
            {
                MessageBox.Show("Audio de encendido no encontrado: " + rutaDelAudio);
            }
        }
        public void DetenerSonidoAvance()
        {
            sonidoAvanceEnBucle = false;
            sonidoDeAvance.Stop();
        }
        public void DetenerSonidoRetroceso()
        {
            sonidoRetrocesoEnBucle = false;
            sonidoDeRetroceso.Stop();
        }
        public void ReproducirSonidoFreno()
        {
            string rutaDeAplicacion = AppDomain.CurrentDomain.BaseDirectory;
            string rutaDelAudio = Path.Combine(rutaDeAplicacion, "res", "audio", "carroFrenando.wav");

            if (File.Exists(rutaDelAudio))
            {
                if (sonidoDeFreno != null)
                {
                    sonidoDeFreno.Stop();
                    sonidoDeFreno.Dispose();
                }

                sonidoDeFrenoReader = new AudioFileReader(rutaDelAudio);
                sonidoDeFreno.Init(sonidoDeFrenoReader);
                sonidoDeFreno.Play();
            }
            else
            {
                MessageBox.Show("Audio de encendido no encontrado: " + rutaDelAudio);
            }
        }
        public void SiguienteCancion()
        {
            radio.Stop();

            if (canciones == null)
            {
                return;
            }
            if (cancionSeleccionada == "")
            {
                cancionSeleccionada = canciones[0];
            }
            else
            {
                int indiceCancion = Array.IndexOf(canciones, cancionSeleccionada);
                if (indiceCancion == canciones.Length - 1)
                {
                    cancionSeleccionada = canciones[0];
                }
                else
                {
                    cancionSeleccionada = canciones[indiceCancion + 1];
                }
            }
            _ventanaPrincipal.SetTextoRadio(cancionSeleccionada);
        }
        public void CancionAnterior()
        {
            radio.Stop();

            if (canciones == null)
            {
                return;
            }
            if (cancionSeleccionada == "")
            {
                cancionSeleccionada = canciones[0];
            }
            else
            {
                int indiceCancion = Array.IndexOf(canciones, cancionSeleccionada);
                if (indiceCancion == 0)
                {
                    cancionSeleccionada = canciones[canciones.Length - 1];
                }
                else
                {
                    cancionSeleccionada = canciones[indiceCancion - 1];
                }
            }
            _ventanaPrincipal.SetTextoRadio(cancionSeleccionada);
        }
        public void EncenderRadio()
        {
            string rutaDeAplicacion = AppDomain.CurrentDomain.BaseDirectory;
            string rutaDelAudio = Path.Combine(rutaDeAplicacion, "res", "audio", cancionSeleccionada);

            if (radio.PlaybackState == PlaybackState.Playing)
            {
                radio.Stop();
                return;
            }

            if (File.Exists(rutaDelAudio))
            {
                if (radio != null)
                {
                    radio.Stop();
                    radio.Dispose();
                }

                radioReader = new AudioFileReader(rutaDelAudio);
                radio.Init(radioReader);
                radio.Play();
            }
            else
            {
                MessageBox.Show("Audio de encendido no encontrado: " + rutaDelAudio);
            }

            radioEncendido = true;
            radioReproduciendo = true;
        }
        public void DetenerRadio()
        {
            radio.Stop();
            radioEncendido = false;
            radioReproduciendo = false;
        }
        /* public void ReproducirSonidoPedal()
        {
            string rutaDeAplicacion = AppDomain.CurrentDomain.BaseDirectory;
            string rutaDelAudio = Path.Combine(rutaDeAplicacion, "res", "audio", "cambiandoVelocidad.wav");

            if (sonidoLucesDeCruce.PlaybackState == PlaybackState.Playing)
            {
                return;
            }

            if (File.Exists(rutaDelAudio))
            {
                if (sonidoDePedal == null)
                {
                    sonidoDePedalReader = new AudioFileReader(rutaDelAudio);
                }

                sonidoDePedal.Stop();
                sonidoDePedal.Init(sonidoDePedalReader);
                sonidoDePedal.Play();
            }
            else
            {
                MessageBox.Show("Audio de encendido no encontrado: " + rutaDelAudio);
            }
        } */

        // Eventos para cuando finaliza un audio
        private void FinalizadoSonidoMotor(object sender, StoppedEventArgs args)
        {
            // volver a reproducir el audio desde el comienzo cuando se detenga
            if (sonidoMotorEnBucle && Encendido)
            {
                sonidoDelMotorReader.Position = 0;
                sonidoDelMotor.Play();
            }
        }
        private void FinalizadoSonidoLuzDeCruce(object sender, StoppedEventArgs args)
        {
            // apagar luces y reiniciar botones cuando el sonido acabe
            if (LuzDeCruceDer && Encendido)
            {
                ApagarLuzDeCruceDer();
                ReproducirSonidoBoton();
                _ventanaPrincipal.SetActivadoLuzCruceDer(true);
            }
            if (LuzDeCruceIzq && Encendido)
            {
                ApagarLuzDeCruceIzq();
                ReproducirSonidoBoton();
                _ventanaPrincipal.SetActivadoLuzCruceIzq(true);
            }
        }
        private void FinalizadoSonidoAcelerador(object sender, StoppedEventArgs args)
        {
            // volver a reproducir el audio desde el comienzo cuando se detenga
            if (sonidoAvanceEnBucle && Encendido)
            {
                sonidoDeAvanceReader.Position = 0;
                sonidoDeAvance.Play();
            }
        }
        private void FinalizadoSonidoReversa(object sender, StoppedEventArgs args)
        {
            // volver a reproducir el audio desde el comienzo cuando se detenga
            if (sonidoRetrocesoEnBucle && Encendido)
            {
                sonidoDeRetrocesoReader.Position = 0;
                sonidoDeRetroceso.Play();
            }
        }

        #endregion
    }
}
