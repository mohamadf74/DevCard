using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_Project.Models
{
    public class ProjectModel
    {

        public ProjectModel(long _Id,string _Name,string _Description,string _image,string _Client)
        {
            Id = _Id;
            Name = _Name;
            Client = _Client;
            Description = _Description;
            Image = _image;
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Client { get; set; }
    }
}
