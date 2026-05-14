using task_01.Classes;

List<Invitato> invitati = new List<Invitato>()
{
    new Invitato(){ Nome = "Mario", Cognome = "Rossi"},
    new Invitato(){ Nome = "Luigi", Cognome = "Verdi"},
};
bool inserimentoAbilitato = true;

while (inserimentoAbilitato)
{
    Console.WriteLine("Cosa vuoi fare?\n" +
        "I per inserimento\n" +
        "S per stampa\n" +
        "Q per Exit");
    string? input = Console.ReadLine();

    switch (input)
    {
        case "I":
            Console.WriteLine("Inserisci il nome dell'invitato:");
            string? nome = Console.ReadLine();
            if(nome is null)
            {
                Console.WriteLine("Il nome non può essere null, riprova.");
                break;
            }

            Console.WriteLine("Inserisci il cognome dell'invitato:");
            string? cognome = Console.ReadLine();
            if (cognome is null)
            {
                Console.WriteLine("Il cognome non può essere null, riprova.");
                break;
            }

            var inv = new Invitato()
            {
                Nome = nome,
                Cognome = cognome,
            };

            invitati.Add(inv);
            Console.WriteLine("Invitato inserito con successo!");

            break;
        case "S":
            foreach(var i in invitati)
            {
                Console.WriteLine($"Nome: {i.Nome} - Cognome: {i.Cognome}");
            }

            break;
        case "Q":
            inserimentoAbilitato = false;
            break;
    }
}