using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketLifecycleRuleExpiration), fullyQualifiedName: "aws.S3BucketLifecycleRuleExpiration")]
    public interface IS3BucketLifecycleRuleExpiration
    {
        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Date
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Days
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "expiredObjectDeleteMarker", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ExpiredObjectDeleteMarker
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketLifecycleRuleExpiration), fullyQualifiedName: "aws.S3BucketLifecycleRuleExpiration")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketLifecycleRuleExpiration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Date
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Days
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "expiredObjectDeleteMarker", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ExpiredObjectDeleteMarker
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
