using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(ISsmAssociationConfig), fullyQualifiedName: "aws.SsmAssociationConfig")]
    public interface ISsmAssociationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiProperty(name: "associationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AssociationName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "automationTargetParameterName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutomationTargetParameterName
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "complianceSeverity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComplianceSeverity
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "documentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DocumentVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "maxConcurrency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxConcurrency
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "maxErrors", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxErrors
        {
            get
            {
                return null;
            }
        }

        /// <summary>output_location block.</summary>
        [JsiiProperty(name: "outputLocation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmAssociationOutputLocation\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISsmAssociationOutputLocation[]? OutputLocation
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScheduleExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>targets block.</summary>
        [JsiiProperty(name: "targets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmAssociationTargets\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ISsmAssociationTargets[]? Targets
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmAssociationConfig), fullyQualifiedName: "aws.SsmAssociationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ISsmAssociationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "associationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AssociationName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "automationTargetParameterName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutomationTargetParameterName
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "complianceSeverity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComplianceSeverity
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "documentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DocumentVersion
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "maxConcurrency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxConcurrency
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "maxErrors", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxErrors
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>output_location block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputLocation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmAssociationOutputLocation\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISsmAssociationOutputLocation[]? OutputLocation
            {
                get => GetInstanceProperty<aws.ISsmAssociationOutputLocation[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Parameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScheduleExpression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>targets block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.SsmAssociationTargets\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.ISsmAssociationTargets[]? Targets
            {
                get => GetInstanceProperty<aws.ISsmAssociationTargets[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
