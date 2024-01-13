

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
var resultado = ListaPersonas.Exists( x => x.Length >= 10 );
Console.WriteLine( $"Existe un nombre de mas de 10 caracteres: {resultado}" );

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