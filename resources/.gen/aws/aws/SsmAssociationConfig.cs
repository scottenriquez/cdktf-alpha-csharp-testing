using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SsmAssociationConfig")]
    public class SsmAssociationConfig : aws.ISsmAssociationConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "associationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AssociationName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "automationTargetParameterName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AutomationTargetParameterName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "complianceSeverity", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ComplianceSeverity
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "documentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DocumentVersion
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InstanceId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrency", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MaxConcurrency
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxErrors", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? MaxErrors
        {
            get;
            set;
        }

        /// <summary>output_location block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputLocation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmAssociationOutputLocation\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISsmAssociationOutputLocation[]? OutputLocation
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ScheduleExpression
        {
            get;
            set;
        }

        /// <summary>targets block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmAssociationTargets\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISsmAssociationTargets[]? Targets
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
