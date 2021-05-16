using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudfrontDistributionLoggingConfig")]
    public class CloudfrontDistributionLoggingConfig : aws.ICloudfrontDistributionLoggingConfig
    {
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Bucket
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeCookies", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IncludeCookies
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Prefix
        {
            get;
            set;
        }
    }
}
