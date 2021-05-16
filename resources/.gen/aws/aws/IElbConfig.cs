using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IElbConfig), fullyQualifiedName: "aws.ElbConfig")]
    public interface IElbConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>listener block.</summary>
        [JsiiProperty(name: "listener", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElbListener\"},\"kind\":\"array\"}}")]
        aws.IElbListener[] Listener
        {
            get;
        }

        /// <summary>access_logs block.</summary>
        [JsiiProperty(name: "accessLogs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElbAccessLogs\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElbAccessLogs[]? AccessLogs
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AvailabilityZones
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "connectionDraining", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ConnectionDraining
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "connectionDrainingTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConnectionDrainingTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "crossZoneLoadBalancing", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? CrossZoneLoadBalancing
        {
            get
            {
                return null;
            }
        }

        /// <summary>health_check block.</summary>
        [JsiiProperty(name: "healthCheck", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElbHealthCheck\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IElbHealthCheck[]? HealthCheck
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "idleTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IdleTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "instances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Instances
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "internal", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Internal
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

        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamePrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecurityGroups
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "sourceSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceSecurityGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Subnets
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElbConfig), fullyQualifiedName: "aws.ElbConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IElbConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>listener block.</summary>
            [JsiiProperty(name: "listener", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElbListener\"},\"kind\":\"array\"}}")]
            public aws.IElbListener[] Listener
            {
                get => GetInstanceProperty<aws.IElbListener[]>()!;
            }

            /// <summary>access_logs block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessLogs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElbAccessLogs\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElbAccessLogs[]? AccessLogs
            {
                get => GetInstanceProperty<aws.IElbAccessLogs[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AvailabilityZones
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "connectionDraining", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ConnectionDraining
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "connectionDrainingTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConnectionDrainingTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "crossZoneLoadBalancing", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? CrossZoneLoadBalancing
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>health_check block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheck", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ElbHealthCheck\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IElbHealthCheck[]? HealthCheck
            {
                get => GetInstanceProperty<aws.IElbHealthCheck[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "idleTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IdleTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "instances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Instances
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "internal", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Internal
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "sourceSecurityGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceSecurityGroup
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Subnets
            {
                get => GetInstanceProperty<string[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
