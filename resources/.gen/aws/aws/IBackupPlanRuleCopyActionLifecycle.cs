using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IBackupPlanRuleCopyActionLifecycle), fullyQualifiedName: "aws.BackupPlanRuleCopyActionLifecycle")]
    public interface IBackupPlanRuleCopyActionLifecycle
    {
        [JsiiProperty(name: "coldStorageAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ColdStorageAfter
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "deleteAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DeleteAfter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBackupPlanRuleCopyActionLifecycle), fullyQualifiedName: "aws.BackupPlanRuleCopyActionLifecycle")]
        internal sealed class _Proxy : DeputyBase, aws.IBackupPlanRuleCopyActionLifecycle
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "coldStorageAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ColdStorageAfter
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "deleteAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DeleteAfter
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
