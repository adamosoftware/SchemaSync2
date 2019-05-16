using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchemaSync.Library;
using SchemaSync.Library.Models;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class Tables
    {
        [TestMethod]
        public void CreateTable()
        {
            var columns = new Column[]
            {
                new Column() { Name = "FirstName", DataType = "nvarchar(50)", IsNullable = false },
                new Column() { Name = "LastName", DataType = "nvarchar(50)", IsNullable = false },
                new Column() { Name = "Id", DataType = "int" }
            };

            var table1 = new Table()
            {
                Name = "Table1",
                Schema = "dbo",
                IdentityColumn = "Id",
                Columns = columns
            };

            var table2 = new Table()
            {
                Name = "Table2",
                Schema = "dbo",
                IdentityColumn = "Id",
                Columns = columns
            };

            var source = new Database()
            {
                Tables = new Table[] { table1, table2 }
            };

            var target = new Database()
            {
                Tables = new Table[] { table2 }
            };

            var diff = source.Merge(target);

            var results = diff.ToArray();

            // should create dbo.Table1
            Assert.IsTrue(results.Length == 1 && results[0].Equals(table1) && results[0].Action == ScriptAction.Create);

        }
    }
}
