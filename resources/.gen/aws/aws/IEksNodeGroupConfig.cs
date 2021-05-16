using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEksNodeGroupConfig), fullyQualifiedName: "aws.EksNodeGroupConfig")]
    public interface IEksNodeGroupConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterName
        {
            get;
        }

        [JsiiProperty(name: "nodeGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string NodeGroupName
        {
            get;
        }

        [JsiiProperty(name: "nodeRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string NodeRoleArn
        {
            get;
        }

        /// <summary>scaling_config block.</summary>
        [JsiiProperty(name: "scalingConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EksNodeGroupScalingConfig\"},\"kind\":\"array\"}}")]
        aws.IEksNodeGroupScalingConfig[] ScalingConfig
        {
            get;
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SubnetIds
        {
            get;
        }

        [JsiiProperty(name: "amiType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AmiType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DiskSize
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "forceUpdateVersion", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ForceUpdateVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "instanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? InstanceTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Labels
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "releaseVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReleaseVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>remote_access block.</summary>
        [JsiiProperty(name: "remoteAccess", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EksNodeGroupRemoteAccess\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEksNodeGroupRemoteAccess[]? RemoteAccess
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

        /// <summary>timeouts block.</summary>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.EksNodeGroupTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEksNodeGroupTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksNodeGroupConfig), fullyQualifiedName: "aws.EksNodeGroupConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IEksNodeGroupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "nodeGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "nodeRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>scaling_config block.</summary>
            [JsiiProperty(name: "scalingConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EksNodeGroupScalingConfig\"},\"kind\":\"array\"}}")]
            public aws.IEksNodeGroupScalingConfig[] ScalingConfig
            {
                get => GetInstanceProperty<aws.IEksNodeGroupScalingConfig[]>()!;
            }

            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SubnetIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "amiType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AmiType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DiskSize
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "forceUpdateVersion", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ForceUpdateVersion
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "instanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? InstanceTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Labels
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "releaseVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReleaseVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>remote_access block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "remoteAccess", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EksNodeGroupRemoteAccess\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEksNodeGroupRemoteAccess[]? RemoteAccess
            {
                get => GetInstanceProperty<aws.IEksNodeGroupRemoteAccess[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.EksNodeGroupTimeouts\"}", isOptional: true)]
            public aws.IEksNodeGroupTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.IEksNodeGroupTimeouts?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
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
