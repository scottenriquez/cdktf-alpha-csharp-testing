using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfiguration), fullyQualifiedName: "aws.S3BucketReplicationConfiguration")]
    public interface IS3BucketReplicationConfiguration
    {
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        string Role
        {
            get;
        }

        /// <summary>rules block.</summary>
        [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfigurationRules\"},\"kind\":\"array\"}}")]
        aws.IS3BucketReplicationConfigurationRules[] Rules
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfiguration), fullyQualifiedName: "aws.S3BucketReplicationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketReplicationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
            public string Role
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>rules block.</summary>
            [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfigurationRules\"},\"kind\":\"array\"}}")]
            public aws.IS3BucketReplicationConfigurationRules[] Rules
            {
                get => GetInstanceProperty<aws.IS3BucketReplicationConfigurationRules[]>()!;
            }
        }
    }
}
