using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.CodebuildProjectEnvironment")]
    public class CodebuildProjectEnvironment : aws.ICodebuildProjectEnvironment
    {
        [JsiiProperty(name: "computeType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ComputeType
        {
            get;
            set;
        }

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Image
        {
            get;
            set;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Certificate
        {
            get;
            set;
        }

        /// <summary>environment_variable block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "environmentVariable", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectEnvironmentEnvironmentVariable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodebuildProjectEnvironmentEnvironmentVariable[]? EnvironmentVariable
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "imagePullCredentialsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ImagePullCredentialsType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "privilegedMode", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? PrivilegedMode
        {
            get;
            set;
        }

        /// <summary>registry_credential block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "registryCredential", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectEnvironmentRegistryCredential\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICodebuildProjectEnvironmentRegistryCredential[]? RegistryCredential
        {
            get;
            set;
        }
    }
}
