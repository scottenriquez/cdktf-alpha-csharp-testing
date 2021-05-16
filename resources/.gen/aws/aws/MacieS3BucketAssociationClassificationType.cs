using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.MacieS3BucketAssociationClassificationType")]
    public class MacieS3BucketAssociationClassificationType : aws.IMacieS3BucketAssociationClassificationType
    {
        [JsiiOptional]
        [JsiiProperty(name: "continuous", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Continuous
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "oneTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OneTime
        {
            get;
            set;
        }
    }
}
