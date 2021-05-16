using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecLoggingAccessLogFile), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecLoggingAccessLogFile")]
    public interface IAppmeshVirtualNodeSpecLoggingAccessLogFile
    {
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecLoggingAccessLogFile), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecLoggingAccessLogFile")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshVirtualNodeSpecLoggingAccessLogFile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
