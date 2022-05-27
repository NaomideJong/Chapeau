using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    public class TableDao : BaseDao
    {
        public List<Table> GetAllTables()
        {
            string query = "SELECT table_ID, isOccupied, isReserved, amountOfSeats, Waiter_ID, description FROM [Table]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        
        public List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {
                    TableID = (int)dr["table_ID"],
                    IsOccupied = (bool)dr["isOccupied"],
                    IsReserverd = (bool)dr["isReserved"],
                    AmountOfSeats = (int)dr["amountOfSeats"],
                    WaiterID = ConvertFromDR<int>(dr["Waiter_ID"]),
                    Description = Convert.ToString(dr["description"]),
                };
                tables.Add(table);
            }
            return tables;
        }
        private T ConvertFromDR<T>(object obj)
        {
            if (obj == DBNull.Value)
            {
                return default(T);
            }
            else
            {
                return (T)obj;
            }
        }
    }
}
