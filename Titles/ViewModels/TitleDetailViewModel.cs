using System.Collections.Generic;
using System.Linq;
using Titles.Models;

namespace Titles.ViewModels
{
    public class TitleDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? TypeId { get; set; }
        public int? ReleaseYear { get; set; }

        public List<AwardViewModel> Awards { get; set; }
        public List<GenreViewModel> Genres { get; set; }
        public List<OtherNameViewModel> OtherNames { get; set; }
        public List<ParticipantViewModel> Participants { get; set; }
        public List<StoryLineViewModel> StoryLines { get; set; }

        public TitleDetailViewModel(Title title)
        {
            this.Id = title.TitleId;
            this.Name = title.TitleNameSortable;
            this.TypeId = title.TitleTypeId;
            this.ReleaseYear = title.ReleaseYear;
            this.Awards = new List<AwardViewModel>();
            this.OtherNames = new List<OtherNameViewModel>();
            this.Participants = new List<ParticipantViewModel>();
            this.StoryLines = new List<StoryLineViewModel>();
            this.Genres = new List<GenreViewModel>();
        }
    }
}