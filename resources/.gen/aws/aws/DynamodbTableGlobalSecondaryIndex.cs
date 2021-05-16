using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DynamodbTableGlobalSecondaryIndex")]
    public class DynamodbTableGlobalSecondaryIndex : aws.IDynamodbTableGlobalSecondaryIndex
    {
        [JsiiProperty(name: "hashKey", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string HashKey
        {
            get;
            set;
        }

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

        [JsiiOptional]
        [JsiiProperty(name: "nonKeyAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? NonKeyAttributes
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RangeKey
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "readCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ReadCapacity
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "writeCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? WriteCapacity
        {
            get;
            set;
        }
    }
}
