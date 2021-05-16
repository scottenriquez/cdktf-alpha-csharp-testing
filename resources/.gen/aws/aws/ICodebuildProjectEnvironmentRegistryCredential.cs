using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectEnvironmentRegistryCredential), fullyQualifiedName: "aws.CodebuildProjectEnvironmentRegistryCredential")]
    public interface ICodebuildProjectEnvironmentRegistryCredential
    {
        [JsiiProperty(name: "credential", typeJson: "{\"primitive\":\"string\"}")]
        string Credential
        {
            get;
        }

        [JsiiProperty(name: "credentialProvider", typeJson: "{\"primitive\":\"string\"}")]
        string CredentialProvider
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectEnvironmentRegistryCredential), fullyQualifiedName: "aws.CodebuildProjectEnvironmentRegistryCredential")]
        internal sealed class _Proxy : DeputyBase, aws.ICodebuildProjectEnvironmentRegistryCredential
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "credential", typeJson: "{\"primitive\":\"string\"}")]
            public string Credential
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "credentialProvider", typeJson: "{\"primitive\":\"string\"}")]
            public string CredentialProvider
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
