using System.ComponentModel.DataAnnotations;

public class Books
{
    [Key]
    public int BookId { get; set; }
    [Required(ErrorMessage ="El título es necesario.")]
    public string? Title { get; set; }
    [Required(ErrorMessage ="El precio es necesario.")]
    public float Price { get; set; }
}