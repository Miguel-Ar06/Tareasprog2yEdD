using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace BoletaSimulator {
    class Entidad {
        public string nombre;
        public int hp, atq, def, vel, lvl;
    }

    class Jugador : Entidad {
        private readonly Random random = new Random();

        public Jugador(string nombre) {
            this.nombre = nombre;
            this.lvl = 1;
            this.hp = 100;
            this.atq = 10;
            this.def = 5;
            this.vel = 10;
        }
    }

    class Menu {

        public void mostrarEspacios(int numeroDeEspacios) {
            for (int i = 0; i < numeroDeEspacios; i++) {
                Console.WriteLine("\n");
            }
        }

        public void mostrarMenuSuperior(Jugador jugador) {
            Console.WriteLine(jugador.nombre + " | Nivel " + jugador.lvl + "\n" +
                              "Vida: " + jugador.hp + "\n" +
                              "Ataque: " + jugador.atq + "\n" +
                              "Defensa: " + jugador.def + "\n" +
                              "Velocidad: " + jugador.vel + "\n");
        }
        public void mostrarMenuInferior() {
            Console.WriteLine("+------------------------------------------+\n" +
                              "| 1.Atacar                                 |\n" +
                              "| 2.Usar Objeto                            |\n" +
                              "| 3.Rendirse (salir)                       |\n" +
                              "+------------------------------------------+\n");
            Console.Write("Tu opcion: ");
        }
    }


    class Program {
        static void Main(string[] args) {
            bool jugando = false;

            // INTRODUCCION
            Console.Clear();
            Console.WriteLine("Bienvenido a BOLETAS VS BRUJAS \nPresiona cualquier tecla para empezar");
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
            Console.WriteLine("\n" + jugador.nombre + " es que ...? mosca no vayas a quedar como la propia loca \nPresiona para continuar");
            Console.ReadKey();

            Menu menu = new Menu();
            // JUEGO COMO TAL
            while (jugando) {
                Console.Clear();
                menu.mostrarMenuSuperior(jugador);
                menu.mostrarEspacios(5);
                menu.mostrarMenuInferior();
                 opcion = Console.ReadKey();
                 if (opcion.KeyChar == '3') {
                    break;
                 }
            }
        }
    }
}