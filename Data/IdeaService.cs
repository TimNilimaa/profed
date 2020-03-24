using System.Collections.Generic;
using profed.Enums;
using profed.Interfaces;
using profed.Models;

namespace profed.Data
{
    public class IdeaService : IIdeaService
    {
        public IEnumerable<IIdea> GetAll()
        {
            return new List<Idea>() {
                new Idea() { Id = 1, DisplayName = "Test", Description = "Looooong text",
                    State = new State() { Id = 1, DisplayName = "New" },
                    Votes = new List<Vote>() { 
                        new Vote() { Id = 1, VoteType = VoteType.Possitive },
                        new Vote() { Id = 2, VoteType = VoteType.Negative },
                        new Vote() { Id = 3, VoteType = VoteType.Possitive }
                    }
                },
                new Idea() { Id = 2, DisplayName = "Cool" },
                new Idea() { Id = 3, DisplayName = "Warm" }
            };
        }
    }
}