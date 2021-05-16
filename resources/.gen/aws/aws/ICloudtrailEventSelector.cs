using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudtrailEventSelector), fullyQualifiedName: "aws.CloudtrailEventSelector")]
    public interface ICloudtrailEventSelector
    {
        /// <summary>data_resource block.</summary>
        [JsiiProperty(name: "dataResource", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudtrailEventSelectorDataResource\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ICloudtrailEventSelectorDataResource[]? DataResource
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "includeManagementEvents", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? IncludeManagementEvents
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "readWriteType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReadWriteType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudtrailEventSelector), fullyQualifiedName: "aws.CloudtrailEventSelector")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudtrailEventSelector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>data_resource block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataResource", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CloudtrailEventSelectorDataResource\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ICloudtrailEventSelectorDataResource[]? DataResource
            {
                get => GetInstanceProperty<aws.ICloudtrailEventSelectorDataResource[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "includeManagementEvents", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? IncludeManagementEvents
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "readWriteType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReadWriteType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
