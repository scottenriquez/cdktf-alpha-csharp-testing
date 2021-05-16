using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.LambdaProvisionedConcurrencyConfig), fullyQualifiedName: "aws.LambdaProvisionedConcurrencyConfig", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.LambdaProvisionedConcurrencyConfigConfig\"}}]")]
    public class LambdaProvisionedConcurrencyConfig : HashiCorp.Cdktf.TerraformResource
    {
        public LambdaProvisionedConcurrencyConfig(Constructs.Construct scope, string id, aws.ILambdaProvisionedConcurrencyConfigConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaProvisionedConcurrencyConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaProvisionedConcurrencyConfig(DeputyProps props): base(props)
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

        [JsiiProperty(name: "functionNameInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionNameInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provisionedConcurrentExecutionsInput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProvisionedConcurrentExecutionsInput
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "qualifierInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QualifierInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.LambdaProvisionedConcurrencyConfigTimeouts\"}", isOptional: true)]
        public virtual aws.ILambdaProvisionedConcurrencyConfigTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.ILambdaProvisionedConcurrencyConfigTimeouts?>();
        }

        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "provisionedConcurrentExecutions", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProvisionedConcurrentExecutions
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "qualifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Qualifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.LambdaProvisionedConcurrencyConfigTimeouts\"}")]
        public virtual aws.ILambdaProvisionedConcurrencyConfigTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.ILambdaProvisionedConcurrencyConfigTimeouts>()!;
            set => SetInstanceProperty(value);
        }
    }
}
