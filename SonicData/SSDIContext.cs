using Microsoft.EntityFrameworkCore;
using SonicData.Model;
using System;

namespace SonicData
{
    public class SSDIContext : DbContext
    {
        public SSDIContext(DbContextOptions options) : base(options) { }

        public DbSet<RequisitionRequest> RequisitionRequests { get; set; }
        
    }
}
