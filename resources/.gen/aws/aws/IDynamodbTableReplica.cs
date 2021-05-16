using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDynamodbTableReplica), fullyQualifiedName: "aws.DynamodbTableReplica")]
    public interface IDynamodbTableReplica
    {
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
        string RegionName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbTableReplica), fullyQualifiedName: "aws.DynamodbTableReplica")]
        internal sealed class _Proxy : DeputyBase, aws.IDynamodbTableReplica
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
            public string RegionName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
