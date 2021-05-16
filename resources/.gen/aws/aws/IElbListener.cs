using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElbListener), fullyQualifiedName: "aws.ElbListener")]
    public interface IElbListener
    {
        [JsiiProperty(name: "instancePort", typeJson: "{\"primitive\":\"number\"}")]
        double InstancePort
        {
            get;
        }

        [JsiiProperty(name: "instanceProtocol", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceProtocol
        {
            get;
        }

        [JsiiProperty(name: "lbPort", typeJson: "{\"primitive\":\"number\"}")]
        double LbPort
        {
            get;
        }

        [JsiiProperty(name: "lbProtocol", typeJson: "{\"primitive\":\"string\"}")]
        string LbProtocol
        {
            get;
        }

        [JsiiProperty(name: "sslCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslCertificateId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElbListener), fullyQualifiedName: "aws.ElbListener")]
        internal sealed class _Proxy : DeputyBase, aws.IElbListener
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "instancePort", typeJson: "{\"primitive\":\"number\"}")]
            public double InstancePort
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "instanceProtocol", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceProtocol
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "lbPort", typeJson: "{\"primitive\":\"number\"}")]
            public double LbPort
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "lbProtocol", typeJson: "{\"primitive\":\"string\"}")]
            public string LbProtocol
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "sslCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslCertificateId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
