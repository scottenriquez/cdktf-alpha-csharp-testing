using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionDeadLetterConfig), fullyQualifiedName: "aws.LambdaFunctionDeadLetterConfig")]
    public interface ILambdaFunctionDeadLetterConfig
    {
        [JsiiProperty(name: "targetArn", typeJson: "{\"primitive\":\"string\"}")]
        string TargetArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionDeadLetterConfig), fullyQualifiedName: "aws.LambdaFunctionDeadLetterConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ILambdaFunctionDeadLetterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "targetArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
