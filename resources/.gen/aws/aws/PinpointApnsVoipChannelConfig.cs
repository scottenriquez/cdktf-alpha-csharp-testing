using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.PinpointApnsVoipChannelConfig")]
    public class PinpointApnsVoipChannelConfig : aws.IPinpointApnsVoipChannelConfig
    {
        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ApplicationId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bundleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BundleId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Certificate
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultAuthenticationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DefaultAuthenticationMethod
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Enabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PrivateKey
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "teamId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TeamId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tokenKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TokenKey
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tokenKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TokenKeyId
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
