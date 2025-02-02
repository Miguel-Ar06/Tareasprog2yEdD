using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using BoletaSimulator;

namespace BoletaSimulator {
    class Entidad {
        public string nombre;
        public int hp, atq, def, vel, lvl;
    }

    class Jugador : Entidad {

        Random probabilidad = new Random();

        public int xp = 0;
        public Jugador(string nombre) {
            this.nombre = nombre;
            this.lvl = 1;
            this.hp = 100;
            this.atq = 10;
            this.def = 5;
            this.vel = 10;
        }

        public void actualizarJugador() {
            if(xp == 20) {
                Console.WriteLine("Vacilatela lacrita, subiste de nivel. \nPresiona enter para continuar");
                Console.ReadKey();
                this.lvl += 1;
                this.hp += 10;
                this.atq += 5;
                this.def += 2;
                this.vel += 2;
            }
        }

        public int atacar() {
            if (probabilidad.Next(0,1) == 1) {
                Console.WriteLine("Burde criminal, tu ataque es efectivo. " + this.atq + "de daño \nPresiona enter para continuar");
                Console.ReadKey();
                return this.atq;
            }
            Console.WriteLine("\nAh no vale picale una torta, fallaste. \nPresiona enter para continuar");
            probabilidad.Next(0,1);
            Console.ReadKey();
            return 0;
        }
    }

    class Enemigo : Entidad {

        Random probabilidad = new Random();

        public Enemigo(string nombre, int lvl, int hp, int atq, int def, int vel) {
            this.nombre = nombre;
            this.lvl = lvl;
            this.hp = hp;
            this.atq = atq;
            this.def = def;
            this.vel = vel;
        }
        public int atacar() {
            if (probabilidad.Next(0,1) == 1) {
                Console.WriteLine("\n" + this.nombre + " te lanza una pocion nociva causandote " + this.atq + "de daño, te vas a dejar?\nPresiona para continuar");
                Console.ReadKey();
                return this.atq;
            }
            Console.WriteLine("\nEl ataque enemigo ha fallado como la propia jeva. \nPresiona enter para continuar");
            Console.ReadKey();
            return 0;
        }    
    }

    class Menu {

        public static void mostrarEspacios(int numeroDeEspacios) {
            for (int i = 0; i < numeroDeEspacios; i++) {
                Console.WriteLine("\n");
            }
        }

        public static void mostrarMenuSuperior(Jugador jugador, Enemigo enemigo) {
            Console.WriteLine(jugador.nombre + " / lvl." + jugador.lvl + " / hp " + jugador.hp + " / atq " + jugador.atq + " / def " + jugador.def + "\n" +
                              enemigo.nombre + " / lvl." + enemigo.lvl + " / hp " + enemigo.hp + " / atq " + enemigo.atq + " / def " + enemigo.def);
        }
        public static void mostrarMenuInferior() {
            Console.WriteLine("+------------------------------------------+\n" +
                              "| 1.Atacar                                 |\n" +
                              "| 2.Usar Objeto                            |\n" +
                              "| 3.Rendirse (salir)                       |\n" +
                              "+------------------------------------------+\n");
        }
    }


    class Program {

        static void Main(string[] args) {

            bool jugando = false;

            Console.Clear();
            Console.WriteLine("Bienvenido a BOLETA SIMULATOR. El juego de cazar brujas favorito de los barrios \nPresiona cualquier tecla para empezar");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Habla claro fresa, traes la bicha activa pal desacato? \n");
            Console.WriteLine("1.Si (te pones tu bolsito cruzado y le echas gasolina a la bera)");
            Console.WriteLine("2.No (sales corriendo por el olor a anis y se te corre el rimel)");
            ConsoleKeyInfo opcion = Console.ReadKey();
            Console.Clear();
            if (opcion.KeyChar == '1' ) {
                jugando = true;
                Console.WriteLine("Primo mio vale. Vamos pa donde las brujas pa que agarren escuela \nPresiona para continuar");
                Console.ReadKey();
            } else {
                Console.WriteLine("Ah no vale ya lo perdimos \nPresiona enter para salir");
                Console.ReadKey();
                return;
            }
            Console.Clear();
            Console.Write("Tirale vista chamit@, como es que tu te llamas?: ");
            string nombreDelJugador = Console.ReadLine();
            Jugador jugador = new Jugador(nombreDelJugador);
            Console.WriteLine("\n" + jugador.nombre + "...? Ayy vaaale no vayas a quedar como la propia loca \nPresiona para continuar");
            Console.ReadKey();


            Enemigo bruja = new Enemigo("Bruja", 2, 15, 10, 5, 2);
            Enemigo brujaMayor = new Enemigo("Bruja mayor", 5, 30, 12, 8, 5);
            Enemigo brujaDeBarrio = new Enemigo("Bruja de barrio", 10, 45, 15, 10, 5);
            List<Enemigo> enemigos = new List<Enemigo> {bruja, brujaMayor, brujaDeBarrio};

            // JUEGO COMO TAL
            Random random = new Random();
            int ronda = 1;
            while (jugando) {

                jugador.actualizarJugador();
                // Menus e interfaz
                Enemigo enemigoActual = enemigos[random.Next(0,2)];
                Console.Clear();
                Menu.mostrarMenuSuperior(jugador, enemigoActual);
                Menu.mostrarEspacios(1);
                Console.WriteLine("Ronda " + ronda + ". Se aproxima una " + enemigoActual.nombre );
                Menu.mostrarMenuInferior();

                // turnos
                if ((ronda % 2) == 1) {
                    Console.Write("Tu opcion: ");
                    opcion = Console.ReadKey();
                    switch (opcion.KeyChar) {
                        case '3':
                            Console.WriteLine("\nAyyy se le aguo el guarapo.") ;
                            return;
                            break;
                        case '1' : 
                            enemigoActual.hp -= jugador.atacar();
                            break;
                        //TODO: opcion 2 y sistema de objetos
                    }
                } else { // Turno del cpu
                    jugador.hp -= enemigoActual.atacar();
                }
                ronda++;
            }
        }
    }
}