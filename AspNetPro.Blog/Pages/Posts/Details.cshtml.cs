using AspNetPro.Blog.Infrastructure.Data;
using AspNetPro.Blog.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetPro.Blog.Pages.Posts;

public class DetailsModel (BlogContext blogContext)
    : PageModel
{
    public PostDetailsViewModel? Post { get; set; }

    public void OnGet(int postId)
    {
        Post = blogContext.Posts
            .Where(x => x.Id == postId)
            .Select(x => new PostDetailsViewModel
            {
                PostId = x.Id,
                Titulo = x.titulo,
                Conteudo = x.conteudo,
                dataPublicacao = x.dataPublicacao.Value.ToShortDateString()
            })
            .FirstOrDefault();
    }
}
