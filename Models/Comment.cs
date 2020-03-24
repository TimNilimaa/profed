using profed.Interfaces;

namespace profed.Models
{
    public class Comment : IComment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public IUser Author { get; set; }
        public IVisibility Visibility { get; set; }
        public bool OfficialResponse { get; set; }
        public bool Removed { get; set; }
    }
}