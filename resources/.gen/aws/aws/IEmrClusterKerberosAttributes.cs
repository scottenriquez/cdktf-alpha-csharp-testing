using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEmrClusterKerberosAttributes), fullyQualifiedName: "aws.EmrClusterKerberosAttributes")]
    public interface IEmrClusterKerberosAttributes
    {
        [JsiiProperty(name: "kdcAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        string KdcAdminPassword
        {
            get;
        }

        [JsiiProperty(name: "realm", typeJson: "{\"primitive\":\"string\"}")]
        string Realm
        {
            get;
        }

        [JsiiProperty(name: "adDomainJoinPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdDomainJoinPassword
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "adDomainJoinUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AdDomainJoinUser
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "crossRealmTrustPrincipalPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CrossRealmTrustPrincipalPassword
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterKerberosAttributes), fullyQualifiedName: "aws.EmrClusterKerberosAttributes")]
        internal sealed class _Proxy : DeputyBase, aws.IEmrClusterKerberosAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "kdcAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
            public string KdcAdminPassword
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "realm", typeJson: "{\"primitive\":\"string\"}")]
            public string Realm
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "adDomainJoinPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdDomainJoinPassword
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "adDomainJoinUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AdDomainJoinUser
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "crossRealmTrustPrincipalPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CrossRealmTrustPrincipalPassword
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
