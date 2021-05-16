using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainClusterConfigZoneAwarenessConfig), fullyQualifiedName: "aws.ElasticsearchDomainClusterConfigZoneAwarenessConfig")]
    public interface IElasticsearchDomainClusterConfigZoneAwarenessConfig
    {
        [JsiiProperty(name: "availabilityZoneCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AvailabilityZoneCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainClusterConfigZoneAwarenessConfig), fullyQualifiedName: "aws.ElasticsearchDomainClusterConfigZoneAwarenessConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IElasticsearchDomainClusterConfigZoneAwarenessConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "availabilityZoneCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AvailabilityZoneCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
