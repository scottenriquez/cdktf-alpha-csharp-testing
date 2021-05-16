using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWorkspacesWorkspaceWorkspaceProperties), fullyQualifiedName: "aws.WorkspacesWorkspaceWorkspaceProperties")]
    public interface IWorkspacesWorkspaceWorkspaceProperties
    {
        [JsiiProperty(name: "computeTypeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputeTypeName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "rootVolumeSizeGib", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RootVolumeSizeGib
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "runningMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RunningMode
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "runningModeAutoStopTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RunningModeAutoStopTimeoutInMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "userVolumeSizeGib", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UserVolumeSizeGib
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkspacesWorkspaceWorkspaceProperties), fullyQualifiedName: "aws.WorkspacesWorkspaceWorkspaceProperties")]
        internal sealed class _Proxy : DeputyBase, aws.IWorkspacesWorkspaceWorkspaceProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "computeTypeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputeTypeName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "rootVolumeSizeGib", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RootVolumeSizeGib
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "runningMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RunningMode
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "runningModeAutoStopTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RunningModeAutoStopTimeoutInMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "userVolumeSizeGib", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UserVolumeSizeGib
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
