using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.LambdaFunctionFileSystemConfig")]
    public class LambdaFunctionFileSystemConfig : aws.ILambdaFunctionFileSystemConfig
    {
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Arn
        {
            get;
            set;
        }

        [JsiiProperty(name: "localMountPath", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LocalMountPath
        {
            get;
            set;
        }
    }
}
