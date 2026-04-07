namespace MaintenanceTracker;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        groupBox1 = new GroupBox();
        tableLayoutPanel3 = new TableLayoutPanel();
        btnTopPerformers = new Button();
        btnWeeklyHours = new Button();
        btnStatusSummary = new Button();
        btnAverageTime = new Button();
        btnTechSummary = new Button();
        tableLayoutPanel4 = new TableLayoutPanel();
        lblDbStatus = new Label();
        groupBox3 = new GroupBox();
        lblInfo = new Label();
        groupBox2 = new GroupBox();
        dgvEmployees = new DataGridView();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        groupBox1.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
        tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(686, 450);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.Controls.Add(groupBox1, 1, 0);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new Size(680, 194);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(tableLayoutPanel3);
        groupBox1.Dock = DockStyle.Fill;
        groupBox1.Location = new Point(343, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(334, 188);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Queries";
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        tableLayoutPanel3.Controls.Add(btnTopPerformers, 0, 4);
        tableLayoutPanel3.Controls.Add(btnWeeklyHours, 0, 3);
        tableLayoutPanel3.Controls.Add(btnStatusSummary, 0, 2);
        tableLayoutPanel3.Controls.Add(btnAverageTime, 0, 1);
        tableLayoutPanel3.Controls.Add(btnTechSummary, 0, 0);
        tableLayoutPanel3.Dock = DockStyle.Fill;
        tableLayoutPanel3.Location = new Point(3, 19);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 5;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel3.Size = new Size(328, 166);
        tableLayoutPanel3.TabIndex = 0;
        // 
        // btnTopPerformers
        // 
        btnTopPerformers.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        btnTopPerformers.Location = new Point(3, 137);
        btnTopPerformers.Name = "btnTopPerformers";
        btnTopPerformers.Size = new Size(322, 23);
        btnTopPerformers.TabIndex = 4;
        btnTopPerformers.Text = "Top Performers";
        btnTopPerformers.UseVisualStyleBackColor = true;
		btnTopPerformers.Click += TopPerformers_Click;
        // 
        // btnWeeklyHours
        // 
        btnWeeklyHours.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        btnWeeklyHours.Location = new Point(3, 104);
        btnWeeklyHours.Name = "btnWeeklyHours";
        btnWeeklyHours.Size = new Size(322, 23);
        btnWeeklyHours.TabIndex = 3;
        btnWeeklyHours.Text = "Weekly Hours";
        btnWeeklyHours.UseVisualStyleBackColor = true;
		btnWeeklyHours.Click += WeeklyHours_Click;
        // 
        // btnStatusSummary
        // 
        btnStatusSummary.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        btnStatusSummary.Location = new Point(3, 71);
        btnStatusSummary.Name = "btnStatusSummary";
        btnStatusSummary.Size = new Size(322, 23);
        btnStatusSummary.TabIndex = 2;
        btnStatusSummary.Text = "Order Status Summary";
        btnStatusSummary.UseVisualStyleBackColor = true;
		btnStatusSummary.Click += StatusSummary_Click;
        // 
        // btnAverageTime
        // 
        btnAverageTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        btnAverageTime.Location = new Point(3, 38);
        btnAverageTime.Name = "btnAverageTime";
        btnAverageTime.Size = new Size(322, 23);
        btnAverageTime.TabIndex = 1;
        btnAverageTime.Text = "Average Order Completion Days";
        btnAverageTime.UseVisualStyleBackColor = true;
		btnAverageTime.Click += AverageTime_Click;
        // 
        // btnTechSummary
        // 
        btnTechSummary.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        btnTechSummary.Location = new Point(3, 5);
        btnTechSummary.Name = "btnTechSummary";
        btnTechSummary.Size = new Size(322, 23);
        btnTechSummary.TabIndex = 0;
        btnTechSummary.Text = "Technician Summary";
        btnTechSummary.UseVisualStyleBackColor = true;
		btnTechSummary.Click += TechSummary_Click;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 1;
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        tableLayoutPanel4.Controls.Add(lblDbStatus, 0, 0);
        tableLayoutPanel4.Controls.Add(groupBox3, 0, 2);
        tableLayoutPanel4.Dock = DockStyle.Fill;
        tableLayoutPanel4.Location = new Point(3, 3);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 3;
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel4.Size = new Size(334, 188);
        tableLayoutPanel4.TabIndex = 1;
        // 
        // lblDbStatus
        // 
        lblDbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblDbStatus.AutoSize = true;
        lblDbStatus.Location = new Point(3, 0);
        lblDbStatus.Name = "lblDbStatus";
        lblDbStatus.Size = new Size(328, 15);
        lblDbStatus.TabIndex = 0;
        lblDbStatus.Text = "Status";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(lblInfo);
        groupBox3.Dock = DockStyle.Fill;
        groupBox3.Location = new Point(3, 107);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(328, 78);
        groupBox3.TabIndex = 2;
        groupBox3.TabStop = false;
        groupBox3.Text = "Info";
        // 
        // lblInfo
        // 
        lblInfo.AutoSize = true;
        lblInfo.Dock = DockStyle.Fill;
        lblInfo.Location = new Point(3, 19);
        lblInfo.Name = "lblInfo";
        lblInfo.Size = new Size(28, 15);
        lblInfo.TabIndex = 1;
        lblInfo.Text = "Info";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(dgvEmployees);
        groupBox2.Dock = DockStyle.Fill;
        groupBox2.Location = new Point(3, 203);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(680, 244);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Employees";
        // 
        // dgvEmployees
        // 
        dgvEmployees.AllowUserToAddRows = false;
        dgvEmployees.AllowUserToDeleteRows = false;
        dgvEmployees.AllowUserToResizeColumns = false;
        dgvEmployees.AllowUserToResizeRows = false;
        dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvEmployees.Dock = DockStyle.Fill;
        dgvEmployees.Location = new Point(3, 19);
        dgvEmployees.Name = "dgvEmployees";
        dgvEmployees.Size = new Size(674, 222);
        dgvEmployees.TabIndex = 0;
		dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(686, 450);
        Controls.Add(tableLayoutPanel1);
        Name = "MainForm";
        Text = "Maintenance Tracker";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel4.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private GroupBox groupBox1;
    private TableLayoutPanel tableLayoutPanel3;
    private Button btnTopPerformers;
    private Button btnWeeklyHours;
    private Button btnStatusSummary;
    private Button btnAverageTime;
    private Button btnTechSummary;
    private TableLayoutPanel tableLayoutPanel4;
    private Label lblDbStatus;
    private Label lblInfo;
    private GroupBox groupBox2;
    private DataGridView dgvEmployees;
    private GroupBox groupBox3;
}
