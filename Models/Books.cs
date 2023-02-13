using System.ComponentModel.DataAnnotations;

public class Books
{
    [Key]
    public int BookId { get; set; }
    public string? Title { get; set; }
    public float Price { get; set; }
}