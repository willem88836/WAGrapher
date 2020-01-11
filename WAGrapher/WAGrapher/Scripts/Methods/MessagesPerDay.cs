using LiveCharts.Wpf;
using LiveCharts;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using Color = System.Windows.Media.Color;
using Brush = System.Windows.Media.Brush;

namespace WAGrapher.Methods
{
	public class MessagesPerDay : EvaluationMethod<CartesianChart, Dictionary<string, int>>
	{

		public override void Process(Message message)
		{
			base.Process(message);

			string date = message.Date.Date.ToString();
			Dictionary<string, int> data = DataPerSender[message.Sender];

			if (data.ContainsKey(date))
				data[date]++;
			else
			{
				var keys = DataPerSender.Keys;
				foreach(string key in keys)
				{
					if(!DataPerSender[key].ContainsKey(date))
						DataPerSender[key].Add(date, 1);
				}
			}
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

		//private Brush GenerateBrushFromName(string name)
		//{
		//	byte[] clr = new byte[3] { 0, 0, 0 };

		//	for (int j = 0; j < name.Length; j++)
		//	{
		//		int k = j % 3;
		//		clr[k] += (byte)name[j];
		//	}

		//	Color color = new Color()
		//	{
		//		R = clr[0],
		//		G = clr[1],
		//		B = clr[2]
		//	};

		//	System.Windows.Forms.MessageBox.Show(string.Format("Color: {0}", color.ToString()));

		//	return new SolidColorBrush(color);
		//}
	}
}
