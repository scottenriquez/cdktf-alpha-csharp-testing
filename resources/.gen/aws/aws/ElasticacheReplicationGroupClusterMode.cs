using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ElasticacheReplicationGroupClusterMode")]
    public class ElasticacheReplicationGroupClusterMode : aws.IElasticacheReplicationGroupClusterMode
    {
        [JsiiProperty(name: "numNodeGroups", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double NumNodeGroups
        {
            get;
            set;
        }

        [JsiiProperty(name: "replicasPerNodeGroup", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double ReplicasPerNodeGroup
        {
            get;
            set;
        }
    }
}
