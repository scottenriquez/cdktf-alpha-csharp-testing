using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CloudformationStackSetTimeouts")]
    public class CloudformationStackSetTimeouts : aws.ICloudformationStackSetTimeouts
    {
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
