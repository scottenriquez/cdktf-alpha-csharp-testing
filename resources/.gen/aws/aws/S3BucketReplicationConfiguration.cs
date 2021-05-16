using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.S3BucketReplicationConfiguration")]
    public class S3BucketReplicationConfiguration : aws.IS3BucketReplicationConfiguration
    {
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Role
        {
            get;
            set;
        }

        /// <summary>rules block.</summary>
        [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.S3BucketReplicationConfigurationRules\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IS3BucketReplicationConfigurationRules[] Rules
        {
            get;
            set;
        }
    }
}
