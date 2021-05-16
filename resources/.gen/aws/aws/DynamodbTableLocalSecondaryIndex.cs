using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DynamodbTableLocalSecondaryIndex")]
    public class DynamodbTableLocalSecondaryIndex : aws.IDynamodbTableLocalSecondaryIndex
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "projectionType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ProjectionType
        {
            get;
            set;
        }

        [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RangeKey
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nonKeyAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? NonKeyAttributes
        {
            get;
            set;
        }
    }
}
