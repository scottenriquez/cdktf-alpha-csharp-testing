using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IStoragegatewayGatewayConfig), fullyQualifiedName: "aws.StoragegatewayGatewayConfig")]
    public interface IStoragegatewayGatewayConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        [JsiiProperty(name: "gatewayName", typeJson: "{\"primitive\":\"string\"}")]
        string GatewayName
        {
            get;
        }

        [JsiiProperty(name: "gatewayTimezone", typeJson: "{\"primitive\":\"string\"}")]
        string GatewayTimezone
        {
            get;
        }

        [JsiiProperty(name: "activationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActivationKey
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "cloudwatchLogGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudwatchLogGroupArn
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "gatewayIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GatewayIpAddress
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "gatewayType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GatewayType
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "gatewayVpcEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GatewayVpcEndpoint
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "mediumChangerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MediumChangerType
        {
            get
            {
                return null;
            }
        }

        /// <summary>smb_active_directory_settings block.</summary>
        [JsiiProperty(name: "smbActiveDirectorySettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.StoragegatewayGatewaySmbActiveDirectorySettings\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IStoragegatewayGatewaySmbActiveDirectorySettings[]? SmbActiveDirectorySettings
        {
            get
            {
                return null;
            }
        }

        [JsiiProperty(name: "smbGuestPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SmbGuestPassword
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

        [JsiiProperty(name: "tapeDriveType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TapeDriveType
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.StoragegatewayGatewayTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IStoragegatewayGatewayTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStoragegatewayGatewayConfig), fullyQualifiedName: "aws.StoragegatewayGatewayConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IStoragegatewayGatewayConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            [JsiiProperty(name: "gatewayName", typeJson: "{\"primitive\":\"string\"}")]
            public string GatewayName
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiProperty(name: "gatewayTimezone", typeJson: "{\"primitive\":\"string\"}")]
            public string GatewayTimezone
            {
                get => GetInstanceProperty<string>()!;
            }

            [JsiiOptional]
            [JsiiProperty(name: "activationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActivationKey
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudwatchLogGroupArn
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "gatewayIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GatewayIpAddress
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "gatewayType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GatewayType
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "gatewayVpcEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GatewayVpcEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "mediumChangerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MediumChangerType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>smb_active_directory_settings block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "smbActiveDirectorySettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.StoragegatewayGatewaySmbActiveDirectorySettings\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.IStoragegatewayGatewaySmbActiveDirectorySettings[]? SmbActiveDirectorySettings
            {
                get => GetInstanceProperty<aws.IStoragegatewayGatewaySmbActiveDirectorySettings[]?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "smbGuestPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SmbGuestPassword
            {
                get => GetInstanceProperty<string?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            [JsiiOptional]
            [JsiiProperty(name: "tapeDriveType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TapeDriveType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.StoragegatewayGatewayTimeouts\"}", isOptional: true)]
            public aws.IStoragegatewayGatewayTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.IStoragegatewayGatewayTimeouts?>();
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
