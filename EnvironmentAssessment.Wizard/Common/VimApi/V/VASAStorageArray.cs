namespace EnvironmentAssessment.Common.VimApi
{
	public class VASAStorageArray : DynamicData
	{
		protected string _name;
		protected string _uuid;
		protected string _vendorId;
		protected string _modelId;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public string Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
			}
		}
		public string VendorId
		{
			get
			{
				return this._vendorId;
			}
			set
			{
				this._vendorId = value;
			}
		}
		public string ModelId
		{
			get
			{
				return this._modelId;
			}
			set
			{
				this._modelId = value;
			}
		}
	}
}
