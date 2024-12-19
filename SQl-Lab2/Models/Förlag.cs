using System;
using System.Collections.Generic;

namespace SQl_Lab2.Models;

public partial class Förlag
{
    public int FörlagId { get; set; }

    public string Namn { get; set; } = null!;

    public virtual ICollection<Böcker> Böckers { get; set; } = new List<Böcker>();
}
