using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEfsAccessPointRootDirectoryCreationInfo), fullyQualifiedName: "aws.EfsAccessPointRootDirectoryCreationInfo")]
    public interface IEfsAccessPointRootDirectoryCreationInfo
    {
        [JsiiProperty(name: "ownerGid", typeJson: "{\"primitive\":\"number\"}")]
        double OwnerGid
        {
            get;
        }

        [JsiiProperty(name: "ownerUid", typeJson: "{\"primitive\":\"number\"}")]
        double OwnerUid
        {
            get;
        }

        [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}")]
        string Permissions
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEfsAccessPointRootDirectoryCreationInfo), fullyQualifiedName: "aws.EfsAccessPointRootDirectoryCreationInfo")]
        internal sealed class _Proxy : DeputyBase, aws.IEfsAccessPointRootDirectoryCreationInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "ownerGid", typeJson: "{\"primitive\":\"number\"}")]
            public double OwnerGid
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "ownerUid", typeJson: "{\"primitive\":\"number\"}")]
            public double OwnerUid
            {
                get => GetInstanceProperty<double>()!;
            }

            [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}")]
            public string Permissions
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
