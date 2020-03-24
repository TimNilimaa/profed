using System.Collections.Generic;
using profed.Interfaces;

namespace profed.Models
{
    public class User : IUser
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string EmailAddress { get; set; }
        public IEnumerable<IRole> Roles { get; set; }
    }
}