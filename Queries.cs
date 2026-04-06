namespace MaintenanceTracker;

public static class Queries
{

	// Displays the total number of work orders per technician
	public static void QueryTotalOrders()
	{
		using var ctx = new MaintenanceContext();

		var result = ctx.WorkOrders.GroupBy(o => o.TechnicianId).
		Select(g => new
		{
			Tech = ctx.Technicians.FirstOrDefault(t => t.TechnicianId == g.Key ),
			Total = g.Count()
		}).
		OrderByDescending(t => t.Total);

		foreach (var t in result)
		{
			Console.WriteLine($"{t.Tech}: {t.Total}");
		}
		
	}

	
	// Displays the average number of days between RequestDate and CompletionDate
	public static void QueryAverageTime()
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
			AverageTime = g.Average(o => ( (DateTime)o.CompletionDate! - o.RequestDate).TotalDays)
		
		// Order times ascending (lower average times first)
		}).OrderBy(t => t.AverageTime);

		foreach (var t in result)
		{
			Console.WriteLine($"{t.Tech}: {t.AverageTime}");
		}

	}

	// Counts how many open and closed orders each technician has
	public static void QueryWorkOrderStatus()
	{
		using var ctx = new MaintenanceContext();

		var result = ctx.WorkOrders.
		GroupBy(o => o.TechnicianId).
		Select(g => new
		{
			Tech = ctx.Technicians.FirstOrDefault(t => t.TechnicianId == g.Key ),
			ClosedCount = g.Count(o => o.Status == "Closed"),
			OpenCount = g.Count(o => o.Status == "Open"),
		}).ToList();

		Console.WriteLine($"Total Closed: {result.Sum(t => t.ClosedCount)}, Total Open: {result.Sum(t => t.OpenCount)}");
		foreach (var t in result)
		{
			Console.WriteLine($"{t.Tech}: Closed: {t.ClosedCount}, Open: {t.OpenCount}");
		}

	}

	// Counts how many hours each technician worked
	public static void QueryWeeklyLaborHours(int year, int weekNumber)
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
				WorkHours = g.Sum(o => o.HoursWorked)
			})
			.OrderByDescending(t => t.WorkHours);

		Console.WriteLine($"Total: {result.Sum(t => t.WorkHours)}");
		foreach (var t in result)
		{
			Console.WriteLine($"{t.Tech}: {t.WorkHours}");
		}
	}

	// Gets top 3 techs with lowest average completion time
	public static void QueryTopPerformers()
	{
		using var ctx = new MaintenanceContext();

		var result = ctx.WorkOrders.
			Where(o => o.Status == "Closed").
			GroupBy(o => o.TechnicianId)
			.Select(g => new
			{
				Tech = ctx.Technicians.FirstOrDefault(t => t.TechnicianId == g.Key ),
				AverageCompletionTime = g.Average(o => o.HoursWorked)
			}).OrderBy(t => t.AverageCompletionTime).
			Take(3);


		foreach (var t in result)
		{
			Console.WriteLine($"{t.Tech}: {t.AverageCompletionTime}");
		}
	}


}