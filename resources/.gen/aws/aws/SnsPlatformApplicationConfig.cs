using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SnsPlatformApplicationConfig")]
    public class SnsPlatformApplicationConfig : aws.ISnsPlatformApplicationConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Platform
        {
            get;
            set;
        }

        [JsiiProperty(name: "platformCredential", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string PlatformCredential
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventDeliveryFailureTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EventDeliveryFailureTopicArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventEndpointCreatedTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EventEndpointCreatedTopicArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventEndpointDeletedTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EventEndpointDeletedTopicArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventEndpointUpdatedTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EventEndpointUpdatedTopicArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "failureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FailureFeedbackRoleArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformPrincipal", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PlatformPrincipal
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "successFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SuccessFeedbackRoleArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "successFeedbackSampleRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SuccessFeedbackSampleRate
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
