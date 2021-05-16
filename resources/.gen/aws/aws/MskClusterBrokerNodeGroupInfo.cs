using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.MskClusterBrokerNodeGroupInfo")]
    public class MskClusterBrokerNodeGroupInfo : aws.IMskClusterBrokerNodeGroupInfo
    {
        [JsiiProperty(name: "clientSubnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] ClientSubnets
        {
            get;
            set;
        }

        [JsiiProperty(name: "ebsVolumeSize", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double EbsVolumeSize
        {
            get;
            set;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string InstanceType
        {
            get;
            set;
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] SecurityGroups
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "azDistribution", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AzDistribution
        {
            get;
            set;
        }
    }
}
