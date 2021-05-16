using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.CloudtrailEventSelector")]
    public class CloudtrailEventSelector : aws.ICloudtrailEventSelector
    {
        /// <summary>data_resource block.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataResource", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudtrailEventSelectorDataResource\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.ICloudtrailEventSelectorDataResource[]? DataResource
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeManagementEvents", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true, isOverride: true)]
        public bool? IncludeManagementEvents
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "readWriteType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ReadWriteType
        {
            get;
            set;
        }
    }
}
