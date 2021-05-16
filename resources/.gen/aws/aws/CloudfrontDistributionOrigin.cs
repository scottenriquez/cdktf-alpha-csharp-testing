using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CloudfrontDistributionOrigin")]
    public class CloudfrontDistributionOrigin : aws.ICloudfrontDistributionOrigin
    {
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DomainName
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

        /// <summary>custom_header block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginCustomHeader\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudfrontDistributionOriginCustomHeader[]? CustomHeader
        {
            get;
            set;
        }

        /// <summary>custom_origin_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customOriginConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginCustomOriginConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudfrontDistributionOriginCustomOriginConfig[]? CustomOriginConfig
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "originPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OriginPath
        {
            get;
            set;
        }

        /// <summary>s3_origin_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3OriginConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudfrontDistributionOriginS3OriginConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudfrontDistributionOriginS3OriginConfig[]? S3OriginConfig
        {
            get;
            set;
        }
    }
}
