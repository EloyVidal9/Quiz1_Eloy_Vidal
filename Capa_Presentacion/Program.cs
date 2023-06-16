using Capa_Logica.Lista_Simple;

OrquestadorInt orquestadorint = new OrquestadorInt();

orquestadorint.Agregar_NodoInt(1);
orquestadorint.Agregar_NodoInt(2);
orquestadorint.Agregar_NodoInt(3);
orquestadorint.Agregar_NodoInt(4);
orquestadorint.Agregar_NodoInt(5);


orquestadorint.Mostrar_Lista_Simple();
orquestadorint.Encontrar_Borrar(1,6);
orquestadorint.Mostrar_Lista_Simple();