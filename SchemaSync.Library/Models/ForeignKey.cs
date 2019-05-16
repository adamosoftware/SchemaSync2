using System;
using System.Collections.Generic;
using System.Text;

namespace SchemaSync.Library.Models
{
    public class ForeignKey : DbObject
    {
        public string Name { get; set; }
        public Table ReferencedTable { get; set; }
        public Table ReferencingTable { get; set; }
        public IEnumerable<Column> Columns { get; set; }
        public bool CascadeDelete { get; set; }
        public bool CascadeUpdate { get; set; }

        public override IEnumerable<string> CreateCommands(SqlSyntax syntax)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<string> DropCommands(SqlSyntax syntax)
        {
            throw new NotImplementedException();
        }
    }
}
