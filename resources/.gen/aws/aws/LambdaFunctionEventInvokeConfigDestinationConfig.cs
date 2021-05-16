using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LambdaFunctionEventInvokeConfigDestinationConfig")]
    public class LambdaFunctionEventInvokeConfigDestinationConfig : aws.ILambdaFunctionEventInvokeConfigDestinationConfig
    {
        /// <summary>on_failure block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onFailure", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionEventInvokeConfigDestinationConfigOnFailure\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure[]? OnFailure
        {
            get;
            set;
        }

        /// <summary>on_success block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onSuccess", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionEventInvokeConfigDestinationConfigOnSuccess\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ILambdaFunctionEventInvokeConfigDestinationConfigOnSuccess[]? OnSuccess
        {
            get;
            set;
        }
    }
}
