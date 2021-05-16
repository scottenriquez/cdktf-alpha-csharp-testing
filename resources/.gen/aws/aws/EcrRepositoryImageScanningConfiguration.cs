using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.EcrRepositoryImageScanningConfiguration")]
    public class EcrRepositoryImageScanningConfiguration : aws.IEcrRepositoryImageScanningConfiguration
    {
        [JsiiProperty(name: "scanOnPush", typeJson: "{\"primitive\":\"boolean\"}", isOverride: true)]
        public bool ScanOnPush
        {
            get;
            set;
        }
    }
}
