using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AppmeshVirtualNodeSpec")]
    public class AppmeshVirtualNodeSpec : aws.IAppmeshVirtualNodeSpec
    {
        /// <summary>backend block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backend", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecBackend\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppmeshVirtualNodeSpecBackend[]? Backend
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backends", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Backends
        {
            get;
            set;
        }

        /// <summary>listener block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "listener", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecListener\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppmeshVirtualNodeSpecListener[]? Listener
        {
            get;
            set;
        }

        /// <summary>logging block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logging", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecLogging\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppmeshVirtualNodeSpecLogging[]? Logging
        {
            get;
            set;
        }

        /// <summary>service_discovery block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceDiscovery", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecServiceDiscovery\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppmeshVirtualNodeSpecServiceDiscovery[]? ServiceDiscovery
        {
            get;
            set;
        }
    }
}
