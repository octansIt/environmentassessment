namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfDuplicatedPropertyIdExport : OvfExport
	{
		protected string _fqid;
		public string Fqid
		{
			get
			{
				return this._fqid;
			}
			set
			{
				this._fqid = value;
			}
		}
	}
}
