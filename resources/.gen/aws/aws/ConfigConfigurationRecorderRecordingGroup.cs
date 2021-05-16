using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.ConfigConfigurationRecorderRecordingGroup")]
    public class ConfigConfigurationRecorderRecordingGroup : aws.IConfigConfigurationRecorderRecordingGroup
    {
        [JsiiOptional]
        [JsiiProperty(name: "allSupported", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? AllSupported
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeGlobalResourceTypes", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IncludeGlobalResourceTypes
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? ResourceTypes
        {
            get;
            set;
        }
    }
}
