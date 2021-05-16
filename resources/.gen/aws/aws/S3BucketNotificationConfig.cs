using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketNotificationConfig")]
    public class S3BucketNotificationConfig : aws.IS3BucketNotificationConfig
    {
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>lambda_function block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketNotificationLambdaFunction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketNotificationLambdaFunction[]? LambdaFunction
        {
            get;
            set;
        }

        /// <summary>queue block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queue", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketNotificationQueue\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketNotificationQueue[]? Queue
        {
            get;
            set;
        }

        /// <summary>topic block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "topic", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketNotificationTopic\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IS3BucketNotificationTopic[]? Topic
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
