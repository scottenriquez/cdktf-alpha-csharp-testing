using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualServiceSpec), fullyQualifiedName: "aws.AppmeshVirtualServiceSpec")]
    public interface IAppmeshVirtualServiceSpec
    {
        /// <summary>provider block.</summary>
        [JsiiProperty(name: "provider", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualServiceSpecProvider\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAppmeshVirtualServiceSpecProvider[]? Provider
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualServiceSpec), fullyQualifiedName: "aws.AppmeshVirtualServiceSpec")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshVirtualServiceSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>provider block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualServiceSpecProvider\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAppmeshVirtualServiceSpecProvider[]? Provider
            {
                get => GetInstanceProperty<aws.IAppmeshVirtualServiceSpecProvider[]?>();
            }
        }
    }
}
