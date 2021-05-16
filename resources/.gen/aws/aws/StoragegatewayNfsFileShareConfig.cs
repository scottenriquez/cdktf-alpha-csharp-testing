using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.StoragegatewayNfsFileShareConfig")]
    public class StoragegatewayNfsFileShareConfig : aws.IStoragegatewayNfsFileShareConfig
    {
        [JsiiProperty(name: "clientList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] ClientList
        {
            get;
            set;
        }

        [JsiiProperty(name: "gatewayArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string GatewayArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "locationArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LocationArn
        {
            get;
            set;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RoleArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultStorageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DefaultStorageClass
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "guessMimeTypeEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? GuessMimeTypeEnabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsEncrypted", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? KmsEncrypted
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }

        /// <summary>nfs_file_share_defaults block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nfsFileShareDefaults", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.StoragegatewayNfsFileShareNfsFileShareDefaults\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IStoragegatewayNfsFileShareNfsFileShareDefaults[]? NfsFileShareDefaults
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectAcl", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ObjectAcl
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? ReadOnly
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requesterPays", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? RequesterPays
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "squash", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Squash
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

        /// <summary>timeouts block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.StoragegatewayNfsFileShareTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IStoragegatewayNfsFileShareTimeouts? Timeouts
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
