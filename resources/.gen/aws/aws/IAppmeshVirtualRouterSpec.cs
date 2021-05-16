using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualRouterSpec), fullyQualifiedName: "aws.AppmeshVirtualRouterSpec")]
    public interface IAppmeshVirtualRouterSpec
    {
        /// <summary>listener block.</summary>
        [JsiiProperty(name: "listener", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualRouterSpecListener\"},\"kind\":\"array\"}}")]
        aws.IAppmeshVirtualRouterSpecListener[] Listener
        {
            get;
        }

        [JsiiProperty(name: "serviceNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ServiceNames
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualRouterSpec), fullyQualifiedName: "aws.AppmeshVirtualRouterSpec")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshVirtualRouterSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>listener block.</summary>
            [JsiiProperty(name: "listener", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualRouterSpecListener\"},\"kind\":\"array\"}}")]
            public aws.IAppmeshVirtualRouterSpecListener[] Listener
            {
                get => GetInstanceProperty<aws.IAppmeshVirtualRouterSpecListener[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "serviceNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ServiceNames
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
