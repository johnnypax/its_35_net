using System;
using System.Collections.Generic;

namespace lez08_videoteca.models;

public partial class Videocassettum
{
    public int VideocassettaId { get; set; }

    public string Titolo { get; set; } = null!;

    public string Genere { get; set; } = null!;

    public string? Regista { get; set; }

    public int? Anno { get; set; }

    public string Codice { get; set; } = null!;

    public virtual ICollection<Prestito> Prestitos { get; set; } = new List<Prestito>();
}
