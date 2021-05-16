using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.SecurityhubMember), fullyQualifiedName: "aws.SecurityhubMember", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.SecurityhubMemberConfig\"}}]")]
    public class SecurityhubMember : HashiCorp.Cdktf.TerraformResource
    {
        public SecurityhubMember(Constructs.Construct scope, string id, aws.ISecurityhubMemberConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SecurityhubMember(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SecurityhubMember(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetInvite")]
        public virtual void ResetInvite()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountIdInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emailInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailInput
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "memberStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MemberStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "inviteInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? InviteInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Email
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "invite", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool Invite
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }
    }
}
