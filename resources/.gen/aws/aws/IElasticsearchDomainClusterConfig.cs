using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainClusterConfig), fullyQualifiedName: "aws.ElasticsearchDomainClusterConfig")]
    public interface IElasticsearchDomainClusterConfig
    {
        [JsiiProperty(name: "dedicatedMasterCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DedicatedMasterCount
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "dedicatedMasterEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? DedicatedMasterEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "dedicatedMasterType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DedicatedMasterType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InstanceCount
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "warmCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WarmCount
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "warmEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? WarmEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "warmType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WarmType
        {
            get
            {
                return null;
            }
        }

        /// <summary>zone_awareness_config block.</summary>
        [JsiiProperty(name: "zoneAwarenessConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainClusterConfigZoneAwarenessConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElasticsearchDomainClusterConfigZoneAwarenessConfig[]? ZoneAwarenessConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "zoneAwarenessEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ZoneAwarenessEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainClusterConfig), fullyQualifiedName: "aws.ElasticsearchDomainClusterConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IElasticsearchDomainClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "dedicatedMasterCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DedicatedMasterCount
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "dedicatedMasterEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? DedicatedMasterEnabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "dedicatedMasterType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DedicatedMasterType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "warmCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WarmCount
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "warmEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? WarmEnabled
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "warmType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WarmType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>zone_awareness_config block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "zoneAwarenessConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElasticsearchDomainClusterConfigZoneAwarenessConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElasticsearchDomainClusterConfigZoneAwarenessConfig[]? ZoneAwarenessConfig
            {
                get => GetInstanceProperty<aws.IElasticsearchDomainClusterConfigZoneAwarenessConfig[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "zoneAwarenessEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ZoneAwarenessEnabled
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
