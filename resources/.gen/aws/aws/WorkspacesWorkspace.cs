using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.WorkspacesWorkspace), fullyQualifiedName: "aws.WorkspacesWorkspace", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.WorkspacesWorkspaceConfig\"}}]")]
    public class WorkspacesWorkspace : HashiCorp.Cdktf.TerraformResource
    {
        public WorkspacesWorkspace(Constructs.Construct scope, string id, aws.IWorkspacesWorkspaceConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkspacesWorkspace(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkspacesWorkspace(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetRootVolumeEncryptionEnabled")]
        public virtual void ResetRootVolumeEncryptionEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserVolumeEncryptionEnabled")]
        public virtual void ResetUserVolumeEncryptionEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVolumeEncryptionKey")]
        public virtual void ResetVolumeEncryptionKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkspaceProperties")]
        public virtual void ResetWorkspaceProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "bundleIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BundleIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputerName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "directoryIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootVolumeEncryptionEnabledInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? RootVolumeEncryptionEnabledInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userVolumeEncryptionEnabledInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? UserVolumeEncryptionEnabledInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeEncryptionKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VolumeEncryptionKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workspacePropertiesInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WorkspacesWorkspaceWorkspaceProperties\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IWorkspacesWorkspaceWorkspaceProperties[]? WorkspacePropertiesInput
        {
            get => GetInstanceProperty<aws.IWorkspacesWorkspaceWorkspaceProperties[]?>();
        }

        [JsiiProperty(name: "bundleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BundleId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rootVolumeEncryptionEnabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool RootVolumeEncryptionEnabled
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userVolumeEncryptionEnabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool UserVolumeEncryptionEnabled
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "volumeEncryptionKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeEncryptionKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workspaceProperties", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WorkspacesWorkspaceWorkspaceProperties\"},\"kind\":\"array\"}}")]
        public virtual aws.IWorkspacesWorkspaceWorkspaceProperties[] WorkspaceProperties
        {
            get => GetInstanceProperty<aws.IWorkspacesWorkspaceWorkspaceProperties[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
