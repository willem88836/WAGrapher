using LiveCharts.Wpf.Charts.Base;
using System;
using System.Collections.Generic;

namespace WAGrapher
{
	public abstract class EvaluationMethod<T, T1> : EvaluationMethodBase where T : Chart
	{
		protected Dictionary<string, T1> DataPerSender = new Dictionary<string, T1>();

		public override void Initialize()
		{
			base.Initialize();
			DataPerSender.Clear();
		}

		public override void Process(Message message)
		{
			string sender = message.Sender;
			if (!DataPerSender.ContainsKey(sender))
			{
				DataPerSender.Add(sender, (T1)Activator.CreateInstance(typeof(T1)));
			}
		}

		public override void DrawGraph(Chart chart)
		{
			DrawGraph((T)chart);
		}

		protected abstract void DrawGraph(T chart);
	}
}
