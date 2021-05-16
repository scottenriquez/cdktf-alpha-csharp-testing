using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAwsProviderConfig), fullyQualifiedName: "aws.AwsProviderConfig")]
    public interface IAwsProviderConfig
    {
        /// <summary>The region where AWS operations will take place.</summary>
        /// <remarks>
        /// Examples
        /// are us-east-1, us-west-2, etc.
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        /// <summary>The access key for API operations.</summary>
        /// <remarks>
        /// You can retrieve this
        /// from the 'Security &amp; Credentials' section of the AWS console.
        /// </remarks>
        [JsiiProperty(name: "accessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Alias name.</summary>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "allowedAccountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedAccountIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>assume_role block.</summary>
        [JsiiProperty(name: "assumeRole", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AwsProviderAssumeRole\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAwsProviderAssumeRole[]? AssumeRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>endpoints block.</summary>
        [JsiiProperty(name: "endpoints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AwsProviderEndpoints\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAwsProviderEndpoints[]? Endpoints
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "forbiddenAccountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ForbiddenAccountIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>ignore_tags block.</summary>
        [JsiiProperty(name: "ignoreTags", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AwsProviderIgnoreTags\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAwsProviderIgnoreTags[]? IgnoreTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Explicitly allow the provider to perform "insecure" SSL requests.</summary>
        /// <remarks>
        /// If omitted,default value is <c>false</c>
        /// </remarks>
        [JsiiProperty(name: "insecure", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Insecure
        {
            get
            {
                return null;
            }
        }

        /// <summary>The maximum number of times an AWS API request is being executed.</summary>
        /// <remarks>
        /// If the API request still fails, an error is
        /// thrown.
        /// </remarks>
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxRetries
        {
            get
            {
                return null;
            }
        }

        /// <summary>The profile for API operations.</summary>
        /// <remarks>
        /// If not set, the default profile
        /// created with <c>aws configure</c> will be used.
        /// </remarks>
        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Profile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set this to true to force the request to use path-style addressing, i.e., http://s3.amazonaws.com/BUCKET/KEY. By default, the S3 client will use virtual hosted bucket addressing when possible (http://BUCKET.s3.amazonaws.com/KEY). Specific to the Amazon S3 service.</summary>
        [JsiiProperty(name: "s3ForcePathStyle", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? S3ForcePathStyle
        {
            get
            {
                return null;
            }
        }

        /// <summary>The secret key for API operations.</summary>
        /// <remarks>
        /// You can retrieve this
        /// from the 'Security &amp; Credentials' section of the AWS console.
        /// </remarks>
        [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>The path to the shared credentials file.</summary>
        /// <remarks>
        /// If not set
        /// this defaults to ~/.aws/credentials.
        /// </remarks>
        [JsiiProperty(name: "sharedCredentialsFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SharedCredentialsFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Skip the credentials validation via STS API.</summary>
        /// <remarks>
        /// Used for AWS API implementations that do not have STS available/implemented.
        /// </remarks>
        [JsiiProperty(name: "skipCredentialsValidation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? SkipCredentialsValidation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Skip getting the supported EC2 platforms.</summary>
        /// <remarks>
        /// Used by users that don't have ec2:DescribeAccountAttributes permissions.
        /// </remarks>
        [JsiiProperty(name: "skipGetEc2Platforms", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? SkipGetEc2Platforms
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "skipMetadataApiCheck", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? SkipMetadataApiCheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>Skip static validation of region name.</summary>
        /// <remarks>
        /// Used by users of alternative AWS-like APIs or users w/ access to regions that are not public (yet).
        /// </remarks>
        [JsiiProperty(name: "skipRegionValidation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? SkipRegionValidation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Skip requesting the account ID.</summary>
        /// <remarks>
        /// Used for AWS API implementations that do not have IAM/STS API and/or metadata API.
        /// </remarks>
        [JsiiProperty(name: "skipRequestingAccountId", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? SkipRequestingAccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>session token.</summary>
        /// <remarks>
        /// A session token is only required if you are
        /// using temporary security credentials.
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Token
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAwsProviderConfig), fullyQualifiedName: "aws.AwsProviderConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IAwsProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The region where AWS operations will take place.</summary>
            /// <remarks>
            /// Examples
            /// are us-east-1, us-west-2, etc.
            /// </remarks>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The access key for API operations.</summary>
            /// <remarks>
            /// You can retrieve this
            /// from the 'Security &amp; Credentials' section of the AWS console.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Alias name.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "allowedAccountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedAccountIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>assume_role block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "assumeRole", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AwsProviderAssumeRole\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAwsProviderAssumeRole[]? AssumeRole
            {
                get => GetInstanceProperty<aws.IAwsProviderAssumeRole[]?>();
            }

            /// <summary>endpoints block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endpoints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AwsProviderEndpoints\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAwsProviderEndpoints[]? Endpoints
            {
                get => GetInstanceProperty<aws.IAwsProviderEndpoints[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "forbiddenAccountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ForbiddenAccountIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>ignore_tags block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreTags", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AwsProviderIgnoreTags\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAwsProviderIgnoreTags[]? IgnoreTags
            {
                get => GetInstanceProperty<aws.IAwsProviderIgnoreTags[]?>();
            }

            /// <summary>Explicitly allow the provider to perform "insecure" SSL requests.</summary>
            /// <remarks>
            /// If omitted,default value is <c>false</c>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "insecure", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Insecure
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>The maximum number of times an AWS API request is being executed.</summary>
            /// <remarks>
            /// If the API request still fails, an error is
            /// thrown.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxRetries
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The profile for API operations.</summary>
            /// <remarks>
            /// If not set, the default profile
            /// created with <c>aws configure</c> will be used.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Profile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set this to true to force the request to use path-style addressing, i.e., http://s3.amazonaws.com/BUCKET/KEY. By default, the S3 client will use virtual hosted bucket addressing when possible (http://BUCKET.s3.amazonaws.com/KEY). Specific to the Amazon S3 service.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3ForcePathStyle", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? S3ForcePathStyle
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>The secret key for API operations.</summary>
            /// <remarks>
            /// You can retrieve this
            /// from the 'Security &amp; Credentials' section of the AWS console.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The path to the shared credentials file.</summary>
            /// <remarks>
            /// If not set
            /// this defaults to ~/.aws/credentials.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sharedCredentialsFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SharedCredentialsFile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Skip the credentials validation via STS API.</summary>
            /// <remarks>
            /// Used for AWS API implementations that do not have STS available/implemented.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipCredentialsValidation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? SkipCredentialsValidation
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>Skip getting the supported EC2 platforms.</summary>
            /// <remarks>
            /// Used by users that don't have ec2:DescribeAccountAttributes permissions.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipGetEc2Platforms", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? SkipGetEc2Platforms
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "skipMetadataApiCheck", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? SkipMetadataApiCheck
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>Skip static validation of region name.</summary>
            /// <remarks>
            /// Used by users of alternative AWS-like APIs or users w/ access to regions that are not public (yet).
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipRegionValidation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? SkipRegionValidation
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>Skip requesting the account ID.</summary>
            /// <remarks>
            /// Used for AWS API implementations that do not have IAM/STS API and/or metadata API.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skipRequestingAccountId", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? SkipRequestingAccountId
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>session token.</summary>
            /// <remarks>
            /// A session token is only required if you are
            /// using temporary security credentials.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Token
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
