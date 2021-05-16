using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISqsQueuePolicyConfig), fullyQualifiedName: "aws.SqsQueuePolicyConfig")]
    public interface ISqsQueuePolicyConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        string Policy
        {
            get;
        }

        [JsiiProperty(name: "queueUrl", typeJson: "{\"primitive\":\"string\"}")]
        string QueueUrl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISqsQueuePolicyConfig), fullyQualifiedName: "aws.SqsQueuePolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ISqsQueuePolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
            public string Policy
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "queueUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string QueueUrl
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
