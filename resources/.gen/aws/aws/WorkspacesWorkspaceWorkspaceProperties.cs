using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.WorkspacesWorkspaceWorkspaceProperties")]
    public class WorkspacesWorkspaceWorkspaceProperties : aws.IWorkspacesWorkspaceWorkspaceProperties
    {
        [JsiiOptional]
        [JsiiProperty(name: "computeTypeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ComputeTypeName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootVolumeSizeGib", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? RootVolumeSizeGib
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "runningMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RunningMode
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "runningModeAutoStopTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? RunningModeAutoStopTimeoutInMinutes
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "userVolumeSizeGib", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? UserVolumeSizeGib
        {
            get;
            set;
        }
    }
}
