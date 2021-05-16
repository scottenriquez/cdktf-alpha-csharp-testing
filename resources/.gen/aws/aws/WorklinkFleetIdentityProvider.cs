using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.WorklinkFleetIdentityProvider")]
    public class WorklinkFleetIdentityProvider : aws.IWorklinkFleetIdentityProvider
    {
        [JsiiProperty(name: "samlMetadata", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SamlMetadata
        {
            get;
            set;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }
    }
}
