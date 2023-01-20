using System;
using System.Collections.Generic;

namespace TP_Final_Bingo.Models;

public partial class HistorialCartone
{
    public int Id { get; set; }

    public DateTime? FechaHora { get; set; }

    public int? Carton1 { get; set; }

    public int? Carton2 { get; set; }

    public int? Carton3 { get; set; }

    public int? Carton4 { get; set; }
}
