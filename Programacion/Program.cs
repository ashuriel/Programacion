int[] arreglo = new int[10];

int contador = 0;
int i = 0;
while (contador <= 9)
{
    Console.WriteLine("Ingresa un numero");
    int a = Convert.ToInt32(Console.ReadLine());
    arreglo[i] = a;
    i += 1;
    contador+=1;
}

int maximo = arreglo.Max();
int posicion = Array.IndexOf(arreglo,maximo);

Console.WriteLine($"El numero mayor es {maximo}, y esta en la posicion {posicion+1}.");


