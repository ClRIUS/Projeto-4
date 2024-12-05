namespace BurguerMania.Models;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public string DetailedDescription { get; set; }
    public string? Image { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }  // Relacionamento com a categoria
}