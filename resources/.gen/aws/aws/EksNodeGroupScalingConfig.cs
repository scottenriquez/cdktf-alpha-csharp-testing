using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EksNodeGroupScalingConfig")]
    public class EksNodeGroupScalingConfig : aws.IEksNodeGroupScalingConfig
    {
        [JsiiProperty(name: "desiredSize", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double DesiredSize
        {
            get;
            set;
        }

        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MaxSize
        {
            get;
            set;
        }

        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MinSize
        {
            get;
            set;
        }
    }
}
