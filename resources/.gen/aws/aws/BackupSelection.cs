using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.BackupSelection), fullyQualifiedName: "aws.BackupSelection", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.BackupSelectionConfig\"}}]")]
    public class BackupSelection : HashiCorp.Cdktf.TerraformResource
    {
        public BackupSelection(Constructs.Construct scope, string id, aws.IBackupSelectionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BackupSelection(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BackupSelection(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetResources")]
        public virtual void ResetResources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSelectionTag")]
        public virtual void ResetSelectionTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "iamRoleArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamRoleArnInput
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

        [JsiiProperty(name: "planIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ResourcesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "selectionTagInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BackupSelectionSelectionTag\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IBackupSelectionSelectionTag[]? SelectionTagInput
        {
            get => GetInstanceProperty<aws.IBackupSelectionSelectionTag[]?>();
        }

        [JsiiProperty(name: "iamRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamRoleArn
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

        [JsiiProperty(name: "planId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Resources
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "selectionTag", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BackupSelectionSelectionTag\"},\"kind\":\"array\"}}")]
        public virtual aws.IBackupSelectionSelectionTag[] SelectionTag
        {
            get => GetInstanceProperty<aws.IBackupSelectionSelectionTag[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
