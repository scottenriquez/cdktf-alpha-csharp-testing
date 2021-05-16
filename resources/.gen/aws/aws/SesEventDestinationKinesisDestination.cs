using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SesEventDestinationKinesisDestination")]
    public class SesEventDestinationKinesisDestination : aws.ISesEventDestinationKinesisDestination
    {
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string StreamArn
        {
            get;
            set;
        }
    }
}
