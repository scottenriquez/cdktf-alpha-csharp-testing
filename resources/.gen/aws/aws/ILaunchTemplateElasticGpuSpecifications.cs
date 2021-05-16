using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateElasticGpuSpecifications), fullyQualifiedName: "aws.LaunchTemplateElasticGpuSpecifications")]
    public interface ILaunchTemplateElasticGpuSpecifications
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateElasticGpuSpecifications), fullyQualifiedName: "aws.LaunchTemplateElasticGpuSpecifications")]
        internal sealed class _Proxy : DeputyBase, aws.ILaunchTemplateElasticGpuSpecifications
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
