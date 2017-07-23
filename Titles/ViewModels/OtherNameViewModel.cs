using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Titles.Models;

namespace Titles.ViewModels
{
    public class OtherNameViewModel
    {
        public int Id { get; set; }
        public string Language { get; set; }
        public string NameType { get; set; }
        public string Name { get; set; }

        public OtherNameViewModel(OtherName otherName)
        {
            this.Id = otherName.Id;
            this.Language = otherName.TitleNameLanguage;
            this.NameType = otherName.TitleNameType;
            this.Name = otherName.TitleNameSortable;
        }
    }
}