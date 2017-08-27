namespace EnvironmentAssessment.Common.VimApi
{
	public class MissingProperty : DynamicData
	{
		protected string _path;
		protected LocalizedMethodFault _fault;
		public string Path
		{
			get
			{
				return this._path;
			}
			set
			{
				this._path = value;
			}
		}
		public LocalizedMethodFault Fault
		{
			get
			{
				return this._fault;
			}
			set
			{
				this._fault = value;
			}
		}
	}
}
