using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class ResourceConfigSpec : DynamicData
	{
		protected ManagedObjectReference _entity;
		protected string _changeVersion;
		protected DateTime? _lastModified;
		protected ResourceAllocationInfo _cpuAllocation;
		protected ResourceAllocationInfo _memoryAllocation;
		protected ResourceConfigSpec_LinkedView _linkedView;
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
		public string ChangeVersion
		{
			get
			{
				return this._changeVersion;
			}
			set
			{
				this._changeVersion = value;
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
		public ResourceAllocationInfo CpuAllocation
		{
			get
			{
				return this._cpuAllocation;
			}
			set
			{
				this._cpuAllocation = value;
			}
		}
		public ResourceAllocationInfo MemoryAllocation
		{
			get
			{
				return this._memoryAllocation;
			}
			set
			{
				this._memoryAllocation = value;
			}
		}
		public ResourceConfigSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
