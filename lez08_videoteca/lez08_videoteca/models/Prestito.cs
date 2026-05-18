using System;
using System.Collections.Generic;

namespace lez08_videoteca.models;

public partial class Prestito
{
    public DateTime? DataPrestito { get; set; }

    public int VideocassettaRif { get; set; }

    public int UtenteRif { get; set; }

    public virtual Utente UtenteRifNavigation { get; set; } = null!;

    public virtual Videocassettum VideocassettaRifNavigation { get; set; } = null!;
}
