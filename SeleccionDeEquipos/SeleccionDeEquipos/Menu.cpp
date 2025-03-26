#include "Menu.h"

namespace seleccionDeEquipos
{
	void Menu::limpiarConsola()
	{
		system("cls");
	}

	void Menu::mostrarBienvenida()
	{
		cout << "---------------------------------------------------------------" << endl;
		cout << "| Bienvenido a la seleccion de equipos mas azarosa de tu vida |" << endl;
		cout << "|             Presiona enter para continuar                   |" << endl;
		cout << "---------------------------------------------------------------" << endl;
		cin.get();
		limpiarConsola();
	}

	int Menu::solicitarOpcionMenu()
	{
		string entrada;
		int opcion;

		do
		{
			cout << "---------------------------------------------------------------" << endl;
			cout << "| Que desea hacer?                                            |" << endl;
			cout << "| 1. Ver equipo 1                                             |" << endl;
			cout << "| 2. Ver equipo 2                                             |" << endl;
			cout << "| 3. Ver personas restantes                                   |" << endl;
			cout << "| 4. Tirar dado                                               |" << endl;
			cout << "| 0. salir                                                    |" << endl;
			cout << "---------------------------------------------------------------" << endl;
			cout << "Opcion: ";

			cin >> entrada;
			cin.ignore();

			// validar opcion y convertirlo a int
			try
			{
				opcion = stoi(entrada);
			}
			catch (exception e)
			{
				opcion = -1;
			}

			if (opcion < 0 || opcion > 4)
			{
				limpiarConsola();
				cout << "Opcion invalida" << endl;
			}

		} while (opcion < 0 || opcion > 4);

		return opcion;
	}

	int Menu::solicitarCantidadPersonas()
	{
		string entrada;
		int cantidad;

		do
		{
			cout << "---------------------------------------------------------------" << endl;
			cout << "| Ingrese la cantidad de personas que desea agregar:          |" << endl;
			cout << "---------------------------------------------------------------" << endl;
			cout << "Cantidad: ";
			cin >> entrada;
			cin.ignore();

			// validar cantidad y convertirla a int
			try
			{
				cantidad = stoi(entrada);
			}
			catch (exception e)
			{
				cantidad = -1;
			}
			if (cantidad < 1)
			{
				limpiarConsola();
				cout << "Cantidad invalida" << endl;
			}

		} while (cantidad < 1);

		return cantidad;
	}

	void Menu::mostrarMensajeDespedida()
	{
		limpiarConsola();
		cout << "---------------------------------------------------------------" << endl;
		cout << "|            Este programa fue traido a usted gracias a:      |" << endl;
		cout << "|                    - Achipano Fly Better -                  |" << endl;
		cout << "| Miguel Arismendi                                            |" << endl;
		cout << "| Sergio Rojas                                                |" << endl;
		cout << "---------------------------------------------------------------" << endl;
		cin.get();
	}

	Persona* Menu::pedirDatosPersona(int n)
	{
		string nombre;
		string entrada;
		int edad;
		Persona* persona;

		limpiarConsola();
		cout << "Persona " << n << endl;
		cout << "| Ingrese el nombre de la persona: ";
		getline(cin, nombre);

		do
		{
			cout << "| Ingrese la edad de la persona: ";
			cin >> entrada;
			cin.ignore();

			try
			{
				edad = stoi(entrada);
			}
			catch (exception e)
			{
				edad = -1;
			}

			if (edad < 15)
			{
				limpiarConsola();
				cout << "Edad invalida, ingrese una edad mayor o igual a 15" << endl;
			}
		} while (edad < 15);
		persona = new Persona(nombre, edad);

		return persona;
	}
}