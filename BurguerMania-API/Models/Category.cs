namespace BurguerMania.Models;

public class Category
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public string? Image { get; set; }

    public ICollection<Product> Products { get; set; }
}