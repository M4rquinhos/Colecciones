////////////////////////////////////////////////////////////////////////////////////////////////
///listas

string[] persona = { "Juan Manuel Garcia", "Felipe", "Maria", "Jose" };


List<string> ListaPersonas = new List<string>();


// Agregar data al List desde un array string[]
ListaPersonas.AddRange(persona);


// Agregar un elemento a la lista 
ListaPersonas.Add("Alondra");
ListaPersonas.Add("David");
ListaPersonas.Add("Vanesa");

// Contar elementos de una lista
Console.WriteLine($"La lista contiene esta cantidad de elementos {ListaPersonas.Count}");


// Consultar un elementos de una lista
Console.WriteLine($"Imprime el primer elemento de la lista {ListaPersonas[0]}");

// Elimina un elemento de la lista
ListaPersonas.RemoveAt(3);
ListaPersonas.Remove("Maria");

// Ordenando alfabeticamente la lista
ListaPersonas.Sort();

// Creacion de un metodo para imprimir todos los elementos de una lista
ImprimirLista(ListaPersonas);
void ImprimirLista(List<string> lista)
{
    foreach (var item in lista)
    {
        Console.WriteLine($"{item}");
    }
}

// Saber si existe algun elemento en la lista
Console.WriteLine($"Existe Felipe en la lista {ListaPersonas.Contains("Felipe")}");

//  Busque aquellos nombres en la lista que tengan mas de 10 caracteres
var resultado = ListaPersonas.Exists(x => x.Length >= 10);
Console.WriteLine($"Existe un nombre de mas de 10 caracteres: {resultado}");

BuscarNombres(ListaPersonas);
void BuscarNombres(List<string> lista)
{
    foreach (var item in lista)
    {
        if (item.Length >= 10)
            Console.WriteLine($"Este nombre contiene mas de 10 caracteres: {item}");
    }
}

//  Buscar un nombre que comience con la letra V
var elementoConV = ListaPersonas.Find(x => x.StartsWith("V"));
Console.WriteLine(elementoConV);

///////////////////////////////////////////////////////////////////////////////////////////////////////////
///LinkedLits
///

Console.WriteLine("///////////////////lINKEDLISTS////////////////////////////////");

string[] canciones = {
    "El Drip",
    "El azul",
    "El tsurito",
    "Se amerita",
    "Ando enfocado",
    "los botones azules",
    "El de la codeina",
    "Igualito a mi apa"
};

// Creando LinkedList
LinkedList<string> ListaReproduccion = new LinkedList<string>(canciones);

//  Agregando elementos al inicio y al final de la lista
ListaReproduccion.AddFirst("Mi primera cancion");
ListaReproduccion.AddLast("Mi ultimacancion");

//  Imprimir elementos de una LinkedList
foreach (var item in ListaReproduccion)
{
    Console.WriteLine(item);
}

//Buscar el primero y ultimo elemento de la linkedlist
LinkedListNode<string> primeraCancion = ListaReproduccion.First!;
LinkedListNode<string> ultimaCancion = ListaReproduccion.Last!;

Console.WriteLine($"La primera canicion {primeraCancion.Value} y la ultima cancion {ultimaCancion.Value}");

// Los elementos pueden ser agregados o removidos dependiendo de un item existente
ListaReproduccion.AddAfter(primeraCancion, "Mi segunda cancion");
foreach (var item in ListaReproduccion)
{
    Console.WriteLine("Lista nueva");
    Console.WriteLine(item);
}

//  Buscar elementos utilizando el metodo Contains
Console.WriteLine($"Buscando la cancion El Drip: {ListaReproduccion.Contains("El Drip")}");

//Acceder a la data utilizando los metodos Next y Previous
Console.WriteLine($"la cancion que sigue de la primera cancion {primeraCancion.Next!.Value }");
Console.WriteLine($"la cancion que sigue de la cancion anterior {ultimaCancion.Previous!.Value}");


Console.WriteLine($"//////////////////////////////////////////////STACK//////////////////////////////////////");

Stack<string> miStack = new Stack<string>();

//  Insertar elementos al stack
miStack.Push("uno");
miStack.Push("dos");
miStack.Push("tres");
miStack.Push("cuatro");
miStack.Push("cinco");
miStack.Push("seis");

//  Imprimir los elementos del stack
foreach (var item in miStack)
{
    Console.WriteLine($"numero dentro del stack: {item}");
}

//  Buscar el primer elemento del stack
string top = miStack.Peek();
Console.WriteLine($"el primer elemento del stack es: {top}");

// Eliminar un elemento del stack
string elemento = miStack.Pop();
Console.WriteLine($"Elemento eliminado: {elemento}");
foreach (var item in miStack)
{
    Console.WriteLine($"numero dentro del stack: {item}");
}

//  Buscamos elementos con el contains()
var elementoExiste = miStack.Contains("tres");
Console.WriteLine($"Existe el elemento en el stack? {elementoExiste}");

/////////////////////////////////////////////////////////////////////////////////////////////////////
Console.WriteLine($"///////////////////////////////QUEUE////////////////////////////////////");

Queue<string> cola = new Queue<string>();

//Agregar elementos al Q

cola.Enqueue("uno");
cola.Enqueue("dos");
cola.Enqueue("tres");
cola.Enqueue("cuatro");
cola.Enqueue("cinco");
cola.Enqueue("seis");

// Mostrar la Q
foreach (var item in cola)
{
    Console.WriteLine($"Elemento enla cola: {item}");
}

//  Buscar el primer elemento de la Q
var miPrimerElemento = cola.Peek();
Console.WriteLine($"Mi primer elemento en la Q: {miPrimerElemento}");

//  Eliminar un elemento de la Q
var elementoEliminadoDeLaQ = cola.Dequeue();
Console.WriteLine($"Sel elimino el elemento: {elementoEliminadoDeLaQ}");
foreach (var item in cola)
{
    Console.WriteLine($"Elemento enla cola: {item}");
}

//  Buscar un elemento con contains
var existeElmentoEnLaQ = cola.Contains("dos");
Console.WriteLine($"Existe el elemento en la Q?: {existeElmentoEnLaQ}");
