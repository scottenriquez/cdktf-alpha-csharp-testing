using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleLambda), fullyQualifiedName: "aws.IotTopicRuleLambda")]
    public interface IIotTopicRuleLambda
    {
        [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
        string FunctionArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleLambda), fullyQualifiedName: "aws.IotTopicRuleLambda")]
        internal sealed class _Proxy : DeputyBase, aws.IIotTopicRuleLambda
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
