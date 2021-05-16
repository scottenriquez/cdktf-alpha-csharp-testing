using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.WorkspacesDirectorySelfServicePermissions")]
    public class WorkspacesDirectorySelfServicePermissions : aws.IWorkspacesDirectorySelfServicePermissions
    {
        [JsiiOptional]
        [JsiiProperty(name: "changeComputeType", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ChangeComputeType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "increaseVolumeSize", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IncreaseVolumeSize
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rebuildWorkspace", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? RebuildWorkspace
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "restartWorkspace", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? RestartWorkspace
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "switchRunningMode", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? SwitchRunningMode
        {
            get;
            set;
        }
    }
}
