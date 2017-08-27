using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class FailoverClusterManager : ViewBase
	{
		protected string[] _disabledClusterMethod;
		public string[] DisabledClusterMethod
		{
			get
			{
				return this._disabledClusterMethod;
			}
		}
		public FailoverClusterManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference setClusterMode_Task(string mode)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim55)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim60)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				setClusterModeRequestType setClusterModeRequestType = new setClusterModeRequestType();
				setClusterModeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				setClusterModeRequestType.mode = mode;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.setClusterMode_Task(new setClusterMode_TaskRequest(setClusterModeRequestType)).setClusterMode_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void setClusterMode(string mode)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim55)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim60)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = this.setClusterMode_Task(mode);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public string getClusterMode()
		{
			string returnval;
			try
			{
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim55)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim60)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				getClusterModeRequestType getClusterModeRequestType = new getClusterModeRequestType();
				getClusterModeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				returnval = this.VimServiceProxy.getClusterMode(new getClusterModeRequest(getClusterModeRequestType)).getClusterModeResponse.returnval;
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return returnval;
		}
		public VchaClusterHealth GetVchaClusterHealth()
		{
			VchaClusterHealth result;
			try
			{
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim55)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim60)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				GetVchaClusterHealthRequestType getVchaClusterHealthRequestType = new GetVchaClusterHealthRequestType();
				getVchaClusterHealthRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (VchaClusterHealth)VIConvert.ToVim(this.VimServiceProxy.GetVchaClusterHealth(new GetVchaClusterHealthRequest(getVchaClusterHealthRequestType)).GetVchaClusterHealthResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference initiateFailover_Task(bool planned)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim55)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim60)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				initiateFailoverRequestType initiateFailoverRequestType = new initiateFailoverRequestType();
				initiateFailoverRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				initiateFailoverRequestType.planned = planned;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.initiateFailover_Task(new initiateFailover_TaskRequest(initiateFailoverRequestType)).initiateFailover_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void initiateFailover(bool planned)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim51)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim55)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim60)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = this.initiateFailover_Task(planned);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
