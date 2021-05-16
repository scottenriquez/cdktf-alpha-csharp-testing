using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.StoragegatewayGatewaySmbActiveDirectorySettings")]
    public class StoragegatewayGatewaySmbActiveDirectorySettings : aws.IStoragegatewayGatewaySmbActiveDirectorySettings
    {
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DomainName
        {
            get;
            set;
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Password
        {
            get;
            set;
        }

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Username
        {
            get;
            set;
        }
    }
}
