using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_Mvc.ViewComponents;

public class ArticlesViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var articles = new List<Article>()
        {
            new Article(1, "Article 1", "Description 1", "blog-post-thumb-card-1.jpg"),
            new Article(2, "Article 1", "Description 1", "blog-post-thumb-card-2.jpg"),
            new Article(3, "Article 1", "Description 1", "blog-post-thumb-card-3.jpg"),
        };
        return View("_Articles", articles);
    }
}