using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.AmiCopy), fullyQualifiedName: "aws.AmiCopy", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.AmiCopyConfig\"}}]")]
    public class AmiCopy : HashiCorp.Cdktf.TerraformResource
    {
        public AmiCopy(Constructs.Construct scope, string id, aws.IAmiCopyConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AmiCopy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AmiCopy(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEbsBlockDevice")]
        public virtual void ResetEbsBlockDevice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncrypted")]
        public virtual void ResetEncrypted()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEphemeralBlockDevice")]
        public virtual void ResetEphemeralBlockDevice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyId")]
        public virtual void ResetKmsKeyId()
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

        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Architecture
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enaSupport", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool EnaSupport
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kernelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KernelId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "manageEbsSnapshots", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool ManageEbsSnapshots
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ramdiskId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RamdiskId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rootDeviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootDeviceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rootSnapshotId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootSnapshotId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceAmiIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceAmiIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceAmiRegionInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceAmiRegionInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sriovNetSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SriovNetSupport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "virtualizationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualizationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsBlockDeviceInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AmiCopyEbsBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAmiCopyEbsBlockDevice[]? EbsBlockDeviceInput
        {
            get => GetInstanceProperty<aws.IAmiCopyEbsBlockDevice[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptedInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? EncryptedInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ephemeralBlockDeviceInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AmiCopyEphemeralBlockDevice\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IAmiCopyEphemeralBlockDevice[]? EphemeralBlockDeviceInput
        {
            get => GetInstanceProperty<aws.IAmiCopyEphemeralBlockDevice[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyIdInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.AmiCopyTimeouts\"}", isOptional: true)]
        public virtual aws.IAmiCopyTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IAmiCopyTimeouts?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AmiCopyEbsBlockDevice\"},\"kind\":\"array\"}}")]
        public virtual aws.IAmiCopyEbsBlockDevice[] EbsBlockDevice
        {
            get => GetInstanceProperty<aws.IAmiCopyEbsBlockDevice[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "encrypted", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool Encrypted
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AmiCopyEphemeralBlockDevice\"},\"kind\":\"array\"}}")]
        public virtual aws.IAmiCopyEphemeralBlockDevice[] EphemeralBlockDevice
        {
            get => GetInstanceProperty<aws.IAmiCopyEphemeralBlockDevice[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceAmiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceAmiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceAmiRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceAmiRegion
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.AmiCopyTimeouts\"}")]
        public virtual aws.IAmiCopyTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IAmiCopyTimeouts>()!;
            set => SetInstanceProperty(value);
        }
    }
}
