using System.Collections.Generic;

namespace profed.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }
        string DisplayName { get; set; }
        string EmailAddress { get; set; }
        IEnumerable<IRole> Roles { get; set; }
    }
}