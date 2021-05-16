using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2StageConfig), fullyQualifiedName: "aws.Apigatewayv2StageConfig")]
    public interface IApigatewayv2StageConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        string ApiId
        {
            get;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>access_log_settings block.</summary>
        [JsiiProperty(name: "accessLogSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2StageAccessLogSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IApigatewayv2StageAccessLogSettings[]? AccessLogSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "autoDeploy", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AutoDeploy
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "clientCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientCertificateId
        {
            get
            {
                return null;
            }
        }

        /// <summary>default_route_settings block.</summary>
        [JsiiProperty(name: "defaultRouteSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2StageDefaultRouteSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IApigatewayv2StageDefaultRouteSettings[]? DefaultRouteSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeploymentId
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>route_settings block.</summary>
        [JsiiProperty(name: "routeSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2StageRouteSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IApigatewayv2StageRouteSettings[]? RouteSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "stageVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? StageVariables
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

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2StageConfig), fullyQualifiedName: "aws.Apigatewayv2StageConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IApigatewayv2StageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiId
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>access_log_settings block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessLogSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2StageAccessLogSettings\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IApigatewayv2StageAccessLogSettings[]? AccessLogSettings
            {
                get => GetInstanceProperty<aws.IApigatewayv2StageAccessLogSettings[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "autoDeploy", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AutoDeploy
            {
                get => GetInstanceProperty<bool?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "clientCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientCertificateId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>default_route_settings block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultRouteSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2StageDefaultRouteSettings\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IApigatewayv2StageDefaultRouteSettings[]? DefaultRouteSettings
            {
                get => GetInstanceProperty<aws.IApigatewayv2StageDefaultRouteSettings[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeploymentId
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>route_settings block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "routeSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.Apigatewayv2StageRouteSettings\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IApigatewayv2StageRouteSettings[]? RouteSettings
            {
                get => GetInstanceProperty<aws.IApigatewayv2StageRouteSettings[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "stageVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? StageVariables
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
