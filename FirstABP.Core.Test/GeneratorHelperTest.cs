using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FirstABP.Core.Test
{
    [TestClass]
    public class GeneratorHelperTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dbConfig = new DbConfig
            {
                ConnectionString = "Data Source=(local);Initial Catalog=T4;User ID=sa;Password=sa;",
                DatabaseType = DatabaseType.SqlServer,
                DbDatabase = "T4"
            };

            var dbSchema = DBSchemaFactory.GetDBSchema(dbConfig);
            List<string> tableList = dbSchema.GetTablesList();

            foreach (string tableName in tableList)
            {
                Table table = dbSchema.GetTableMetadata(tableName);
            }
        }
    }
}
