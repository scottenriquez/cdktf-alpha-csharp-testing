using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListener), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecListener")]
    public interface IAppmeshVirtualNodeSpecListener
    {
        /// <summary>port_mapping block.</summary>
        [JsiiProperty(name: "portMapping", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecListenerPortMapping\"},\"kind\":\"array\"}}")]
        aws.IAppmeshVirtualNodeSpecListenerPortMapping[] PortMapping
        {
            get;
        }

        /// <summary>health_check block.</summary>
        [JsiiProperty(name: "healthCheck", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecListenerHealthCheck\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppmeshVirtualNodeSpecListenerHealthCheck[]? HealthCheck
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListener), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecListener")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshVirtualNodeSpecListener
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>port_mapping block.</summary>
            [JsiiProperty(name: "portMapping", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecListenerPortMapping\"},\"kind\":\"array\"}}")]
            public aws.IAppmeshVirtualNodeSpecListenerPortMapping[] PortMapping
            {
                get => GetInstanceProperty<aws.IAppmeshVirtualNodeSpecListenerPortMapping[]>()!;
            }

            /// <summary>health_check block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheck", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecListenerHealthCheck\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppmeshVirtualNodeSpecListenerHealthCheck[]? HealthCheck
            {
                get => GetInstanceProperty<aws.IAppmeshVirtualNodeSpecListenerHealthCheck[]?>();
            }
        }
    }
}
