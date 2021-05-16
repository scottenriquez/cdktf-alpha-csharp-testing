using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.StoragegatewayGatewayConfig")]
    public class StoragegatewayGatewayConfig : aws.IStoragegatewayGatewayConfig
    {
        [JsiiProperty(name: "gatewayName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string GatewayName
        {
            get;
            set;
        }

        [JsiiProperty(name: "gatewayTimezone", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string GatewayTimezone
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ActivationKey
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CloudwatchLogGroupArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? GatewayIpAddress
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? GatewayType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayVpcEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? GatewayVpcEndpoint
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "mediumChangerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MediumChangerType
        {
            get;
            set;
        }

        /// <summary>smb_active_directory_settings block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "smbActiveDirectorySettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.StoragegatewayGatewaySmbActiveDirectorySettings\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IStoragegatewayGatewaySmbActiveDirectorySettings[]? SmbActiveDirectorySettings
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "smbGuestPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SmbGuestPassword
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tapeDriveType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TapeDriveType
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.StoragegatewayGatewayTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IStoragegatewayGatewayTimeouts? Timeouts
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
