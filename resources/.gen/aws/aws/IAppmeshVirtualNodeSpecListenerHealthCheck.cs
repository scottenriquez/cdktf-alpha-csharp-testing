using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListenerHealthCheck), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecListenerHealthCheck")]
    public interface IAppmeshVirtualNodeSpecListenerHealthCheck
    {
        [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
        double HealthyThreshold
        {
            get;
        }

        [JsiiProperty(name: "intervalMillis", typeJson: "{\"primitive\":\"number\"}")]
        double IntervalMillis
        {
            get;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        [JsiiProperty(name: "timeoutMillis", typeJson: "{\"primitive\":\"number\"}")]
        double TimeoutMillis
        {
            get;
        }

        [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
        double UnhealthyThreshold
        {
            get;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListenerHealthCheck), fullyQualifiedName: "aws.AppmeshVirtualNodeSpecListenerHealthCheck")]
        internal sealed class _Proxy : DeputyBase, aws.IAppmeshVirtualNodeSpecListenerHealthCheck
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
            public double HealthyThreshold
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "intervalMillis", typeJson: "{\"primitive\":\"number\"}")]
            public double IntervalMillis
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "timeoutMillis", typeJson: "{\"primitive\":\"number\"}")]
            public double TimeoutMillis
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
            public double UnhealthyThreshold
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
