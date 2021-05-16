using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AppmeshVirtualNodeSpecLogging")]
    public class AppmeshVirtualNodeSpecLogging : aws.IAppmeshVirtualNodeSpecLogging
    {
        /// <summary>access_log block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessLog", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AppmeshVirtualNodeSpecLoggingAccessLog\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.IAppmeshVirtualNodeSpecLoggingAccessLog[]? AccessLog
        {
            get;
            set;
        }
    }
}
