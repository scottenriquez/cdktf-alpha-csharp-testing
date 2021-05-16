using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EfsAccessPointPosixUser")]
    public class EfsAccessPointPosixUser : aws.IEfsAccessPointPosixUser
    {
        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Gid
        {
            get;
            set;
        }

        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Uid
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondaryGids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public double[]? SecondaryGids
        {
            get;
            set;
        }
    }
}
