using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_Project.ViewComponents
{
    public class LatestArticleViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Articles = new List<ArticlesModel>
            {
                new ArticlesModel(1," آموزش Asp core mvc","کامل ترین آموزش Asp Core به زبان فارسی","blog-post-thumb-card-1.jpg"),
                new ArticlesModel(2,"دفتر کار اشتراکی ","باید ها و نباید های دفترهای کار اشتراکی","blog-post-thumb-card-2.jpg"),
                new ArticlesModel(3,"گجت های پوشیدنی","آیا گجت های پوشیدنی به زندگی ما کمک می کند؟","blog-post-thumb-card-3.jpg"),
            };

            return View("_latestArticleViewComponent",Articles);
        }
    }
}
