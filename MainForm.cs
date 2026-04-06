
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

	}


}
