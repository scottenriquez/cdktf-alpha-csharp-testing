using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DataAwsElasticacheReplicationGroup), fullyQualifiedName: "aws.DataAwsElasticacheReplicationGroup", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DataAwsElasticacheReplicationGroupConfig\"}}]")]
    public class DataAwsElasticacheReplicationGroup : HashiCorp.Cdktf.TerraformDataSource
    {
        public DataAwsElasticacheReplicationGroup(Constructs.Construct scope, string id, aws.IDataAwsElasticacheReplicationGroupConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticacheReplicationGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsElasticacheReplicationGroup(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "authTokenEnabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool AuthTokenEnabled
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "automaticFailoverEnabled", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool AutomaticFailoverEnabled
        {
            get => GetInstanceProperty<bool>()!;
        }

        [JsiiProperty(name: "configurationEndpointAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationEndpointAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "memberClusters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MemberClusters
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "numberCacheClusters", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberCacheClusters
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "primaryEndpointAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryEndpointAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicationGroupDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationGroupDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicationGroupIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationGroupIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "snapshotRetentionLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SnapshotRetentionLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "snapshotWindow", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnapshotWindow
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "replicationGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
