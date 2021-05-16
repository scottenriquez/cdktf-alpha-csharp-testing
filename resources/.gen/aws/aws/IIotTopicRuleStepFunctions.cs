using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IIotTopicRuleStepFunctions), fullyQualifiedName: "aws.IotTopicRuleStepFunctions")]
    public interface IIotTopicRuleStepFunctions
    {
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        [JsiiProperty(name: "stateMachineName", typeJson: "{\"primitive\":\"string\"}")]
        string StateMachineName
        {
            get;
        }

        [JsiiProperty(name: "executionNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExecutionNamePrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleStepFunctions), fullyQualifiedName: "aws.IotTopicRuleStepFunctions")]
        internal sealed class _Proxy : DeputyBase, aws.IIotTopicRuleStepFunctions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "stateMachineName", typeJson: "{\"primitive\":\"string\"}")]
            public string StateMachineName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "executionNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExecutionNamePrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
