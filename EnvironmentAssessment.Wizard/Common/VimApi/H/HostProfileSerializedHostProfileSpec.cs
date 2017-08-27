namespace EnvironmentAssessment.Common.VimApi
{
	public class HostProfileSerializedHostProfileSpec : ProfileSerializedCreateSpec
	{
		protected ManagedObjectReference _validatorHost;
		protected bool? _validating;
		protected HostProfileSerializedHostProfileSpec_LinkedView _linkedView;
		public ManagedObjectReference ValidatorHost
		{
			get
			{
				return this._validatorHost;
			}
			set
			{
				this._validatorHost = value;
			}
		}
		public bool? Validating
		{
			get
			{
				return this._validating;
			}
			set
			{
				this._validating = value;
			}
		}
		public HostProfileSerializedHostProfileSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
