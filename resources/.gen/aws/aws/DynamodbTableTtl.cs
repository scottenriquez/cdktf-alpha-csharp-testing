using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DynamodbTableTtl")]
    public class DynamodbTableTtl : aws.IDynamodbTableTtl
    {
        [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AttributeName
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
    }
}
