using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.MskClusterConfigurationInfo")]
    public class MskClusterConfigurationInfo : aws.IMskClusterConfigurationInfo
    {
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Arn
        {
            get;
            set;
        }

        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Revision
        {
            get;
            set;
        }
    }
}
