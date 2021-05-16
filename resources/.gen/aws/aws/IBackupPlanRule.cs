using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IBackupPlanRule), fullyQualifiedName: "aws.BackupPlanRule")]
    public interface IBackupPlanRule
    {
        [JsiiProperty(name: "ruleName", typeJson: "{\"primitive\":\"string\"}")]
        string RuleName
        {
            get;
        }

        [JsiiProperty(name: "targetVaultName", typeJson: "{\"primitive\":\"string\"}")]
        string TargetVaultName
        {
            get;
        }

        [JsiiProperty(name: "completionWindow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CompletionWindow
        {
            get
            {
                return null;
            }
        }

        /// <summary>copy_action block.</summary>
        [JsiiProperty(name: "copyAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BackupPlanRuleCopyAction\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IBackupPlanRuleCopyAction[]? CopyAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>lifecycle block.</summary>
        [JsiiProperty(name: "lifecycle", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BackupPlanRuleLifecycle\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IBackupPlanRuleLifecycle[]? Lifecycle
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "recoveryPointTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? RecoveryPointTags
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Schedule
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "startWindow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StartWindow
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBackupPlanRule), fullyQualifiedName: "aws.BackupPlanRule")]
        internal sealed class _Proxy : DeputyBase, aws.IBackupPlanRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "ruleName", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "targetVaultName", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetVaultName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "completionWindow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CompletionWindow
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>copy_action block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "copyAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BackupPlanRuleCopyAction\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IBackupPlanRuleCopyAction[]? CopyAction
            {
                get => GetInstanceProperty<aws.IBackupPlanRuleCopyAction[]?>();
            }

            /// <summary>lifecycle block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BackupPlanRuleLifecycle\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IBackupPlanRuleLifecycle[]? Lifecycle
            {
                get => GetInstanceProperty<aws.IBackupPlanRuleLifecycle[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "recoveryPointTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? RecoveryPointTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Schedule
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "startWindow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StartWindow
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
