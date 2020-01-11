namespace WAGrapher
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
			this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
			this.browseButton = new System.Windows.Forms.Button();
			this.pathField = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.selectButton = new System.Windows.Forms.Button();
			this.rb_period_day = new System.Windows.Forms.RadioButton();
			this.rb_period_week = new System.Windows.Forms.RadioButton();
			this.rb_period_month = new System.Windows.Forms.RadioButton();
			this.rb_period_year = new System.Windows.Forms.RadioButton();
			this.periodBox = new System.Windows.Forms.GroupBox();
			this.rb_method_perweekday = new System.Windows.Forms.RadioButton();
			this.rb_method_perhour = new System.Windows.Forms.RadioButton();
			this.periodBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// elementHost1
			// 
			this.elementHost1.Location = new System.Drawing.Point(126, 12);
			this.elementHost1.Name = "elementHost1";
			this.elementHost1.Size = new System.Drawing.Size(1446, 310);
			this.elementHost1.TabIndex = 0;
			this.elementHost1.Text = "elementHost1";
			this.elementHost1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.elementHost1_ChildChanged);
			this.elementHost1.Child = this.cartesianChart1;
			// 
			// browseButton
			// 
			this.browseButton.Location = new System.Drawing.Point(1416, 328);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(75, 23);
			this.browseButton.TabIndex = 1;
			this.browseButton.Text = "Browse";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// pathField
			// 
			this.pathField.Location = new System.Drawing.Point(12, 330);
			this.pathField.Name = "pathField";
			this.pathField.Size = new System.Drawing.Size(1398, 20);
			this.pathField.TabIndex = 2;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// selectButton
			// 
			this.selectButton.Location = new System.Drawing.Point(1497, 328);
			this.selectButton.Name = "selectButton";
			this.selectButton.Size = new System.Drawing.Size(75, 23);
			this.selectButton.TabIndex = 3;
			this.selectButton.Text = "Select";
			this.selectButton.UseVisualStyleBackColor = true;
			this.selectButton.Click += new System.EventHandler(this.button2_Click);
			// 
			// rb_period_day
			// 
			this.rb_period_day.AutoSize = true;
			this.rb_period_day.Location = new System.Drawing.Point(6, 19);
			this.rb_period_day.Name = "rb_period_day";
			this.rb_period_day.Size = new System.Drawing.Size(57, 17);
			this.rb_period_day.TabIndex = 4;
			this.rb_period_day.Text = "m/Day";
			this.rb_period_day.UseVisualStyleBackColor = true;
			this.rb_period_day.CheckedChanged += new System.EventHandler(this.rb_period_day_CheckedChanged);
			// 
			// rb_period_week
			// 
			this.rb_period_week.AutoSize = true;
			this.rb_period_week.Location = new System.Drawing.Point(6, 42);
			this.rb_period_week.Name = "rb_period_week";
			this.rb_period_week.Size = new System.Drawing.Size(67, 17);
			this.rb_period_week.TabIndex = 5;
			this.rb_period_week.Text = "m/Week";
			this.rb_period_week.UseVisualStyleBackColor = true;
			this.rb_period_week.CheckedChanged += new System.EventHandler(this.rb_period_week_CheckedChanged);
			// 
			// rb_period_month
			// 
			this.rb_period_month.AutoSize = true;
			this.rb_period_month.Location = new System.Drawing.Point(6, 65);
			this.rb_period_month.Name = "rb_period_month";
			this.rb_period_month.Size = new System.Drawing.Size(68, 17);
			this.rb_period_month.TabIndex = 6;
			this.rb_period_month.Text = "m/Month";
			this.rb_period_month.UseVisualStyleBackColor = true;
			this.rb_period_month.CheckedChanged += new System.EventHandler(this.rb_period_month_CheckedChanged);
			// 
			// rb_period_year
			// 
			this.rb_period_year.AutoSize = true;
			this.rb_period_year.Location = new System.Drawing.Point(6, 88);
			this.rb_period_year.Name = "rb_period_year";
			this.rb_period_year.Size = new System.Drawing.Size(60, 17);
			this.rb_period_year.TabIndex = 7;
			this.rb_period_year.Text = "m/Year";
			this.rb_period_year.UseVisualStyleBackColor = true;
			this.rb_period_year.CheckedChanged += new System.EventHandler(this.rb_period_year_CheckedChanged);
			// 
			// periodBox
			// 
			this.periodBox.Controls.Add(this.rb_method_perweekday);
			this.periodBox.Controls.Add(this.rb_period_year);
			this.periodBox.Controls.Add(this.rb_method_perhour);
			this.periodBox.Controls.Add(this.rb_period_day);
			this.periodBox.Controls.Add(this.rb_period_month);
			this.periodBox.Controls.Add(this.rb_period_week);
			this.periodBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.periodBox.Location = new System.Drawing.Point(12, 6);
			this.periodBox.Name = "periodBox";
			this.periodBox.Size = new System.Drawing.Size(108, 316);
			this.periodBox.TabIndex = 9;
			this.periodBox.TabStop = false;
			this.periodBox.Text = "Method";
			// 
			// rb_method_perweekday
			// 
			this.rb_method_perweekday.AutoSize = true;
			this.rb_method_perweekday.Location = new System.Drawing.Point(6, 134);
			this.rb_method_perweekday.Name = "rb_method_perweekday";
			this.rb_method_perweekday.Size = new System.Drawing.Size(84, 17);
			this.rb_method_perweekday.TabIndex = 3;
			this.rb_method_perweekday.Text = "m/Weekday";
			this.rb_method_perweekday.UseVisualStyleBackColor = true;
			this.rb_method_perweekday.CheckedChanged += new System.EventHandler(this.rb_method_perweekday_CheckedChanged);
			// 
			// rb_method_perhour
			// 
			this.rb_method_perhour.AutoSize = true;
			this.rb_method_perhour.Location = new System.Drawing.Point(6, 111);
			this.rb_method_perhour.Name = "rb_method_perhour";
			this.rb_method_perhour.Size = new System.Drawing.Size(61, 17);
			this.rb_method_perhour.TabIndex = 2;
			this.rb_method_perhour.Text = "m/Hour";
			this.rb_method_perhour.UseVisualStyleBackColor = true;
			this.rb_method_perhour.CheckedChanged += new System.EventHandler(this.rb_method_perhour_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1584, 361);
			this.Controls.Add(this.periodBox);
			this.Controls.Add(this.selectButton);
			this.Controls.Add(this.pathField);
			this.Controls.Add(this.browseButton);
			this.Controls.Add(this.elementHost1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1600, 400);
			this.MinimumSize = new System.Drawing.Size(1600, 400);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "WhatsAppGrapher";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.periodBox.ResumeLayout(false);
			this.periodBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Integration.ElementHost elementHost1;
		private LiveCharts.Wpf.CartesianChart cartesianChart1;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.TextBox pathField;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button selectButton;
		private System.Windows.Forms.RadioButton rb_period_day;
		private System.Windows.Forms.RadioButton rb_period_week;
		private System.Windows.Forms.RadioButton rb_period_month;
		private System.Windows.Forms.RadioButton rb_period_year;
		private System.Windows.Forms.GroupBox periodBox;
		private System.Windows.Forms.RadioButton rb_method_perweekday;
		private System.Windows.Forms.RadioButton rb_method_perhour;
	}
}

