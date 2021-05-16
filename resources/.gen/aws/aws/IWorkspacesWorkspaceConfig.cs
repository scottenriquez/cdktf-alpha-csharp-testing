using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IWorkspacesWorkspaceConfig), fullyQualifiedName: "aws.WorkspacesWorkspaceConfig")]
    public interface IWorkspacesWorkspaceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "bundleId", typeJson: "{\"primitive\":\"string\"}")]
        string BundleId
        {
            get;
        }

        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
        string DirectoryId
        {
            get;
        }

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        string UserName
        {
            get;
        }

        [JsiiProperty(name: "rootVolumeEncryptionEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? RootVolumeEncryptionEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "userVolumeEncryptionEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? UserVolumeEncryptionEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "volumeEncryptionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeEncryptionKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>workspace_properties block.</summary>
        [JsiiProperty(name: "workspaceProperties", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WorkspacesWorkspaceWorkspaceProperties\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IWorkspacesWorkspaceWorkspaceProperties[]? WorkspaceProperties
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkspacesWorkspaceConfig), fullyQualifiedName: "aws.WorkspacesWorkspaceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IWorkspacesWorkspaceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "bundleId", typeJson: "{\"primitive\":\"string\"}")]
            public string BundleId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
            public string DirectoryId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
            public string UserName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "rootVolumeEncryptionEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? RootVolumeEncryptionEnabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "userVolumeEncryptionEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? UserVolumeEncryptionEnabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "volumeEncryptionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeEncryptionKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>workspace_properties block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "workspaceProperties", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WorkspacesWorkspaceWorkspaceProperties\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IWorkspacesWorkspaceWorkspaceProperties[]? WorkspaceProperties
            {
                get => GetInstanceProperty<aws.IWorkspacesWorkspaceWorkspaceProperties[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
