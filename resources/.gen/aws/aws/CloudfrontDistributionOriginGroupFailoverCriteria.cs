using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudfrontDistributionOriginGroupFailoverCriteria")]
    public class CloudfrontDistributionOriginGroupFailoverCriteria : aws.ICloudfrontDistributionOriginGroupFailoverCriteria
    {
        [JsiiProperty(name: "statusCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOverride: true)]
        public double[] StatusCodes
        {
            get;
            set;
        }
    }
}
