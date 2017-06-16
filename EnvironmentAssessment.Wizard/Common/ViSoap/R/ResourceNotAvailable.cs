namespace EnvironmentAssessment.Common.VISoap
{
    public class ResourceNotAvailable : VimFault
	{
		protected string _containerType;
		protected string _containerName;
		protected string _type;
		public string ContainerType
		{
			get
			{
				return this._containerType;
			}
			set
			{
				this._containerType = value;
			}
		}
		public string ContainerName
		{
			get
			{
				return this._containerName;
			}
			set
			{
				this._containerName = value;
			}
		}
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
	}
}
