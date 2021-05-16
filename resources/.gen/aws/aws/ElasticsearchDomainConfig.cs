using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ElasticsearchDomainConfig")]
    public class ElasticsearchDomainConfig : aws.IElasticsearchDomainConfig
    {
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DomainName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessPolicies", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AccessPolicies
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "advancedOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? AdvancedOptions
        {
            get;
            set;
        }

        /// <summary>advanced_security_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "advancedSecurityOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainAdvancedSecurityOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElasticsearchDomainAdvancedSecurityOptions[]? AdvancedSecurityOptions
        {
            get;
            set;
        }

        /// <summary>cluster_config block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainClusterConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElasticsearchDomainClusterConfig[]? ClusterConfig
        {
            get;
            set;
        }

        /// <summary>cognito_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cognitoOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainCognitoOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElasticsearchDomainCognitoOptions[]? CognitoOptions
        {
            get;
            set;
        }

        /// <summary>domain_endpoint_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domainEndpointOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainDomainEndpointOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElasticsearchDomainDomainEndpointOptions[]? DomainEndpointOptions
        {
            get;
            set;
        }

        /// <summary>ebs_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ebsOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainEbsOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElasticsearchDomainEbsOptions[]? EbsOptions
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ElasticsearchVersion
        {
            get;
            set;
        }

        /// <summary>encrypt_at_rest block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptAtRest", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainEncryptAtRest\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElasticsearchDomainEncryptAtRest[]? EncryptAtRest
        {
            get;
            set;
        }

        /// <summary>log_publishing_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logPublishingOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainLogPublishingOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElasticsearchDomainLogPublishingOptions[]? LogPublishingOptions
        {
            get;
            set;
        }

        /// <summary>node_to_node_encryption block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeToNodeEncryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainNodeToNodeEncryption\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElasticsearchDomainNodeToNodeEncryption[]? NodeToNodeEncryption
        {
            get;
            set;
        }

        /// <summary>snapshot_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainSnapshotOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElasticsearchDomainSnapshotOptions[]? SnapshotOptions
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
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ElasticsearchDomainTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.IElasticsearchDomainTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>vpc_options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainVpcOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IElasticsearchDomainVpcOptions[]? VpcOptions
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
