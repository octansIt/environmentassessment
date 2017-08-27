namespace EnvironmentAssessment.Common.VimApi
{
	public class VMOnVirtualIntranet : CannotAccessNetwork
	{
		public new VMOnVirtualIntranet_LinkedView LinkedView
		{
			get
			{
				return (VMOnVirtualIntranet_LinkedView)this._linkedView;
			}
		}
	}
}
