using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecBackend), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecBackend")]
    public interface IAppmeshVirtualNodeSpecBackend
    {
        /// <summary>virtual_service block.</summary>
        [JsiiProperty(name: "virtualService", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecBackendVirtualService\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppmeshVirtualNodeSpecBackendVirtualService[]? VirtualService
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecBackend), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecBackend")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshVirtualNodeSpecBackend
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>virtual_service block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "virtualService", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecBackendVirtualService\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppmeshVirtualNodeSpecBackendVirtualService[]? VirtualService
            {
                get => GetInstanceProperty<aws.IAppmeshVirtualNodeSpecBackendVirtualService[]?>();
            }
        }
    }
}
