using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects), fullyQualifiedName: "aws.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects")]
    public interface IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects
    {
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
        bool Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects), fullyQualifiedName: "aws.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool Enabled
            {
                get => GetInstanceProperty<bool>()!;
            }
        }
    }
}
