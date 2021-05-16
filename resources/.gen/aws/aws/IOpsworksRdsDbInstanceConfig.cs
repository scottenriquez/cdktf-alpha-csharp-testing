using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IOpsworksRdsDbInstanceConfig), fullyQualifiedName: "aws.OpsworksRdsDbInstanceConfig")]
    public interface IOpsworksRdsDbInstanceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "dbPassword", typeJson: "{\"primitive\":\"string\"}")]
        string DbPassword
        {
            get;
        }

        [JsiiProperty(name: "dbUser", typeJson: "{\"primitive\":\"string\"}")]
        string DbUser
        {
            get;
        }

        [JsiiProperty(name: "rdsDbInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
        string RdsDbInstanceArn
        {
            get;
        }

        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
        string StackId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsworksRdsDbInstanceConfig), fullyQualifiedName: "aws.OpsworksRdsDbInstanceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IOpsworksRdsDbInstanceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "dbPassword", typeJson: "{\"primitive\":\"string\"}")]
            public string DbPassword
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "dbUser", typeJson: "{\"primitive\":\"string\"}")]
            public string DbUser
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "rdsDbInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RdsDbInstanceArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
            public string StackId
            {
                get => GetInstanceProperty<string>()!;
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
