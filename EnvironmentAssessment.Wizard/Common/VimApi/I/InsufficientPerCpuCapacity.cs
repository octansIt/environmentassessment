namespace EnvironmentAssessment.Common.VimApi
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
