using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDynamodbGlobalTableReplica), fullyQualifiedName: "aws.DynamodbGlobalTableReplica")]
    public interface IDynamodbGlobalTableReplica
    {
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
        string RegionName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbGlobalTableReplica), fullyQualifiedName: "aws.DynamodbGlobalTableReplica")]
        internal sealed class _Proxy : DeputyBase, aws.IDynamodbGlobalTableReplica
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
