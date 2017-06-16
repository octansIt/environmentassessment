namespace EnvironmentAssessment.Common.VISoap
{
    public class InsufficientPerCpuCapacity : InsufficientHostCapacityFault
	{
		public new InsufficientPerCpuCapacity_LinkedView LinkedView
		{
			get
			{
				return (InsufficientPerCpuCapacity_LinkedView)this._linkedView;
			}
		}
	}
}
