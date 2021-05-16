using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudfrontDistributionOriginGroupMember")]
    public class CloudfrontDistributionOriginGroupMember : aws.ICloudfrontDistributionOriginGroupMember
    {
        [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string OriginId
        {
            get;
            set;
        }
    }
}
