using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.NeptuneClusterInstanceConfig")]
    public class NeptuneClusterInstanceConfig : aws.INeptuneClusterInstanceConfig
    {
        [JsiiProperty(name: "clusterIdentifier", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ClusterIdentifier
        {
            get;
            set;
        }

        [JsiiProperty(name: "instanceClass", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string InstanceClass
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applyImmediately", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ApplyImmediately
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoMinorVersionUpgrade", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AutoMinorVersionUpgrade
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AvailabilityZone
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Engine
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EngineVersion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Identifier
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "identifierPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IdentifierPrefix
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "neptuneParameterGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NeptuneParameterGroupName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "neptuneSubnetGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NeptuneSubnetGroupName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Port
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "preferredBackupWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PreferredBackupWindow
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "preferredMaintenanceWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PreferredMaintenanceWindow
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "promotionTier", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? PromotionTier
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? PubliclyAccessible
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

        /// <summary>timeouts block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.NeptuneClusterInstanceTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.INeptuneClusterInstanceTimeouts? Timeouts
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
