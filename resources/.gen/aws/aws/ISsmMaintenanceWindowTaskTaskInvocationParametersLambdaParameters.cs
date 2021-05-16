using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters), fullyQualifiedName: "aws.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters")]
    public interface ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters
    {
        [JsiiProperty(name: "clientContext", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientContext
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "payload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Payload
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "qualifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Qualifier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters), fullyQualifiedName: "aws.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters")]
        internal sealed class _Proxy : DeputyBase, aws.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "clientContext", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientContext
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "payload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Payload
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "qualifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Qualifier
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
