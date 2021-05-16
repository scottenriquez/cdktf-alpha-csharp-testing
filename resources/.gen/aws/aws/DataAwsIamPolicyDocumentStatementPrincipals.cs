using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DataAwsIamPolicyDocumentStatementPrincipals")]
    public class DataAwsIamPolicyDocumentStatementPrincipals : aws.IDataAwsIamPolicyDocumentStatementPrincipals
    {
        [JsiiProperty(name: "identifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Identifiers
        {
            get;
            set;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }
    }
}
