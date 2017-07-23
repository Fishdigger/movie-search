using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Titles.Models;

namespace Titles.ViewModels
{
    public class StoryLineViewModel
    {
        public string Source { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }

        public StoryLineViewModel(StoryLine story)
        {
            this.Id = story.Id;
            this.Source = story.Type;
            this.Description = story.Description;
            this.Language = story.Language;
        }
    }
}