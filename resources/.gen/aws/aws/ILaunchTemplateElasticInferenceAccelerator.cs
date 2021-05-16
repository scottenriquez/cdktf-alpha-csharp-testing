using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateElasticInferenceAccelerator), fullyQualifiedName: "aws.LaunchTemplateElasticInferenceAccelerator")]
    public interface ILaunchTemplateElasticInferenceAccelerator
    {
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateElasticInferenceAccelerator), fullyQualifiedName: "aws.LaunchTemplateElasticInferenceAccelerator")]
        internal sealed class _Proxy : DeputyBase, aws.ILaunchTemplateElasticInferenceAccelerator
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
