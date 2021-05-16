using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AppmeshVirtualServiceSpecProvider")]
    public class AppmeshVirtualServiceSpecProvider : aws.IAppmeshVirtualServiceSpecProvider
    {
        /// <summary>virtual_node block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "virtualNode", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualServiceSpecProviderVirtualNode\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppmeshVirtualServiceSpecProviderVirtualNode[]? VirtualNode
        {
            get;
            set;
        }

        /// <summary>virtual_router block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "virtualRouter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualServiceSpecProviderVirtualRouter\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppmeshVirtualServiceSpecProviderVirtualRouter[]? VirtualRouter
        {
            get;
            set;
        }
    }
}
