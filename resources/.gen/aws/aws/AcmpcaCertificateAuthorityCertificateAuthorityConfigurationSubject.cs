using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject")]
    public class AcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject : aws.IAcmpcaCertificateAuthorityCertificateAuthorityConfigurationSubject
    {
        [JsiiOptional]
        [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CommonName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Country
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "distinguishedNameQualifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DistinguishedNameQualifier
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "generationQualifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? GenerationQualifier
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "givenName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? GivenName
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "initials", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Initials
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "locality", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Locality
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "organization", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Organization
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "organizationalUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OrganizationalUnit
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "pseudonym", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Pseudonym
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? State
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "surname", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Surname
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Title
        {
            get;
            set;
        }
    }
}
