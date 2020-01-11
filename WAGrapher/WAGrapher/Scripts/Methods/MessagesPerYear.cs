using LiveCharts;
using LiveCharts.Wpf;
using System.Collections.Generic;
using System.Linq;

namespace WAGrapher.Methods
{
	public class MessagesPerYear : EvaluationMethod<CartesianChart, Dictionary<string, int>>
	{
		public override void Process(Message message)
		{
			base.Process(message);

			string date = message.Date.Year.ToString();

			Dictionary<string, int> data = DataPerSender[message.Sender];

			if (!data.ContainsKey(date))
				data.Add(date, 0);

			data[date]++;
		}

		protected override void DrawGraph(CartesianChart chart)
		{
			var keys = DataPerSender.Keys.ToArray();

			foreach (string key in keys)
			{
				Dictionary<string, int> data = DataPerSender[key];

				LineSeries lineSeries = new LineSeries()
				{
					Title = key,
					PointGeometry = DefaultGeometries.Circle,
					LineSmoothness = 0.0d,
					Values = new ChartValues<int>(data.Values.ToArray())
				};

				chart.Series.Add(lineSeries);

				System.Console.WriteLine(lineSeries.Values.Count);
			}

			chart.AxisX.Clear();
			chart.AxisX.Add(new Axis()
			{
				Title = this.GetType().ToString(),
				Labels = DataPerSender[keys[0]].Keys.ToArray()
			});
		}
	}
}
