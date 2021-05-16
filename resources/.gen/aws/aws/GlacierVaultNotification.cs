using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.GlacierVaultNotification")]
    public class GlacierVaultNotification : aws.IGlacierVaultNotification
    {
        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Events
        {
            get;
            set;
        }

        [JsiiProperty(name: "snsTopic", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SnsTopic
        {
            get;
            set;
        }
    }
}
