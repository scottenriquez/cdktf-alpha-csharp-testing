using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualServiceSpecProviderVirtualRouter), fullyQualifiedName: "aws.AppmeshVirtualServiceSpecProviderVirtualRouter")]
    public interface IAppmeshVirtualServiceSpecProviderVirtualRouter
    {
        [JsiiProperty(name: "virtualRouterName", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualRouterName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualServiceSpecProviderVirtualRouter), fullyQualifiedName: "aws.AppmeshVirtualServiceSpecProviderVirtualRouter")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshVirtualServiceSpecProviderVirtualRouter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "virtualRouterName", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualRouterName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
