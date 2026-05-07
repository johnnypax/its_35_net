using lez04_astrazione.Classes;

List<Animale> animales = new List<Animale>();

Cane gengis = new Cane() { 
    HasPelo = true,
    NumZampe = 4,
    Vola = false
};

animales.Add(gengis);
