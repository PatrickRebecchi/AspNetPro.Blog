namespace AspNetPro.Blog.Models.Entity;

public class Post
{
    public int Id { get; set; }
    public string? titulo { get; set; }
    public string? resumo { get; set; }
    public string? conteudo { get; set; }
    public DateTime? dataPublicacao { get; set; }   
}

