using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElasticacheReplicationGroupClusterMode), fullyQualifiedName: "aws.ElasticacheReplicationGroupClusterMode")]
    public interface IElasticacheReplicationGroupClusterMode
    {
        [JsiiProperty(name: "numNodeGroups", typeJson: "{\"primitive\":\"number\"}")]
        double NumNodeGroups
        {
            get;
        }

        [JsiiProperty(name: "replicasPerNodeGroup", typeJson: "{\"primitive\":\"number\"}")]
        double ReplicasPerNodeGroup
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticacheReplicationGroupClusterMode), fullyQualifiedName: "aws.ElasticacheReplicationGroupClusterMode")]
        internal sealed class _Proxy : DeputyBase, aws.IElasticacheReplicationGroupClusterMode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "numNodeGroups", typeJson: "{\"primitive\":\"number\"}")]
            public double NumNodeGroups
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "replicasPerNodeGroup", typeJson: "{\"primitive\":\"number\"}")]
            public double ReplicasPerNodeGroup
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
