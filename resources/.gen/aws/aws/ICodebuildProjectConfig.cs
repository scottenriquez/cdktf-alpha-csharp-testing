using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectConfig), fullyQualifiedName: "aws.CodebuildProjectConfig")]
    public interface ICodebuildProjectConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>artifacts block.</summary>
        [JsiiProperty(name: "artifacts", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectArtifacts\"},\"kind\":\"array\"}}")]
        aws.ICodebuildProjectArtifacts[] Artifacts
        {
            get;
        }

        /// <summary>environment block.</summary>
        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectEnvironment\"},\"kind\":\"array\"}}")]
        aws.ICodebuildProjectEnvironment[] Environment
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceRole
        {
            get;
        }

        /// <summary>source block.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSource\"},\"kind\":\"array\"}}")]
        aws.ICodebuildProjectSource[] Source
        {
            get;
        }

        [JsiiProperty(name: "badgeEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? BadgeEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "buildTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BuildTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>cache block.</summary>
        [JsiiProperty(name: "cache", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectCache\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodebuildProjectCache[]? Cache
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "encryptionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>logs_config block.</summary>
        [JsiiProperty(name: "logsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectLogsConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodebuildProjectLogsConfig[]? LogsConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "queuedTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? QueuedTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>secondary_artifacts block.</summary>
        [JsiiProperty(name: "secondaryArtifacts", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSecondaryArtifacts\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodebuildProjectSecondaryArtifacts[]? SecondaryArtifacts
        {
            get
            {
                return null;
            }
        }

        /// <summary>secondary_sources block.</summary>
        [JsiiProperty(name: "secondarySources", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSecondarySources\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodebuildProjectSecondarySources[]? SecondarySources
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceVersion
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

        /// <summary>vpc_config block.</summary>
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectVpcConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodebuildProjectVpcConfig[]? VpcConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectConfig), fullyQualifiedName: "aws.CodebuildProjectConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ICodebuildProjectConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>artifacts block.</summary>
            [JsiiProperty(name: "artifacts", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectArtifacts\"},\"kind\":\"array\"}}")]
            public aws.ICodebuildProjectArtifacts[] Artifacts
            {
                get => GetInstanceProperty<aws.ICodebuildProjectArtifacts[]>()!;
            }

            /// <summary>environment block.</summary>
            [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectEnvironment\"},\"kind\":\"array\"}}")]
            public aws.ICodebuildProjectEnvironment[] Environment
            {
                get => GetInstanceProperty<aws.ICodebuildProjectEnvironment[]>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceRole
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>source block.</summary>
            [JsiiProperty(name: "source", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSource\"},\"kind\":\"array\"}}")]
            public aws.ICodebuildProjectSource[] Source
            {
                get => GetInstanceProperty<aws.ICodebuildProjectSource[]>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "badgeEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? BadgeEnabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "buildTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BuildTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>cache block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cache", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectCache\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodebuildProjectCache[]? Cache
            {
                get => GetInstanceProperty<aws.ICodebuildProjectCache[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "encryptionKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>logs_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectLogsConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodebuildProjectLogsConfig[]? LogsConfig
            {
                get => GetInstanceProperty<aws.ICodebuildProjectLogsConfig[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "queuedTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? QueuedTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>secondary_artifacts block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secondaryArtifacts", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSecondaryArtifacts\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodebuildProjectSecondaryArtifacts[]? SecondaryArtifacts
            {
                get => GetInstanceProperty<aws.ICodebuildProjectSecondaryArtifacts[]?>();
            }

            /// <summary>secondary_sources block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secondarySources", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectSecondarySources\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodebuildProjectSecondarySources[]? SecondarySources
            {
                get => GetInstanceProperty<aws.ICodebuildProjectSecondarySources[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceVersion
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>vpc_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectVpcConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodebuildProjectVpcConfig[]? VpcConfig
            {
                get => GetInstanceProperty<aws.ICodebuildProjectVpcConfig[]?>();
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
