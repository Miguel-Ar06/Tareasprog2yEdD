﻿using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using BoletaSimulator;

namespace BoletaSimulator {
    class Entidad {
        protected static readonly Random _probabilidad = new Random();
        public string nombre;
        public int hp, atq, def, vel, lvl;

        public virtual void Reiniciar() {
            
        }
    }

    class Jugador : Entidad {

        public int xp = 0;
        private int curacion = 2;
        public int curacionCantidad = 6;
        public Jugador(string nombre) {
            this.nombre = nombre;
            this.lvl = 1;
            this.hp = 100;
            this.atq = 10;
            this.def = 5;
            this.vel = 10;
        }

        public override void Reiniciar() {
            this.lvl = 1;
            this.hp = 100;
            this.atq = 10;
            this.def = 5;
            this.vel = 10;
            this.curacion = 2;
            this.curacionCantidad = 6;
        }

        public void ActualizarJugador() {
            if(xp == 20) {
                Console.WriteLine("Vacilatela menor, subiste de nivel. \nPresiona enter para continuar");
                Console.ReadKey();
                this.lvl += 1;
                this.hp += 10;
                this.atq += 5;
                this.def += 2;
                this.vel += 2;
                this.xp = 0;
                this.curacion += 1;
            }
        }

        public int Atacar() {
            if (_probabilidad.Next(0,1+1) == 1) {
                Console.WriteLine("\nBurde criminal, tu ataque es efectivo mano. Le metiste " + this.atq + " de daño bien carteluo \nPresiona enter para continuar");
                Console.ReadKey();
                return this.atq;
            }
            Console.WriteLine("\nAh no vale picale una torta, fallaste. \nPresiona enter para continuar");
            Console.ReadKey();
            return 0;
        }

        public void Curarse() {
            if (curacionCantidad > 0) {
                Console.WriteLine("\nActivo mano, te curaste " + curacion + " de vida sabroso");
                curacionCantidad--;
                this.hp += this.curacion;
                Console.ReadKey();
            } else {
                Console.WriteLine("\nNo mano tu estas pelando");
                Console.ReadKey();
            }
        }
    }

    class Enemigo : Entidad {

        int defaultHp;

        public Enemigo(string nombre, int lvl, int hp, int atq, int def, int vel) {
            this.nombre = nombre;
            this.lvl = lvl;
            this.hp = hp;
            this.atq = atq;
            this.def = def;
            this.vel = vel;
            this.defaultHp = hp;
        }


        public override void Reiniciar() {
            this.hp = this.defaultHp;
        }

        public int Atacar() {
            if (_probabilidad.Next(0,1+1) == 1) {
                Console.WriteLine("\n" + this.nombre + " te lanza una pocion nociva causandote " + this.atq + " de daño, te vas a dejar?\nPresiona para continuar");
                Console.ReadKey();
                return this.atq;
            }
            Console.WriteLine("\nEl ataque enemigo ha fallado como la propia jeva. \nPresiona enter para continuar");
            Console.ReadKey();
            return 0;
        }    
    }

    class Menu {

        public static void MostrarEspacios(int numeroDeEspacios) {
            for (int i = 0; i < numeroDeEspacios; i++) {
                Console.WriteLine("\n");
            }
        }

        public static void MostrarMenuSuperior(Jugador jugador, Enemigo enemigo) {
            Console.WriteLine(jugador.nombre + " / lvl." + jugador.lvl + " / hp " + jugador.hp + " / atq " + jugador.atq + " / def " + jugador.def + "|| Xp (" + jugador.xp +"/20)" +"\n" +
                              enemigo.nombre + " / lvl." + enemigo.lvl + " / hp " + enemigo.hp + " / atq " + enemigo.atq + " / def " + enemigo.def);
        }
        public static void MostrarMenuInferior(Jugador jugador) {
            Console.WriteLine("+------------------------------------------+\n" +
                              "| 1.Atacar                                 |\n" +
                              "| 2.Cartujo (x"+jugador.curacionCantidad+")"+"                           |\n" +
                              "| 3.Rendirse (salir)                       |\n" +
                              "+------------------------------------------+\n");
        }
    }


    class Program {

        static void Main(string[] args) {

            bool jugando = false;

            Console.Clear();
            Console.WriteLine("Bienvenido a BOLETA SIMULATOR. \n-El juego de cazar brujas favorito de los barrios- \nPresiona cualquier tecla para empezar");
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
            Console.Write("Tirale vista chamito, como es que tu te llamas?: ");
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
            int brujasEliminadas = 0;
            while (jugando) {

                jugador.ActualizarJugador();
                Enemigo enemigoActual = enemigos[random.Next(0,2+1)]; //pasar al siguiente enemigo

                // turnos
                int turno = 1;
                while ((enemigoActual.hp > 0) && (jugador.hp > 0)) {
                    Console.Clear();
                    Menu.MostrarMenuSuperior(jugador, enemigoActual);
                    Console.WriteLine("[ Ronda " + ronda + " ]\n[ Brujas eliminadas: " + brujasEliminadas + " ]");
                    Menu.MostrarEspacios(1);
                    Menu.MostrarMenuInferior(jugador);

                    if ((turno % 2) == 1) {
                        Console.Write("Tu opcion: ");
                        opcion = Console.ReadKey();
                            switch (opcion.KeyChar) {
                                case '3':
                                    Console.WriteLine("\nAyyy se le aguo el guarapo.") ;
                                    return;
                                    break;
                                case '1' : 
                                    enemigoActual.hp -= jugador.Atacar();
                                    break;
                                case '2' :
                                    jugador.Curarse();
                                    break;
                                default :
                                    Console.WriteLine("\nEscoge una opcion valida gafo");
                                    Console.ReadKey();
                                    break;
                            }
                    } else { // Turno del cpu
                        jugador.hp -= enemigoActual.Atacar();
                    }
                    turno++;
                }

                if (jugador.hp <= 0) {
                        Console.WriteLine("Mala tuya mano, te falto calle\nQuieres darle otra vez o te freseas?\n1.Si\n(otra tecla).Me freseo");
                        opcion = Console.ReadKey();
                        if (opcion.KeyChar == '1') {
                            jugador.Reiniciar();
                            ronda = 1;
                            turno = 1;
                            brujasEliminadas = 0;
                            enemigoActual.Reiniciar();
                            
                        } else {
                            Console.WriteLine("La propia jeva mano...");
                            return;
                        }
                    } else {
                        Console.WriteLine("\nDemasiado lacreo, la bruja se ha desmayado\nLe desvalijaste 5xp y un cartujo mano\nRonda siguiente (Enter)");
                        jugador.xp += 5;
                        brujasEliminadas++;
                        jugador.curacionCantidad++;
                        enemigoActual.Reiniciar();
                        Console.ReadKey();
                    }
                ronda++;
            }
        }
    }
}
