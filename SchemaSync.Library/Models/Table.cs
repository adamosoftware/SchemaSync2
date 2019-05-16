using System;
using System.Collections.Generic;
using System.Text;

namespace SchemaSync.Library.Models
{
    public class Table : DbObject
    {

        public string Schema { get; set; }
        public string Name { get; set; }
        public string IdentityColumn { get; set; }
        public string ClusteredIndex { get; set; }
        public int RowCount { get; set; }

        public IEnumerable<Column> Columns { get; set; }
        public IEnumerable<Index> Indexes { get; set; }

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
