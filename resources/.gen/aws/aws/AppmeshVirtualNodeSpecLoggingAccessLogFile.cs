using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.AppmeshVirtualNodeSpecLoggingAccessLogFile")]
    public class AppmeshVirtualNodeSpecLoggingAccessLogFile : aws.IAppmeshVirtualNodeSpecLoggingAccessLogFile
    {
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Path
        {
            get;
            set;
        }
    }
}
