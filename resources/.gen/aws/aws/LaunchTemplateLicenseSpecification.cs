using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.LaunchTemplateLicenseSpecification")]
    public class LaunchTemplateLicenseSpecification : aws.ILaunchTemplateLicenseSpecification
    {
        [JsiiProperty(name: "licenseConfigurationArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LicenseConfigurationArn
        {
            get;
            set;
        }
    }
}
