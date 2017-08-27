using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class HostSpecification : DynamicData
	{
		protected DateTime _createdTime;
		protected DateTime? _lastModified;
		protected ManagedObjectReference _host;
		protected HostSubSpecification[] _subSpecs;
		protected string _changeID;
		protected HostSpecification_LinkedView _linkedView;
		public DateTime CreatedTime
		{
			get
			{
				return this._createdTime;
			}
			set
			{
				this._createdTime = value;
			}
		}
		public DateTime? LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				this._lastModified = value;
			}
		}
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public HostSubSpecification[] SubSpecs
		{
			get
			{
				return this._subSpecs;
			}
			set
			{
				this._subSpecs = value;
			}
		}
		public string ChangeID
		{
			get
			{
				return this._changeID;
			}
			set
			{
				this._changeID = value;
			}
		}
		public HostSpecification_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
