using profed.Enums;

namespace profed.Interfaces
{
    public interface IVote
    {
        int Id { get; set; }
        IUser Voter { get; set; }
        IIdea Idea { get; set; }
        VoteType VoteType { get; set; }
    }
}