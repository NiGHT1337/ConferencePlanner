using GraphQL.Data;
using HotChocolate;
using System.Linq;

namespace GraphQL
{
    public class Query
    {
        public IQueryable<Speaker> GetSpeakers([Service] ApplicationDbContext context) =>
             context.Speakers;
    }
}
