namespace EnvironmentAssessment.Common.VimApi
{
	public class HostUnresolvedVmfsVolumeResolveStatus : DynamicData
	{
		protected bool _resolvable;
		protected bool? _incompleteExtents;
		protected bool? _multipleCopies;
		public bool Resolvable
		{
			get
			{
				return this._resolvable;
			}
			set
			{
				this._resolvable = value;
			}
		}
		public bool? IncompleteExtents
		{
			get
			{
				return this._incompleteExtents;
			}
			set
			{
				this._incompleteExtents = value;
			}
		}
		public bool? MultipleCopies
		{
			get
			{
				return this._multipleCopies;
			}
			set
			{
				this._multipleCopies = value;
			}
		}
	}
}
