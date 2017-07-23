using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Titles.Models;

namespace Titles.ViewModels
{
    public class TitleViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? TypeId { get; set; }
        public int? ReleaseYear { get; set; }

        public TitleViewModel(Title title)
        {
            this.Id = title.TitleId;
            this.Name = title.TitleName;
            this.TypeId = title.TitleTypeId;
            this.ReleaseYear = title.ReleaseYear;
        }
    }
}