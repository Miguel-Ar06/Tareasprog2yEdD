#pragma once
#include <iostream>
#include <stdlib.h>
#include "persona.h"
using namespace std;

namespace seleccionEquipos
{
    class NodoSimple
    {
        private:
            Persona* persona;
            NodoSimple *siguiente;
    };

    class NodoDoble
    {
        private:
            Persona* persona;
            NodoDoble *siguiente;
            NodoDoble *anterior;
    };
}
