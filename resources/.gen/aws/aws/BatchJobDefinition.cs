using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.BatchJobDefinition), fullyQualifiedName: "aws.BatchJobDefinition", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.BatchJobDefinitionConfig\"}}]")]
    public class BatchJobDefinition : HashiCorp.Cdktf.TerraformResource
    {
        public BatchJobDefinition(Constructs.Construct scope, string id, aws.IBatchJobDefinitionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchJobDefinition(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchJobDefinition(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetContainerProperties")]
        public virtual void ResetContainerProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameters")]
        public virtual void ResetParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetryStrategy")]
        public virtual void ResetRetryStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeout")]
        public virtual void ResetTimeout()
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

        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Revision
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerPropertiesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerPropertiesInput
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
        [JsiiProperty(name: "retryStrategyInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BatchJobDefinitionRetryStrategy\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IBatchJobDefinitionRetryStrategy[]? RetryStrategyInput
        {
            get => GetInstanceProperty<aws.IBatchJobDefinitionRetryStrategy[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BatchJobDefinitionTimeout\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IBatchJobDefinitionTimeout[]? TimeoutInput
        {
            get => GetInstanceProperty<aws.IBatchJobDefinitionTimeout[]?>();
        }

        [JsiiProperty(name: "containerProperties", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerProperties
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

        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retryStrategy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BatchJobDefinitionRetryStrategy\"},\"kind\":\"array\"}}")]
        public virtual aws.IBatchJobDefinitionRetryStrategy[] RetryStrategy
        {
            get => GetInstanceProperty<aws.IBatchJobDefinitionRetryStrategy[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.BatchJobDefinitionTimeout\"},\"kind\":\"array\"}}")]
        public virtual aws.IBatchJobDefinitionTimeout[] Timeout
        {
            get => GetInstanceProperty<aws.IBatchJobDefinitionTimeout[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
