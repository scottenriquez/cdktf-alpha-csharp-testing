using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.GlueJobCommand")]
    public class GlueJobCommand : aws.IGlueJobCommand
    {
        [JsiiProperty(name: "scriptLocation", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ScriptLocation
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Name
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "pythonVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PythonVersion
        {
            get;
            set;
        }
    }
}
