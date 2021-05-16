using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualServiceSpecProvider), fullyQualifiedName: "aws.AppmeshVirtualServiceSpecProvider")]
    public interface IAppmeshVirtualServiceSpecProvider
    {
        /// <summary>virtual_node block.</summary>
        [JsiiProperty(name: "virtualNode", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualServiceSpecProviderVirtualNode\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppmeshVirtualServiceSpecProviderVirtualNode[]? VirtualNode
        {
            get
            {
                return null;
            }
        }

        /// <summary>virtual_router block.</summary>
        [JsiiProperty(name: "virtualRouter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualServiceSpecProviderVirtualRouter\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppmeshVirtualServiceSpecProviderVirtualRouter[]? VirtualRouter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualServiceSpecProvider), fullyQualifiedName: "aws.AppmeshVirtualServiceSpecProvider")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshVirtualServiceSpecProvider
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>virtual_node block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "virtualNode", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualServiceSpecProviderVirtualNode\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppmeshVirtualServiceSpecProviderVirtualNode[]? VirtualNode
            {
                get => GetInstanceProperty<aws.IAppmeshVirtualServiceSpecProviderVirtualNode[]?>();
            }

            /// <summary>virtual_router block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "virtualRouter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualServiceSpecProviderVirtualRouter\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppmeshVirtualServiceSpecProviderVirtualRouter[]? VirtualRouter
            {
                get => GetInstanceProperty<aws.IAppmeshVirtualServiceSpecProviderVirtualRouter[]?>();
            }
        }
    }
}
