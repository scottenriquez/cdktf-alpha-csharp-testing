using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LambdaEventSourceMappingDestinationConfig")]
    public class LambdaEventSourceMappingDestinationConfig : aws.ILambdaEventSourceMappingDestinationConfig
    {
        /// <summary>on_failure block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onFailure", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaEventSourceMappingDestinationConfigOnFailure\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILambdaEventSourceMappingDestinationConfigOnFailure[]? OnFailure
        {
            get;
            set;
        }
    }
}
