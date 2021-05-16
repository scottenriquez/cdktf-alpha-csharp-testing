using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AppmeshVirtualServiceSpec")]
    public class AppmeshVirtualServiceSpec : aws.IAppmeshVirtualServiceSpec
    {
        /// <summary>provider block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualServiceSpecProvider\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppmeshVirtualServiceSpecProvider[]? Provider
        {
            get;
            set;
        }
    }
}
