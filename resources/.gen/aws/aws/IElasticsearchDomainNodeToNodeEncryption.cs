using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainNodeToNodeEncryption), fullyQualifiedName: "aws.ElasticsearchDomainNodeToNodeEncryption")]
    public interface IElasticsearchDomainNodeToNodeEncryption
    {
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
        bool Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainNodeToNodeEncryption), fullyQualifiedName: "aws.ElasticsearchDomainNodeToNodeEncryption")]
        internal sealed class _Proxy : DeputyBase, aws.IElasticsearchDomainNodeToNodeEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool Enabled
            {
                get => GetInstanceProperty<bool>()!;
            }
        }
    }
}
