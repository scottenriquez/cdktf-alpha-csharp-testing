using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.MqBrokerEncryptionOptions")]
    public class MqBrokerEncryptionOptions : aws.IMqBrokerEncryptionOptions
    {
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "useAwsOwnedKey", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? UseAwsOwnedKey
        {
            get;
            set;
        }
    }
}
