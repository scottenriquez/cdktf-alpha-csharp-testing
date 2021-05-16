using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.WorklinkFleetConfig")]
    public class WorklinkFleetConfig : aws.IWorklinkFleetConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "auditStreamArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AuditStreamArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceCaCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeviceCaCertificate
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        /// <summary>identity_provider block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityProvider", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WorklinkFleetIdentityProvider\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWorklinkFleetIdentityProvider[]? IdentityProvider
        {
            get;
            set;
        }

        /// <summary>network block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "network", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WorklinkFleetNetwork\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWorklinkFleetNetwork[]? Network
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "optimizeForEndUserLocation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? OptimizeForEndUserLocation
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
