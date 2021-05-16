using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EksClusterEncryptionConfig")]
    public class EksClusterEncryptionConfig : aws.IEksClusterEncryptionConfig
    {
        /// <summary>provider block.</summary>
        [JsiiProperty(name: "provider", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EksClusterEncryptionConfigProvider\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IEksClusterEncryptionConfigProvider[] Provider
        {
            get;
            set;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Resources
        {
            get;
            set;
        }
    }
}
