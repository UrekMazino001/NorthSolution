using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using Northwind.Models;
using Northwind.Repositories;

namespace Northwind.DataAccess
{
    class SupplierRespository : Repository<Supplier>, ISupplierRepository
    {
        public SupplierRespository(string connectionString) : base(connectionString)
        {
        }

        public IEnumerable<Supplier> SupplierPagedList(int page, int rows)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@page", page);
            parameters.Add("@rows", rows);

            var connection = new SqlConnection(_connectionString);
            return connection.Query<Supplier>("dbo.SupplierPagedList", parameters, commandType: System.Data.CommandType.StoredProcedure);

        }
    }
}
