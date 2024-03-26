using AspNetPro.Blog.Infrastructure.Data;
using AspNetPro.Blog.Models.Entity;
using AspNetPro.Blog.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetPro.Blog.Pages.Posts;

public class IndexModel : PageModel
{
    private readonly BlogContext blogContext;

    public IndexModel(BlogContext blogContext)
    {
        this.blogContext = blogContext;
    }

    public IEnumerable<PostListItemViewModel> Posts { get; set; }

    public void OnGet()
    {
        Posts = blogContext.Posts
            .OrderByDescending(x => x.dataPublicacao)
            .Select(x => new PostListItemViewModel
            {
                PostId = x.Id,
                Titulo = x.titulo,
                Resumo = x.resumo,
                dataPublicacao = x.dataPublicacao

            })
            .ToList();
    }
}
