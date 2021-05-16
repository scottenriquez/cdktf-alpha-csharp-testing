using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketWebsite), fullyQualifiedName: "aws.S3BucketWebsite")]
    public interface IS3BucketWebsite
    {
        [JsiiProperty(name: "errorDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ErrorDocument
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "indexDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IndexDocument
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "redirectAllRequestsTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RedirectAllRequestsTo
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "routingRules", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoutingRules
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketWebsite), fullyQualifiedName: "aws.S3BucketWebsite")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketWebsite
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "errorDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ErrorDocument
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "indexDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IndexDocument
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "redirectAllRequestsTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RedirectAllRequestsTo
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "routingRules", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoutingRules
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
