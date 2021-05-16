using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectEnvironment), fullyQualifiedName: "aws.CodebuildProjectEnvironment")]
    public interface ICodebuildProjectEnvironment
    {
        [JsiiProperty(name: "computeType", typeJson: "{\"primitive\":\"string\"}")]
        string ComputeType
        {
            get;
        }

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        string Image
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Certificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>environment_variable block.</summary>
        [JsiiProperty(name: "environmentVariable", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectEnvironmentEnvironmentVariable\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodebuildProjectEnvironmentEnvironmentVariable[]? EnvironmentVariable
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "imagePullCredentialsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImagePullCredentialsType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "privilegedMode", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? PrivilegedMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>registry_credential block.</summary>
        [JsiiProperty(name: "registryCredential", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectEnvironmentRegistryCredential\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICodebuildProjectEnvironmentRegistryCredential[]? RegistryCredential
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectEnvironment), fullyQualifiedName: "aws.CodebuildProjectEnvironment")]
        internal sealed class _Proxy : DeputyBase, aws.ICodebuildProjectEnvironment
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "computeType", typeJson: "{\"primitive\":\"string\"}")]
            public string ComputeType
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
            public string Image
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Certificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>environment_variable block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "environmentVariable", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectEnvironmentEnvironmentVariable\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodebuildProjectEnvironmentEnvironmentVariable[]? EnvironmentVariable
            {
                get => GetInstanceProperty<aws.ICodebuildProjectEnvironmentEnvironmentVariable[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "imagePullCredentialsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImagePullCredentialsType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "privilegedMode", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? PrivilegedMode
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>registry_credential block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "registryCredential", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CodebuildProjectEnvironmentRegistryCredential\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICodebuildProjectEnvironmentRegistryCredential[]? RegistryCredential
            {
                get => GetInstanceProperty<aws.ICodebuildProjectEnvironmentRegistryCredential[]?>();
            }
        }
    }
}
