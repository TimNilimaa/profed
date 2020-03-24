using System.Collections.Generic;

namespace profed.Interfaces
{
    public interface IIdeaService
    {
        IEnumerable<IIdea> GetAll();
    }
}