using System;
using System.Collections.Generic;
using System.Text;

namespace SchemaSync.Library.Models
{
    public class Database
    {
        public IEnumerable<Schema> Schemas { get; set; }
        public IEnumerable<Table> Tables { get; set; }
        public IEnumerable<ForeignKey> ForeignKeys { get; set; }

        public Comparison Merge(Database target)
        {
            throw new NotImplementedException();
        }
    }
}
