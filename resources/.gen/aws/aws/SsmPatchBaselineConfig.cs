using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SsmPatchBaselineConfig")]
    public class SsmPatchBaselineConfig : aws.ISsmPatchBaselineConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>approval_rule block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "approvalRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmPatchBaselineApprovalRule\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISsmPatchBaselineApprovalRule[]? ApprovalRule
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "approvedPatches", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? ApprovedPatches
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "approvedPatchesComplianceLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ApprovedPatchesComplianceLevel
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>global_filter block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "globalFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmPatchBaselineGlobalFilter\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISsmPatchBaselineGlobalFilter[]? GlobalFilter
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OperatingSystem
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rejectedPatches", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? RejectedPatches
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
