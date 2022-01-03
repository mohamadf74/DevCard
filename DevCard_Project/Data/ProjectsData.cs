using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_Project.Models;

namespace DevCard_Project.Data
{
    public class ProjectsData
    {
        public static List<ProjectModel> GetProjects()
        {
            return new List<ProjectModel>
            {
                new ProjectModel(1, "درخواست تاکسی", "درخواست آنلاین تاکسی برای سفرهای درون شهری", "project-1.jpg","اسنپ"),
                new ProjectModel(2, "زودفود", "درخواست آنلاین غذا برای سراسر کشور","project-2.jpg", "زودفود"),
                new ProjectModel(3, "مدارس", "سیستم مدیریت یکپارچه مدارس","project-3.jpg", "مونوپ"),
                new ProjectModel(4 , "فضاپیما", "برنامه مدیریت فضاپیماهای ناسا","project-4.jpg", "ناسا"),
            };
        }

        public static ProjectModel getProjectBy(long id)
        {
            return GetProjects().FirstOrDefault(c => c.Id == id);
        }
    }
}
