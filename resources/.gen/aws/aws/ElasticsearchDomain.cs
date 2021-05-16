using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.ElasticsearchDomain), fullyQualifiedName: "aws.ElasticsearchDomain", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ElasticsearchDomainConfig\"}}]")]
    public class ElasticsearchDomain : HashiCorp.Cdktf.TerraformResource
    {
        public ElasticsearchDomain(Constructs.Construct scope, string id, aws.IElasticsearchDomainConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomain(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomain(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAccessPolicies")]
        public virtual void ResetAccessPolicies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdvancedOptions")]
        public virtual void ResetAdvancedOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdvancedSecurityOptions")]
        public virtual void ResetAdvancedSecurityOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterConfig")]
        public virtual void ResetClusterConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCognitoOptions")]
        public virtual void ResetCognitoOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDomainEndpointOptions")]
        public virtual void ResetDomainEndpointOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEbsOptions")]
        public virtual void ResetEbsOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticsearchVersion")]
        public virtual void ResetElasticsearchVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptAtRest")]
        public virtual void ResetEncryptAtRest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogPublishingOptions")]
        public virtual void ResetLogPublishingOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeToNodeEncryption")]
        public virtual void ResetNodeToNodeEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotOptions")]
        public virtual void ResetSnapshotOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcOptions")]
        public virtual void ResetVpcOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kibanaEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KibanaEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessPoliciesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessPoliciesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "advancedOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AdvancedOptionsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "advancedSecurityOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainAdvancedSecurityOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElasticsearchDomainAdvancedSecurityOptions[]? AdvancedSecurityOptionsInput
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainAdvancedSecurityOptions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainClusterConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElasticsearchDomainClusterConfig[]? ClusterConfigInput
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainClusterConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cognitoOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainCognitoOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElasticsearchDomainCognitoOptions[]? CognitoOptionsInput
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainCognitoOptions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainEndpointOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainDomainEndpointOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElasticsearchDomainDomainEndpointOptions[]? DomainEndpointOptionsInput
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainDomainEndpointOptions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainEbsOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElasticsearchDomainEbsOptions[]? EbsOptionsInput
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainEbsOptions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ElasticsearchVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptAtRestInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainEncryptAtRest\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElasticsearchDomainEncryptAtRest[]? EncryptAtRestInput
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainEncryptAtRest[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logPublishingOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainLogPublishingOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElasticsearchDomainLogPublishingOptions[]? LogPublishingOptionsInput
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainLogPublishingOptions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeToNodeEncryptionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainNodeToNodeEncryption\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElasticsearchDomainNodeToNodeEncryption[]? NodeToNodeEncryptionInput
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainNodeToNodeEncryption[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainSnapshotOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElasticsearchDomainSnapshotOptions[]? SnapshotOptionsInput
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainSnapshotOptions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.ElasticsearchDomainTimeouts\"}", isOptional: true)]
        public virtual aws.IElasticsearchDomainTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainVpcOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IElasticsearchDomainVpcOptions[]? VpcOptionsInput
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainVpcOptions[]?>();
        }

        [JsiiProperty(name: "accessPolicies", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessPolicies
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "advancedOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdvancedOptions
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "advancedSecurityOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainAdvancedSecurityOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.IElasticsearchDomainAdvancedSecurityOptions[] AdvancedSecurityOptions
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainAdvancedSecurityOptions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainClusterConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.IElasticsearchDomainClusterConfig[] ClusterConfig
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainClusterConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cognitoOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainCognitoOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.IElasticsearchDomainCognitoOptions[] CognitoOptions
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainCognitoOptions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domainEndpointOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainDomainEndpointOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.IElasticsearchDomainDomainEndpointOptions[] DomainEndpointOptions
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainDomainEndpointOptions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ebsOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainEbsOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.IElasticsearchDomainEbsOptions[] EbsOptions
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainEbsOptions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "elasticsearchVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElasticsearchVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "encryptAtRest", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainEncryptAtRest\"},\"kind\":\"array\"}}")]
        public virtual aws.IElasticsearchDomainEncryptAtRest[] EncryptAtRest
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainEncryptAtRest[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logPublishingOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainLogPublishingOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.IElasticsearchDomainLogPublishingOptions[] LogPublishingOptions
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainLogPublishingOptions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeToNodeEncryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainNodeToNodeEncryption\"},\"kind\":\"array\"}}")]
        public virtual aws.IElasticsearchDomainNodeToNodeEncryption[] NodeToNodeEncryption
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainNodeToNodeEncryption[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snapshotOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainSnapshotOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.IElasticsearchDomainSnapshotOptions[] SnapshotOptions
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainSnapshotOptions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ElasticsearchDomainTimeouts\"}")]
        public virtual aws.IElasticsearchDomainTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainTimeouts>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainVpcOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.IElasticsearchDomainVpcOptions[] VpcOptions
        {
            get => GetInstanceProperty<aws.IElasticsearchDomainVpcOptions[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
