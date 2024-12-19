using System;
using System.Collections.Generic;

namespace SQl_Lab2.Models;

public partial class LagerSaldo
{
    public int LagerId { get; set; }

    public int ButikId { get; set; }

    public string? Isbn { get; set; }

    public int Antal { get; set; }

    public virtual Butiker Butik { get; set; } = null!;

    public virtual Böcker? IsbnNavigation { get; set; }
}
