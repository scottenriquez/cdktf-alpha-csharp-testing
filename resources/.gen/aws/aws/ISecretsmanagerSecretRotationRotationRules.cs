using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISecretsmanagerSecretRotationRotationRules), fullyQualifiedName: "aws.SecretsmanagerSecretRotationRotationRules")]
    public interface ISecretsmanagerSecretRotationRotationRules
    {
        [JsiiProperty(name: "automaticallyAfterDays", typeJson: "{\"primitive\":\"number\"}")]
        double AutomaticallyAfterDays
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISecretsmanagerSecretRotationRotationRules), fullyQualifiedName: "aws.SecretsmanagerSecretRotationRotationRules")]
        internal sealed class _Proxy : DeputyBase, aws.ISecretsmanagerSecretRotationRotationRules
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
