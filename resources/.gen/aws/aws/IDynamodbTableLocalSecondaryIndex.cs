using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDynamodbTableLocalSecondaryIndex), fullyQualifiedName: "aws.DynamodbTableLocalSecondaryIndex")]
    public interface IDynamodbTableLocalSecondaryIndex
    {
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

        [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}")]
        string RangeKey
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

        [JsiiTypeProxy(nativeType: typeof(IDynamodbTableLocalSecondaryIndex), fullyQualifiedName: "aws.DynamodbTableLocalSecondaryIndex")]
        internal sealed class _Proxy : DeputyBase, aws.IDynamodbTableLocalSecondaryIndex
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
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

            [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}")]
            public string RangeKey
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "nonKeyAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NonKeyAttributes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
