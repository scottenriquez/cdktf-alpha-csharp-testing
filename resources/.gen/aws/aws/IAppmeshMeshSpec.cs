using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshMeshSpec), fullyQualifiedName: "aws.AppmeshMeshSpec")]
    public interface IAppmeshMeshSpec
    {
        /// <summary>egress_filter block.</summary>
        [JsiiProperty(name: "egressFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshMeshSpecEgressFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppmeshMeshSpecEgressFilter[]? EgressFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshMeshSpec), fullyQualifiedName: "aws.AppmeshMeshSpec")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshMeshSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>egress_filter block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "egressFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshMeshSpecEgressFilter\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppmeshMeshSpecEgressFilter[]? EgressFilter
            {
                get => GetInstanceProperty<aws.IAppmeshMeshSpecEgressFilter[]?>();
            }
        }
    }
}
