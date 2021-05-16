using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.StoragegatewayNfsFileShare), fullyQualifiedName: "aws.StoragegatewayNfsFileShare", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.StoragegatewayNfsFileShareConfig\"}}]")]
    public class StoragegatewayNfsFileShare : HashiCorp.Cdktf.TerraformResource
    {
        public StoragegatewayNfsFileShare(Constructs.Construct scope, string id, aws.IStoragegatewayNfsFileShareConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StoragegatewayNfsFileShare(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StoragegatewayNfsFileShare(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDefaultStorageClass")]
        public virtual void ResetDefaultStorageClass()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGuessMimeTypeEnabled")]
        public virtual void ResetGuessMimeTypeEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsEncrypted")]
        public virtual void ResetKmsEncrypted()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyArn")]
        public virtual void ResetKmsKeyArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNfsFileShareDefaults")]
        public virtual void ResetNfsFileShareDefaults()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectAcl")]
        public virtual void ResetObjectAcl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReadOnly")]
        public virtual void ResetReadOnly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequesterPays")]
        public virtual void ResetRequesterPays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSquash")]
        public virtual void ResetSquash()
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

        [JsiiProperty(name: "clientListInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ClientListInput
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "fileshareId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileshareId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gatewayArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locationArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocationArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultStorageClassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultStorageClassInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "guessMimeTypeEnabledInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? GuessMimeTypeEnabledInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsEncryptedInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? KmsEncryptedInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nfsFileShareDefaultsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.StoragegatewayNfsFileShareNfsFileShareDefaults\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IStoragegatewayNfsFileShareNfsFileShareDefaults[]? NfsFileShareDefaultsInput
        {
            get => GetInstanceProperty<aws.IStoragegatewayNfsFileShareNfsFileShareDefaults[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectAclInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectAclInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "readOnlyInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? ReadOnlyInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requesterPaysInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? RequesterPaysInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "squashInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SquashInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.StoragegatewayNfsFileShareTimeouts\"}", isOptional: true)]
        public virtual aws.IStoragegatewayNfsFileShareTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IStoragegatewayNfsFileShareTimeouts?>();
        }

        [JsiiProperty(name: "clientList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ClientList
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultStorageClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultStorageClass
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gatewayArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "guessMimeTypeEnabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool GuessMimeTypeEnabled
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsEncrypted", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool KmsEncrypted
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "locationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocationArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nfsFileShareDefaults", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.StoragegatewayNfsFileShareNfsFileShareDefaults\"},\"kind\":\"array\"}}")]
        public virtual aws.IStoragegatewayNfsFileShareNfsFileShareDefaults[] NfsFileShareDefaults
        {
            get => GetInstanceProperty<aws.IStoragegatewayNfsFileShareNfsFileShareDefaults[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectAcl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectAcl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool ReadOnly
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requesterPays", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool RequesterPays
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "squash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Squash
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.StoragegatewayNfsFileShareTimeouts\"}")]
        public virtual aws.IStoragegatewayNfsFileShareTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IStoragegatewayNfsFileShareTimeouts>()!;
            set => SetInstanceProperty(value);
        }
    }
}
