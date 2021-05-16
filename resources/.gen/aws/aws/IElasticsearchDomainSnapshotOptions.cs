using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElasticsearchDomainSnapshotOptions), fullyQualifiedName: "aws.ElasticsearchDomainSnapshotOptions")]
    public interface IElasticsearchDomainSnapshotOptions
    {
        [JsiiProperty(name: "automatedSnapshotStartHour", typeJson: "{\"primitive\":\"number\"}")]
        double AutomatedSnapshotStartHour
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticsearchDomainSnapshotOptions), fullyQualifiedName: "aws.ElasticsearchDomainSnapshotOptions")]
        internal sealed class _Proxy : DeputyBase, aws.IElasticsearchDomainSnapshotOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "automatedSnapshotStartHour", typeJson: "{\"primitive\":\"number\"}")]
            public double AutomatedSnapshotStartHour
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
