using Capa_Modelo.Nodos;

namespace Capa_Logica.Lista_Simple; 

public class OrquestadorInt{

        private NodoInt cabeza;

        public void Agregar_NodoInt(int valor) {

            NodoInt nodoNuevo = new NodoInt(valor);

            if (cabeza == null)
            {
                cabeza = nodoNuevo;
            }
            else {

                NodoInt nodoActual = cabeza;

                while (nodoActual.Siguiente != null) {
                    nodoActual = nodoActual.Siguiente;
                }

                nodoActual.Siguiente = nodoNuevo;
            }
        }

        public void Mostrar_Lista_Simple() {

            NodoInt nodoActual = cabeza;

            if (Cabeza_No_Nula())
            {
                Console.WriteLine("Empieza Lista");
                while (nodoActual != null)
                {
                    int valorActual = nodoActual.Valor;
                    Console.WriteLine(valorActual.ToString());
                    nodoActual = nodoActual.Siguiente;
                }
                Console.WriteLine("Termina Lista");
            }
        }

        public bool Cabeza_No_Nula(){
            return cabeza != null? true : false;
        }

        public void Elimine_Nodo_Cabeza() {

            if (Cabeza_No_Nula())
            {
                NodoInt nodoActual = cabeza;
                NodoInt aux = cabeza;
                nodoActual = nodoActual.Siguiente;
                aux = null;
                cabeza = nodoActual;
            } }

        public void Encontrar_Borrar(int enconctrar, int borrar){

            int posicion = enconctrar;
            int cola = borrar; 
            int cont = 1; 

            NodoInt nodoActual = cabeza;


            if(Cabeza_No_Nula()){

                if(nodoActual.Siguiente == null){
                    if (cola > 0){
                        Elimine_Nodo_Cabeza();
                        System.Console.WriteLine("No hay nodos que mostrar");
                    } 
                }

                while(cont < posicion ){

                    nodoActual = nodoActual.Siguiente;
                    cont++;

                }

                    System.Console.WriteLine(cont);

                    NodoInt aux = nodoActual;

                cont = 0; 

                while(cont <= cola){

                    if(nodoActual==null){
                        break;
                    }

                    nodoActual = nodoActual.Siguiente;
                    cont++;
                }

                aux.Siguiente = nodoActual;

            }

        }

}