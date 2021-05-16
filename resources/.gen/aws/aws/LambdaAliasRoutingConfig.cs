using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.LambdaAliasRoutingConfig")]
    public class LambdaAliasRoutingConfig : aws.ILambdaAliasRoutingConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "additionalVersionWeights", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, double>? AdditionalVersionWeights
        {
            get;
            set;
        }
    }
}
