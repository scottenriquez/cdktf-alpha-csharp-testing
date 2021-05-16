using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IRedshiftClusterSnapshotCopy), fullyQualifiedName: "aws.RedshiftClusterSnapshotCopy")]
    public interface IRedshiftClusterSnapshotCopy
    {
        [JsiiProperty(name: "destinationRegion", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationRegion
        {
            get;
        }

        [JsiiProperty(name: "grantName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GrantName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "retentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetentionPeriod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedshiftClusterSnapshotCopy), fullyQualifiedName: "aws.RedshiftClusterSnapshotCopy")]
        internal sealed class _Proxy : DeputyBase, aws.IRedshiftClusterSnapshotCopy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "destinationRegion", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationRegion
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "grantName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GrantName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "retentionPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionPeriod
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
