using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Titles.Models;

namespace Titles.ViewModels
{
    public class AwardViewModel
    {
        public int Id { get; set; }
        public bool? AwardWon { get; set; }
        public int? Year { get; set; }
        public string Name { get; set;}
        public string Company { get; set; }

        public AwardViewModel() { }
        public AwardViewModel(Award award)
        {
            this.Id = award.Id;
            this.AwardWon = award.AwardWon;
            this.Year = award.AwardYear;
            this.Name = award.Award1;
            this.Company = award.AwardCompany;
        }
    }
}