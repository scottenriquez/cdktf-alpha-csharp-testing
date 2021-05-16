using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LambdaFunctionEnvironment")]
    public class LambdaFunctionEnvironment : aws.ILambdaFunctionEnvironment
    {
        [JsiiOptional]
        [JsiiProperty(name: "variables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Variables
        {
            get;
            set;
        }
    }
}
