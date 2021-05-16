using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.StoragegatewayNfsFileShareNfsFileShareDefaults")]
    public class StoragegatewayNfsFileShareNfsFileShareDefaults : aws.IStoragegatewayNfsFileShareNfsFileShareDefaults
    {
        [JsiiOptional]
        [JsiiProperty(name: "directoryMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DirectoryMode
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FileMode
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? GroupId
        {
            get;
            set;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? OwnerId
        {
            get;
            set;
        }
    }
}
