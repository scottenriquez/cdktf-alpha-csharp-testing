using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppmeshVirtualNodeSpecListenerPortMapping")]
    public class AppmeshVirtualNodeSpecListenerPortMapping : aws.IAppmeshVirtualNodeSpecListenerPortMapping
    {
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Port
        {
            get;
            set;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Protocol
        {
            get;
            set;
        }
    }
}
