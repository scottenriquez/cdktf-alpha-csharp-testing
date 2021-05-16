using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecBackendVirtualService), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecBackendVirtualService")]
    public interface IAppmeshVirtualNodeSpecBackendVirtualService
    {
        [JsiiProperty(name: "virtualServiceName", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualServiceName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecBackendVirtualService), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecBackendVirtualService")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshVirtualNodeSpecBackendVirtualService
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "virtualServiceName", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualServiceName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
