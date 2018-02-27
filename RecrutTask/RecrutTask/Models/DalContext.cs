using System.Data.Entity;

/// <summary>
/// Create the Database Context
/// </summary>

namespace RecrutTask.Models
{
    public class DalContext : DbContext
    {
        public DbSet<DataModelEntity> dataModelEntities { get; set; }
 
    }
}