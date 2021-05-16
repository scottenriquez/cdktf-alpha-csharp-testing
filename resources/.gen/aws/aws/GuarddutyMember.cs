using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiClass(nativeType: typeof(aws.GuarddutyMember), fullyQualifiedName: "aws.GuarddutyMember", parametersJson: "[{\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.GuarddutyMemberConfig\"}}]")]
    public class GuarddutyMember : HashiCorp.Cdktf.TerraformResource
    {
        public GuarddutyMember(Constructs.Construct scope, string id, aws.IGuarddutyMemberConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GuarddutyMember(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GuarddutyMember(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDisableEmailNotification")]
        public virtual void ResetDisableEmailNotification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInvitationMessage")]
        public virtual void ResetInvitationMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInvite")]
        public virtual void ResetInvite()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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

        [JsiiProperty(name: "detectorIdInput", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DetectorIdInput
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

        [JsiiProperty(name: "relationshipStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RelationshipStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableEmailNotificationInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? DisableEmailNotificationInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "invitationMessageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InvitationMessageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inviteInput", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public virtual bool? InviteInput
        {
            get => GetInstanceProperty<bool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.GuarddutyMemberTimeouts\"}", isOptional: true)]
        public virtual aws.IGuarddutyMemberTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.IGuarddutyMemberTimeouts?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "detectorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DetectorId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "disableEmailNotification", typeJson: "{\"primitive\":\"boolean\"}")]
        public virtual bool DisableEmailNotification
        {
            get => GetInstanceProperty<bool>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Email
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "invitationMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvitationMessage
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.GuarddutyMemberTimeouts\"}")]
        public virtual aws.IGuarddutyMemberTimeouts Timeouts
        {
            get => GetInstanceProperty<aws.IGuarddutyMemberTimeouts>()!;
            set => SetInstanceProperty(value);
        }
    }
}
