using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppsyncDatasourceElasticsearchConfig")]
    public class AppsyncDatasourceElasticsearchConfig : aws.IAppsyncDatasourceElasticsearchConfig
    {
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Endpoint
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Region
        {
            get;
            set;
        }
    }
}
