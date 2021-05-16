using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudwatchLogDestinationPolicyConfig), fullyQualifiedName: "aws.CloudwatchLogDestinationPolicyConfig")]
    public interface ICloudwatchLogDestinationPolicyConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "accessPolicy", typeJson: "{\"primitive\":\"string\"}")]
        string AccessPolicy
        {
            get;
        }

        [JsiiProperty(name: "destinationName", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchLogDestinationPolicyConfig), fullyQualifiedName: "aws.CloudwatchLogDestinationPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudwatchLogDestinationPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "accessPolicy", typeJson: "{\"primitive\":\"string\"}")]
            public string AccessPolicy
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "destinationName", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationName
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
