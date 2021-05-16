using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketInventorySchedule")]
    public class S3BucketInventorySchedule : aws.IS3BucketInventorySchedule
    {
        [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Frequency
        {
            get;
            set;
        }
    }
}
