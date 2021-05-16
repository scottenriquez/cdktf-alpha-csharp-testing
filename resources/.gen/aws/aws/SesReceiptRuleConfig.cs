using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SesReceiptRuleConfig")]
    public class SesReceiptRuleConfig : aws.ISesReceiptRuleConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "ruleSetName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RuleSetName
        {
            get;
            set;
        }

        /// <summary>add_header_action block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "addHeaderAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleAddHeaderAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISesReceiptRuleAddHeaderAction[]? AddHeaderAction
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "after", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? After
        {
            get;
            set;
        }

        /// <summary>bounce_action block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bounceAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleBounceAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISesReceiptRuleBounceAction[]? BounceAction
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

        /// <summary>lambda_action block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleLambdaAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISesReceiptRuleLambdaAction[]? LambdaAction
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "recipients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Recipients
        {
            get;
            set;
        }

        /// <summary>s3_action block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3Action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleS3Action\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISesReceiptRuleS3Action[]? S3Action
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "scanEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ScanEnabled
        {
            get;
            set;
        }

        /// <summary>sns_action block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snsAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleSnsAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISesReceiptRuleSnsAction[]? SnsAction
        {
            get;
            set;
        }

        /// <summary>stop_action block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stopAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleStopAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISesReceiptRuleStopAction[]? StopAction
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TlsPolicy
        {
            get;
            set;
        }

        /// <summary>workmail_action block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "workmailAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SesReceiptRuleWorkmailAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ISesReceiptRuleWorkmailAction[]? WorkmailAction
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
