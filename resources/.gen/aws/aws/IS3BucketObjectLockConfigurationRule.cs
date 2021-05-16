using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketObjectLockConfigurationRule), fullyQualifiedName: "aws.S3BucketObjectLockConfigurationRule")]
    public interface IS3BucketObjectLockConfigurationRule
    {
        /// <summary>default_retention block.</summary>
        [JsiiProperty(name: "defaultRetention", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketObjectLockConfigurationRuleDefaultRetention\"},\"kind\":\"array\"}}")]
        aws.IS3BucketObjectLockConfigurationRuleDefaultRetention[] DefaultRetention
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketObjectLockConfigurationRule), fullyQualifiedName: "aws.S3BucketObjectLockConfigurationRule")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketObjectLockConfigurationRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_retention block.</summary>
            [JsiiProperty(name: "defaultRetention", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketObjectLockConfigurationRuleDefaultRetention\"},\"kind\":\"array\"}}")]
            public aws.IS3BucketObjectLockConfigurationRuleDefaultRetention[] DefaultRetention
            {
                get => GetInstanceProperty<aws.IS3BucketObjectLockConfigurationRuleDefaultRetention[]>()!;
            }
        }
    }
}
