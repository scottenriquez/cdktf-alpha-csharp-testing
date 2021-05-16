using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.S3BucketNotification), fullyQualifiedName: "aws.S3BucketNotification", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.S3BucketNotificationConfig\"}}]")]
    public class S3BucketNotification : HashiCorp.Cdktf.TerraformResource
    {
        public S3BucketNotification(Constructs.Construct scope, string id, aws.IS3BucketNotificationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketNotification(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketNotification(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLambdaFunction")]
        public virtual void ResetLambdaFunction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueue")]
        public virtual void ResetQueue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTopic")]
        public virtual void ResetTopic()
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketNotificationLambdaFunction\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IS3BucketNotificationLambdaFunction[]? LambdaFunctionInput
        {
            get => GetInstanceProperty<aws.IS3BucketNotificationLambdaFunction[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queueInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketNotificationQueue\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IS3BucketNotificationQueue[]? QueueInput
        {
            get => GetInstanceProperty<aws.IS3BucketNotificationQueue[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "topicInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketNotificationTopic\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.IS3BucketNotificationTopic[]? TopicInput
        {
            get => GetInstanceProperty<aws.IS3BucketNotificationTopic[]?>();
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lambdaFunction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketNotificationLambdaFunction\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3BucketNotificationLambdaFunction[] LambdaFunction
        {
            get => GetInstanceProperty<aws.IS3BucketNotificationLambdaFunction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queue", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketNotificationQueue\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3BucketNotificationQueue[] Queue
        {
            get => GetInstanceProperty<aws.IS3BucketNotificationQueue[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "topic", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketNotificationTopic\"},\"kind\":\"array\"}}")]
        public virtual aws.IS3BucketNotificationTopic[] Topic
        {
            get => GetInstanceProperty<aws.IS3BucketNotificationTopic[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
