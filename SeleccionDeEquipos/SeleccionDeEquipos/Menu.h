#pragma once
#include <iostream>
#include <stdlib.h>
#include <string>
#include <cstdlib>
#include "Persona.h"
using namespace seleccionDeEquipos;
using namespace std;

namespace seleccionDeEquipos
{
	class Menu
	{
	public:
		static void limpiarConsola();
		static void mostrarBienvenida();
		static int solicitarOpcionMenu();
		static int solicitarCantidadPersonas();
		static void mostrarMensajeDespedida();
		static Persona* pedirDatosPersona(int n);
	};
}
