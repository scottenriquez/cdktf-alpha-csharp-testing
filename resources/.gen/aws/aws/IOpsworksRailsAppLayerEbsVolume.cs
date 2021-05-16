using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IOpsworksRailsAppLayerEbsVolume), fullyQualifiedName: "aws.OpsworksRailsAppLayerEbsVolume")]
    public interface IOpsworksRailsAppLayerEbsVolume
    {
        [JsiiProperty(name: "mountPoint", typeJson: "{\"primitive\":\"string\"}")]
        string MountPoint
        {
            get;
        }

        [JsiiProperty(name: "numberOfDisks", typeJson: "{\"primitive\":\"number\"}")]
        double NumberOfDisks
        {
            get;
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        [JsiiProperty(name: "encrypted", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Encrypted
        {
            get
            {
                return null;
            }
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

        [JsiiProperty(name: "raidLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RaidLevel
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsworksRailsAppLayerEbsVolume), fullyQualifiedName: "aws.OpsworksRailsAppLayerEbsVolume")]
        internal sealed class _Proxy : DeputyBase, aws.IOpsworksRailsAppLayerEbsVolume
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "mountPoint", typeJson: "{\"primitive\":\"string\"}")]
            public string MountPoint
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "numberOfDisks", typeJson: "{\"primitive\":\"number\"}")]
            public double NumberOfDisks
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "encrypted", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Encrypted
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Iops
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "raidLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RaidLevel
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
