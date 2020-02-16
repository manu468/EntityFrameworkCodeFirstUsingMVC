using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace MuppavarapuStateUniversity.DAL
{

    //All we have to do to enable connection resiliency is create a class in your assembly that derives 
    //    from the DbConfiguration class, and in that class set the SQL Database execution strategy, which 
    //    in EF is another term for retry policy.
    public class SchoolConfiguration : DbConfiguration
    {
        public SchoolConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}