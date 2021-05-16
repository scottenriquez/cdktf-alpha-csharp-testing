using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.QuicksightUserConfig")]
    public class QuicksightUserConfig : aws.IQuicksightUserConfig
    {
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Email
        {
            get;
            set;
        }

        [JsiiProperty(name: "identityType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string IdentityType
        {
            get;
            set;
        }

        [JsiiProperty(name: "userRole", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string UserRole
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AwsAccountId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IamArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Namespace
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sessionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SessionName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? UserName
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
