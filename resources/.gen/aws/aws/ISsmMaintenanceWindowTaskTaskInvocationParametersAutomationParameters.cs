using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters), fullyQualifiedName: "aws.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters")]
    public interface ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters
    {
        [JsiiProperty(name: "documentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DocumentVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>parameter block.</summary>
        [JsiiProperty(name: "parameter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersParameter\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersParameter[]? Parameter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters), fullyQualifiedName: "aws.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters")]
        internal sealed class _Proxy : DeputyBase, aws.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiOptional]
            [JsiiProperty(name: "documentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DocumentVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>parameter block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parameter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersParameter\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersParameter[]? Parameter
            {
                get => GetInstanceProperty<aws.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersParameter[]?>();
            }
        }
    }
}
