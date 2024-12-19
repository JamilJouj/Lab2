using System;
using System.Collections.Generic;

namespace SQl_Lab2.Models;

public partial class Butiker
{
    public int ButikId { get; set; }

    public string ButiksNamn { get; set; } = null!;

    public string Gata { get; set; } = null!;

    public string? GatuNummer { get; set; }

    public virtual ICollection<LagerSaldo> LagerSaldos { get; set; } = new List<LagerSaldo>();
}
