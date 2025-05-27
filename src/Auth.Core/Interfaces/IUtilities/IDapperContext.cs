using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Auth.Core.Interfaces.IUtilities
{
    public interface IDapperContext
    {
        IDbConnection GetDefaultConnection();

        IDbConnection GetAdminDbConnection();

        IDbConnection GetMerchantDbConnection();

        IDbConnection GetVirtualTransferDbConnection();
    }
}