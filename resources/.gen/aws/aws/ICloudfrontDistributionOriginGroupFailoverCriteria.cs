using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionOriginGroupFailoverCriteria), fullyQualifiedName: "aws.CloudfrontDistributionOriginGroupFailoverCriteria")]
    public interface ICloudfrontDistributionOriginGroupFailoverCriteria
    {
        [JsiiProperty(name: "statusCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        double[] StatusCodes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionOriginGroupFailoverCriteria), fullyQualifiedName: "aws.CloudfrontDistributionOriginGroupFailoverCriteria")]
        internal sealed class _Proxy : DeputyBase, aws.ICloudfrontDistributionOriginGroupFailoverCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "statusCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
            public double[] StatusCodes
            {
                get => GetInstanceProperty<double[]>()!;
            }
        }
    }
}
