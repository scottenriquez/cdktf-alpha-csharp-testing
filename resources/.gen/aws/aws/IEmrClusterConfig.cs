using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEmrClusterConfig), fullyQualifiedName: "aws.EmrClusterConfig")]
    public interface IEmrClusterConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "releaseLabel", typeJson: "{\"primitive\":\"string\"}")]
        string ReleaseLabel
        {
            get;
        }

        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceRole
        {
            get;
        }

        [JsiiProperty(name: "additionalInfo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdditionalInfo
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "applications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Applications
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "autoscalingRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutoscalingRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>bootstrap_action block.</summary>
        [JsiiProperty(name: "bootstrapAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterBootstrapAction\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEmrClusterBootstrapAction[]? BootstrapAction
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "configurations", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Configurations
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "configurationsJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConfigurationsJson
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "coreInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CoreInstanceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>core_instance_group block.</summary>
        [JsiiProperty(name: "coreInstanceGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterCoreInstanceGroup\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEmrClusterCoreInstanceGroup[]? CoreInstanceGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "coreInstanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CoreInstanceType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "customAmiId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomAmiId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "ebsRootVolumeSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EbsRootVolumeSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>ec2_attributes block.</summary>
        [JsiiProperty(name: "ec2Attributes", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterEc2Attributes\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEmrClusterEc2Attributes[]? Ec2Attributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>instance_group block.</summary>
        [JsiiProperty(name: "instanceGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterInstanceGroup\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEmrClusterInstanceGroup[]? InstanceGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "keepJobFlowAliveWhenNoSteps", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? KeepJobFlowAliveWhenNoSteps
        {
            get
            {
                return null;
            }
        }

        /// <summary>kerberos_attributes block.</summary>
        [JsiiProperty(name: "kerberosAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterKerberosAttributes\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEmrClusterKerberosAttributes[]? KerberosAttributes
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "logUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>master_instance_group block.</summary>
        [JsiiProperty(name: "masterInstanceGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterMasterInstanceGroup\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEmrClusterMasterInstanceGroup[]? MasterInstanceGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "masterInstanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MasterInstanceType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "scaleDownBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScaleDownBehavior
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "step", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterStep\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEmrClusterStep[]? Step
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "stepConcurrencyLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StepConcurrencyLevel
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "terminationProtection", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? TerminationProtection
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "visibleToAllUsers", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? VisibleToAllUsers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterConfig), fullyQualifiedName: "aws.EmrClusterConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IEmrClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "releaseLabel", typeJson: "{\"primitive\":\"string\"}")]
            public string ReleaseLabel
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceRole
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "additionalInfo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdditionalInfo
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "applications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Applications
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "autoscalingRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutoscalingRole
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>bootstrap_action block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bootstrapAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterBootstrapAction\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEmrClusterBootstrapAction[]? BootstrapAction
            {
                get => GetInstanceProperty<aws.IEmrClusterBootstrapAction[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "configurations", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Configurations
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "configurationsJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConfigurationsJson
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "coreInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CoreInstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>core_instance_group block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "coreInstanceGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterCoreInstanceGroup\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEmrClusterCoreInstanceGroup[]? CoreInstanceGroup
            {
                get => GetInstanceProperty<aws.IEmrClusterCoreInstanceGroup[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "coreInstanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CoreInstanceType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "customAmiId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomAmiId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "ebsRootVolumeSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EbsRootVolumeSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>ec2_attributes block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ec2Attributes", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterEc2Attributes\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEmrClusterEc2Attributes[]? Ec2Attributes
            {
                get => GetInstanceProperty<aws.IEmrClusterEc2Attributes[]?>();
            }

            /// <summary>instance_group block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterInstanceGroup\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEmrClusterInstanceGroup[]? InstanceGroup
            {
                get => GetInstanceProperty<aws.IEmrClusterInstanceGroup[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "keepJobFlowAliveWhenNoSteps", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? KeepJobFlowAliveWhenNoSteps
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>kerberos_attributes block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kerberosAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterKerberosAttributes\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEmrClusterKerberosAttributes[]? KerberosAttributes
            {
                get => GetInstanceProperty<aws.IEmrClusterKerberosAttributes[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "logUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>master_instance_group block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "masterInstanceGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterMasterInstanceGroup\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEmrClusterMasterInstanceGroup[]? MasterInstanceGroup
            {
                get => GetInstanceProperty<aws.IEmrClusterMasterInstanceGroup[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "masterInstanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MasterInstanceType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "scaleDownBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScaleDownBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityConfiguration
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "step", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterStep\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEmrClusterStep[]? Step
            {
                get => GetInstanceProperty<aws.IEmrClusterStep[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "stepConcurrencyLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StepConcurrencyLevel
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "terminationProtection", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? TerminationProtection
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "visibleToAllUsers", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? VisibleToAllUsers
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
