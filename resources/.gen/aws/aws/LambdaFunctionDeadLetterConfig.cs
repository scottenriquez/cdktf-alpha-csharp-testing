using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.LambdaFunctionDeadLetterConfig")]
    public class LambdaFunctionDeadLetterConfig : aws.ILambdaFunctionDeadLetterConfig
    {
        [JsiiProperty(name: "targetArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TargetArn
        {
            get;
            set;
        }
    }
}
