namespace EnvironmentAssessment.Common.VimApi
{
	public class InaccessibleFTMetadataDatastore : InaccessibleDatastore
	{
		public new InaccessibleFTMetadataDatastore_LinkedView LinkedView
		{
			get
			{
				return (InaccessibleFTMetadataDatastore_LinkedView)this._linkedView;
			}
		}
	}
}
