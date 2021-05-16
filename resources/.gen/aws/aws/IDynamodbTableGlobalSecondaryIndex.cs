using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDynamodbTableGlobalSecondaryIndex), fullyQualifiedName: "aws.DynamodbTableGlobalSecondaryIndex")]
    public interface IDynamodbTableGlobalSecondaryIndex
    {
        [JsiiProperty(name: "hashKey", typeJson: "{\"primitive\":\"string\"}")]
        string HashKey
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "projectionType", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectionType
        {
            get;
        }

        [JsiiProperty(name: "nonKeyAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NonKeyAttributes
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RangeKey
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "readCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "writeCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WriteCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbTableGlobalSecondaryIndex), fullyQualifiedName: "aws.DynamodbTableGlobalSecondaryIndex")]
        internal sealed class _Proxy : DeputyBase, aws.IDynamodbTableGlobalSecondaryIndex
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "hashKey", typeJson: "{\"primitive\":\"string\"}")]
            public string HashKey
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "projectionType", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectionType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "nonKeyAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NonKeyAttributes
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RangeKey
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "readCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadCapacity
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "writeCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WriteCapacity
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
