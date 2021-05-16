using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AppmeshMeshSpec")]
    public class AppmeshMeshSpec : aws.IAppmeshMeshSpec
    {
        /// <summary>egress_filter block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "egressFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshMeshSpecEgressFilter\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppmeshMeshSpecEgressFilter[]? EgressFilter
        {
            get;
            set;
        }
    }
}
