using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.BackupPlanRuleCopyAction")]
    public class BackupPlanRuleCopyAction : aws.IBackupPlanRuleCopyAction
    {
        [JsiiProperty(name: "destinationVaultArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DestinationVaultArn
        {
            get;
            set;
        }

        /// <summary>lifecycle block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BackupPlanRuleCopyActionLifecycle\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IBackupPlanRuleCopyActionLifecycle[]? Lifecycle
        {
            get;
            set;
        }
    }
}
