using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppmeshVirtualNodeSpecListener")]
    public class AppmeshVirtualNodeSpecListener : aws.IAppmeshVirtualNodeSpecListener
    {
        /// <summary>port_mapping block.</summary>
        [JsiiProperty(name: "portMapping", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecListenerPortMapping\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IAppmeshVirtualNodeSpecListenerPortMapping[] PortMapping
        {
            get;
            set;
        }

        /// <summary>health_check block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheck", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecListenerHealthCheck\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppmeshVirtualNodeSpecListenerHealthCheck[]? HealthCheck
        {
            get;
            set;
        }
    }
}
