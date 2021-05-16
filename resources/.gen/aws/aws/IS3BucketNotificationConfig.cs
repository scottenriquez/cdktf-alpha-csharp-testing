using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketNotificationConfig), fullyQualifiedName: "aws.S3BucketNotificationConfig")]
    public interface IS3BucketNotificationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>lambda_function block.</summary>
        [JsiiProperty(name: "lambdaFunction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketNotificationLambdaFunction\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketNotificationLambdaFunction[]? LambdaFunction
        {
            get
            {
                return null;
            }
        }

        /// <summary>queue block.</summary>
        [JsiiProperty(name: "queue", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketNotificationQueue\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketNotificationQueue[]? Queue
        {
            get
            {
                return null;
            }
        }

        /// <summary>topic block.</summary>
        [JsiiProperty(name: "topic", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketNotificationTopic\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketNotificationTopic[]? Topic
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketNotificationConfig), fullyQualifiedName: "aws.S3BucketNotificationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketNotificationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>lambda_function block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaFunction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketNotificationLambdaFunction\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketNotificationLambdaFunction[]? LambdaFunction
            {
                get => GetInstanceProperty<aws.IS3BucketNotificationLambdaFunction[]?>();
            }

            /// <summary>queue block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queue", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketNotificationQueue\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketNotificationQueue[]? Queue
            {
                get => GetInstanceProperty<aws.IS3BucketNotificationQueue[]?>();
            }

            /// <summary>topic block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "topic", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketNotificationTopic\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketNotificationTopic[]? Topic
            {
                get => GetInstanceProperty<aws.IS3BucketNotificationTopic[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
