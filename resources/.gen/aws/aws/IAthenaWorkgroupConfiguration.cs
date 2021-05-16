using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAthenaWorkgroupConfiguration), fullyQualifiedName: "aws.AthenaWorkgroupConfiguration")]
    public interface IAthenaWorkgroupConfiguration
    {
        [JsiiProperty(name: "bytesScannedCutoffPerQuery", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BytesScannedCutoffPerQuery
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "enforceWorkgroupConfiguration", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? EnforceWorkgroupConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "publishCloudwatchMetricsEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? PublishCloudwatchMetricsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>result_configuration block.</summary>
        [JsiiProperty(name: "resultConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AthenaWorkgroupConfigurationResultConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IAthenaWorkgroupConfigurationResultConfiguration[]? ResultConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAthenaWorkgroupConfiguration), fullyQualifiedName: "aws.AthenaWorkgroupConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IAthenaWorkgroupConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "bytesScannedCutoffPerQuery", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BytesScannedCutoffPerQuery
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "enforceWorkgroupConfiguration", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? EnforceWorkgroupConfiguration
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "publishCloudwatchMetricsEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? PublishCloudwatchMetricsEnabled
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>result_configuration block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resultConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.AthenaWorkgroupConfigurationResultConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IAthenaWorkgroupConfigurationResultConfiguration[]? ResultConfiguration
            {
                get => GetInstanceProperty<aws.IAthenaWorkgroupConfigurationResultConfiguration[]?>();
            }
        }
    }
}
