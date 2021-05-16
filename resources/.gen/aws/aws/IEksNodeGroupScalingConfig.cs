using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEksNodeGroupScalingConfig), fullyQualifiedName: "aws.EksNodeGroupScalingConfig")]
    public interface IEksNodeGroupScalingConfig
    {
        [JsiiProperty(name: "desiredSize", typeJson: "{\"primitive\":\"number\"}")]
        double DesiredSize
        {
            get;
        }

        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}")]
        double MaxSize
        {
            get;
        }

        [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}")]
        double MinSize
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEksNodeGroupScalingConfig), fullyQualifiedName: "aws.EksNodeGroupScalingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IEksNodeGroupScalingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "desiredSize", typeJson: "{\"primitive\":\"number\"}")]
            public double DesiredSize
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxSize
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "minSize", typeJson: "{\"primitive\":\"number\"}")]
            public double MinSize
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
