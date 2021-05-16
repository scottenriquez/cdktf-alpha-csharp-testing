using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DataAwsGlueScriptDagNode")]
    public class DataAwsGlueScriptDagNode : aws.IDataAwsGlueScriptDagNode
    {
        /// <summary>args block.</summary>
        [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.DataAwsGlueScriptDagNodeArgs\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.IDataAwsGlueScriptDagNodeArgs[] Args
        {
            get;
            set;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Id
        {
            get;
            set;
        }

        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string NodeType
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "lineNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? LineNumber
        {
            get;
            set;
        }
    }
}
