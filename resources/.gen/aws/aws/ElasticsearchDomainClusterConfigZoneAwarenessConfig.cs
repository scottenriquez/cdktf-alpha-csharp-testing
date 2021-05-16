using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.ElasticsearchDomainClusterConfigZoneAwarenessConfig")]
    public class ElasticsearchDomainClusterConfigZoneAwarenessConfig : aws.IElasticsearchDomainClusterConfigZoneAwarenessConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZoneCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? AvailabilityZoneCount
        {
            get;
            set;
        }
    }
}
