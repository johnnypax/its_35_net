using lez07_minimal_CRUD.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var elenco = new List<Libro>()
{
    new Libro(){
        Id = 1,
        Titolo = "Il Signore degli Anelli",
        Descrizione = "Un romanzo fantasy epico scritto da J.R.R. Tolkien.",
        Autore = "J.R.R. Tolkien",
        Anno = 1954
    },
    new Libro(){
        Id = 2,
        Titolo = "1984",
        Descrizione = "Un romanzo distopico scritto da George Orwell.",
        Autore = "George Orwell",
        Anno = 1949
    },
    new Libro(){
        Id = 3,
        Titolo = "Il Grande Gatsby",
        Descrizione = "Un romanzo scritto da F. Scott Fitzgerald che esplora il sogno americano.",
        Autore = "F. Scott Fitzgerald",
        Anno = 1925
    }
};

// Get All
app.MapGet("api/libri", () => elenco);

// Get By Id
app.MapGet("api/libri/{varId}", (int varId) =>
{
    var libro = elenco.Where(l => l.Id == varId).FirstOrDefault();
    #region Versione semplice
    //if (libro is not null)
    //{
    //    return Results.Ok(libro);
    //}
    //else
    //{
    //    return Results.NotFound();
    //}
    #endregion

    return libro is not null ? Results.Ok(libro) : Results.NotFound();
});

app.MapPost("api/libri", (Libro l) =>
{
    l.Id = elenco.Count + 1;
    elenco.Add(l);

    return Results.Created();
});

app.MapDelete("api/libri/{varId}", (int varId) =>
{
    #region Normale
    //var libro = elenco.Where(l => l.Id == varId).FirstOrDefault();
    //if (libro is null)
    //    return Results.NotFound();

    //elenco.Remove(libro);
    //return Results.Ok();
    #endregion

    foreach(var l in elenco)
    {
        if(l.Id == varId)
        {
            elenco.Remove(l);
            return Results.Ok();
        }
    }

    return Results.NotFound();
});

app.MapPut("api/libri/{varId}", (int varId, Libro libUpd) =>
{
    var libro = elenco.FirstOrDefault(l => l.Id == varId);
    if (libro is null)
        return Results.NotFound();

    libro.Titolo = libUpd.Titolo is not null ? libUpd.Titolo : libro.Titolo;
    libro.Descrizione = libUpd.Descrizione is not null ? libUpd.Descrizione : libro.Descrizione;
    libro.Autore = libUpd.Autore is not null ? libUpd.Autore : libro.Autore;
    libro.Anno = libUpd.Anno != 0 ? libUpd.Anno : libro.Anno;

    return Results.Ok();
});





app.Run();