using System;
using System.Collections.Generic;
using System.Text;

namespace Databaseoppgave8_31_2021
{
    /// <summary>
    /// SQL pointer client
    /// </summary>
    class SqlClient
    {
        
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="host"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="table"></param>
        public SqlClient(string host, string username, string password, string table)
        {

        }


        /// <summary>
        /// Sends a query to the local sql client with specified data
        /// </summary>
        /// <param name="script"></param>
        /// <returns></returns>
        public string[][] Query(string data)
        {
            return new string[][]{ };
        }
    }

    /// <summary>
    /// Standard SQL table with simple logic
    /// </summary>
    class SqlTable
    {
        /// <summary>
        /// Gets / sets the items of the table
        /// </summary>
        public SqlColumns Items { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="Items"></param>
        public SqlTable(SqlColumns Items = null)
        {
            if(Items != null)
            {
                this.Items = Items;
            }
            else
            {
                this.Items = new SqlColumns();
            }
        }
    }

    class SqlColumns : Dictionary<string, SqlColumn> { }

    /// <summary>
    /// Standard SQL column
    /// </summary>
    class SqlColumn
    {
        /// <summary>
        /// Gets / sets the name of the column
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets / sets the row of the column
        /// </summary>
        public string[] Row { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="Name"></param>
        public SqlColumn(string Name)
        {
            this.Name = Name;
        }
    }
}
