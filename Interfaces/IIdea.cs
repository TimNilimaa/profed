using System.Collections.Generic;
using System.Linq;

namespace profed.Interfaces
{
    public interface IIdea
    {
        int Id { get; set; }
        string DisplayName { get; set; }
        string Description { get; set; }
        IState State { get; set; }
        int VoteCount { get => Votes.Count(); }
        //int Points { get => Votes.Sum(y => Votes.Select(x => x.VoteType)); }
        IEnumerable<IVote> Votes { get; set; }
        IEnumerable<IComment> Comments { get; set; }
    }
}