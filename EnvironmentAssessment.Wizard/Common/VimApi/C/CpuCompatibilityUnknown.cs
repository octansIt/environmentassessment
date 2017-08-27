namespace EnvironmentAssessment.Common.VimApi
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
