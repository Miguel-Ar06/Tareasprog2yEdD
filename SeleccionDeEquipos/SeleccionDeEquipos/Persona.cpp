#include "Persona.h"

namespace seleccionDeEquipos {
    Persona::Persona(string _nombre, int _edad)
    {
        nombre = _nombre;
        edad = _edad;
    }

    // getters y setters
    string Persona::getNombre()
    {
        return nombre;
    }

    int Persona::getEdad()
    {
        return edad;
    }

    void Persona::setNombre(string _nombre)
    {
        nombre = _nombre;
    }

    void Persona::setEdad(int _edad)
    {
        edad = _edad;
    }

    string Persona::GetDatosStr()
    {
        return (nombre + ", " + to_string(edad));
    }
}
