using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CodebuildProjectConfig")]
    public class CodebuildProjectConfig : aws.ICodebuildProjectConfig
    {
        /// <summary>artifacts block.</summary>
        [JsiiProperty(name: "artifacts", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectArtifacts\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ICodebuildProjectArtifacts[] Artifacts
        {
            get;
            set;
        }

        /// <summary>environment block.</summary>
        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectEnvironment\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ICodebuildProjectEnvironment[] Environment
        {
            get;
            set;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ServiceRole
        {
            get;
            set;
        }

        /// <summary>source block.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSource\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.ICodebuildProjectSource[] Source
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "badgeEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? BadgeEnabled
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? BuildTimeout
        {
            get;
            set;
        }

        /// <summary>cache block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cache", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectCache\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodebuildProjectCache[]? Cache
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
        [JsiiProperty(name: "encryptionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EncryptionKey
        {
            get;
            set;
        }

        /// <summary>logs_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectLogsConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodebuildProjectLogsConfig[]? LogsConfig
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "queuedTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? QueuedTimeout
        {
            get;
            set;
        }

        /// <summary>secondary_artifacts block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secondaryArtifacts", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSecondaryArtifacts\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodebuildProjectSecondaryArtifacts[]? SecondaryArtifacts
        {
            get;
            set;
        }

        /// <summary>secondary_sources block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secondarySources", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSecondarySources\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodebuildProjectSecondarySources[]? SecondarySources
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SourceVersion
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

        /// <summary>vpc_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectVpcConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodebuildProjectVpcConfig[]? VpcConfig
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
