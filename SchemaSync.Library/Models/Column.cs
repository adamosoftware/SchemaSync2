using System;
using System.Collections.Generic;
using System.Text;

namespace SchemaSync.Library.Models
{
    public class Column : DbObject
    {
        public Table Table { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; }
        public bool IsNullable { get; set; }
        public string Default { get; set; }
        public string Collation { get; set; }
        public long MaxLength { get; set; }
        public int Scale { get; set; }
        public int Precision { get; set; }

        /// <summary>
        /// Expression used for computed column
        /// </summary>
        public string Expression { get; set; }

        /// <summary>
        /// Expression to use with UPDATE...SET when creating required column in table with data
        /// </summary>
        public string DefaultExpression { get; set; }

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
