namespace EnvironmentAssessment.Common.VISoap
{
    public class PatchBinariesNotFound : VimFault
	{
		protected string _patchID;
		protected string[] _binary;
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
		public string[] Binary
		{
			get
			{
				return this._binary;
			}
			set
			{
				this._binary = value;
			}
		}
	}
}
