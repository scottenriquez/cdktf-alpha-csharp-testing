using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DataAwsIamPolicyDocumentStatementCondition")]
    public class DataAwsIamPolicyDocumentStatementCondition : aws.IDataAwsIamPolicyDocumentStatementCondition
    {
        [JsiiProperty(name: "test", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Test
        {
            get;
            set;
        }

        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Values
        {
            get;
            set;
        }

        [JsiiProperty(name: "variable", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Variable
        {
            get;
            set;
        }
    }
}
