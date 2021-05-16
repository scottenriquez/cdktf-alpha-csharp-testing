using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.S3AccessPointPublicAccessBlockConfiguration")]
    public class S3AccessPointPublicAccessBlockConfiguration : aws.IS3AccessPointPublicAccessBlockConfiguration
    {
        [JsiiOptional]
        [JsiiProperty(name: "blockPublicAcls", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? BlockPublicAcls
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockPublicPolicy", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? BlockPublicPolicy
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ignorePublicAcls", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IgnorePublicAcls
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "restrictPublicBuckets", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? RestrictPublicBuckets
        {
            get;
            set;
        }
    }
}
