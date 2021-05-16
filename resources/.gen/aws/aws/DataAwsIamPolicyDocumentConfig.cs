using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.DataAwsIamPolicyDocumentConfig")]
    public class DataAwsIamPolicyDocumentConfig : aws.IDataAwsIamPolicyDocumentConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "overrideJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OverrideJson
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PolicyId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SourceJson
        {
            get;
            set;
        }

        /// <summary>statement block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsIamPolicyDocumentStatement\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDataAwsIamPolicyDocumentStatement[]? Statement
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Version
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
