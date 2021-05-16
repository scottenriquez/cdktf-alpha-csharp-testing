using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionFileSystemConfig), fullyQualifiedName: "aws.LambdaFunctionFileSystemConfig")]
    public interface ILambdaFunctionFileSystemConfig
    {
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        [JsiiProperty(name: "localMountPath", typeJson: "{\"primitive\":\"string\"}")]
        string LocalMountPath
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionFileSystemConfig), fullyQualifiedName: "aws.LambdaFunctionFileSystemConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ILambdaFunctionFileSystemConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "localMountPath", typeJson: "{\"primitive\":\"string\"}")]
            public string LocalMountPath
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
