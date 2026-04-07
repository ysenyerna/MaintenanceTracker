
using Microsoft.EntityFrameworkCore;

namespace MaintenanceTracker;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

		// Initialize database
		using var ctx = new MaintenanceContext();

		try {ctx.Database.Migrate(); }
		catch {ctx.Database.EnsureCreated();}

		lblDbStatus.Text = "Status: Database 'Maintenance.db' was successfully loaded";
		lblDbStatus.Text += $"\n {ctx.Technicians.Count()} Technicians on record";
		lblDbStatus.Text += $"\n {ctx.WorkOrders.Count()} Orders on record";



	}

    private void TopPerformers_Click(object? sender, EventArgs e)
	{
		dgvEmployees.DataSource = Queries.QueryTopPerformers(out string summary);
		if (dgvEmployees.Columns.Count > 0)
			dgvEmployees.Columns[0].FillWeight = 15;

		lblInfo.Text = summary;
	}
    private void WeeklyHours_Click(object? sender, EventArgs e)
	{
		// Get the current week
		var currentWeek = System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
			DateTime.Today, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Sunday);

		dgvEmployees.DataSource = Queries.QueryWeeklyLaborHours(DateTime.Today.Year, currentWeek, out string summary);
		if (dgvEmployees.Columns.Count > 0)
			dgvEmployees.Columns[0].FillWeight = 15;

		lblInfo.Text = summary;
		
	}
    private void StatusSummary_Click(object? sender, EventArgs e)
	{
		dgvEmployees.DataSource = Queries.QueryWorkOrderStatus(out string summary);
		if (dgvEmployees.Columns.Count > 0)
		{
			dgvEmployees.Columns[0].FillWeight = 15;
		}

		lblInfo.Text = summary;
	}
    private void AverageTime_Click(object? sender, EventArgs e)
	{
		dgvEmployees.DataSource = Queries.QueryAverageTime(out string summary);
		if (dgvEmployees.Columns.Count > 0)
			dgvEmployees.Columns[0].FillWeight = 15;

		lblInfo.Text = summary;
	}
    private void TechSummary_Click(object? sender, EventArgs e)
	{
		dgvEmployees.DataSource = Queries.QueryTotalOrders(out string summary);
		if (dgvEmployees.Columns.Count > 0)
			dgvEmployees.Columns[0].FillWeight = 15;

		lblInfo.Text = summary;
	}



}
