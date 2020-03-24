using profed.Interfaces;

namespace profed.Models
{
    public class State : IState
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
    }
}