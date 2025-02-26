#include "Listas.h"

namespace seleccionDeEquipos
{
    // Lista circular
    ListaCircular::ListaCircular()
    {
        cabeza = nullptr;
        tamano = 0;
    }

    bool ListaCircular::estaVacia()
    {
        return (tamano == 0);
    }

    int ListaCircular::getTamano()
    {
        return tamano;
    }

    void ListaCircular::insertarPersona(Persona* persona)
    {
        NodoSimple* nuevoNodo = new NodoSimple(persona);
        if (estaVacia())
        {
            cabeza = nuevoNodo;
            cabeza->setSiguiente(cabeza);
        }
        else
        {
            NodoSimple* nodoActual = cabeza;
            while (nodoActual->getSiguiente() != cabeza)
            {
                nodoActual = nodoActual->getSiguiente();
            }
            nodoActual->setSiguiente(nuevoNodo);
            nuevoNodo->setSiguiente(cabeza);
        }
        tamano++;
    }

    void ListaCircular::eliminarPersona(Persona* persona)
    {
        if (!estaVacia())
        {
            // comenzamos uno despues de la cabeza para siempre tener un anterior
            NodoSimple* nodoActual = cabeza->getSiguiente();
            NodoSimple* nodoAnterior = cabeza;

            // si el nodo es el unico de la lista
            if ((nodoActual == nodoAnterior) && (nodoActual->getPersona() == persona))
            {
                cabeza == nullptr;
                delete(nodoActual);
                tamano--;
                return;
            }

			// recorrer la lista hasta encontrar el nodo o regresar a la cabeza
            do
            {
                nodoAnterior = nodoActual;
                nodoActual = nodoActual->getSiguiente();
            } 
            while ((nodoActual->getPersona() != persona) && (nodoActual != cabeza->getSiguiente()));

            if (nodoActual->getPersona() == persona)
            {
                nodoAnterior->setSiguiente(nodoActual->getSiguiente());
                if (nodoActual == cabeza)
                {
                    cabeza = nodoActual->getSiguiente();
                }
                delete(nodoActual);
                tamano--;
            }
            else
            {
				cout << "Persona no encontrada" << endl;
            }
        }
    }

    void ListaCircular::mostrarLista()
    {
		if (estaVacia())
		{
			cout << "Lista vacia" << endl;
			return;
		}

        NodoSimple* nodoActual = cabeza;

        cout << "...->";
        
        while (nodoActual->getSiguiente() != cabeza)
        {
            cout << "(" << nodoActual->getPersona()->GetDatosStr() << ")-->";
			nodoActual = nodoActual->getSiguiente();
        }
        cout << "(" << nodoActual->getPersona()->GetDatosStr() << ")-...\n" << endl;
    }

    Persona* ListaCircular::recorrerLista(int posicionInicio, int avances)
    {
        // avanzar desde la cabeza posicionInicio veces y tomar el nodo avances veces desde esa posicion
		NodoSimple* nodoPartida = cabeza;
        for (int i = 0; i < posicionInicio; i++)
        {
			nodoPartida = nodoPartida->getSiguiente();
        }

        NodoSimple* nodoSeleccionado = nodoPartida;
		for (int i = 0; i < avances; i++)
		{
			nodoSeleccionado = nodoSeleccionado->getSiguiente();
		}
		
        return nodoSeleccionado->getPersona();
    }


    // Lista Doble
    ListaDobleEnlazada::ListaDobleEnlazada()
    {
        cabeza = nullptr;
        tamano = 0;
    }

    bool ListaDobleEnlazada::estaVacia()
    {
        return (tamano == 0);
    }

    int ListaDobleEnlazada::getTamano()
    {
        return tamano;
    }

    void ListaDobleEnlazada::insertarPersona(Persona* persona)
    {
        NodoDoble* nuevoNodo = new NodoDoble(persona);

        if (estaVacia())
        {
            cabeza = nuevoNodo;
            cabeza->setSiguiente(nullptr);
            cabeza->setAnterior(nullptr);
            tamano++;
        }
        else
        {
            NodoDoble* nodoActual = cabeza;

            while (nodoActual->getSiguiente() != nullptr)
            {
                nodoActual = nodoActual->getSiguiente();
            }
            nodoActual->setSiguiente(nuevoNodo);
            nuevoNodo->setAnterior(nodoActual);
            nuevoNodo->setSiguiente(nullptr);
			tamano++;
        }
    }

    void ListaDobleEnlazada::eliminarPersona(Persona* persona)
    {
        if (!estaVacia())
        {
            NodoDoble* nodoActual = cabeza;

            // si es el unico elemento de la lista
            if ((nodoActual->getAnterior() == nullptr) && (nodoActual->getSiguiente() == nullptr) && (nodoActual->getPersona() == persona))
            {
                delete(nodoActual);
                tamano--;
                return;
            }

            // si es el primer elemento
            if ((nodoActual->getAnterior() == nullptr) && (nodoActual->getPersona() == persona))
            {
                cabeza = nodoActual->getSiguiente();
                cabeza->setAnterior(nullptr);
                delete (nodoActual);
                tamano--;
                return;
            }

            // recorrer la lista buscando
            while (nodoActual != nullptr && nodoActual->getPersona() != persona)
            {
                nodoActual = nodoActual->getSiguiente();
            }

            // si es el ultimo
            if ((nodoActual->getSiguiente() == nullptr) && (nodoActual->getPersona() == persona))
            {
                nodoActual->getAnterior()->setSiguiente(nullptr);
                delete (nodoActual);
                tamano--;
                return;
            }

            // si es cualquier otro elemento o no esta
            if (nodoActual->getPersona() == persona)
            {
                nodoActual->getAnterior()->setSiguiente(nodoActual->getSiguiente());
                nodoActual->getSiguiente()->setAnterior(nodoActual->getAnterior());
                delete (nodoActual);
                tamano--;
            }
            else
            {
                cout << "Persona no encontrada" << endl;
            }
        }
    }

    void ListaDobleEnlazada::mostrarLista()
    {
        if (estaVacia())
        {
            cout << "Lista vacia" << endl;
            return;
        }

        NodoDoble* nodoActual = cabeza;

        cout << "null <--";

        while (nodoActual->getSiguiente() != nullptr)
        {
            cout << "(" << nodoActual->getPersona()->GetDatosStr() << ")<-->";
            nodoActual = nodoActual->getSiguiente();
        }
        cout << "(" << nodoActual->getPersona()->GetDatosStr() << ")--> null\n" << endl;
    }

    void ListaDobleEnlazada::ordenarPorEdadAsc()
    {
        if (estaVacia() || cabeza->getSiguiente() == nullptr)
        {
            return;
        }

        NodoDoble* nodoActual = cabeza->getSiguiente();

        // insertion sort
        while (nodoActual != nullptr)
        {
            NodoDoble* nodoComparado = nodoActual;
            NodoDoble* nodoAnterior = nodoActual->getAnterior();

            while (nodoAnterior != nullptr && nodoComparado->getPersona()->getEdad() < nodoAnterior->getPersona()->getEdad())
            {
                // intercambiar de lugar las personas (no los nodos)
                Persona* tempPersona = nodoComparado->getPersona();
                nodoComparado->setPersona(nodoAnterior->getPersona());
                nodoAnterior->setPersona(tempPersona);

                nodoComparado = nodoAnterior;
                nodoAnterior = nodoAnterior->getAnterior();
            }

            nodoActual = nodoActual->getSiguiente();
        }
    }

}
