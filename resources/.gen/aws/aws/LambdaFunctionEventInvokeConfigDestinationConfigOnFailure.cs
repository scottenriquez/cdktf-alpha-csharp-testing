using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.LambdaFunctionEventInvokeConfigDestinationConfigOnFailure")]
    public class LambdaFunctionEventInvokeConfigDestinationConfigOnFailure : aws.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure
    {
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Destination
        {
            get;
            set;
        }
    }
}
