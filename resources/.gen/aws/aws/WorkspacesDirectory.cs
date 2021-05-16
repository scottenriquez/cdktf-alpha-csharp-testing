using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.WorkspacesDirectory), fullyQualifiedName: "aws.WorkspacesDirectory", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.WorkspacesDirectoryConfig\"}}]")]
    public class WorkspacesDirectory : HashiCorp.Cdktf.TerraformResource
    {
        public WorkspacesDirectory(Constructs.Construct scope, string id, aws.IWorkspacesDirectoryConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkspacesDirectory(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkspacesDirectory(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSelfServicePermissions")]
        public virtual void ResetSelfServicePermissions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetIds")]
        public virtual void ResetSubnetIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Alias
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerUserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "directoryIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "directoryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "directoryType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "iamRoleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamRoleId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IpGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "registrationCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistrationCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workspaceSecurityGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceSecurityGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "selfServicePermissionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WorkspacesDirectorySelfServicePermissions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IWorkspacesDirectorySelfServicePermissions[]? SelfServicePermissionsInput
        {
            get => GetInstanceProperty<aws.IWorkspacesDirectorySelfServicePermissions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SubnetIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "selfServicePermissions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WorkspacesDirectorySelfServicePermissions\"},\"kind\":\"array\"}}")]
        public virtual aws.IWorkspacesDirectorySelfServicePermissions[] SelfServicePermissions
        {
            get => GetInstanceProperty<aws.IWorkspacesDirectorySelfServicePermissions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
