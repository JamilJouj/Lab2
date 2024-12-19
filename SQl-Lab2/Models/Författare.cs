using System;
using System.Collections.Generic;

namespace SQl_Lab2.Models;

public partial class Författare
{
    public int Id { get; set; }

    public string FörNamn { get; set; } = null!;

    public string EfterNamn { get; set; } = null!;

    public DateOnly? FödelseDatum { get; set; }

    public virtual ICollection<Böcker> Böckers { get; set; } = new List<Böcker>();
}
