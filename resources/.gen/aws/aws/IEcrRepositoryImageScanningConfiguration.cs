using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEcrRepositoryImageScanningConfiguration), fullyQualifiedName: "aws.EcrRepositoryImageScanningConfiguration")]
    public interface IEcrRepositoryImageScanningConfiguration
    {
        [JsiiProperty(name: "scanOnPush", typeJson: "{\"primitive\":\"boolean\"}")]
        bool ScanOnPush
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcrRepositoryImageScanningConfiguration), fullyQualifiedName: "aws.EcrRepositoryImageScanningConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IEcrRepositoryImageScanningConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "scanOnPush", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool ScanOnPush
            {
                get => GetInstanceProperty<bool>()!;
            }
        }
    }
}
