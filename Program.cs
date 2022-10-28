
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

