using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.SecretsmanagerSecretRotationRotationRules")]
    public class SecretsmanagerSecretRotationRotationRules : aws.ISecretsmanagerSecretRotationRotationRules
    {
        [JsiiProperty(name: "automaticallyAfterDays", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double AutomaticallyAfterDays
        {
            get;
            set;
        }
    }
}
