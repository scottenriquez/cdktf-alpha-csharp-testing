using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IStoragegatewayNfsFileShareNfsFileShareDefaults), fullyQualifiedName: "aws.StoragegatewayNfsFileShareNfsFileShareDefaults")]
    public interface IStoragegatewayNfsFileShareNfsFileShareDefaults
    {
        [JsiiProperty(name: "directoryMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DirectoryMode
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "fileMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FileMode
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GroupId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OwnerId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStoragegatewayNfsFileShareNfsFileShareDefaults), fullyQualifiedName: "aws.StoragegatewayNfsFileShareNfsFileShareDefaults")]
        internal sealed class _Proxy : DeputyBase, aws.IStoragegatewayNfsFileShareNfsFileShareDefaults
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "directoryMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DirectoryMode
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "fileMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FileMode
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GroupId
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OwnerId
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
