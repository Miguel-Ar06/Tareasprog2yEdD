#pragma once
#include <iostream>
#include <stdlib.h>
#include "persona.h"
using namespace std;

namespace seleccionDeEquipos
{
    class NodoSimple
    {
        private:
            Persona* persona;
            NodoSimple* siguiente;

        public:
            NodoSimple(Persona* _persona);
            Persona* getPersona();
            NodoSimple* getSiguiente();
            void setSiguiente(NodoSimple* _siguiente);
            void setPersona(Persona* _persona);
    };

    class NodoDoble
    {
        private:
            Persona* persona;
            NodoDoble* siguiente;
            NodoDoble* anterior;

        public:
            NodoDoble(Persona* _persona);
            Persona* getPersona();
            NodoDoble* getSiguiente();
            NodoDoble* getAnterior();
            void setSiguiente(NodoDoble* _siguiente);
            void setAnterior(NodoDoble* _anterior);
            void setPersona(Persona* _persona);
    };
}

