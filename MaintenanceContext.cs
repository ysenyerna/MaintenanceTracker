using Microsoft.EntityFrameworkCore;

namespace MaintenanceTracker;

public class MaintenanceContext : DbContext
{
	public DbSet<Technician> Technicians {get; set;}
	public DbSet<WorkOrder> WorkOrders {get; set;}



	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=> optionsBuilder.UseSqlite("Data Source=Maintenance.db");
	
}

public class Technician
{
	public int TechnicianId { get; set; }
	public required string Name { get; set; }
	public required string Department { get; set; }

	public override string ToString()
	{
		return $"[{TechnicianId}] {Name} - {Department}";
	}

}

public class WorkOrder
{
	public int WorkOrderId { get; set; }
	public int TechnicianId { get; set; }
	public DateTime RequestDate { get; set; }
	public DateTime? CompletionDate { get; set; }
	public required string Status { get; set; }
	public double HoursWorked { get; set; }
	
}