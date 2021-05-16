using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AwsProviderConfig")]
    public class AwsProviderConfig : aws.IAwsProviderConfig
    {
        /// <summary>The region where AWS operations will take place.</summary>
        /// <remarks>
        /// Examples
        /// are us-east-1, us-west-2, etc.
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Region
        {
            get;
            set;
        }

        /// <summary>The access key for API operations.</summary>
        /// <remarks>
        /// You can retrieve this
        /// from the 'Security &amp; Credentials' section of the AWS console.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AccessKey
        {
            get;
            set;
        }

        /// <summary>Alias name.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Alias
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedAccountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? AllowedAccountIds
        {
            get;
            set;
        }

        /// <summary>assume_role block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "assumeRole", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AwsProviderAssumeRole\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAwsProviderAssumeRole[]? AssumeRole
        {
            get;
            set;
        }

        /// <summary>endpoints block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpoints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AwsProviderEndpoints\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAwsProviderEndpoints[]? Endpoints
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "forbiddenAccountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? ForbiddenAccountIds
        {
            get;
            set;
        }

        /// <summary>ignore_tags block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ignoreTags", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AwsProviderIgnoreTags\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAwsProviderIgnoreTags[]? IgnoreTags
        {
            get;
            set;
        }

        /// <summary>Explicitly allow the provider to perform "insecure" SSL requests.</summary>
        /// <remarks>
        /// If omitted,default value is <c>false</c>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "insecure", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? Insecure
        {
            get;
            set;
        }

        /// <summary>The maximum number of times an AWS API request is being executed.</summary>
        /// <remarks>
        /// If the API request still fails, an error is
        /// thrown.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxRetries
        {
            get;
            set;
        }

        /// <summary>The profile for API operations.</summary>
        /// <remarks>
        /// If not set, the default profile
        /// created with <c>aws configure</c> will be used.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Profile
        {
            get;
            set;
        }

        /// <summary>Set this to true to force the request to use path-style addressing, i.e., http://s3.amazonaws.com/BUCKET/KEY. By default, the S3 client will use virtual hosted bucket addressing when possible (http://BUCKET.s3.amazonaws.com/KEY). Specific to the Amazon S3 service.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3ForcePathStyle", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? S3ForcePathStyle
        {
            get;
            set;
        }

        /// <summary>The secret key for API operations.</summary>
        /// <remarks>
        /// You can retrieve this
        /// from the 'Security &amp; Credentials' section of the AWS console.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SecretKey
        {
            get;
            set;
        }

        /// <summary>The path to the shared credentials file.</summary>
        /// <remarks>
        /// If not set
        /// this defaults to ~/.aws/credentials.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sharedCredentialsFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SharedCredentialsFile
        {
            get;
            set;
        }

        /// <summary>Skip the credentials validation via STS API.</summary>
        /// <remarks>
        /// Used for AWS API implementations that do not have STS available/implemented.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "skipCredentialsValidation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? SkipCredentialsValidation
        {
            get;
            set;
        }

        /// <summary>Skip getting the supported EC2 platforms.</summary>
        /// <remarks>
        /// Used by users that don't have ec2:DescribeAccountAttributes permissions.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "skipGetEc2Platforms", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? SkipGetEc2Platforms
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipMetadataApiCheck", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? SkipMetadataApiCheck
        {
            get;
            set;
        }

        /// <summary>Skip static validation of region name.</summary>
        /// <remarks>
        /// Used by users of alternative AWS-like APIs or users w/ access to regions that are not public (yet).
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "skipRegionValidation", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? SkipRegionValidation
        {
            get;
            set;
        }

        /// <summary>Skip requesting the account ID.</summary>
        /// <remarks>
        /// Used for AWS API implementations that do not have IAM/STS API and/or metadata API.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "skipRequestingAccountId", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? SkipRequestingAccountId
        {
            get;
            set;
        }

        /// <summary>session token.</summary>
        /// <remarks>
        /// A session token is only required if you are
        /// using temporary security credentials.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Token
        {
            get;
            set;
        }
    }
}
