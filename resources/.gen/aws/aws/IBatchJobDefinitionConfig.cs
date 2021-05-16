using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IBatchJobDefinitionConfig), fullyQualifiedName: "aws.BatchJobDefinitionConfig")]
    public interface IBatchJobDefinitionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiProperty(name: "containerProperties", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContainerProperties
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>retry_strategy block.</summary>
        [JsiiProperty(name: "retryStrategy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BatchJobDefinitionRetryStrategy\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IBatchJobDefinitionRetryStrategy[]? RetryStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeout block.</summary>
        [JsiiProperty(name: "timeout", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BatchJobDefinitionTimeout\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IBatchJobDefinitionTimeout[]? Timeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchJobDefinitionConfig), fullyQualifiedName: "aws.BatchJobDefinitionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IBatchJobDefinitionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "containerProperties", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContainerProperties
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Parameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>retry_strategy block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retryStrategy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BatchJobDefinitionRetryStrategy\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IBatchJobDefinitionRetryStrategy[]? RetryStrategy
            {
                get => GetInstanceProperty<aws.IBatchJobDefinitionRetryStrategy[]?>();
            }

            /// <summary>timeout block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BatchJobDefinitionTimeout\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IBatchJobDefinitionTimeout[]? Timeout
            {
                get => GetInstanceProperty<aws.IBatchJobDefinitionTimeout[]?>();
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
