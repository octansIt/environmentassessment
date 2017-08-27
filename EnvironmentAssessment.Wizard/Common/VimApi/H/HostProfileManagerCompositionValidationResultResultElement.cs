namespace EnvironmentAssessment.Common.VimApi
{
	public class HostProfileManagerCompositionValidationResultResultElement : DynamicData
	{
		protected ManagedObjectReference _target;
		protected string _status;
		protected LocalizableMessage[] _errors;
		protected HostApplyProfile _sourceDiffForToBeMerged;
		protected HostApplyProfile _targetDiffForToBeMerged;
		protected HostApplyProfile _toBeAdded;
		protected HostApplyProfile _toBeDeleted;
		protected HostApplyProfile _toBeDisabled;
		protected HostApplyProfile _toBeEnabled;
		protected HostApplyProfile _toBeReenableCC;
		protected HostProfileManagerCompositionValidationResultResultElement_LinkedView _linkedView;
		public ManagedObjectReference Target
		{
			get
			{
				return this._target;
			}
			set
			{
				this._target = value;
			}
		}
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
			}
		}
		public LocalizableMessage[] Errors
		{
			get
			{
				return this._errors;
			}
			set
			{
				this._errors = value;
			}
		}
		public HostApplyProfile SourceDiffForToBeMerged
		{
			get
			{
				return this._sourceDiffForToBeMerged;
			}
			set
			{
				this._sourceDiffForToBeMerged = value;
			}
		}
		public HostApplyProfile TargetDiffForToBeMerged
		{
			get
			{
				return this._targetDiffForToBeMerged;
			}
			set
			{
				this._targetDiffForToBeMerged = value;
			}
		}
		public HostApplyProfile ToBeAdded
		{
			get
			{
				return this._toBeAdded;
			}
			set
			{
				this._toBeAdded = value;
			}
		}
		public HostApplyProfile ToBeDeleted
		{
			get
			{
				return this._toBeDeleted;
			}
			set
			{
				this._toBeDeleted = value;
			}
		}
		public HostApplyProfile ToBeDisabled
		{
			get
			{
				return this._toBeDisabled;
			}
			set
			{
				this._toBeDisabled = value;
			}
		}
		public HostApplyProfile ToBeEnabled
		{
			get
			{
				return this._toBeEnabled;
			}
			set
			{
				this._toBeEnabled = value;
			}
		}
		public HostApplyProfile ToBeReenableCC
		{
			get
			{
				return this._toBeReenableCC;
			}
			set
			{
				this._toBeReenableCC = value;
			}
		}
		public HostProfileManagerCompositionValidationResultResultElement_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
