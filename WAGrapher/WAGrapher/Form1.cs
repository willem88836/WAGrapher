using System;
using System.Windows.Forms;
using LiveCharts;
using System.Threading;
using WAGrapher.Methods;

namespace WAGrapher
{
	public partial class Form1 : Form
	{
		private EvaluationMethodBase[] methods = new EvaluationMethodBase[]
		{
			new MessagesPerDay(),
			new MessagesPerWeekDay(),
			new MessagesPerHour(),
			new MessagesPerMonth(),
			new MessagesPerWeek(),
			new MessagesPerYear()
		};
		private WhatsAppGrapher grapher;


		public Form1()
		{
			grapher = new WhatsAppGrapher(methods);
			InitializeComponent();
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			cartesianChart1.Zoom = ZoomingOptions.X;
		}


		private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
		{

		}


		private void button1_Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = pathField.Text;
			DialogResult result = openFileDialog1.ShowDialog();
			pathField.Text = openFileDialog1.FileName;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			new Thread(new ThreadStart(delegate
			{
				try
				{
					grapher.Analyse(pathField.Text);
				}
				catch (Exception ex)
				{
					MessageBox.Show(string.Format("error: {0}", ex.Message));
				}
			})).Start();
		}


		private void rb_period_day_CheckedChanged(object sender, EventArgs e)
		{
			RedrawGraph(0);
		}

		private void rb_period_week_CheckedChanged(object sender, EventArgs e)
		{
			RedrawGraph(4);
		}

		private void rb_period_month_CheckedChanged(object sender, EventArgs e)
		{
			RedrawGraph(3);
		}

		private void rb_period_year_CheckedChanged(object sender, EventArgs e)
		{
			RedrawGraph(5);
		}

		private void rb_method_perhour_CheckedChanged(object sender, EventArgs e)
		{
			RedrawGraph(2);
		}

		private void rb_method_perweekday_CheckedChanged(object sender, EventArgs e)
		{
			RedrawGraph(1);
		}


		private void RedrawGraph(int index)
		{
			try
			{
				cartesianChart1.Series.Clear();
				cartesianChart1.AxisX.Clear();
				methods[index].DrawGraph(cartesianChart1);
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("error: {0}", ex.Message));
			}
		}
	}
}
