using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketObjectLockConfigurationRuleDefaultRetention")]
    public class S3BucketObjectLockConfigurationRuleDefaultRetention : aws.IS3BucketObjectLockConfigurationRuleDefaultRetention
    {
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Mode
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Days
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "years", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Years
        {
            get;
            set;
        }
    }
}
