using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.EfsAccessPoint), fullyQualifiedName: "aws.EfsAccessPoint", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.EfsAccessPointConfig\"}}]")]
    public class EfsAccessPoint : HashiCorp.Cdktf.TerraformResource
    {
        public EfsAccessPoint(Constructs.Construct scope, string id, aws.IEfsAccessPointConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EfsAccessPoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EfsAccessPoint(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetPosixUser")]
        public virtual void ResetPosixUser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRootDirectory")]
        public virtual void ResetRootDirectory()
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

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileSystemArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileSystemIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "posixUserInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EfsAccessPointPosixUser\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEfsAccessPointPosixUser[]? PosixUserInput
        {
            get => GetInstanceProperty<aws.IEfsAccessPointPosixUser[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootDirectoryInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EfsAccessPointRootDirectory\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IEfsAccessPointRootDirectory[]? RootDirectoryInput
        {
            get => GetInstanceProperty<aws.IEfsAccessPointRootDirectory[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "posixUser", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EfsAccessPointPosixUser\"},\"kind\":\"array\"}}")]
        public virtual aws.IEfsAccessPointPosixUser[] PosixUser
        {
            get => GetInstanceProperty<aws.IEfsAccessPointPosixUser[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rootDirectory", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EfsAccessPointRootDirectory\"},\"kind\":\"array\"}}")]
        public virtual aws.IEfsAccessPointRootDirectory[] RootDirectory
        {
            get => GetInstanceProperty<aws.IEfsAccessPointRootDirectory[]>()!;
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
