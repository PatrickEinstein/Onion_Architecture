using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Auth.Core.Interfaces.IUtilities;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Auth.Infrastructure.Configurations
{
  
         public class DapperContext : IDapperContext
    {
        private readonly IConfiguration _configuration;
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection GetDefaultConnection()
        {
            string _connectionString = _configuration.GetConnectionString("DefaultConnection");
            return new NpgsqlConnection(_connectionString);
        }

        public IDbConnection GetAdminDbConnection()
        {
            string _connectionString = _configuration.GetConnectionString("AdminConnection");
            return new NpgsqlConnection(_connectionString);
        }

        public IDbConnection GetMerchantDbConnection()
        {
            string _connectionString = _configuration.GetConnectionString("MerchantConnection");
            return new NpgsqlConnection(_connectionString);
        }

        public IDbConnection GetVirtualTransferDbConnection()
        {
            string _connectionString = _configuration.GetConnectionString("Payment");
            return new NpgsqlConnection(_connectionString);
        }
    
    }
}