using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppmeshVirtualRouterSpecListener")]
    public class AppmeshVirtualRouterSpecListener : aws.IAppmeshVirtualRouterSpecListener
    {
        /// <summary>port_mapping block.</summary>
        [JsiiProperty(name: "portMapping", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualRouterSpecListenerPortMapping\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IAppmeshVirtualRouterSpecListenerPortMapping[] PortMapping
        {
            get;
            set;
        }
    }
}
