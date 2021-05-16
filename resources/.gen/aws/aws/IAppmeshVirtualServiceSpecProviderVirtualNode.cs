using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualServiceSpecProviderVirtualNode), fullyQualifiedName: "aws.AppmeshVirtualServiceSpecProviderVirtualNode")]
    public interface IAppmeshVirtualServiceSpecProviderVirtualNode
    {
        [JsiiProperty(name: "virtualNodeName", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualNodeName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualServiceSpecProviderVirtualNode), fullyQualifiedName: "aws.AppmeshVirtualServiceSpecProviderVirtualNode")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshVirtualServiceSpecProviderVirtualNode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "virtualNodeName", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualNodeName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
