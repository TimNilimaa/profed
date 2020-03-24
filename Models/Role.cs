using profed.Interfaces;

namespace profed.Models
{
    public class Role : IRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}