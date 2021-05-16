using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.DataAwsIamPolicyDocumentStatement")]
    public class DataAwsIamPolicyDocumentStatement : aws.IDataAwsIamPolicyDocumentStatement
    {
        [JsiiOptional]
        [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Actions
        {
            get;
            set;
        }

        /// <summary>condition block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "condition", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsIamPolicyDocumentStatementCondition\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDataAwsIamPolicyDocumentStatementCondition[]? Condition
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Effect
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "notActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? NotActions
        {
            get;
            set;
        }

        /// <summary>not_principals block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notPrincipals", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsIamPolicyDocumentStatementNotPrincipals\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDataAwsIamPolicyDocumentStatementNotPrincipals[]? NotPrincipals
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "notResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? NotResources
        {
            get;
            set;
        }

        /// <summary>principals block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "principals", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsIamPolicyDocumentStatementPrincipals\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDataAwsIamPolicyDocumentStatementPrincipals[]? Principals
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Resources
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sid", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Sid
        {
            get;
            set;
        }
    }
}
