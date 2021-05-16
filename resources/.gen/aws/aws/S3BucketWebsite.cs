using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.S3BucketWebsite")]
    public class S3BucketWebsite : aws.IS3BucketWebsite
    {
        [JsiiOptional]
        [JsiiProperty(name: "errorDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ErrorDocument
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "indexDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IndexDocument
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "redirectAllRequestsTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RedirectAllRequestsTo
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingRules", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RoutingRules
        {
            get;
            set;
        }
    }
}
