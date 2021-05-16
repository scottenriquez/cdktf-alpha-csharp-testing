using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IBackupPlanRuleCopyAction), fullyQualifiedName: "aws.BackupPlanRuleCopyAction")]
    public interface IBackupPlanRuleCopyAction
    {
        [JsiiProperty(name: "destinationVaultArn", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationVaultArn
        {
            get;
        }

        /// <summary>lifecycle block.</summary>
        [JsiiProperty(name: "lifecycle", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BackupPlanRuleCopyActionLifecycle\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IBackupPlanRuleCopyActionLifecycle[]? Lifecycle
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBackupPlanRuleCopyAction), fullyQualifiedName: "aws.BackupPlanRuleCopyAction")]
        internal sealed class _Proxy : DeputyBase, aws.IBackupPlanRuleCopyAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "destinationVaultArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationVaultArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>lifecycle block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BackupPlanRuleCopyActionLifecycle\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IBackupPlanRuleCopyActionLifecycle[]? Lifecycle
            {
                get => GetInstanceProperty<aws.IBackupPlanRuleCopyActionLifecycle[]?>();
            }
        }
    }
}
