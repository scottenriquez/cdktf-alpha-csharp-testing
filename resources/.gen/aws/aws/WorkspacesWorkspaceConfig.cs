using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.WorkspacesWorkspaceConfig")]
    public class WorkspacesWorkspaceConfig : aws.IWorkspacesWorkspaceConfig
    {
        [JsiiProperty(name: "bundleId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string BundleId
        {
            get;
            set;
        }

        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DirectoryId
        {
            get;
            set;
        }

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string UserName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootVolumeEncryptionEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? RootVolumeEncryptionEnabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "userVolumeEncryptionEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? UserVolumeEncryptionEnabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "volumeEncryptionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? VolumeEncryptionKey
        {
            get;
            set;
        }

        /// <summary>workspace_properties block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "workspaceProperties", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.WorkspacesWorkspaceWorkspaceProperties\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IWorkspacesWorkspaceWorkspaceProperties[]? WorkspaceProperties
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
