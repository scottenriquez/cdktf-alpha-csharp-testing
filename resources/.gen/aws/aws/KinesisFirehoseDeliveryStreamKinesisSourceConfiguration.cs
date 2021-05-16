using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.KinesisFirehoseDeliveryStreamKinesisSourceConfiguration")]
    public class KinesisFirehoseDeliveryStreamKinesisSourceConfiguration : aws.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration
    {
        [JsiiProperty(name: "kinesisStreamArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string KinesisStreamArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }
    }
}
