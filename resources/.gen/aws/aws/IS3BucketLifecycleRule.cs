using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IS3BucketLifecycleRule), fullyQualifiedName: "aws.S3BucketLifecycleRule")]
    public interface IS3BucketLifecycleRule
    {
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
        bool Enabled
        {
            get;
        }

        [JsiiProperty(name: "abortIncompleteMultipartUploadDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AbortIncompleteMultipartUploadDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>expiration block.</summary>
        [JsiiProperty(name: "expiration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLifecycleRuleExpiration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketLifecycleRuleExpiration[]? Expiration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>noncurrent_version_expiration block.</summary>
        [JsiiProperty(name: "noncurrentVersionExpiration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLifecycleRuleNoncurrentVersionExpiration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketLifecycleRuleNoncurrentVersionExpiration[]? NoncurrentVersionExpiration
        {
            get
            {
                return null;
            }
        }

        /// <summary>noncurrent_version_transition block.</summary>
        [JsiiProperty(name: "noncurrentVersionTransition", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLifecycleRuleNoncurrentVersionTransition\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketLifecycleRuleNoncurrentVersionTransition[]? NoncurrentVersionTransition
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>transition block.</summary>
        [JsiiProperty(name: "transition", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLifecycleRuleTransition\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IS3BucketLifecycleRuleTransition[]? Transition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketLifecycleRule), fullyQualifiedName: "aws.S3BucketLifecycleRule")]
        internal sealed class _Proxy : DeputyBase, aws.IS3BucketLifecycleRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"boolean\"}")]
            public bool Enabled
            {
                get => GetInstanceProperty<bool>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "abortIncompleteMultipartUploadDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AbortIncompleteMultipartUploadDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>expiration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expiration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLifecycleRuleExpiration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketLifecycleRuleExpiration[]? Expiration
            {
                get => GetInstanceProperty<aws.IS3BucketLifecycleRuleExpiration[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>noncurrent_version_expiration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "noncurrentVersionExpiration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLifecycleRuleNoncurrentVersionExpiration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketLifecycleRuleNoncurrentVersionExpiration[]? NoncurrentVersionExpiration
            {
                get => GetInstanceProperty<aws.IS3BucketLifecycleRuleNoncurrentVersionExpiration[]?>();
            }

            /// <summary>noncurrent_version_transition block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "noncurrentVersionTransition", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLifecycleRuleNoncurrentVersionTransition\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketLifecycleRuleNoncurrentVersionTransition[]? NoncurrentVersionTransition
            {
                get => GetInstanceProperty<aws.IS3BucketLifecycleRuleNoncurrentVersionTransition[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>transition block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transition", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketLifecycleRuleTransition\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IS3BucketLifecycleRuleTransition[]? Transition
            {
                get => GetInstanceProperty<aws.IS3BucketLifecycleRuleTransition[]?>();
            }
        }
    }
}
