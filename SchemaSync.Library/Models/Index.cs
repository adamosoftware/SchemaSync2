using System;
using System.Collections.Generic;
using System.Text;

namespace SchemaSync.Library.Models
{
    public enum IndexType
    {
        PrimaryKey = 1,
        UniqueIndex = 2,
        UniqueConstraint = 3,
        NonUnique = 4
    }

    public enum SortDirection
    {
        Ascending,
        Descending
    }

    public class Index : DbObject
    {
        public string Name { get; set; }
        public IndexType Type { get; set; }
        public IEnumerable<IndexColumn> Columns { get; set; }

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
