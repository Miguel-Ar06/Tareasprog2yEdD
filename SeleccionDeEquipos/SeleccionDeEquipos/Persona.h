#pragma once
#include <iostream>
#include <stdlib.h>
#include <string>
using namespace std;

namespace seleccionDeEquipos {
    class Persona {
        private:
            string nombre;
            int edad;
        public:
            Persona(string nombre, int edad);
            string getNombre();
            int getEdad();
            void setNombre(string nombre);
            void setEdad(int edad);
            string GetDatosStr();
    };
}
