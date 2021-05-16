using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DmsEndpointElasticsearchSettings")]
    public class DmsEndpointElasticsearchSettings : aws.IDmsEndpointElasticsearchSettings
    {
        [JsiiProperty(name: "endpointUri", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string EndpointUri
        {
            get;
            set;
        }

        [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ServiceAccessRoleArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorRetryDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ErrorRetryDuration
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fullLoadErrorPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? FullLoadErrorPercentage
        {
            get;
            set;
        }
    }
}
