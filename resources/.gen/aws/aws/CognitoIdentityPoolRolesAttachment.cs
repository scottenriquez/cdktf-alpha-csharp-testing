using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.CognitoIdentityPoolRolesAttachment), fullyQualifiedName: "aws.CognitoIdentityPoolRolesAttachment", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.CognitoIdentityPoolRolesAttachmentConfig\"}}]")]
    public class CognitoIdentityPoolRolesAttachment : HashiCorp.Cdktf.TerraformResource
    {
        public CognitoIdentityPoolRolesAttachment(Constructs.Construct scope, string id, aws.ICognitoIdentityPoolRolesAttachmentConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoIdentityPoolRolesAttachment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoIdentityPoolRolesAttachment(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetRoleMapping")]
        public virtual void ResetRoleMapping()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identityPoolIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityPoolIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rolesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> RolesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleMappingInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoIdentityPoolRolesAttachmentRoleMapping\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.ICognitoIdentityPoolRolesAttachmentRoleMapping[]? RoleMappingInput
        {
            get => GetInstanceProperty<aws.ICognitoIdentityPoolRolesAttachmentRoleMapping[]?>();
        }

        [JsiiProperty(name: "identityPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityPoolId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleMapping", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.CognitoIdentityPoolRolesAttachmentRoleMapping\"},\"kind\":\"array\"}}")]
        public virtual aws.ICognitoIdentityPoolRolesAttachmentRoleMapping[] RoleMapping
        {
            get => GetInstanceProperty<aws.ICognitoIdentityPoolRolesAttachmentRoleMapping[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Roles
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
