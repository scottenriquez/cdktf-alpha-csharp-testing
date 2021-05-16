using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEksFargateProfileConfig), fullyQualifiedName: "aws.EksFargateProfileConfig")]
    public interface IEksFargateProfileConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterName
        {
            get;
        }

        [JsiiProperty(name: "fargateProfileName", typeJson: "{\"primitive\":\"string\"}")]
        string FargateProfileName
        {
            get;
        }

        [JsiiProperty(name: "podExecutionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string PodExecutionRoleArn
        {
            get;
        }

        /// <summary>selector block.</summary>
        [JsiiProperty(name: "selector", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EksFargateProfileSelector\"},\"kind\":\"array\"}}")]
        aws.IEksFargateProfileSelector[] Selector
        {
            get;
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubnetIds
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
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.EksFargateProfileTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEksFargateProfileTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksFargateProfileConfig), fullyQualifiedName: "aws.EksFargateProfileConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IEksFargateProfileConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "fargateProfileName", typeJson: "{\"primitive\":\"string\"}")]
            public string FargateProfileName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "podExecutionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string PodExecutionRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>selector block.</summary>
            [JsiiProperty(name: "selector", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EksFargateProfileSelector\"},\"kind\":\"array\"}}")]
            public aws.IEksFargateProfileSelector[] Selector
            {
                get => GetInstanceProperty<aws.IEksFargateProfileSelector[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubnetIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.EksFargateProfileTimeouts\"}", isOptional: true)]
            public aws.IEksFargateProfileTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.IEksFargateProfileTimeouts?>();
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
