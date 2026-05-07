using lez03_ereditarieta.Classes;

var persona = new Persona();
persona.Nominativo = "Mario Rossi";
persona.Email = "mar@ros.com";
Console.WriteLine(persona.Stampa());

var studente = new Studente();
studente.Nominativo = "Valeria Verdi";
studente.Email = "val@ver.com";
studente.Matricola = "AB12345";
Console.WriteLine(studente.Stampa());