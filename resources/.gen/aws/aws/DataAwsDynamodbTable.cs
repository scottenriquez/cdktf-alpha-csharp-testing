using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsDynamodbTable), fullyQualifiedName: "aws.DataAwsDynamodbTable", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DataAwsDynamodbTableConfig\"}}]")]
    public class DataAwsDynamodbTable : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsDynamodbTable(Constructs.Construct scope, string id, aws.IDataAwsDynamodbTableConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsDynamodbTable(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsDynamodbTable(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "attribute", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsDynamodbTableAttribute\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsDynamodbTableAttribute Attribute(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsDynamodbTableAttribute>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "globalSecondaryIndex", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsDynamodbTableGlobalSecondaryIndex\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsDynamodbTableGlobalSecondaryIndex GlobalSecondaryIndex(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsDynamodbTableGlobalSecondaryIndex>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "localSecondaryIndex", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsDynamodbTableLocalSecondaryIndex\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsDynamodbTableLocalSecondaryIndex LocalSecondaryIndex(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsDynamodbTableLocalSecondaryIndex>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "pointInTimeRecovery", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsDynamodbTablePointInTimeRecovery\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsDynamodbTablePointInTimeRecovery PointInTimeRecovery(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsDynamodbTablePointInTimeRecovery>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "replica", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsDynamodbTableReplica\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsDynamodbTableReplica Replica(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsDynamodbTableReplica>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "resetServerSideEncryption")]
        public virtual void ResetServerSideEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "ttl", returnsJson: "{\"type\":{\"fqn\":\"aws.DataAwsDynamodbTableTtl\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.DataAwsDynamodbTableTtl Ttl(string index)
        {
            return InvokeInstanceMethod<aws.DataAwsDynamodbTableTtl>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "billingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hashKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HashKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RangeKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "readCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReadCapacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streamEnabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool StreamEnabled
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "streamLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamLabel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streamViewType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamViewType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "writeCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WriteCapacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryptionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsDynamodbTableServerSideEncryption\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDataAwsDynamodbTableServerSideEncryption[]? ServerSideEncryptionInput
        {
            get => GetInstanceProperty<aws.IDataAwsDynamodbTableServerSideEncryption[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsDynamodbTableServerSideEncryption\"},\"kind\":\"array\"}}")]
        public virtual aws.IDataAwsDynamodbTableServerSideEncryption[] ServerSideEncryption
        {
            get => GetInstanceProperty<aws.IDataAwsDynamodbTableServerSideEncryption[]>()!;
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
