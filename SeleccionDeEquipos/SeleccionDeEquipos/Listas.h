#pragma once
#include <iostream>
#include <stdlib.h>
#include <string>
#include "Nodos.h"
using namespace std;
using namespace seleccionDeEquipos;

namespace seleccionDeEquipos
{
    class ListaCircular
    {
        private:
            NodoSimple* cabeza;
            int tamano;

        public:
            ListaCircular();
            void insertarPersona(Persona* _persona);
            void eliminarPersona(Persona* _persona);
            int getTamano();
            bool estaVacia();
            void mostrarLista();
			Persona* recorrerLista(int inicio, int objetivo);
    };

    class ListaDobleEnlazada
    {
        private:
            NodoDoble* cabeza;
            int tamano;

        public:
            ListaDobleEnlazada();
            void insertarPersona(Persona* _persona);
            void eliminarPersona(Persona* _persona);
            int getTamano();
            bool estaVacia();
            void mostrarLista();
            void ordenarPorEdadAsc();
            void limpiarLista();
    };
}

