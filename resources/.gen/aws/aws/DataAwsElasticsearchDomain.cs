using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsElasticsearchDomain), fullyQualifiedName: "aws.DataAwsElasticsearchDomain", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DataAwsElasticsearchDomainConfig\"}}]")]
    public class DataAwsElasticsearchDomain : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsElasticsearchDomain(Constructs.Construct scope, string id, aws.IDataAwsElasticsearchDomainConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticsearchDomain(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticsearchDomain(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "advancedOptions", returnsJson: "{\"type\":{\"primitive\":\"string\"}}", parametersJson: "[{\"name\":\"key\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual string AdvancedOptions(string key)
        {
            return InvokeInstanceMethod<string>(new System.Type[]{typeof(string)}, new object[]{key})!;
        }

        [JsiiMethod(name: "advancedSecurityOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsElasticsearchDomainAdvancedSecurityOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsElasticsearchDomainAdvancedSecurityOptions AdvancedSecurityOptions(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsElasticsearchDomainAdvancedSecurityOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "clusterConfig", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsElasticsearchDomainClusterConfig\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsElasticsearchDomainClusterConfig ClusterConfig(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsElasticsearchDomainClusterConfig>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "cognitoOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsElasticsearchDomainCognitoOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsElasticsearchDomainCognitoOptions CognitoOptions(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsElasticsearchDomainCognitoOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "ebsOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsElasticsearchDomainEbsOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsElasticsearchDomainEbsOptions EbsOptions(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsElasticsearchDomainEbsOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "encryptionAtRest", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsElasticsearchDomainEncryptionAtRest\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsElasticsearchDomainEncryptionAtRest EncryptionAtRest(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsElasticsearchDomainEncryptionAtRest>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "logPublishingOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsElasticsearchDomainLogPublishingOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsElasticsearchDomainLogPublishingOptions LogPublishingOptions(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsElasticsearchDomainLogPublishingOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "nodeToNodeEncryption", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsElasticsearchDomainNodeToNodeEncryption\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsElasticsearchDomainNodeToNodeEncryption NodeToNodeEncryption(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsElasticsearchDomainNodeToNodeEncryption>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "snapshotOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsElasticsearchDomainSnapshotOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsElasticsearchDomainSnapshotOptions SnapshotOptions(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsElasticsearchDomainSnapshotOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "vpcOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsElasticsearchDomainVpcOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsElasticsearchDomainVpcOptions VpcOptions(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsElasticsearchDomainVpcOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiProperty(name: "accessPolicies", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessPolicies
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool Created
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "deleted", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool Deleted
        {
            get => GetInstanceProperty<bool>()!;
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

        [JsiiProperty(name: "elasticsearchVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ElasticsearchVersion
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

        [JsiiProperty(name: "processing", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool Processing
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
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
