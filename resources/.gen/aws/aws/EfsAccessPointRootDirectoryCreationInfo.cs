using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EfsAccessPointRootDirectoryCreationInfo")]
    public class EfsAccessPointRootDirectoryCreationInfo : aws.IEfsAccessPointRootDirectoryCreationInfo
    {
        [JsiiProperty(name: "ownerGid", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double OwnerGid
        {
            get;
            set;
        }

        [JsiiProperty(name: "ownerUid", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double OwnerUid
        {
            get;
            set;
        }

        [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Permissions
        {
            get;
            set;
        }
    }
}
