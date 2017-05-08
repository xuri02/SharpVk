﻿using SharpVk.Generator.Collation;

using static SharpVk.Emit.ExpressionBuilder;

namespace SharpVk.Generator.Generation.Marshalling
{
    public class VersionMemberPattern
        : IMemberPatternRule
    {
        private readonly NameLookup nameLookup;

        public VersionMemberPattern(NameLookup nameLookup)
        {
            this.nameLookup = nameLookup;
        }

        public bool Apply(TypeDeclaration type, MemberDeclaration member, MemberPatternInfo info)
        {
            if (member.Name.EndsWith("Version") && member.Type.VkName.StartsWith("uint32"))
            {
                info.PublicStruct.Properties.Add(new MemberDefinition
                {
                    Name = member.Name,
                    Type = "Version"
                });

                info.MarshalFrom.MemberActions.Add(new Action
                {
                    ValueExpression = Cast("Version", DerefMember(Variable("pointer"), member.Name)),
                    TargetExpression = Member(Variable("result"), member.Name),
                });

                info.InteropStruct.Fields.Add(new MemberDefinition
                {
                    Name = member.Name,
                    Type = this.nameLookup.Lookup(member.Type, true)
                });

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}