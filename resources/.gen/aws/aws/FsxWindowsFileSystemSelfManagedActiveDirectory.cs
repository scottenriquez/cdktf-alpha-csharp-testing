using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.FsxWindowsFileSystemSelfManagedActiveDirectory")]
    public class FsxWindowsFileSystemSelfManagedActiveDirectory : aws.IFsxWindowsFileSystemSelfManagedActiveDirectory
    {
        [JsiiProperty(name: "dnsIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] DnsIps
        {
            get;
            set;
        }

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

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemAdministratorsGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FileSystemAdministratorsGroup
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "organizationalUnitDistinguishedName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OrganizationalUnitDistinguishedName
        {
            get;
            set;
        }
    }
}
