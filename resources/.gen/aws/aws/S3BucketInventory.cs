using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.S3BucketInventory), fullyQualifiedName: "aws.S3BucketInventory", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.S3BucketInventoryConfig\"}}]")]
    public class S3BucketInventory : HashiCorp.Cdktf.TerraformResource
    {
        public S3BucketInventory(Constructs.Construct scope, string id, aws.IS3BucketInventoryConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketInventory(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketInventory(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOptionalFields")]
        public virtual void ResetOptionalFields()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "destinationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryDestination\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3BucketInventoryDestination[] DestinationInput
        {
            get => GetInstanceProperty<aws.IS3BucketInventoryDestination[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "includedObjectVersionsInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IncludedObjectVersionsInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduleInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventorySchedule\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3BucketInventorySchedule[] ScheduleInput
        {
            get => GetInstanceProperty<aws.IS3BucketInventorySchedule[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? EnabledInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IS3BucketInventoryFilter[]? FilterInput
        {
            get => GetInstanceProperty<aws.IS3BucketInventoryFilter[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "optionalFieldsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? OptionalFieldsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destination", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryDestination\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3BucketInventoryDestination[] Destination
        {
            get => GetInstanceProperty<aws.IS3BucketInventoryDestination[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool Enabled
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventoryFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3BucketInventoryFilter[] Filter
        {
            get => GetInstanceProperty<aws.IS3BucketInventoryFilter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "includedObjectVersions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IncludedObjectVersions
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

        [JsiiProperty(name: "optionalFields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OptionalFields
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketInventorySchedule\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3BucketInventorySchedule[] Schedule
        {
            get => GetInstanceProperty<aws.IS3BucketInventorySchedule[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
