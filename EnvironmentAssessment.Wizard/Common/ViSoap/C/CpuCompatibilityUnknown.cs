namespace EnvironmentAssessment.Common.VISoap
{
    public class CpuCompatibilityUnknown : CpuIncompatible
	{
		public new CpuCompatibilityUnknown_LinkedView LinkedView
		{
			get
			{
				return (CpuCompatibilityUnknown_LinkedView)this._linkedView;
			}
		}
	}
}
