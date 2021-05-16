using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.LambdaFunctionEventInvokeConfig), fullyQualifiedName: "aws.LambdaFunctionEventInvokeConfig", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.LambdaFunctionEventInvokeConfigConfig\"}}]")]
    public class LambdaFunctionEventInvokeConfig : HashiCorp.Cdktf.TerraformResource
    {
        public LambdaFunctionEventInvokeConfig(Constructs.Construct scope, string id, aws.ILambdaFunctionEventInvokeConfigConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaFunctionEventInvokeConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaFunctionEventInvokeConfig(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDestinationConfig")]
        public virtual void ResetDestinationConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumEventAgeInSeconds")]
        public virtual void ResetMaximumEventAgeInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumRetryAttempts")]
        public virtual void ResetMaximumRetryAttempts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQualifier")]
        public virtual void ResetQualifier()
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

        [JsiiOptional]
        [JsiiProperty(name: "destinationConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionEventInvokeConfigDestinationConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ILambdaFunctionEventInvokeConfigDestinationConfig[]? DestinationConfigInput
        {
            get => GetInstanceProperty<aws.ILambdaFunctionEventInvokeConfigDestinationConfig[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumEventAgeInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumEventAgeInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumRetryAttemptsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumRetryAttemptsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "qualifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QualifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "destinationConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.LambdaFunctionEventInvokeConfigDestinationConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.ILambdaFunctionEventInvokeConfigDestinationConfig[] DestinationConfig
        {
            get => GetInstanceProperty<aws.ILambdaFunctionEventInvokeConfigDestinationConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumEventAgeInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumEventAgeInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumRetryAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumRetryAttempts
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
    }
}
