namespace SQl_Lab2.Models
{
    public class BookInfo
    {
        public string? ISBN { get; set; }
        public string? Titel { get; set; }
        public DateOnly? UtgivningsDatum { get; set; }
        public string? Författare { get; set; }
        public double? Price { get; set; }
        public int Antal { get; set; }
        public int ButikID { get; set; }
        public string? Butiksnamn { get; set; }
        public DateOnly? FödelseDatum { get; set; }
    }
}
