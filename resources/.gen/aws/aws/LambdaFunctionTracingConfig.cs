using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.LambdaFunctionTracingConfig")]
    public class LambdaFunctionTracingConfig : aws.ILambdaFunctionTracingConfig
    {
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Mode
        {
            get;
            set;
        }
    }
}
