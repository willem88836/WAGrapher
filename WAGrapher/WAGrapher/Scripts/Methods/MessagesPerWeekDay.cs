using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WAGrapher.Methods
{
	public class MessagesPerWeekDay : EvaluationMethod<CartesianChart, Dictionary<DayOfWeek, int>>
	{
		public override void Process(Message message)
		{
			base.Process(message);

			DayOfWeek dayOfWeek = message.Date.DayOfWeek;

			Dictionary<DayOfWeek, int> data = DataPerSender[message.Sender];

			if (!data.ContainsKey(dayOfWeek))
			{
				foreach(DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
				{
					data.Add(day, 0);
				}
			}

			data[dayOfWeek]++;
		}

		protected override void DrawGraph(CartesianChart chart)
		{
			var keys = DataPerSender.Keys.ToArray();

			foreach(string key in keys)
			{
				Dictionary<DayOfWeek, int> data = DataPerSender[key];

				LineSeries lineSeries = new LineSeries()
				{
					Title = key,
					PointGeometry = DefaultGeometries.Circle,
					LineSmoothness = 0.0d,
					Values = new ChartValues<int>(data.Values.ToArray())
				};

				chart.Series.Add(lineSeries);
			}

			chart.AxisX.Add(new Axis()
			{
				Title = this.GetType().ToString(),
				Labels = Enum.GetNames(typeof(DayOfWeek))
			});
		}
	}
}
