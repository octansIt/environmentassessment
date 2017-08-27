namespace EnvironmentAssessment.Common.VimApi
{
	public class BaseConfigInfoFileBackingInfo : BaseConfigInfoBackingInfo
	{
		protected string _filePath;
		protected string _backingObjectId;
		protected BaseConfigInfoFileBackingInfo _parent;
		protected long? _deltaSizeInMB;
		public string FilePath
		{
			get
			{
				return this._filePath;
			}
			set
			{
				this._filePath = value;
			}
		}
		public string BackingObjectId
		{
			get
			{
				return this._backingObjectId;
			}
			set
			{
				this._backingObjectId = value;
			}
		}
		public BaseConfigInfoFileBackingInfo Parent
		{
			get
			{
				return this._parent;
			}
			set
			{
				this._parent = value;
			}
		}
		public long? DeltaSizeInMB
		{
			get
			{
				return this._deltaSizeInMB;
			}
			set
			{
				this._deltaSizeInMB = value;
			}
		}
		public new BaseConfigInfoFileBackingInfo_LinkedView LinkedView
		{
			get
			{
				return (BaseConfigInfoFileBackingInfo_LinkedView)this._linkedView;
			}
		}
	}
}
