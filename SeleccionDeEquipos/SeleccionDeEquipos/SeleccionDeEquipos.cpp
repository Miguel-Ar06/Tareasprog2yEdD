#include <iostream>
#include <stdlib.h>
#include <string>
#include <random>
#include "Listas.h"
#include "Menu.h"
using namespace std;
using namespace seleccionDeEquipos;


int main()
{
	Menu::mostrarBienvenida();
	int cantidadPersonas = Menu::solicitarCantidadPersonas();

	ListaCircular listaPersonas;
	ListaDobleEnlazada equipo1;
	ListaDobleEnlazada equipo2;

	for (int personaActual = 0; personaActual < cantidadPersonas; personaActual++)
	{
		Persona* persona = Menu::pedirDatosPersona(personaActual + 1);
		listaPersonas.insertarPersona(persona);
	}

	Menu::limpiarConsola();
	cout << "Personas:" << endl;
	listaPersonas.mostrarLista();

	// Cosas necesarias para el randomizador segun la documentacion
	random_device randomizador;
	mt19937 gen(randomizador());
	uniform_int_distribution<> distribucion(1, 6);

	int opcion;
	int turno = 1;

	do
	{
		opcion = Menu::solicitarOpcionMenu();

		switch (opcion)
		{
			case 1:
				Menu::limpiarConsola();
				cout << "Equipo 1:" << endl;
				equipo1.ordenarPorEdadAsc();
				equipo1.mostrarLista();
				break;
			case 2:
				Menu::limpiarConsola();
				cout << "Equipo 2:" << endl;
				equipo2.ordenarPorEdadAsc();
				equipo2.mostrarLista();
				break;
			case 3:
				Menu::limpiarConsola();
				cout << "Personas restantes:" << endl;
				listaPersonas.mostrarLista();
				break;
			case 4:
				if (listaPersonas.estaVacia())
				{
					Menu::limpiarConsola();
					cout << "No hay personas restantes\n" << endl;
					cout << "Equipo 1:" << endl;
					equipo1.mostrarLista();
					cout << "Equipo 2:" << endl;
					equipo2.mostrarLista();
					cout << endl;
					break;
				}

				// tirar dado hasta que sea una edad valida

				int intentos = 0;
				int edad;
				Persona* personaPorEliminar;
				do
				{
					int numeroDelDado = distribucion(gen);
					Menu::limpiarConsola();
					cout << "El dado cayo en: " << numeroDelDado << endl;
					personaPorEliminar = listaPersonas.recorrerLista(intentos, numeroDelDado);
					edad = personaPorEliminar->getEdad();
					intentos++;

				} while ((((edad <= 20) && ((turno % 2) == 0)) || ((edad > 20) && ((turno % 2) == 1))) && intentos != listaPersonas.getTamano());

				cout << "intentos (partiendo de la cabeza): " << intentos << endl;
				cout << "Lista antes del cambio: " << endl;
				listaPersonas.mostrarLista();
				cout << endl;

				if (turno % 2 == 1)
				{
					equipo1.insertarPersona(personaPorEliminar);
					listaPersonas.eliminarPersona(personaPorEliminar);
					cout << "Se ha agregado a " << personaPorEliminar->getNombre() << " al equipo 1" << endl;
					equipo1.ordenarPorEdadAsc();
					equipo1.mostrarLista();
				}
				else
				{
					equipo2.insertarPersona(personaPorEliminar);
					listaPersonas.eliminarPersona(personaPorEliminar);
					cout << "Se ha agregado a " << personaPorEliminar->getNombre() << " al equipo 2" << endl;
					equipo2.ordenarPorEdadAsc();
					equipo2.mostrarLista();
				}

				turno++;
				break;
		}
	}
	while (opcion != 0);

	Menu::limpiarConsola();
	equipo1.limpiarLista();
	equipo2.limpiarLista();
	cout << "Presion enter para salir" << endl;
	cin.get();

	Menu::mostrarMensajeDespedida();
}