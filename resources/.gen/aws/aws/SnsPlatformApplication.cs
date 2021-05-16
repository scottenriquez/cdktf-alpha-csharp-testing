using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.SnsPlatformApplication), fullyQualifiedName: "aws.SnsPlatformApplication", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.SnsPlatformApplicationConfig\"}}]")]
    public class SnsPlatformApplication : HashiCorp.Cdktf.TerraformResource
    {
        public SnsPlatformApplication(Constructs.Construct scope, string id, aws.ISnsPlatformApplicationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SnsPlatformApplication(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SnsPlatformApplication(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEventDeliveryFailureTopicArn")]
        public virtual void ResetEventDeliveryFailureTopicArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventEndpointCreatedTopicArn")]
        public virtual void ResetEventEndpointCreatedTopicArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventEndpointDeletedTopicArn")]
        public virtual void ResetEventEndpointDeletedTopicArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventEndpointUpdatedTopicArn")]
        public virtual void ResetEventEndpointUpdatedTopicArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFailureFeedbackRoleArn")]
        public virtual void ResetFailureFeedbackRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlatformPrincipal")]
        public virtual void ResetPlatformPrincipal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSuccessFeedbackRoleArn")]
        public virtual void ResetSuccessFeedbackRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSuccessFeedbackSampleRate")]
        public virtual void ResetSuccessFeedbackSampleRate()
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

        [JsiiProperty(name: "platformCredentialInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformCredentialInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platformInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventDeliveryFailureTopicArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventDeliveryFailureTopicArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventEndpointCreatedTopicArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventEndpointCreatedTopicArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventEndpointDeletedTopicArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventEndpointDeletedTopicArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventEndpointUpdatedTopicArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventEndpointUpdatedTopicArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "failureFeedbackRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FailureFeedbackRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformPrincipalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlatformPrincipalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "successFeedbackRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SuccessFeedbackRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "successFeedbackSampleRateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SuccessFeedbackSampleRateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "eventDeliveryFailureTopicArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventDeliveryFailureTopicArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventEndpointCreatedTopicArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventEndpointCreatedTopicArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventEndpointDeletedTopicArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventEndpointDeletedTopicArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventEndpointUpdatedTopicArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventEndpointUpdatedTopicArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "failureFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FailureFeedbackRoleArn
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

        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Platform
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "platformCredential", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformCredential
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "platformPrincipal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformPrincipal
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "successFeedbackRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SuccessFeedbackRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "successFeedbackSampleRate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SuccessFeedbackSampleRate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
