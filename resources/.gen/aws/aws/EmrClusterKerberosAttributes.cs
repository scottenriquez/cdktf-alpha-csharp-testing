using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EmrClusterKerberosAttributes")]
    public class EmrClusterKerberosAttributes : aws.IEmrClusterKerberosAttributes
    {
        [JsiiProperty(name: "kdcAdminPassword", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string KdcAdminPassword
        {
            get;
            set;
        }

        [JsiiProperty(name: "realm", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Realm
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adDomainJoinPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AdDomainJoinPassword
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adDomainJoinUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AdDomainJoinUser
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "crossRealmTrustPrincipalPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CrossRealmTrustPrincipalPassword
        {
            get;
            set;
        }
    }
}
