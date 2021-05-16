using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AcmCertificateConfig")]
    public class AcmCertificateConfig : aws.IAcmCertificateConfig
    {
        [JsiiOptional]
        [JsiiProperty(name: "certificateAuthorityArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CertificateAuthorityArn
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CertificateBody
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateChain", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CertificateChain
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DomainName
        {
            get;
            set;
        }

        /// <summary>options block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "options", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AcmCertificateOptions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAcmCertificateOptions[]? Options
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PrivateKey
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SubjectAlternativeNames
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "validationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ValidationMethod
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
