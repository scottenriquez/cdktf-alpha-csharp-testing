using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.EmrCluster), fullyQualifiedName: "aws.EmrCluster", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.EmrClusterConfig\"}}]")]
    public class EmrCluster : HashiCorp.Cdktf.TerraformResource
    {
        public EmrCluster(Constructs.Construct scope, string id, aws.IEmrClusterConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrCluster(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAdditionalInfo")]
        public virtual void ResetAdditionalInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApplications")]
        public virtual void ResetApplications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoscalingRole")]
        public virtual void ResetAutoscalingRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBootstrapAction")]
        public virtual void ResetBootstrapAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigurations")]
        public virtual void ResetConfigurations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigurationsJson")]
        public virtual void ResetConfigurationsJson()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCoreInstanceCount")]
        public virtual void ResetCoreInstanceCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCoreInstanceGroup")]
        public virtual void ResetCoreInstanceGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCoreInstanceType")]
        public virtual void ResetCoreInstanceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomAmiId")]
        public virtual void ResetCustomAmiId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEbsRootVolumeSize")]
        public virtual void ResetEbsRootVolumeSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEc2Attributes")]
        public virtual void ResetEc2Attributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceGroup")]
        public virtual void ResetInstanceGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeepJobFlowAliveWhenNoSteps")]
        public virtual void ResetKeepJobFlowAliveWhenNoSteps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKerberosAttributes")]
        public virtual void ResetKerberosAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogUri")]
        public virtual void ResetLogUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMasterInstanceGroup")]
        public virtual void ResetMasterInstanceGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMasterInstanceType")]
        public virtual void ResetMasterInstanceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScaleDownBehavior")]
        public virtual void ResetScaleDownBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityConfiguration")]
        public virtual void ResetSecurityConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStep")]
        public virtual void ResetStep()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepConcurrencyLevel")]
        public virtual void ResetStepConcurrencyLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTerminationProtection")]
        public virtual void ResetTerminationProtection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVisibleToAllUsers")]
        public virtual void ResetVisibleToAllUsers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterPublicDns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterPublicDns
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "releaseLabelInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseLabelInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceRoleInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRoleInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalInfoInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdditionalInfoInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ApplicationsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoscalingRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutoscalingRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootstrapActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterBootstrapAction\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEmrClusterBootstrapAction[]? BootstrapActionInput
        {
            get => GetInstanceProperty<aws.IEmrClusterBootstrapAction[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigurationsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationsJsonInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigurationsJsonInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "coreInstanceCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CoreInstanceCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "coreInstanceGroupInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterCoreInstanceGroup\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEmrClusterCoreInstanceGroup[]? CoreInstanceGroupInput
        {
            get => GetInstanceProperty<aws.IEmrClusterCoreInstanceGroup[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "coreInstanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CoreInstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customAmiIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomAmiIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsRootVolumeSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EbsRootVolumeSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2AttributesInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterEc2Attributes\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEmrClusterEc2Attributes[]? Ec2AttributesInput
        {
            get => GetInstanceProperty<aws.IEmrClusterEc2Attributes[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceGroupInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterInstanceGroup\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEmrClusterInstanceGroup[]? InstanceGroupInput
        {
            get => GetInstanceProperty<aws.IEmrClusterInstanceGroup[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keepJobFlowAliveWhenNoStepsInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? KeepJobFlowAliveWhenNoStepsInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kerberosAttributesInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterKerberosAttributes\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEmrClusterKerberosAttributes[]? KerberosAttributesInput
        {
            get => GetInstanceProperty<aws.IEmrClusterKerberosAttributes[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterInstanceGroupInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterMasterInstanceGroup\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEmrClusterMasterInstanceGroup[]? MasterInstanceGroupInput
        {
            get => GetInstanceProperty<aws.IEmrClusterMasterInstanceGroup[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterInstanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MasterInstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleDownBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScaleDownBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityConfigurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityConfigurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepConcurrencyLevelInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StepConcurrencyLevelInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterStep\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEmrClusterStep[]? StepInput
        {
            get => GetInstanceProperty<aws.IEmrClusterStep[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminationProtectionInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? TerminationProtectionInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "visibleToAllUsersInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? VisibleToAllUsersInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiProperty(name: "additionalInfo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdditionalInfo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "applications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Applications
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoscalingRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoscalingRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bootstrapAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterBootstrapAction\"},\"kind\":\"array\"}}")]
        public virtual aws.IEmrClusterBootstrapAction[] BootstrapAction
        {
            get => GetInstanceProperty<aws.IEmrClusterBootstrapAction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configurations", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Configurations
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configurationsJson", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationsJson
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "coreInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CoreInstanceCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "coreInstanceGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterCoreInstanceGroup\"},\"kind\":\"array\"}}")]
        public virtual aws.IEmrClusterCoreInstanceGroup[] CoreInstanceGroup
        {
            get => GetInstanceProperty<aws.IEmrClusterCoreInstanceGroup[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "coreInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CoreInstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customAmiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomAmiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ebsRootVolumeSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EbsRootVolumeSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ec2Attributes", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterEc2Attributes\"},\"kind\":\"array\"}}")]
        public virtual aws.IEmrClusterEc2Attributes[] Ec2Attributes
        {
            get => GetInstanceProperty<aws.IEmrClusterEc2Attributes[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterInstanceGroup\"},\"kind\":\"array\"}}")]
        public virtual aws.IEmrClusterInstanceGroup[] InstanceGroup
        {
            get => GetInstanceProperty<aws.IEmrClusterInstanceGroup[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keepJobFlowAliveWhenNoSteps", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool KeepJobFlowAliveWhenNoSteps
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kerberosAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterKerberosAttributes\"},\"kind\":\"array\"}}")]
        public virtual aws.IEmrClusterKerberosAttributes[] KerberosAttributes
        {
            get => GetInstanceProperty<aws.IEmrClusterKerberosAttributes[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "masterInstanceGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterMasterInstanceGroup\"},\"kind\":\"array\"}}")]
        public virtual aws.IEmrClusterMasterInstanceGroup[] MasterInstanceGroup
        {
            get => GetInstanceProperty<aws.IEmrClusterMasterInstanceGroup[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "masterInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterInstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "releaseLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseLabel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scaleDownBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScaleDownBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityConfiguration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "step", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterStep\"},\"kind\":\"array\"}}")]
        public virtual aws.IEmrClusterStep[] Step
        {
            get => GetInstanceProperty<aws.IEmrClusterStep[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stepConcurrencyLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StepConcurrencyLevel
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "terminationProtection", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool TerminationProtection
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "visibleToAllUsers", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool VisibleToAllUsers
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }
    }
}
