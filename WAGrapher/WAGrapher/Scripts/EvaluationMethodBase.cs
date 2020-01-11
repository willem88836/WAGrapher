using LiveCharts.Wpf.Charts.Base;

namespace WAGrapher
{
	public abstract class EvaluationMethodBase
	{
		public virtual void Initialize() { }
		public abstract void Process(Message message);
		public abstract void DrawGraph(Chart chart);
	}
}
