using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Titles.Models;
using Titles.ViewModels;

namespace Titles.Controllers
{
    public class TitlesController : ApiController
    {
        private TitleContext titleContext;
        public TitlesController()
        {
            this.titleContext = new TitleContext();
        }

        public IEnumerable<TitleViewModel> GetAllTitles()
        {
            var titleVM = new List<TitleViewModel>();
            var titles = titleContext.Titles;
            foreach(var title in titles)
            {
                titleVM.Add(new TitleViewModel(title));
            }
            return titleVM;
        }

        public IHttpActionResult GetTitleById(int id)
        {
            var title = titleContext.Titles.Where(t => t.TitleId == id).FirstOrDefault();
            if(title == null)
            {
                return (IHttpActionResult)BadRequest("Title not Found");
            }
            var titleVM = FillInViewModel(title);
            return Ok(titleVM);
        }

        public IHttpActionResult GetTitleByName(string name)
        {
            var title = titleContext.Titles.Where(t => t.TitleName == name).FirstOrDefault();
            if(title == null)
            {
                return (IHttpActionResult)BadRequest("Title not Found");
            }
            var vm = FillInViewModel(title);
            return Ok(vm);
        }

        private TitleDetailViewModel FillInViewModel(Title title)
        {
            var titleVM = new TitleDetailViewModel(title);
            foreach (var award in title.Awards)
            {
                titleVM.Awards.Add(new AwardViewModel(award));
            }
            foreach (var participant in title.TitleParticipants)
            {
                titleVM.Participants.Add(new ParticipantViewModel(participant.Participant));
            }
            foreach (var otherName in title.OtherNames)
            {
                titleVM.OtherNames.Add(new OtherNameViewModel(otherName));
            }
            foreach (var storyLine in title.StoryLines)
            {
                titleVM.StoryLines.Add(new StoryLineViewModel(storyLine));
            }
            foreach (var genre in title.TitleGenres)
            {
                titleVM.Genres.Add(new GenreViewModel(genre.Genre));
            }
            return titleVM;
        }
    }
}
