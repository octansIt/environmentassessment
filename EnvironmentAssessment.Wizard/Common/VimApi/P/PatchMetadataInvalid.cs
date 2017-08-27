namespace EnvironmentAssessment.Common.VimApi
{
	public class PatchMetadataInvalid : VimFault
	{
		protected string _patchID;
		protected string[] _metaData;
		public string PatchID
		{
			get
			{
				return this._patchID;
			}
			set
			{
				this._patchID = value;
			}
		}
		public string[] MetaData
		{
			get
			{
				return this._metaData;
			}
			set
			{
				this._metaData = value;
			}
		}
	}
}
