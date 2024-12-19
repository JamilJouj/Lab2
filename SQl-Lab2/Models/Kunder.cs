using System;
using System.Collections.Generic;

namespace SQl_Lab2.Models;

public partial class Kunder
{
    public int KundId { get; set; }

    public string FörNamn { get; set; } = null!;

    public string EfterNamn { get; set; } = null!;

    public string? Email { get; set; }

    public string? Nummer { get; set; }

    public string? Adress { get; set; }
}
