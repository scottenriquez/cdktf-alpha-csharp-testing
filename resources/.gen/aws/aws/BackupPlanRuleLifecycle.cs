using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.BackupPlanRuleLifecycle")]
    public class BackupPlanRuleLifecycle : aws.IBackupPlanRuleLifecycle
    {
        [JsiiOptional]
        [JsiiProperty(name: "coldStorageAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ColdStorageAfter
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteAfter", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? DeleteAfter
        {
            get;
            set;
        }
    }
}
