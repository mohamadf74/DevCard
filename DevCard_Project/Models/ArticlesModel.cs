using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_Project.Models
{
    public class ArticlesModel
    {
        public ArticlesModel(long _Id,string _Title,string _Description,string _Image)
        {
            Id = _Id;
            Title = _Title;
            Description = _Description;
            Image = _Image;
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
