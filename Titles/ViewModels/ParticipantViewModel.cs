using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Titles.Models;

namespace Titles.ViewModels
{
    public class ParticipantViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public ParticipantViewModel(Participant participant)
        {
            this.Id = participant.Id;
            this.Name = participant.Name;
            this.Type = participant.ParticipantType;
        }
    }
}