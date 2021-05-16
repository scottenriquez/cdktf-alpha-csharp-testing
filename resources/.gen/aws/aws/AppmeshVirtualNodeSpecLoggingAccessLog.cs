using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AppmeshVirtualNodeSpecLoggingAccessLog")]
    public class AppmeshVirtualNodeSpecLoggingAccessLog : aws.IAppmeshVirtualNodeSpecLoggingAccessLog
    {
        /// <summary>file block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "file", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecLoggingAccessLogFile\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppmeshVirtualNodeSpecLoggingAccessLogFile[]? File
        {
            get;
            set;
        }
    }
}
