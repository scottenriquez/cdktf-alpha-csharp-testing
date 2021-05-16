using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.DynamodbGlobalTable), fullyQualifiedName: "aws.DynamodbGlobalTable", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.DynamodbGlobalTableConfig\"}}]")]
    public class DynamodbGlobalTable : HashiCorp.Cdktf.TerraformResource
    {
        public DynamodbGlobalTable(Constructs.Construct scope, string id, aws.IDynamodbGlobalTableConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynamodbGlobalTable(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DynamodbGlobalTable(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "replicaInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbGlobalTableReplica\"},\"kind\":\"array\"}}")]
        public virtual aws.IDynamodbGlobalTableReplica[] ReplicaInput
        {
            get => GetInstanceProperty<aws.IDynamodbGlobalTableReplica[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.DynamodbGlobalTableTimeouts\"}", isOptional: true)]
        public virtual aws.IDynamodbGlobalTableTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IDynamodbGlobalTableTimeouts?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replica", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DynamodbGlobalTableReplica\"},\"kind\":\"array\"}}")]
        public virtual aws.IDynamodbGlobalTableReplica[] Replica
        {
            get => GetInstanceProperty<aws.IDynamodbGlobalTableReplica[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.DynamodbGlobalTableTimeouts\"}")]
        public virtual aws.IDynamodbGlobalTableTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IDynamodbGlobalTableTimeouts>()!;
            set => SetInstanceProperty(value);
        }
    }
}
