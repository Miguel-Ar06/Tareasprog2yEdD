#pragma once
#include "Nodos.h"

namespace seleccionEquipos
{
    // Nodo simple
    // Constructor
    NodoSimple::NodoSimple(Persona* _persona)
    {
        persona = _persona;
        siguiente = nullptr;
    }

    // getters y setter
    Persona* NodoSimple::getPersona()
    {
        return persona;
    }
    NodoSimple* NodoSimple::getSiguiente()
    {
        return siguiente;
    }
    void NodoSimple::setSiguiente(NodoSimple* _siguiente)
    {
        siguiente = _siguiente;
    }
    void NodoSimple::setPersona(Persona* _persona)
    {
        persona = _persona;
    }

    //Nodo doble
    // Constructor
    NodoDoble::NodoDoble(Persona* _persona)
    {
        persona = _persona;
        siguiente = NULL;
        anterior = nullptr;
    }

    // getters y setter
    Persona* NodoDoble::getPersona()
    {
        return persona;
    }
    NodoDoble* NodoDoble::getSiguiente()
    {
        return siguiente;
    }
    NodoDoble* NodoDoble::getAnterior()
    {
        return anterior;
    }
    void NodoDoble::setSiguiente(NodoDoble* _siguiente)
    {
        siguiente = _siguiente;
    }
    void NodoDoble::setAnterior(NodoDoble* _anterior)
    {
        anterior = _anterior;
    }
    void NodoDoble::setPersona(Persona* _persona)
    {
        persona = _persona;
    }
}