using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketObjectLockConfiguration), fullyQualifiedName: "aws.S3BucketObjectLockConfiguration")]
    public interface IS3BucketObjectLockConfiguration
    {
        [JsiiProperty(name: "objectLockEnabled", typeJson: "{\"primitive\":\"string\"}")]
        string ObjectLockEnabled
        {
            get;
        }

        /// <summary>rule block.</summary>
        [JsiiProperty(name: "rule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketObjectLockConfigurationRule\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketObjectLockConfigurationRule[]? Rule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketObjectLockConfiguration), fullyQualifiedName: "aws.S3BucketObjectLockConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketObjectLockConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "objectLockEnabled", typeJson: "{\"primitive\":\"string\"}")]
            public string ObjectLockEnabled
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>rule block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketObjectLockConfigurationRule\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketObjectLockConfigurationRule[]? Rule
            {
                get => GetInstanceProperty<aws.IS3BucketObjectLockConfigurationRule[]?>();
            }
        }
    }
}
