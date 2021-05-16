using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KmsGrantConfig")]
    public class KmsGrantConfig : aws.IKmsGrantConfig
    {
        [JsiiProperty(name: "granteePrincipal", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string GranteePrincipal
        {
            get;
            set;
        }

        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string KeyId
        {
            get;
            set;
        }

        [JsiiProperty(name: "operations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Operations
        {
            get;
            set;
        }

        /// <summary>constraints block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "constraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.KmsGrantConstraints\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IKmsGrantConstraints[]? Constraints
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "grantCreationTokens", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? GrantCreationTokens
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Name
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "retireOnDelete", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? RetireOnDelete
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "retiringPrincipal", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RetiringPrincipal
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
