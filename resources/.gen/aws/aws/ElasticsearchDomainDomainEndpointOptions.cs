using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ElasticsearchDomainDomainEndpointOptions")]
    public class ElasticsearchDomainDomainEndpointOptions : aws.IElasticsearchDomainDomainEndpointOptions
    {
        [JsiiProperty(name: "enforceHttps", typeJson: "{\"primitive\":\"boolean\"}", isOverride: true)]
        public bool EnforceHttps
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsSecurityPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TlsSecurityPolicy
        {
            get;
            set;
        }
    }
}
