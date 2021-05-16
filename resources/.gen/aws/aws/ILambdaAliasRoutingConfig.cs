using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILambdaAliasRoutingConfig), fullyQualifiedName: "aws.LambdaAliasRoutingConfig")]
    public interface ILambdaAliasRoutingConfig
    {
        [JsiiProperty(name: "additionalVersionWeights", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, double>? AdditionalVersionWeights
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaAliasRoutingConfig), fullyQualifiedName: "aws.LambdaAliasRoutingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ILambdaAliasRoutingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "additionalVersionWeights", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, double>? AdditionalVersionWeights
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, double>?>();
            }
        }
    }
}
