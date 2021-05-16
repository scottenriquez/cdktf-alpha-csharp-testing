using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.LambdaPermissionConfig")]
    public class LambdaPermissionConfig : aws.ILambdaPermissionConfig
    {
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Action
        {
            get;
            set;
        }

        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string FunctionName
        {
            get;
            set;
        }

        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Principal
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventSourceToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EventSourceToken
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "qualifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Qualifier
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SourceAccount
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SourceArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "statementId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StatementId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "statementIdPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StatementIdPrefix
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
