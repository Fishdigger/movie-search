using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Titles.Models;

namespace Titles.ViewModels
{
    public class GenreViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public GenreViewModel(Genre genre)
        {
            this.Id = genre.Id;
            this.Name = genre.Name;
        }
    }
}