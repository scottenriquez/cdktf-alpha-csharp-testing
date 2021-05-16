using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.PinpointAppCampaignHook")]
    public class PinpointAppCampaignHook : aws.IPinpointAppCampaignHook
    {
        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LambdaFunctionName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Mode
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "webUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? WebUrl
        {
            get;
            set;
        }
    }
}
