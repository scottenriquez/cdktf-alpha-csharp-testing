using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AthenaDatabaseEncryptionConfiguration")]
    public class AthenaDatabaseEncryptionConfiguration : aws.IAthenaDatabaseEncryptionConfiguration
    {
        [JsiiProperty(name: "encryptionOption", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string EncryptionOption
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KmsKey
        {
            get;
            set;
        }
    }
}
