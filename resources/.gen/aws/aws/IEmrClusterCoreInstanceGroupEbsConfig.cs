using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEmrClusterCoreInstanceGroupEbsConfig), fullyQualifiedName: "aws.EmrClusterCoreInstanceGroupEbsConfig")]
    public interface IEmrClusterCoreInstanceGroupEbsConfig
    {
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Iops
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "volumesPerInstance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VolumesPerInstance
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterCoreInstanceGroupEbsConfig), fullyQualifiedName: "aws.EmrClusterCoreInstanceGroupEbsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IEmrClusterCoreInstanceGroupEbsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Iops
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "volumesPerInstance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VolumesPerInstance
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
