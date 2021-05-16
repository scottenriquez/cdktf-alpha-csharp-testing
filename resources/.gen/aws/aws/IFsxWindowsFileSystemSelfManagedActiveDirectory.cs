using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IFsxWindowsFileSystemSelfManagedActiveDirectory), fullyQualifiedName: "aws.FsxWindowsFileSystemSelfManagedActiveDirectory")]
    public interface IFsxWindowsFileSystemSelfManagedActiveDirectory
    {
        [JsiiProperty(name: "dnsIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DnsIps
        {
            get;
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        string DomainName
        {
            get;
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        [JsiiProperty(name: "fileSystemAdministratorsGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FileSystemAdministratorsGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "organizationalUnitDistinguishedName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrganizationalUnitDistinguishedName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxWindowsFileSystemSelfManagedActiveDirectory), fullyQualifiedName: "aws.FsxWindowsFileSystemSelfManagedActiveDirectory")]
        internal sealed class _Proxy : DeputyBase, aws.IFsxWindowsFileSystemSelfManagedActiveDirectory
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "dnsIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DnsIps
            {
                get => GetInstanceProperty<string[]>()!;
            }

            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "fileSystemAdministratorsGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FileSystemAdministratorsGroup
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "organizationalUnitDistinguishedName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrganizationalUnitDistinguishedName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
