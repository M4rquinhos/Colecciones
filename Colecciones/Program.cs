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