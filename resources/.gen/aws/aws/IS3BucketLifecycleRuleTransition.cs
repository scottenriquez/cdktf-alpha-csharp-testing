using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketLifecycleRuleTransition), fullyQualifiedName: "aws.S3BucketLifecycleRuleTransition")]
    public interface IS3BucketLifecycleRuleTransition
    {
        [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}")]
        string StorageClass
        {
            get;
        }

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

        [JsiiTypeProxy(nativeType: typeof(IS3BucketLifecycleRuleTransition), fullyQualifiedName: "aws.S3BucketLifecycleRuleTransition")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketLifecycleRuleTransition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "storageClass", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageClass
            {
                get => GetInstanceProperty<string>()!;
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
        }
    }
}
