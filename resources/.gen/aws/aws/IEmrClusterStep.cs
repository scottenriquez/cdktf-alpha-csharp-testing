using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IEmrClusterStep), fullyQualifiedName: "aws.EmrClusterStep")]
    public interface IEmrClusterStep
    {
        [JsiiProperty(name: "actionOnFailure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActionOnFailure
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "hadoopJarStep", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterStepHadoopJarStep\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IEmrClusterStepHadoopJarStep[]? HadoopJarStep
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterStep), fullyQualifiedName: "aws.EmrClusterStep")]
        internal sealed class _Proxy : DeputyBase, aws.IEmrClusterStep
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "actionOnFailure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActionOnFailure
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "hadoopJarStep", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.EmrClusterStepHadoopJarStep\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IEmrClusterStepHadoopJarStep[]? HadoopJarStep
            {
                get => GetInstanceProperty<aws.IEmrClusterStepHadoopJarStep[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
