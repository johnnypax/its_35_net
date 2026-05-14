var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/saluta", () =>
{
    return "Ciao Giovanni";
});

app.MapGet("/saluta/{nome}/{cognome}", (string nome, string cognome) =>
{
    return $"Ciao {nome}, {cognome}";
});

app.MapGet("/somma/{a}/{b}", (int a, int b) =>
{
    int somma = a + b;
    return somma;
});

app.MapGet("/utente/info", () =>
{
    var u = new Utente("Givoanni Pace", 20);
    return u;
});

app.MapPost("/utente/inserisci", (Utente u) =>
{
    return $"Nome: {u.Nominativo} età: {u.Eta}";
});

app.MapGet("/conritardo", async () =>
{
    await Task.Delay(5000);
    return "Arrivato con ritardo";
});


app.Run();

record Utente(string Nominativo, int Eta);