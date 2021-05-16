using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IOpsworksNodejsAppLayerConfig), fullyQualifiedName: "aws.OpsworksNodejsAppLayerConfig")]
    public interface IOpsworksNodejsAppLayerConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
        string StackId
        {
            get;
        }

        [JsiiProperty(name: "autoAssignElasticIps", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AutoAssignElasticIps
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "autoAssignPublicIps", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AutoAssignPublicIps
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "autoHealing", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AutoHealing
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "customConfigureRecipes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CustomConfigureRecipes
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "customDeployRecipes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CustomDeployRecipes
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "customInstanceProfileArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomInstanceProfileArn
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

        [JsiiProperty(name: "customSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CustomSecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "customSetupRecipes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CustomSetupRecipes
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "customShutdownRecipes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CustomShutdownRecipes
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "customUndeployRecipes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CustomUndeployRecipes
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "drainElbOnShutdown", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? DrainElbOnShutdown
        {
            get
            {
                return null;
            }
        }

        /// <summary>ebs_volume block.</summary>
        [JsiiProperty(name: "ebsVolume", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksNodejsAppLayerEbsVolume\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IOpsworksNodejsAppLayerEbsVolume[]? EbsVolume
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "elasticLoadBalancer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ElasticLoadBalancer
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "installUpdatesOnBoot", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? InstallUpdatesOnBoot
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "instanceShutdownTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InstanceShutdownTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "nodejsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodejsVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "systemPackages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SystemPackages
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

        [JsiiProperty(name: "useEbsOptimizedInstances", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? UseEbsOptimizedInstances
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsworksNodejsAppLayerConfig), fullyQualifiedName: "aws.OpsworksNodejsAppLayerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IOpsworksNodejsAppLayerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
            public string StackId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "autoAssignElasticIps", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AutoAssignElasticIps
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "autoAssignPublicIps", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AutoAssignPublicIps
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "autoHealing", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AutoHealing
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "customConfigureRecipes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CustomConfigureRecipes
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "customDeployRecipes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CustomDeployRecipes
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "customInstanceProfileArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomInstanceProfileArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "customJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomJson
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "customSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CustomSecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "customSetupRecipes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CustomSetupRecipes
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "customShutdownRecipes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CustomShutdownRecipes
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "customUndeployRecipes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CustomUndeployRecipes
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "drainElbOnShutdown", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? DrainElbOnShutdown
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>ebs_volume block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ebsVolume", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.OpsworksNodejsAppLayerEbsVolume\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IOpsworksNodejsAppLayerEbsVolume[]? EbsVolume
            {
                get => GetInstanceProperty<aws.IOpsworksNodejsAppLayerEbsVolume[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "elasticLoadBalancer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ElasticLoadBalancer
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "installUpdatesOnBoot", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? InstallUpdatesOnBoot
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "instanceShutdownTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InstanceShutdownTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "nodejsVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodejsVersion
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "systemPackages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SystemPackages
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "useEbsOptimizedInstances", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? UseEbsOptimizedInstances
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
