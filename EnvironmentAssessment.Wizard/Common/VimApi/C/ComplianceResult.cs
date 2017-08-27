using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class ComplianceResult : DynamicData
	{
		protected ManagedObjectReference _profile;
		protected string _complianceStatus;
		protected ManagedObjectReference _entity;
		protected DateTime? _checkTime;
		protected ComplianceFailure[] _failure;
		protected ComplianceResult_LinkedView _linkedView;
		public ManagedObjectReference Profile
		{
			get
			{
				return this._profile;
			}
			set
			{
				this._profile = value;
			}
		}
		public string ComplianceStatus
		{
			get
			{
				return this._complianceStatus;
			}
			set
			{
				this._complianceStatus = value;
			}
		}
		public ManagedObjectReference Entity
		{
			get
			{
				return this._entity;
			}
			set
			{
				this._entity = value;
			}
		}
		public DateTime? CheckTime
		{
			get
			{
				return this._checkTime;
			}
			set
			{
				this._checkTime = value;
			}
		}
		public ComplianceFailure[] Failure
		{
			get
			{
				return this._failure;
			}
			set
			{
				this._failure = value;
			}
		}
		public ComplianceResult_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
