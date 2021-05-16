using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISecretsmanagerSecretRotationRules), fullyQualifiedName: "aws.SecretsmanagerSecretRotationRules")]
    public interface ISecretsmanagerSecretRotationRules
    {
        [JsiiProperty(name: "automaticallyAfterDays", typeJson: "{\"primitive\":\"number\"}")]
        double AutomaticallyAfterDays
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISecretsmanagerSecretRotationRules), fullyQualifiedName: "aws.SecretsmanagerSecretRotationRules")]
        internal sealed class _Proxy : DeputyBase, aws.ISecretsmanagerSecretRotationRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "automaticallyAfterDays", typeJson: "{\"primitive\":\"number\"}")]
            public double AutomaticallyAfterDays
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
