using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainConfig), fullyQualifiedName: "aws.ElasticsearchDomainConfig")]
    public interface IElasticsearchDomainConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        string DomainName
        {
            get;
        }

        [JsiiProperty(name: "accessPolicies", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessPolicies
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "advancedOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? AdvancedOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>advanced_security_options block.</summary>
        [JsiiProperty(name: "advancedSecurityOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainAdvancedSecurityOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElasticsearchDomainAdvancedSecurityOptions[]? AdvancedSecurityOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>cluster_config block.</summary>
        [JsiiProperty(name: "clusterConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainClusterConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElasticsearchDomainClusterConfig[]? ClusterConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>cognito_options block.</summary>
        [JsiiProperty(name: "cognitoOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainCognitoOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElasticsearchDomainCognitoOptions[]? CognitoOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>domain_endpoint_options block.</summary>
        [JsiiProperty(name: "domainEndpointOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainDomainEndpointOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElasticsearchDomainDomainEndpointOptions[]? DomainEndpointOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>ebs_options block.</summary>
        [JsiiProperty(name: "ebsOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainEbsOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElasticsearchDomainEbsOptions[]? EbsOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "elasticsearchVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ElasticsearchVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>encrypt_at_rest block.</summary>
        [JsiiProperty(name: "encryptAtRest", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainEncryptAtRest\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElasticsearchDomainEncryptAtRest[]? EncryptAtRest
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_publishing_options block.</summary>
        [JsiiProperty(name: "logPublishingOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainLogPublishingOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElasticsearchDomainLogPublishingOptions[]? LogPublishingOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>node_to_node_encryption block.</summary>
        [JsiiProperty(name: "nodeToNodeEncryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainNodeToNodeEncryption\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElasticsearchDomainNodeToNodeEncryption[]? NodeToNodeEncryption
        {
            get
            {
                return null;
            }
        }

        /// <summary>snapshot_options block.</summary>
        [JsiiProperty(name: "snapshotOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainSnapshotOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElasticsearchDomainSnapshotOptions[]? SnapshotOptions
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

        /// <summary>timeouts block.</summary>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ElasticsearchDomainTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElasticsearchDomainTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc_options block.</summary>
        [JsiiProperty(name: "vpcOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainVpcOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElasticsearchDomainVpcOptions[]? VpcOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainConfig), fullyQualifiedName: "aws.ElasticsearchDomainConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IElasticsearchDomainConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "accessPolicies", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessPolicies
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "advancedOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? AdvancedOptions
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>advanced_security_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "advancedSecurityOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainAdvancedSecurityOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElasticsearchDomainAdvancedSecurityOptions[]? AdvancedSecurityOptions
            {
                get => GetInstanceProperty<aws.IElasticsearchDomainAdvancedSecurityOptions[]?>();
            }

            /// <summary>cluster_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clusterConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainClusterConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElasticsearchDomainClusterConfig[]? ClusterConfig
            {
                get => GetInstanceProperty<aws.IElasticsearchDomainClusterConfig[]?>();
            }

            /// <summary>cognito_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cognitoOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainCognitoOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElasticsearchDomainCognitoOptions[]? CognitoOptions
            {
                get => GetInstanceProperty<aws.IElasticsearchDomainCognitoOptions[]?>();
            }

            /// <summary>domain_endpoint_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domainEndpointOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainDomainEndpointOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElasticsearchDomainDomainEndpointOptions[]? DomainEndpointOptions
            {
                get => GetInstanceProperty<aws.IElasticsearchDomainDomainEndpointOptions[]?>();
            }

            /// <summary>ebs_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ebsOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainEbsOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElasticsearchDomainEbsOptions[]? EbsOptions
            {
                get => GetInstanceProperty<aws.IElasticsearchDomainEbsOptions[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "elasticsearchVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ElasticsearchVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>encrypt_at_rest block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptAtRest", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainEncryptAtRest\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElasticsearchDomainEncryptAtRest[]? EncryptAtRest
            {
                get => GetInstanceProperty<aws.IElasticsearchDomainEncryptAtRest[]?>();
            }

            /// <summary>log_publishing_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logPublishingOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainLogPublishingOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElasticsearchDomainLogPublishingOptions[]? LogPublishingOptions
            {
                get => GetInstanceProperty<aws.IElasticsearchDomainLogPublishingOptions[]?>();
            }

            /// <summary>node_to_node_encryption block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeToNodeEncryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainNodeToNodeEncryption\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElasticsearchDomainNodeToNodeEncryption[]? NodeToNodeEncryption
            {
                get => GetInstanceProperty<aws.IElasticsearchDomainNodeToNodeEncryption[]?>();
            }

            /// <summary>snapshot_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "snapshotOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainSnapshotOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElasticsearchDomainSnapshotOptions[]? SnapshotOptions
            {
                get => GetInstanceProperty<aws.IElasticsearchDomainSnapshotOptions[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ElasticsearchDomainTimeouts\"}", isOptional: true)]
            public aws.IElasticsearchDomainTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.IElasticsearchDomainTimeouts?>();
            }

            /// <summary>vpc_options block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainVpcOptions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElasticsearchDomainVpcOptions[]? VpcOptions
            {
                get => GetInstanceProperty<aws.IElasticsearchDomainVpcOptions[]?>();
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
