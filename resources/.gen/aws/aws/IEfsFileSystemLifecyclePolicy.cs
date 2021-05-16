using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEfsFileSystemLifecyclePolicy), fullyQualifiedName: "aws.EfsFileSystemLifecyclePolicy")]
    public interface IEfsFileSystemLifecyclePolicy
    {
        [JsiiProperty(name: "transitionToIa", typeJson: "{\"primitive\":\"string\"}")]
        string TransitionToIa
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEfsFileSystemLifecyclePolicy), fullyQualifiedName: "aws.EfsFileSystemLifecyclePolicy")]
        internal sealed class _Proxy : DeputyBase, aws.IEfsFileSystemLifecyclePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "transitionToIa", typeJson: "{\"primitive\":\"string\"}")]
            public string TransitionToIa
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
