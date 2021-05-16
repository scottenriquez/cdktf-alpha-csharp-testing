using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation), fullyQualifiedName: "aws.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation")]
    public interface IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation
    {
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        string Owner
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation), fullyQualifiedName: "aws.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
            public string Owner
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
