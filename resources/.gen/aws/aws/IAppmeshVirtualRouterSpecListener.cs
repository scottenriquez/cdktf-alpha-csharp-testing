using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualRouterSpecListener), fullyQualifiedName: "aws.AppmeshVirtualRouterSpecListener")]
    public interface IAppmeshVirtualRouterSpecListener
    {
        /// <summary>port_mapping block.</summary>
        [JsiiProperty(name: "portMapping", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualRouterSpecListenerPortMapping\"},\"kind\":\"array\"}}")]
        aws.IAppmeshVirtualRouterSpecListenerPortMapping[] PortMapping
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualRouterSpecListener), fullyQualifiedName: "aws.AppmeshVirtualRouterSpecListener")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshVirtualRouterSpecListener
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>port_mapping block.</summary>
            [JsiiProperty(name: "portMapping", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualRouterSpecListenerPortMapping\"},\"kind\":\"array\"}}")]
            public aws.IAppmeshVirtualRouterSpecListenerPortMapping[] PortMapping
            {
                get => GetInstanceProperty<aws.IAppmeshVirtualRouterSpecListenerPortMapping[]>()!;
            }
        }
    }
}
