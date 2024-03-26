namespace AspNetPro.Blog.Models.ViewModels;

public record PostListItemViewModel //  DTO  = Data Transfer Object, como   é um DTO, ele  vira um record
{
    public int PostId { get; set; }
    public string? Titulo { get; set; }
    public string? Resumo { get; set; }
    public DateTime? dataPublicacao { get; set; }

}
