

//Si chiede di implementare due funzioni che eseguano le corrsipettive funzioni matematiche:
//1 - Fattoriale di un numero
//1) il fattoriale di un numero può essere calcolato solo su numeri positivi:
//0! = 1 1! = 1 2! = 2 3! = 6 4! = 24 5! = 120 N! = ???
//    risolverla in modo RICORSIVO o anche in modo ITERATIVO (FOR)

 int fattorialeRicorsivo(int numero)
{
    if (numero > 0)
        return fattorialeRicorsivo(numero - 1) * numero;
    else
        return 1;

}

Console.WriteLine(fattorialeRicorsivo(4));

int fattorialeFor(int numero)
{
    if (numero > 0)
    {
        int fattoriale = 1;
        for (int i = 1; i <= numero; i++)
        {
            fattoriale = fattoriale * i;
        }
            return fattoriale;
    }
    else
        return 1;

}

Console.WriteLine(fattorialeFor(5));

//2 - La sequenza di fibonacci di un numero

//n Fn
//0	0
//1	1
//2	1
//3	2
//4	3
//5	5
//6	8
//7	13
//8	21
//9	34
//10	55
//fibonacci(10) = 55
//Risolverla in modo RICORSIVO o anche in modo ITERATIVO (FOR)

int fibonacciRicorsivo(int numero)
{
    if (numero > 2)
        return fibonacciRicorsivo(numero - 1) + fibonacciRicorsivo(numero - 2);
    else if(numero == 0)
        return 0;
    else
        return 1;

}

Console.WriteLine(fibonacciRicorsivo(10));



//BONUS: Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile,
//ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via. A questo punto modificare il programma in modo che chieda
//all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente.
//Rieseguire il programma con l’input preso esternamente dall’utente.

Console.WriteLine("Quanti numeri vuoi inserire?");

int NumeroUtente = Convert.ToInt32(Console.ReadLine());

int[] Array = new int[NumeroUtente];


int[] ChiediNumeri(int numero)
{
    for (int i = 0; i < numero; i++)
    {
        Console.WriteLine("Inserisci un numero");

        int NumeriUtente = Convert.ToInt32(Console.ReadLine());
        Array[i] = NumeriUtente;
    }
    return Array;
}
ChiediNumeri(NumeroUtente);



//In questo esercizio vi chiedo di definire qualche funzione di utilità che poi potete usare per poter fare operazioni complesse nei vostri programma principale.
//Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
//void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.
//Potete prendere quella fatta in classe questa mattina


//int[] Array = { 2, 6, 7, 5, 3, 9 };

// funzione stampa
void StampaArray(int[] array)
{
        Console.Write("[");

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(",");

    }
    Console.Write("]");

}



//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.

int Quadrato(int numero)
{
    int quadratoNumero = numero * numero;

    return quadratoNumero;
}



//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un
//nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] ArrayQuadrato = new int[array.Length];

    for(int i = 0; i < array.Length; i++)
    {
        int numeroModificato = Quadrato(array[i]);
        ArrayQuadrato[i] = numeroModificato;
    }
    return ArrayQuadrato;
}


//int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.


int SommaElementiArray(int[] array)
{
    int somma = 0;

    for(int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }
    return somma;
}

//Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
//Stampare l’array di numeri fornito a video
Console.WriteLine("Array di base");
StampaArray(Array);
Console.WriteLine();

//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente
//l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])

Console.WriteLine("Array al quadrato");
StampaArray(ElevaArrayAlQuadrato(Array));
Console.WriteLine();

Console.WriteLine("Di nuovo l'array di base");
StampaArray(Array);
Console.WriteLine();

//Stampare la somma di tutti i numeri
Console.WriteLine("Stampa somma numeri array base");
Console.WriteLine(SommaElementiArray(Array));
Console.WriteLine();


//Stampare la somma di tutti i numeri elevati al quadrati
Console.WriteLine("Stampa somma numeri array al quadrato");

Console.WriteLine(SommaElementiArray(ElevaArrayAlQuadrato(Array)));
Console.WriteLine();

