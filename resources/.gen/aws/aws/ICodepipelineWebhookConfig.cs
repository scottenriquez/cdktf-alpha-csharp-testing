using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodepipelineWebhookConfig), fullyQualifiedName: "aws.CodepipelineWebhookConfig")]
    public interface ICodepipelineWebhookConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "authentication", typeJson: "{\"primitive\":\"string\"}")]
        string Authentication
        {
            get;
        }

        /// <summary>filter block.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodepipelineWebhookFilter\"},\"kind\":\"array\"}}")]
        aws.ICodepipelineWebhookFilter[] Filter
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "targetAction", typeJson: "{\"primitive\":\"string\"}")]
        string TargetAction
        {
            get;
        }

        [JsiiProperty(name: "targetPipeline", typeJson: "{\"primitive\":\"string\"}")]
        string TargetPipeline
        {
            get;
        }

        /// <summary>authentication_configuration block.</summary>
        [JsiiProperty(name: "authenticationConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodepipelineWebhookAuthenticationConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodepipelineWebhookAuthenticationConfiguration[]? AuthenticationConfiguration
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

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineWebhookConfig), fullyQualifiedName: "aws.CodepipelineWebhookConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICodepipelineWebhookConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "authentication", typeJson: "{\"primitive\":\"string\"}")]
            public string Authentication
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>filter block.</summary>
            [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodepipelineWebhookFilter\"},\"kind\":\"array\"}}")]
            public aws.ICodepipelineWebhookFilter[] Filter
            {
                get => GetInstanceProperty<aws.ICodepipelineWebhookFilter[]>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "targetAction", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetAction
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "targetPipeline", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetPipeline
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>authentication_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authenticationConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodepipelineWebhookAuthenticationConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodepipelineWebhookAuthenticationConfiguration[]? AuthenticationConfiguration
            {
                get => GetInstanceProperty<aws.ICodepipelineWebhookAuthenticationConfiguration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
