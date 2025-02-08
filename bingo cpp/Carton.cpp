#include <iostream>
#include <string>
#include <cstdlib>
#include <ctime>
using namespace std;

// Follow the steps below to use this file

// 1. In main file add the following include 
// #include "NewFile1.cpp"

// 2. Add the following in the code
// sayHelloFromNewFile1();

class Carton
{
    const FILAS = 3;
    const COLUMNAS = 5;
    
    private:
        string propietario;
        int numeros[FILAS][COLUMNAS];
        bool numerosTachados[FILAS][COLUMNAS];
        float apuesta;
        bool linea;
        bool bingo;
        
        bool NumeroRepetido(int numero, int carton[FILAS][COLUMNAS])
        {
            for(i = 0; i < 3; i++)
            {
                for(j = 0; j < 5; j++)
                {
                   if(numero == carton[i][j])
                      return true;
                }
            }
            return false;
        }
        
        void LlenarCarton()
        {
            int numeroActual;
            for(i = 0; i < FILAS; i++)
            {
                for(j = 0; j < COLUMNAS; j++)
                {
                    do 
                    {
                      numeroActual = rand() % 80 +1;
                    }
                    while(NumeroRepetido(numeroActual, numeros) == true);
                    
                    numeros[i][j] = numeroActual;
                    numerosTachados[i][j] = false;
                }
            }
        }
        
    public:
        // constructor
        Carton(string _propietario, float _apuesta)
        {
            propietario = _propietario;
            apuesta = _apuesta;
            linea = false;
            bingo = false;
            LlenarCarton();
            cantidadTachados = 0;
        }
        
        void MostrarCarton() 
        {
            for(i = 0; i < FILAS; i++)
            {
                for(j = 0; j < COLUMNAS; j++)
                {
                    if (numeros[i][j] > 10)
                        cout << "[" << numeros[i][j] << "]";
                    else 
                        cout <<"[" << numeros[i][j] << " ]";
                }
                cout << endl;
            }
        }
        
        // setters
        void SetPropietario(string nombre) 
        {
            propietario = nombre;
        }
        void SetApuesta(float cantidad)
        {
            apuesta = cantidad;
        }
        
        // getters
        string GetPropietario()
        {
            return propietario;
        }
        float GetApuesta()
        {
          return apuesta;
        }
        
        // funcionalidad
        void MarcarCarton(numeroCantado)
        {
            
            for(i = 0; i < FILAS; i++)
            {
                for(j = 0; j < COLUMNAS; j++)
                {
                    if (numeros[i][j] == numeroCantado)
                        numerosTachados[i][j] = true;
                }
            } 
        }
        
        bool VerificarGanador()
        {
            // Verificar bingo
            int cantidadTachados = 0;
            for(i = 0; i < FILAS; i++)
            {
                for(j = 0; j < COLUMNAS; j++)
                {
                    if (numerosTachados[i][j] == true)
                    {
                        cantidadTachados++;
                    }
                }
            }
            
            if (cantidadTachados == (FILAS * COLUMNAS))
            {
                return true;
            }
            
            // verificar linea (horizontal)
            for (i = 0; i < FILAS; i++)
            {
                int tachadosHorizontal = 0;
                for (j = 0; j < COLUMNAS; j++)
                {
                    if (numerosTachados[i][j] == true)
                    {
                        tachadosHorizontal++;
                    }
                }
                
                if (tachadosHorizontal == COLUMNAS && linea == false)
                {
                    cout << "Linea! " << propietario << endl;
                    Linea == true;
                    
                }
            }
        }
        
}


/* cstdlib, ctime
 numero al azar = std::rand() % 80 +1 */
