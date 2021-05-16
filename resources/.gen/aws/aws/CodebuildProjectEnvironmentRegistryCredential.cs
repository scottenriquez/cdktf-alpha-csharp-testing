using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CodebuildProjectEnvironmentRegistryCredential")]
    public class CodebuildProjectEnvironmentRegistryCredential : aws.ICodebuildProjectEnvironmentRegistryCredential
    {
        [JsiiProperty(name: "credential", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Credential
        {
            get;
            set;
        }

        [JsiiProperty(name: "credentialProvider", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string CredentialProvider
        {
            get;
            set;
        }
    }
}
