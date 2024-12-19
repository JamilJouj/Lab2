using System;
using System.Collections.Generic;

namespace SQl_Lab2.Models;

public partial class Böcker
{
    public string Isbn { get; set; } = null!;

    public string Titel { get; set; } = null!;

    public string Språk { get; set; } = null!;

    public decimal Pris { get; set; }

    public DateOnly? UtgivningsDatum { get; set; }

    public int FörfattareId { get; set; }

    public int FörlagId { get; set; }

    public string Kategori { get; set; } = null!;

    public virtual Författare Författare { get; set; } = null!;

    public virtual Förlag Förlag { get; set; } = null!;

    public virtual ICollection<LagerSaldo> LagerSaldos { get; set; } = new List<LagerSaldo>();
}
