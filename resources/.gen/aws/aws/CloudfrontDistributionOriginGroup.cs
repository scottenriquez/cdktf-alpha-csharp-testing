using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudfrontDistributionOriginGroup")]
    public class CloudfrontDistributionOriginGroup : aws.ICloudfrontDistributionOriginGroup
    {
        /// <summary>failover_criteria block.</summary>
        [JsiiProperty(name: "failoverCriteria", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginGroupFailoverCriteria\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ICloudfrontDistributionOriginGroupFailoverCriteria[] FailoverCriteria
        {
            get;
            set;
        }

        /// <summary>member block.</summary>
        [JsiiProperty(name: "member", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginGroupMember\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ICloudfrontDistributionOriginGroupMember[] Member
        {
            get;
            set;
        }

        [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string OriginId
        {
            get;
            set;
        }
    }
}
