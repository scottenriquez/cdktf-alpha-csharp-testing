using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.GlueCatalogTable), fullyQualifiedName: "aws.GlueCatalogTable", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.GlueCatalogTableConfig\"}}]")]
    public class GlueCatalogTable : HashiCorp.Cdktf.TerraformResource
    {
        public GlueCatalogTable(Constructs.Construct scope, string id, aws.IGlueCatalogTableConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCatalogTable(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCatalogTable(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCatalogId")]
        public virtual void ResetCatalogId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOwner")]
        public virtual void ResetOwner()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameters")]
        public virtual void ResetParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPartitionKeys")]
        public virtual void ResetPartitionKeys()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetention")]
        public virtual void ResetRetention()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageDescriptor")]
        public virtual void ResetStorageDescriptor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTableType")]
        public virtual void ResetTableType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetViewExpandedText")]
        public virtual void ResetViewExpandedText()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetViewOriginalText")]
        public virtual void ResetViewOriginalText()
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

        [JsiiProperty(name: "databaseNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseNameInput
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

        [JsiiOptional]
        [JsiiProperty(name: "catalogIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CatalogIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ownerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OwnerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parametersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ParametersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partitionKeysInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCatalogTablePartitionKeys\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IGlueCatalogTablePartitionKeys[]? PartitionKeysInput
        {
            get => GetInstanceProperty<aws.IGlueCatalogTablePartitionKeys[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetentionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageDescriptorInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCatalogTableStorageDescriptor\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IGlueCatalogTableStorageDescriptor[]? StorageDescriptorInput
        {
            get => GetInstanceProperty<aws.IGlueCatalogTableStorageDescriptor[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TableTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "viewExpandedTextInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ViewExpandedTextInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "viewOriginalTextInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ViewOriginalTextInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CatalogId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Owner
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "partitionKeys", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCatalogTablePartitionKeys\"},\"kind\":\"array\"}}")]
        public virtual aws.IGlueCatalogTablePartitionKeys[] PartitionKeys
        {
            get => GetInstanceProperty<aws.IGlueCatalogTablePartitionKeys[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retention", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Retention
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageDescriptor", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.GlueCatalogTableStorageDescriptor\"},\"kind\":\"array\"}}")]
        public virtual aws.IGlueCatalogTableStorageDescriptor[] StorageDescriptor
        {
            get => GetInstanceProperty<aws.IGlueCatalogTableStorageDescriptor[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tableType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "viewExpandedText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViewExpandedText
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "viewOriginalText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViewOriginalText
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
