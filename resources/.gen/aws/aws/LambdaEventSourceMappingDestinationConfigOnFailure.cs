using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.LambdaEventSourceMappingDestinationConfigOnFailure")]
    public class LambdaEventSourceMappingDestinationConfigOnFailure : aws.ILambdaEventSourceMappingDestinationConfigOnFailure
    {
        [JsiiProperty(name: "destinationArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DestinationArn
        {
            get;
            set;
        }
    }
}
