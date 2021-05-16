using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWorkspacesDirectorySelfServicePermissions), fullyQualifiedName: "aws.WorkspacesDirectorySelfServicePermissions")]
    public interface IWorkspacesDirectorySelfServicePermissions
    {
        [JsiiProperty(name: "changeComputeType", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ChangeComputeType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "increaseVolumeSize", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? IncreaseVolumeSize
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "rebuildWorkspace", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? RebuildWorkspace
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "restartWorkspace", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? RestartWorkspace
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "switchRunningMode", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? SwitchRunningMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkspacesDirectorySelfServicePermissions), fullyQualifiedName: "aws.WorkspacesDirectorySelfServicePermissions")]
        internal sealed class _Proxy : DeputyBase, aws.IWorkspacesDirectorySelfServicePermissions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "changeComputeType", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ChangeComputeType
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "increaseVolumeSize", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? IncreaseVolumeSize
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "rebuildWorkspace", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? RebuildWorkspace
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "restartWorkspace", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? RestartWorkspace
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "switchRunningMode", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? SwitchRunningMode
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
