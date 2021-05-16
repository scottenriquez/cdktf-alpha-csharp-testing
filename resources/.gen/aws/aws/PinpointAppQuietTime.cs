using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.PinpointAppQuietTime")]
    public class PinpointAppQuietTime : aws.IPinpointAppQuietTime
    {
        [JsiiOptional]
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? End
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Start
        {
            get;
            set;
        }
    }
}
