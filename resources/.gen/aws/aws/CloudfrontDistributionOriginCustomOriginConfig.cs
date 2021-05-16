using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudfrontDistributionOriginCustomOriginConfig")]
    public class CloudfrontDistributionOriginCustomOriginConfig : aws.ICloudfrontDistributionOriginCustomOriginConfig
    {
        [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double HttpPort
        {
            get;
            set;
        }

        [JsiiProperty(name: "httpsPort", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double HttpsPort
        {
            get;
            set;
        }

        [JsiiProperty(name: "originProtocolPolicy", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string OriginProtocolPolicy
        {
            get;
            set;
        }

        [JsiiProperty(name: "originSslProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] OriginSslProtocols
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "originKeepaliveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? OriginKeepaliveTimeout
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "originReadTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? OriginReadTimeout
        {
            get;
            set;
        }
    }
}
