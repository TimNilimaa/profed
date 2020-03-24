namespace profed.Interfaces
{
    public interface IComment
    {
        int Id { get; set; }
        string Content { get; set; }
        IUser Author { get; set; }
        IVisibility Visibility { get; set; }
        bool OfficialResponse { get; set; }
        bool Removed { get; set; }
    }
}