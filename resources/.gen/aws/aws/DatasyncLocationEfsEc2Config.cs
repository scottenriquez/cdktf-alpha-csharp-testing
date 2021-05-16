using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DatasyncLocationEfsEc2Config")]
    public class DatasyncLocationEfsEc2Config : aws.IDatasyncLocationEfsEc2Config
    {
        [JsiiProperty(name: "securityGroupArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] SecurityGroupArns
        {
            get;
            set;
        }

        [JsiiProperty(name: "subnetArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SubnetArn
        {
            get;
            set;
        }
    }
}
