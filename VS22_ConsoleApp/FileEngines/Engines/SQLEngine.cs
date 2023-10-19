using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using PROG260_Week5.FileEngines;
using PROG260_Week5.Interfaces;
using static PROG260_Week5.FileEngines.FileConstants;

namespace PROG260_Week5.FileEngines.Engines
{
    public class SQLEngine : FileEngine
    {
        public string ConnectionString { get; protected set; }

        public SQLEngine()
        {
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            sqlBuilder["server"] = @"(localdb)\MSSQLLocalDB";
            sqlBuilder["Trusted_Connection"] = true;
            sqlBuilder["Intergrated Security"] = "SSPI";
            sqlBuilder["Initial Catalog"] = "PROG260FA23";
            ConnectionString = sqlBuilder.ToString();
        }

        public override void Process(IFile file)
        {
            using (StreamReader reader = new StreamReader(file.Path))
            {
                var table_vals = reader.ReadLine().Split(DelimiterDict[".csv"]);

                var line = reader.ReadLine();

                while(line != null)
                {
                    var fields = line.Split(DelimiterDict[file.Extension]);

                    string inlineSQL = $"INSERT [dbo].[{file.Name}] ([{table_vals[0]}], [{table_vals[1]}], [{table_vals[2]}], [{table_vals[3]}]) VALUES ('{fields[0]}', '{fields[1]}', '{fields[2]}', '{fields[3]}')";

                    using(SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(inlineSQL, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    line = reader.ReadLine();
                }
                reader.Close();
                reader.Dispose();
            }
        }
    }
}