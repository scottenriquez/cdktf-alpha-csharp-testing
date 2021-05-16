using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpec), fullyQualifiedName: "aws.AppmeshVirtualNodeSpec")]
    public interface IAppmeshVirtualNodeSpec
    {
        /// <summary>backend block.</summary>
        [JsiiProperty(name: "backend", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecBackend\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppmeshVirtualNodeSpecBackend[]? Backend
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "backends", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Backends
        {
            get
            {
                return null;
            }
        }

        /// <summary>listener block.</summary>
        [JsiiProperty(name: "listener", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecListener\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppmeshVirtualNodeSpecListener[]? Listener
        {
            get
            {
                return null;
            }
        }

        /// <summary>logging block.</summary>
        [JsiiProperty(name: "logging", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecLogging\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppmeshVirtualNodeSpecLogging[]? Logging
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_discovery block.</summary>
        [JsiiProperty(name: "serviceDiscovery", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecServiceDiscovery\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppmeshVirtualNodeSpecServiceDiscovery[]? ServiceDiscovery
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpec), fullyQualifiedName: "aws.AppmeshVirtualNodeSpec")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshVirtualNodeSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>backend block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backend", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecBackend\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppmeshVirtualNodeSpecBackend[]? Backend
            {
                get => GetInstanceProperty<aws.IAppmeshVirtualNodeSpecBackend[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "backends", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Backends
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>listener block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "listener", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecListener\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppmeshVirtualNodeSpecListener[]? Listener
            {
                get => GetInstanceProperty<aws.IAppmeshVirtualNodeSpecListener[]?>();
            }

            /// <summary>logging block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logging", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecLogging\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppmeshVirtualNodeSpecLogging[]? Logging
            {
                get => GetInstanceProperty<aws.IAppmeshVirtualNodeSpecLogging[]?>();
            }

            /// <summary>service_discovery block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceDiscovery", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecServiceDiscovery\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppmeshVirtualNodeSpecServiceDiscovery[]? ServiceDiscovery
            {
                get => GetInstanceProperty<aws.IAppmeshVirtualNodeSpecServiceDiscovery[]?>();
            }
        }
    }
}
