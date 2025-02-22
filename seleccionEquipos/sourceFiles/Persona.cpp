#pragma once
#include "Persona.h"

namespace seleccionEquipos {
    Persona::Persona(string _nombre, int _edad)
    {
        nombre = _nombre;
        edad = _edad;
    }

    // getters
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

    void Persona::mostrarDatos()
    {
        cout << "Nombre: " << nombre << endl;
        cout << "Edad: " << edad << endl;
    }
}