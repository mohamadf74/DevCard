using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_Project.ViewComponents
{
    public class ProjectsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<ProjectModel>()
            {
                new ProjectModel(1, "درخواست تاکسی", "درخواست آنلاین تاکسی برای سفرهای درون شهری", "project-1.jpg","اسنپ"),
                new ProjectModel(2, "زودفود", "درخواست آنلاین غذا برای سراسر کشور","project-2.jpg", "زودفود"),
                new ProjectModel(3, "مدارس", "سیستم مدیریت یکپارچه مدارس","project-3.jpg", "مونوپ"),
                new ProjectModel(4 , "فضاپیما", "برنامه مدیریت فضاپیماهای ناسا","project-4.jpg", "ناسا"),
            };

            return View("_ProjectsViewComponent",projects);
        }
    }
}
