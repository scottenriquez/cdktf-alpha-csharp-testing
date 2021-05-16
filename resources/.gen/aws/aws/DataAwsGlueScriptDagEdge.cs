using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DataAwsGlueScriptDagEdge")]
    public class DataAwsGlueScriptDagEdge : aws.IDataAwsGlueScriptDagEdge
    {
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Source
        {
            get;
            set;
        }

        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Target
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetParameter", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TargetParameter
        {
            get;
            set;
        }
    }
}
