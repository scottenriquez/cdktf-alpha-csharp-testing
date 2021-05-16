using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateLicenseSpecification), fullyQualifiedName: "aws.LaunchTemplateLicenseSpecification")]
    public interface ILaunchTemplateLicenseSpecification
    {
        [JsiiProperty(name: "licenseConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
        string LicenseConfigurationArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateLicenseSpecification), fullyQualifiedName: "aws.LaunchTemplateLicenseSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.ILaunchTemplateLicenseSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "licenseConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LicenseConfigurationArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
