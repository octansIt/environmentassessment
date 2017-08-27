using System;
using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class FailoverClusterConfigurator : ViewBase
	{
		protected string[] _disabledConfigureMethod;
		public string[] DisabledConfigureMethod
		{
			get
			{
				return this._disabledConfigureMethod;
			}
		}
		public FailoverClusterConfigurator(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference prepareVcha_Task(VchaClusterNetworkSpec networkSpec)
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
				prepareVchaRequestType prepareVchaRequestType = new prepareVchaRequestType();
				prepareVchaRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				prepareVchaRequestType.networkSpec = (VimApi_65.VchaClusterNetworkSpec)VIConvert.ToWsdlType(networkSpec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.prepareVcha_Task(new prepareVcha_TaskRequest(prepareVchaRequestType)).prepareVcha_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void prepareVcha(VchaClusterNetworkSpec networkSpec)
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
				ManagedObjectReference taskReference = this.prepareVcha_Task(networkSpec);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference deployVcha_Task(VchaClusterDeploymentSpec deploymentSpec)
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
				deployVchaRequestType deployVchaRequestType = new deployVchaRequestType();
				deployVchaRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				deployVchaRequestType.deploymentSpec = (VimApi_65.VchaClusterDeploymentSpec)VIConvert.ToWsdlType(deploymentSpec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.deployVcha_Task(new deployVcha_TaskRequest(deployVchaRequestType)).deployVcha_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void deployVcha(VchaClusterDeploymentSpec deploymentSpec)
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
				ManagedObjectReference taskReference = this.deployVcha_Task(deploymentSpec);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference configureVcha_Task(VchaClusterConfigSpec configSpec)
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
				configureVchaRequestType configureVchaRequestType = new configureVchaRequestType();
				configureVchaRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				configureVchaRequestType.configSpec = (VimApi_65.VchaClusterConfigSpec)VIConvert.ToWsdlType(configSpec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.configureVcha_Task(new configureVcha_TaskRequest(configureVchaRequestType)).configureVcha_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void configureVcha(VchaClusterConfigSpec configSpec)
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
				ManagedObjectReference taskReference = this.configureVcha_Task(configSpec);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference createPassiveNode_Task(PassiveNodeDeploymentSpec passiveDeploymentSpec, SourceNodeSpec sourceVcSpec)
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
				createPassiveNodeRequestType createPassiveNodeRequestType = new createPassiveNodeRequestType();
				createPassiveNodeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createPassiveNodeRequestType.passiveDeploymentSpec = (VimApi_65.PassiveNodeDeploymentSpec)VIConvert.ToWsdlType(passiveDeploymentSpec);
				createPassiveNodeRequestType.sourceVcSpec = (VimApi_65.SourceNodeSpec)VIConvert.ToWsdlType(sourceVcSpec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.createPassiveNode_Task(new createPassiveNode_TaskRequest(createPassiveNodeRequestType)).createPassiveNode_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void createPassiveNode(PassiveNodeDeploymentSpec passiveDeploymentSpec, SourceNodeSpec sourceVcSpec)
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
				ManagedObjectReference taskReference = this.createPassiveNode_Task(passiveDeploymentSpec, sourceVcSpec);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public ManagedObjectReference createWitnessNode_Task(NodeDeploymentSpec witnessDeploymentSpec, SourceNodeSpec sourceVcSpec)
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
				createWitnessNodeRequestType createWitnessNodeRequestType = new createWitnessNodeRequestType();
				createWitnessNodeRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				createWitnessNodeRequestType.witnessDeploymentSpec = (VimApi_65.NodeDeploymentSpec)VIConvert.ToWsdlType(witnessDeploymentSpec);
				createWitnessNodeRequestType.sourceVcSpec = (VimApi_65.SourceNodeSpec)VIConvert.ToWsdlType(sourceVcSpec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.createWitnessNode_Task(new createWitnessNode_TaskRequest(createWitnessNodeRequestType)).createWitnessNode_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void createWitnessNode(NodeDeploymentSpec witnessDeploymentSpec, SourceNodeSpec sourceVcSpec)
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
				ManagedObjectReference taskReference = this.createWitnessNode_Task(witnessDeploymentSpec, sourceVcSpec);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public VchaClusterConfigInfo getVchaConfig()
		{
			VchaClusterConfigInfo result;
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
				getVchaConfigRequestType getVchaConfigRequestType = new getVchaConfigRequestType();
				getVchaConfigRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (VchaClusterConfigInfo)VIConvert.ToVim(this.VimServiceProxy.getVchaConfig(new getVchaConfigRequest(getVchaConfigRequestType)).getVchaConfigResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public ManagedObjectReference destroyVcha_Task()
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
				destroyVchaRequestType destroyVchaRequestType = new destroyVchaRequestType();
				destroyVchaRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.destroyVcha_Task(new destroyVcha_TaskRequest(destroyVchaRequestType)).destroyVcha_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void destroyVcha()
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
				ManagedObjectReference taskReference = this.destroyVcha_Task();
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
