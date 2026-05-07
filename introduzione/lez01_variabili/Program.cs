#region Primi step con le variabili
//int eta = 20;
//Console.WriteLine(eta);

//eta = 55;

//eta = 60;

//eta = 30;

//Console.WriteLine(eta);
#endregion

#region Tipi di dato
//string nome = "Mario Rossi";
//String cognome = "Rossi";           //Wrapper

//string? matricola = null;       //Posso ritornare a null
//matricola = "123456";
//matricola = null;
//Console.WriteLine(matricola);

//string test = null!;
//test = "Ciao Giovanni";
////test = null;                //Non posso ritornare a null
//Console.WriteLine(test);

//var nonloso = "ciao";
////nonloso = 5;                  //NOn permesso, già Stringa
//nonloso = null;
//Console.WriteLine(nonloso);
#endregion

#region Modalità di interazione
#if DEBUG
Console.WriteLine("Ciao sono debug");
#elif RELEASE
    Console.WriteLine("Ciao sono release");
#endif

//Console.ReadLine();
#endregion

#region Interpolazione di stringhe
//string nome = "Mario Rossi";
//int eta = 20;

//Console.WriteLine($"Ciao {nome}, hai {eta} anni");
//Console.WriteLine($"La somma di due numeri è: {5 + 9}");
//Console.WriteLine($"La comparazione di due numeri è: {5 > 9}");

//int a = 5;
//int b = 9;

//var risultato = a > b ? "Maggiore" : "Minore";
//Console.WriteLine($"Il valore di {a} è {risultato} di {b}");
#endregion

/*
 * Scrivere un programma che chiede alll'utente la temperatura corporea.
 * Se la temperatura supera i 37.5 gradi, stampare "Hai la febbre", 
 * altrimenti "La tua temperatura, di 36.. è normale".
 */

var temperatura = Console.ReadLine();

try
{
    float temperaturaFloat = float.Parse(temperatura!);

    if (temperaturaFloat >= 37.5)
        Console.WriteLine("Hai la febbre");
    else
        Console.WriteLine($"La tua temperatura, di {temperatura} è normale");
} catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

