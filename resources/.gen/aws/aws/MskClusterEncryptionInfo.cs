using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.MskClusterEncryptionInfo")]
    public class MskClusterEncryptionInfo : aws.IMskClusterEncryptionInfo
    {
        [JsiiOptional]
        [JsiiProperty(name: "encryptionAtRestKmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EncryptionAtRestKmsKeyArn
        {
            get;
            set;
        }

        /// <summary>encryption_in_transit block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionInTransit", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.MskClusterEncryptionInfoEncryptionInTransit\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IMskClusterEncryptionInfoEncryptionInTransit[]? EncryptionInTransit
        {
            get;
            set;
        }
    }
}
