using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppmeshVirtualRouterSpec")]
    public class AppmeshVirtualRouterSpec : aws.IAppmeshVirtualRouterSpec
    {
        /// <summary>listener block.</summary>
        [JsiiProperty(name: "listener", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualRouterSpecListener\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IAppmeshVirtualRouterSpecListener[] Listener
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? ServiceNames
        {
            get;
            set;
        }
    }
}
