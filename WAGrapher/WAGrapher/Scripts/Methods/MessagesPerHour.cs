using LiveCharts;
using LiveCharts.Wpf;
using System.Collections.Generic;
using System.Linq;

namespace WAGrapher.Methods
{
	public class MessagesPerHour : EvaluationMethod<CartesianChart, Dictionary<int, int>>
	{
		public override void Process(Message message)
		{
			base.Process(message);

			int hourOfDay = message.Date.Hour; 

			Dictionary<int,int> data = DataPerSender[message.Sender];

			if (!data.ContainsKey(hourOfDay))
			{
				for (int i = 0; i < 24; i++)
					data.Add(i, 0);
			}

			data[hourOfDay]++;
		}

		protected override void DrawGraph(CartesianChart chart)
		{
			var keys = DataPerSender.Keys.ToArray();

			foreach(string key in keys)
			{
				Dictionary<int, int> data = DataPerSender[key];

				LineSeries lineSeries = new LineSeries()
				{
					Title = key,
					PointGeometry = DefaultGeometries.Circle,
					LineSmoothness = 0.0d,
					Values = new ChartValues<int>(data.Values.ToArray())
				};

				chart.Series.Add(lineSeries);
			}

			string[] labels = new string[24];
			for (int i = 0; i < 24; i++)
				labels[i] = i.ToString();


			chart.AxisX.Add(new Axis()
			{
				Title = this.GetType().ToString(),
				Labels = labels
			});
		}
	}
}
