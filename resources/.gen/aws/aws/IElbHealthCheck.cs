using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElbHealthCheck), fullyQualifiedName: "aws.ElbHealthCheck")]
    public interface IElbHealthCheck
    {
        [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
        double HealthyThreshold
        {
            get;
        }

        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
        double Interval
        {
            get;
        }

        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
        string Target
        {
            get;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        double Timeout
        {
            get;
        }

        [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
        double UnhealthyThreshold
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IElbHealthCheck), fullyQualifiedName: "aws.ElbHealthCheck")]
        internal sealed class _Proxy : DeputyBase, aws.IElbHealthCheck
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
            public double HealthyThreshold
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
            public double Interval
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
            public string Target
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
            public double Timeout
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
            public double UnhealthyThreshold
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
