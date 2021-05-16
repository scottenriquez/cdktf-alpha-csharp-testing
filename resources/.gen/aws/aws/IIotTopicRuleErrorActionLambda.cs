using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleErrorActionLambda), fullyQualifiedName: "aws.IotTopicRuleErrorActionLambda")]
    public interface IIotTopicRuleErrorActionLambda
    {
        [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
        string FunctionArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleErrorActionLambda), fullyQualifiedName: "aws.IotTopicRuleErrorActionLambda")]
        internal sealed class _Proxy : DeputyBase, aws.IIotTopicRuleErrorActionLambda
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
            public string FunctionArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
