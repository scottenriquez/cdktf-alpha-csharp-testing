using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CodepipelineWebhookAuthenticationConfiguration")]
    public class CodepipelineWebhookAuthenticationConfiguration : aws.ICodepipelineWebhookAuthenticationConfiguration
    {
        [JsiiOptional]
        [JsiiProperty(name: "allowedIpRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AllowedIpRange
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SecretToken
        {
            get;
            set;
        }
    }
}
