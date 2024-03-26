namespace AspNetPro.Blog.Models.ViewModels;

public record PostDetailsViewModel
{
    public int PostId { get; set; }
    public string? Titulo { get; set; }
    public string? Conteudo { get; set; }
    public string? dataPublicacao { get; set; }
}
    