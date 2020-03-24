using System.Collections.Generic;
using profed.Interfaces;

namespace profed.Models
{
    public class Idea : IIdea
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public IState State { get; set; }
        public string Description { get; set; }
        public int VoteCount { get; set; }
        public IEnumerable<IVote> Votes { get; set; }
        public IEnumerable<IComment> Comments { get; set; }
    }
}