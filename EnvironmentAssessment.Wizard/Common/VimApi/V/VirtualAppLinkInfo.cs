namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualAppLinkInfo : DynamicData
	{
		protected ManagedObjectReference _key;
		protected bool? _destroyWithParent;
		protected VirtualAppLinkInfo_LinkedView _linkedView;
		public ManagedObjectReference Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public bool? DestroyWithParent
		{
			get
			{
				return this._destroyWithParent;
			}
			set
			{
				this._destroyWithParent = value;
			}
		}
		public VirtualAppLinkInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
