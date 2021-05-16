using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.SesIdentityNotificationTopic), fullyQualifiedName: "aws.SesIdentityNotificationTopic", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.SesIdentityNotificationTopicConfig\"}}]")]
    public class SesIdentityNotificationTopic : HashiCorp.Cdktf.TerraformResource
    {
        public SesIdentityNotificationTopic(Constructs.Construct scope, string id, aws.ISesIdentityNotificationTopicConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SesIdentityNotificationTopic(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SesIdentityNotificationTopic(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetIncludeOriginalHeaders")]
        public virtual void ResetIncludeOriginalHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTopicArn")]
        public virtual void ResetTopicArn()
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

        [JsiiProperty(name: "identityInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notificationTypeInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotificationTypeInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeOriginalHeadersInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? IncludeOriginalHeadersInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "topicArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TopicArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "identity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Identity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "includeOriginalHeaders", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool IncludeOriginalHeaders
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "notificationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotificationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TopicArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
