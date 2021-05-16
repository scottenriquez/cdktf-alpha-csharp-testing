using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainDomainEndpointOptions), fullyQualifiedName: "aws.ElasticsearchDomainDomainEndpointOptions")]
    public interface IElasticsearchDomainDomainEndpointOptions
    {
        [JsiiProperty(name: "enforceHttps", typeJson: "{\"primitive\":\"boolean\"}")]
        bool EnforceHttps
        {
            get;
        }

        [JsiiProperty(name: "tlsSecurityPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TlsSecurityPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainDomainEndpointOptions), fullyQualifiedName: "aws.ElasticsearchDomainDomainEndpointOptions")]
        internal sealed class _Proxy : DeputyBase, aws.IElasticsearchDomainDomainEndpointOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "enforceHttps", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool EnforceHttps
            {
                get => GetInstanceProperty<bool>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "tlsSecurityPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TlsSecurityPolicy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
