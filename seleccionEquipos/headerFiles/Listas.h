#pragma once
#include <iostream>
#include <stdlib.h>
#include <string>
#include "Nodos.h"
using namespace std;

namespace seleccionEquipos
{
    class ListaDobleEnlazada
    {
        private:
            NodoDoble* cabeza;
            int tamano;
        
        public:
            ListaDobleEnlazada();
            void insertarPersona(Persona* _persona);
            void eliminarPersona(string _nombre);
            void eliminarPersona(int _posicion);
            int getTamano();
            void mostrarLista();
    };

    class ListaCircular
    {
        private:
            NodoSimple* cabeza;
            int tamano;
        
        public:
            ListaCircular();
            void insertarPersona(Persona* _persona);
            void eliminarPersona(string _nombre);
            void eliminarPersona(int _posicion);
            int getTamano();
            void mostrarLista();
    };
}