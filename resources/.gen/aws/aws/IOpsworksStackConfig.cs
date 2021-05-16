using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IOpsworksStackConfig), fullyQualifiedName: "aws.OpsworksStackConfig")]
    public interface IOpsworksStackConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "defaultInstanceProfileArn", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultInstanceProfileArn
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceRoleArn
        {
            get;
        }

        [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AgentVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "berkshelfVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BerkshelfVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "color", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Color
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "configurationManagerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConfigurationManagerName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "configurationManagerVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConfigurationManagerVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_cookbooks_source block.</summary>
        [JsiiProperty(name: "customCookbooksSource", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksStackCustomCookbooksSource\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IOpsworksStackCustomCookbooksSource[]? CustomCookbooksSource
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "customJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomJson
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "defaultAvailabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultAvailabilityZone
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "defaultOs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultOs
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "defaultRootDeviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultRootDeviceType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "defaultSshKeyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultSshKeyName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "defaultSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultSubnetId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "hostnameTheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostnameTheme
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "manageBerkshelf", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ManageBerkshelf
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

        [JsiiProperty(name: "useCustomCookbooks", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? UseCustomCookbooks
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "useOpsworksSecurityGroups", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? UseOpsworksSecurityGroups
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpcId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsworksStackConfig), fullyQualifiedName: "aws.OpsworksStackConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IOpsworksStackConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "defaultInstanceProfileArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultInstanceProfileArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AgentVersion
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "berkshelfVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BerkshelfVersion
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "color", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Color
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "configurationManagerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConfigurationManagerName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "configurationManagerVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConfigurationManagerVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>custom_cookbooks_source block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customCookbooksSource", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksStackCustomCookbooksSource\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IOpsworksStackCustomCookbooksSource[]? CustomCookbooksSource
            {
                get => GetInstanceProperty<aws.IOpsworksStackCustomCookbooksSource[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "customJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomJson
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "defaultAvailabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultAvailabilityZone
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "defaultOs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultOs
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "defaultRootDeviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultRootDeviceType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "defaultSshKeyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultSshKeyName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "defaultSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultSubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "hostnameTheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostnameTheme
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "manageBerkshelf", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ManageBerkshelf
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "useCustomCookbooks", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? UseCustomCookbooks
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "useOpsworksSecurityGroups", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? UseOpsworksSecurityGroups
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpcId
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
