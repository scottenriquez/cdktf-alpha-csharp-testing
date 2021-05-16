using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.BackupPlanRule")]
    public class BackupPlanRule : aws.IBackupPlanRule
    {
        [JsiiProperty(name: "ruleName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RuleName
        {
            get;
            set;
        }

        [JsiiProperty(name: "targetVaultName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TargetVaultName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "completionWindow", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? CompletionWindow
        {
            get;
            set;
        }

        /// <summary>copy_action block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "copyAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BackupPlanRuleCopyAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IBackupPlanRuleCopyAction[]? CopyAction
        {
            get;
            set;
        }

        /// <summary>lifecycle block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BackupPlanRuleLifecycle\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IBackupPlanRuleLifecycle[]? Lifecycle
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "recoveryPointTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? RecoveryPointTags
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Schedule
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "startWindow", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? StartWindow
        {
            get;
            set;
        }
    }
}
