using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ElasticsearchDomainEbsOptions")]
    public class ElasticsearchDomainEbsOptions : aws.IElasticsearchDomainEbsOptions
    {
        [JsiiProperty(name: "ebsEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOverride: true)]
        public bool EbsEnabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Iops
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? VolumeSize
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? VolumeType
        {
            get;
            set;
        }
    }
}
