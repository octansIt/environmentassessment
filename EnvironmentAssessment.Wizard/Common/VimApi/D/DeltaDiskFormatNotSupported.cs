namespace EnvironmentAssessment.Common.VimApi
{
	public class DeltaDiskFormatNotSupported : VmConfigFault
	{
		protected ManagedObjectReference[] _datastore;
		protected string _deltaDiskFormat;
		protected DeltaDiskFormatNotSupported_LinkedView _linkedView;
		public ManagedObjectReference[] Datastore
		{
			get
			{
				return this._datastore;
			}
			set
			{
				this._datastore = value;
			}
		}
		public string DeltaDiskFormat
		{
			get
			{
				return this._deltaDiskFormat;
			}
			set
			{
				this._deltaDiskFormat = value;
			}
		}
		public DeltaDiskFormatNotSupported_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
