using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class OnceTaskScheduler : TaskScheduler
	{
		protected DateTime? _runAt;
		public DateTime? RunAt
		{
			get
			{
				return this._runAt;
			}
			set
			{
				this._runAt = value;
			}
		}
	}
}
