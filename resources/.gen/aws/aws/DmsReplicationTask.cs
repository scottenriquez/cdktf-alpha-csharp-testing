using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DmsReplicationTask), fullyQualifiedName: "aws.DmsReplicationTask", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DmsReplicationTaskConfig\"}}]")]
    public class DmsReplicationTask : HashiCorp.Cdktf.TerraformResource
    {
        public DmsReplicationTask(Constructs.Construct scope, string id, aws.IDmsReplicationTaskConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsReplicationTask(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsReplicationTask(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCdcStartTime")]
        public virtual void ResetCdcStartTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicationTaskSettings")]
        public virtual void ResetReplicationTaskSettings()
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "migrationTypeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MigrationTypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicationInstanceArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationInstanceArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicationTaskArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationTaskArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicationTaskIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationTaskIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceEndpointArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceEndpointArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tableMappingsInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableMappingsInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetEndpointArnInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetEndpointArnInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cdcStartTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CdcStartTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationTaskSettingsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplicationTaskSettingsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "cdcStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CdcStartTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "migrationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MigrationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicationInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationInstanceArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicationTaskId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationTaskId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicationTaskSettings", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationTaskSettings
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceEndpointArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceEndpointArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tableMappings", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableMappings
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

        [JsiiProperty(name: "targetEndpointArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetEndpointArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
