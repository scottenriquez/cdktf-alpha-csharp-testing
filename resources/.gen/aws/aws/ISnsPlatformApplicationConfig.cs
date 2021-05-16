using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISnsPlatformApplicationConfig), fullyQualifiedName: "aws.SnsPlatformApplicationConfig")]
    public interface ISnsPlatformApplicationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}")]
        string Platform
        {
            get;
        }

        [JsiiProperty(name: "platformCredential", typeJson: "{\"primitive\":\"string\"}")]
        string PlatformCredential
        {
            get;
        }

        [JsiiProperty(name: "eventDeliveryFailureTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventDeliveryFailureTopicArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "eventEndpointCreatedTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventEndpointCreatedTopicArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "eventEndpointDeletedTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventEndpointDeletedTopicArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "eventEndpointUpdatedTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventEndpointUpdatedTopicArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "failureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FailureFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "platformPrincipal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlatformPrincipal
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "successFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SuccessFeedbackRoleArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "successFeedbackSampleRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SuccessFeedbackSampleRate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISnsPlatformApplicationConfig), fullyQualifiedName: "aws.SnsPlatformApplicationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ISnsPlatformApplicationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}")]
            public string Platform
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "platformCredential", typeJson: "{\"primitive\":\"string\"}")]
            public string PlatformCredential
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "eventDeliveryFailureTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventDeliveryFailureTopicArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "eventEndpointCreatedTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventEndpointCreatedTopicArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "eventEndpointDeletedTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventEndpointDeletedTopicArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "eventEndpointUpdatedTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventEndpointUpdatedTopicArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "failureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FailureFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "platformPrincipal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlatformPrincipal
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "successFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SuccessFeedbackRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "successFeedbackSampleRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SuccessFeedbackSampleRate
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
