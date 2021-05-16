using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodepipelineWebhookAuthenticationConfiguration), fullyQualifiedName: "aws.CodepipelineWebhookAuthenticationConfiguration")]
    public interface ICodepipelineWebhookAuthenticationConfiguration
    {
        [JsiiProperty(name: "allowedIpRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllowedIpRange
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "secretToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretToken
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodepipelineWebhookAuthenticationConfiguration), fullyQualifiedName: "aws.CodepipelineWebhookAuthenticationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ICodepipelineWebhookAuthenticationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "allowedIpRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllowedIpRange
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "secretToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretToken
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
