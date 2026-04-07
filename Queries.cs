using System.Data;

namespace MaintenanceTracker;

public static class Queries
{

	// Returns a table with all technicians along with their total orders, outputs a formatted summary
	public static DataTable QueryTotalOrders(out string summary)
	{
		using var ctx = new MaintenanceContext();

		var result = ctx.WorkOrders.GroupBy(o => o.TechnicianId).
		Select(g => new
		{
			Tech = ctx.Technicians.FirstOrDefault(t => t.TechnicianId == g.Key ),
			Total = g.Count()
		}).
		OrderByDescending(t => t.Total).
		AsEnumerable();


		var table = GetTechnicianTable();
		table.Columns.Add( "Orders" );

		// Add rows
		foreach (var t in result)
		{
			if (t.Tech is null)
				continue;
			table.Rows.Add(t.Tech.TechnicianId, t.Tech.Name, t.Tech.Department, t.Total);
		}

		// Summary
		if (result.Any())
			summary = "The total number of work orders across all technicians is " + result.Sum(t => t.Total).ToString();
		else
			summary = "There are no technicians on record";

		return table;

	}

	// Returns a table with the average number of days between RequestDate and CompletionDate, outputs a summary
	public static DataTable QueryAverageTime(out string summary)
	{
		using var ctx = new MaintenanceContext();

		var result = ctx.WorkOrders.AsEnumerable().
		// Only get orders that are complete
		Where(o => o.CompletionDate != null).
		// Group all orders by tech id
		GroupBy(o => o.TechnicianId).

		Select(g => new
		{
			Tech = ctx.Technicians.FirstOrDefault(t => t.TechnicianId == g.Key ),
			AverageTime = Math.Round(g.Average(o => ( (DateTime)o.CompletionDate! - o.RequestDate).TotalDays), 2)
		
		// Order times ascending (lower average times first)
		}).OrderBy(t => t.AverageTime);

		var table = GetTechnicianTable();
		table.Columns.Add("Average Time (days)" );

		foreach (var t in result)
		{
			if (t.Tech is null)
				continue;
			table.Rows.Add(t.Tech.TechnicianId, t.Tech.Name, t.Tech.Department, t.AverageTime);
		}

		if (result.Any())
			summary = "The average technician order completion time is " + result.Average(t => t.AverageTime).ToString("F2") + " days";
		else 
			summary = "There are no technicians on record.";

		return table;

	}

	// Returns a table containing how many open and closed orders each technician has, outputs a summary
	public static DataTable QueryWorkOrderStatus(out string summary)
	{
		using var ctx = new MaintenanceContext();

		var result = ctx.WorkOrders.
		GroupBy(o => o.TechnicianId).
		Select(g => new
		{
			Tech = ctx.Technicians.FirstOrDefault(t => t.TechnicianId == g.Key ),
			ClosedCount = g.Count(o => o.Status == "Closed"),
			OpenCount = g.Count(o => o.Status == "Open"),
		}).AsEnumerable();


		var table = GetTechnicianTable();
		table.Columns.Add("Closed Orders");
		table.Columns.Add("Open Orders");
		foreach (var t in result)
		{
			if (t.Tech is null)
				continue;
			table.Rows.Add(t.Tech.TechnicianId, t.Tech.Name, t.Tech.Department, t.ClosedCount, t.OpenCount);
		}

		if (result.Any())
			summary = $"Total number of closed orders: {result.Sum(t => t.ClosedCount)} \nTotal number of open orders: {result.Sum(t => t.OpenCount)}";
		else 
			summary = "There are no technicians on record.";

		return table;

	}

	// Retuns the number of hours every technician worked on a given week, outputs a summary
	public static DataTable QueryWeeklyLaborHours(int year, int weekNumber, out string summary)
	{
		using var ctx = new MaintenanceContext();

		var result = ctx.WorkOrders.AsEnumerable()
			// Year
			.Where(o => o.RequestDate.Year == year)
			// Week of year
			.Where(o => System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
				o.RequestDate, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Sunday
			) == weekNumber)
			// Group orders by technician
			.GroupBy(o => o.TechnicianId )
			.Select(g => new
			{
				Tech = ctx.Technicians.FirstOrDefault(t => t.TechnicianId == g.Key ),
				WorkHours = Math.Round(g.Sum(o => o.HoursWorked), 2)
			})
			.OrderByDescending(t => t.WorkHours);

		// Create and fill table
		var table = GetTechnicianTable();
		table.Columns.Add("Work Hours");
		foreach (var t in result)
		{
			if (t.Tech is null)
				continue;
			table.Rows.Add(t.Tech.TechnicianId, t.Tech.Name, t.Tech.Department, t.WorkHours);
		}

		// Output summary
		if (result.Any())
			summary = $"The total hours worked across all technicians on week {weekNumber} of {year}: " + result.Sum(t => t.WorkHours);
		else 
			summary = $"No hours worked on week {weekNumber} of {year}.";
		
		return table;
	}

	// Returns a data table with the top 3 techs (lowest average completion time), outpus a summary
	public static DataTable QueryTopPerformers(out string summary)
	{
		using var ctx = new MaintenanceContext();

		var result = ctx.WorkOrders.
			Where(o => o.Status == "Closed").
			GroupBy(o => o.TechnicianId)
			.Select(g => new
			{
				Tech = ctx.Technicians.FirstOrDefault(t => t.TechnicianId == g.Key ),
				AverageCompletionTime = Math.Round(g.Average(o => o.HoursWorked), 2)
			}).OrderBy(t => t.AverageCompletionTime).
			Take(3);


		summary = "The top 3 highest performing technicians are: \n";

		// Create and fill table
		var table = GetTechnicianTable();
		table.Columns.Add("Average Order Completion Time (hours)");
		foreach (var t in result)
		{
			if (t.Tech is null)
				continue;
			table.Rows.Add(t.Tech.TechnicianId, t.Tech.Name, t.Tech.Department, t.AverageCompletionTime);
			summary += t.Tech.Name + "\n";
		}

		// Output summary
		if (!result.Any())
			summary = "There are no technicians on record.";
		
		return table;

	}

	// Returns a new table with technician columns (id, name, department) formatted
	private static DataTable GetTechnicianTable()
	{
		var table = new DataTable();
		table.Columns.Clear();
		table.Columns.Add("ID");
		table.Columns.Add("Name" );
		table.Columns.Add("Department" );
		return table;

	}

}