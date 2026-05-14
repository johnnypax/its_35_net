using lez08_minimal_otm.Models;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var elencoAutori = new List<Autore>() {
    new Autore() { Id = 1, Nome = "Mario", Cognome = "Rossi" },
    new Autore() { Id = 2, Nome = "Valeria", Cognome = "Verdi" },
    new Autore() { Id = 3, Nome = "Mauro", Cognome = "Bianchi" },
};

var elencoLibri = new List<Libro>()
{
    new Libro() {
        Id = 1,
        Titolo = "Il Signore degli Anelli", 
        Descrizione = "Un libro fantasy", 
        Autore = elencoAutori[0] 
    },
    new Libro() {
        Id = 2,
        Titolo = "Il Codice Da Vinci",
        Descrizione = "Un libro giallo",
        Autore = elencoAutori[1]
    },
    new Libro() {
        Id = 3,
        Titolo = "Il Piccolo Principe",
        Descrizione = "Un libro per bambini",
        Autore = elencoAutori[2]
    }
};

app.MapGet("api/libri", () => elencoLibri);

//Inserimento libro
app.MapPost("api/libri/autore/{autoreId}", (Libro lib, int autoreId) =>
{
    var aut = elencoAutori.FirstOrDefault(a => a.Id == autoreId);
    if (aut is null)
        return Results.BadRequest();

    lib.Id = elencoLibri.Count + 1;
    lib.Autore = aut;
    elencoLibri.Add(lib);

    return Results.Created();
});

//Completa gli endpoint con:
// GET - Ricerca tutti i libri per autore ID
// GET - Ricerca tutti i libri per autore (nome e/o cognome)

/*
 * Strutturare una piccola applicazione REACTJS che:
 * - Elenca tutti i libri nella home, comprensivi dei dettagli dell'autore (almeno nominativo)
 * - La tabella deve avere una input di ricerca in alto che, alla modifica interattiva, 
 *   filtra i libri per autore (nome e/o cognome)
 * - Form di inserimento di un nuovo libro, con selezione dell'autore (dropdown)
 *(

app.Run();
