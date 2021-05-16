using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ILaunchTemplateCpuOptions), fullyQualifiedName: "aws.LaunchTemplateCpuOptions")]
    public interface ILaunchTemplateCpuOptions
    {
        [JsiiProperty(name: "coreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CoreCount
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "threadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThreadsPerCore
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILaunchTemplateCpuOptions), fullyQualifiedName: "aws.LaunchTemplateCpuOptions")]
        internal sealed class _Proxy : DeputyBase, aws.ILaunchTemplateCpuOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "coreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CoreCount
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "threadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThreadsPerCore
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
