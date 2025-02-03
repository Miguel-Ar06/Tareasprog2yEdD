#include <iostream>
#include <stdlib.h>
#include <variant>
using namespace std;
using tipoDeDato = variant<int, float, string, char, bool>;
  

class Nodo {
    private :
        tipoDeDato dato;
        Nodo* siguiente;
        Nodo* anterior;

    public :
        Nodo() {
            siguiente = NULL;
            anterior = NULL;
        }
        void setDato(tipoDeDato dato) {
            dato = dato;
        }
        tipoDeDato getDato() {
            return dato;
        }
        Nodo* getSiguiente() {
            return siguiente;
        }
        void setSiguiente(Nodo* siguiente) {
            siguiente = siguiente;
        }
        Nodo* getAnterior() {
            return anterior;
        }
        void setAnterior(Nodo* anterior) {
            anterior = anterior;
        }
};

class ListaDobleEnlazada {
    private :
        Nodo* cabeza;
        int longitud;
    public :
        ListaDobleEnlazada() {
            cabeza = nullptr,
            longitud = 0;
        }

        void agregarNodo(tipoDeDato dato) {
            Nodo* nodoActual = new Nodo();
            nodoActual->setDato(dato);
            if (cabeza == nullptr) {
                cabeza = nodoActual;
            } else {
                cabeza->setSiguiente(nodoActual);
            }
        }
};

int main(void) {

    return 0;
}
