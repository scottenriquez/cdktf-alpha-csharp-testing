using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketObjectLockConfigurationRuleDefaultRetention), fullyQualifiedName: "aws.S3BucketObjectLockConfigurationRuleDefaultRetention")]
    public interface IS3BucketObjectLockConfigurationRuleDefaultRetention
    {
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
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

        [JsiiProperty(name: "years", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Years
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketObjectLockConfigurationRuleDefaultRetention), fullyQualifiedName: "aws.S3BucketObjectLockConfigurationRuleDefaultRetention")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketObjectLockConfigurationRuleDefaultRetention
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Days
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "years", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Years
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
