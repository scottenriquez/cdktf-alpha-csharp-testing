using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DynamodbTable), fullyQualifiedName: "aws.DynamodbTable", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DynamodbTableConfig\"}}]")]
    public class DynamodbTable : HashiCorp.Cdktf.TerraformResource
    {
        public DynamodbTable(Constructs.Construct scope, string id, aws.IDynamodbTableConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynamodbTable(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynamodbTable(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBillingMode")]
        public virtual void ResetBillingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGlobalSecondaryIndex")]
        public virtual void ResetGlobalSecondaryIndex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalSecondaryIndex")]
        public virtual void ResetLocalSecondaryIndex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPointInTimeRecovery")]
        public virtual void ResetPointInTimeRecovery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRangeKey")]
        public virtual void ResetRangeKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReadCapacity")]
        public virtual void ResetReadCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplica")]
        public virtual void ResetReplica()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerSideEncryption")]
        public virtual void ResetServerSideEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreamEnabled")]
        public virtual void ResetStreamEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreamViewType")]
        public virtual void ResetStreamViewType()
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

        [JsiiMethod(name: "resetTtl")]
        public virtual void ResetTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWriteCapacity")]
        public virtual void ResetWriteCapacity()
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

        [JsiiProperty(name: "attributeInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableAttribute\"},\"kind\":\"array\"}}")]
        public virtual aws.IDynamodbTableAttribute[] AttributeInput
        {
            get => GetInstanceProperty<aws.IDynamodbTableAttribute[]>()!;
        }

        [JsiiProperty(name: "hashKeyInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HashKeyInput
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

        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streamLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamLabel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "billingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BillingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "globalSecondaryIndexInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableGlobalSecondaryIndex\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDynamodbTableGlobalSecondaryIndex[]? GlobalSecondaryIndexInput
        {
            get => GetInstanceProperty<aws.IDynamodbTableGlobalSecondaryIndex[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localSecondaryIndexInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableLocalSecondaryIndex\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDynamodbTableLocalSecondaryIndex[]? LocalSecondaryIndexInput
        {
            get => GetInstanceProperty<aws.IDynamodbTableLocalSecondaryIndex[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pointInTimeRecoveryInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTablePointInTimeRecovery\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDynamodbTablePointInTimeRecovery[]? PointInTimeRecoveryInput
        {
            get => GetInstanceProperty<aws.IDynamodbTablePointInTimeRecovery[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rangeKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RangeKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReadCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicaInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableReplica\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDynamodbTableReplica[]? ReplicaInput
        {
            get => GetInstanceProperty<aws.IDynamodbTableReplica[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryptionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableServerSideEncryption\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDynamodbTableServerSideEncryption[]? ServerSideEncryptionInput
        {
            get => GetInstanceProperty<aws.IDynamodbTableServerSideEncryption[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamEnabledInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? StreamEnabledInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamViewTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StreamViewTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.DynamodbTableTimeouts\"}", isOptional: true)]
        public virtual aws.IDynamodbTableTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IDynamodbTableTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ttlInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableTtl\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IDynamodbTableTtl[]? TtlInput
        {
            get => GetInstanceProperty<aws.IDynamodbTableTtl[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "writeCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WriteCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "attribute", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableAttribute\"},\"kind\":\"array\"}}")]
        public virtual aws.IDynamodbTableAttribute[] Attribute
        {
            get => GetInstanceProperty<aws.IDynamodbTableAttribute[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "billingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "globalSecondaryIndex", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableGlobalSecondaryIndex\"},\"kind\":\"array\"}}")]
        public virtual aws.IDynamodbTableGlobalSecondaryIndex[] GlobalSecondaryIndex
        {
            get => GetInstanceProperty<aws.IDynamodbTableGlobalSecondaryIndex[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hashKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HashKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localSecondaryIndex", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableLocalSecondaryIndex\"},\"kind\":\"array\"}}")]
        public virtual aws.IDynamodbTableLocalSecondaryIndex[] LocalSecondaryIndex
        {
            get => GetInstanceProperty<aws.IDynamodbTableLocalSecondaryIndex[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pointInTimeRecovery", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTablePointInTimeRecovery\"},\"kind\":\"array\"}}")]
        public virtual aws.IDynamodbTablePointInTimeRecovery[] PointInTimeRecovery
        {
            get => GetInstanceProperty<aws.IDynamodbTablePointInTimeRecovery[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RangeKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "readCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReadCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replica", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableReplica\"},\"kind\":\"array\"}}")]
        public virtual aws.IDynamodbTableReplica[] Replica
        {
            get => GetInstanceProperty<aws.IDynamodbTableReplica[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableServerSideEncryption\"},\"kind\":\"array\"}}")]
        public virtual aws.IDynamodbTableServerSideEncryption[] ServerSideEncryption
        {
            get => GetInstanceProperty<aws.IDynamodbTableServerSideEncryption[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "streamEnabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool StreamEnabled
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "streamViewType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamViewType
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.DynamodbTableTimeouts\"}")]
        public virtual aws.IDynamodbTableTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IDynamodbTableTimeouts>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ttl", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbTableTtl\"},\"kind\":\"array\"}}")]
        public virtual aws.IDynamodbTableTtl[] Ttl
        {
            get => GetInstanceProperty<aws.IDynamodbTableTtl[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "writeCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WriteCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
