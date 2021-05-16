using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DirectoryServiceDirectoryConfig")]
    public class DirectoryServiceDirectoryConfig : aws.IDirectoryServiceDirectoryConfig
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Password
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Alias
        {
            get;
            set;
        }

        /// <summary>connect_settings block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DirectoryServiceDirectoryConnectSettings\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDirectoryServiceDirectoryConnectSettings[]? ConnectSettings
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "edition", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Edition
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableSso", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? EnableSso
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "shortName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ShortName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Size
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
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>vpc_settings block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DirectoryServiceDirectoryVpcSettings\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IDirectoryServiceDirectoryVpcSettings[]? VpcSettings
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
