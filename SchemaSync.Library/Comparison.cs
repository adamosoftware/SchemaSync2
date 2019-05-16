using SchemaSync.Library.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchemaSync.Library
{
    public class Comparison
    {
        public IEnumerable<DbObject> Create { get; set; } = Enumerable.Empty<DbObject>();
        public IEnumerable<DbObject> Alter { get; set; } = Enumerable.Empty<DbObject>();
        public IEnumerable<DbObject> Drop { get; set; } = Enumerable.Empty<DbObject>();
    }
}
