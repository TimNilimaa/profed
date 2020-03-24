using profed.Enums;
using profed.Interfaces;

namespace profed.Models
{
    public class Vote : IVote
    {
        public int Id { get; set; }
        public IUser Voter { get; set; }
        public IIdea Idea { get; set; }
        public VoteType VoteType { get; set; }
    }
}