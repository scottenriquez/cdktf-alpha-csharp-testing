using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IMskClusterConfigurationInfo), fullyQualifiedName: "aws.MskClusterConfigurationInfo")]
    public interface IMskClusterConfigurationInfo
    {
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}")]
        double Revision
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterConfigurationInfo), fullyQualifiedName: "aws.MskClusterConfigurationInfo")]
        internal sealed class _Proxy : DeputyBase, aws.IMskClusterConfigurationInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}")]
            public double Revision
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
