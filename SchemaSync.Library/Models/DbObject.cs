using System;
using System.Collections.Generic;
using System.Text;

namespace SchemaSync.Library.Models
{
    public enum ScriptAction
    {
        Create,
        Alter,
        Drop
    }

    public abstract class DbObject
    {
        public ScriptAction Action { get; set; }

        /// <summary>
        /// Generates the SQL CREATE statement(s) for an object
        /// </summary>
        public abstract IEnumerable<string> CreateCommands(SqlSyntax syntax);

        /// <summary>
        /// Generates the SQL DROP statement(s) for an object
        /// </summary>
        public abstract IEnumerable<string> DropCommands(SqlSyntax syntax);

    }
}
