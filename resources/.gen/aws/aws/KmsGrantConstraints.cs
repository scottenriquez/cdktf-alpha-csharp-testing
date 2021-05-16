using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.KmsGrantConstraints")]
    public class KmsGrantConstraints : aws.IKmsGrantConstraints
    {
        [JsiiOptional]
        [JsiiProperty(name: "encryptionContextEquals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? EncryptionContextEquals
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionContextSubset", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true, isOverride: true)]
        public System.Collections.Generic.IDictionary<string, string>? EncryptionContextSubset
        {
            get;
            set;
        }
    }
}
