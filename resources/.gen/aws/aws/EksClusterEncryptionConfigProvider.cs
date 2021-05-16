using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EksClusterEncryptionConfigProvider")]
    public class EksClusterEncryptionConfigProvider : aws.IEksClusterEncryptionConfigProvider
    {
        [JsiiProperty(name: "keyArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string KeyArn
        {
            get;
            set;
        }
    }
}
