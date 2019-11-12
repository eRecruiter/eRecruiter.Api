using System.Collections.Generic;

namespace eRecruiter.Api.Responses.Integrations
{
    public class ApplyWithSettingResponse
    {
        public ApplyWithSettingResponse()
        {
            Fields = new ApplyWithSettingFieldsResponse();
            Policies = new ApplyWithSettingPoliciesResponse();
        }

        public string Name { get; set; }
        public string ClientId { get; set; }
        public ApplyWithSettingFieldsResponse Fields { get; set; }
        public ApplyWithSettingPoliciesResponse Policies { get; set; }
        public ICollection<ApplyWithSettingCustomFieldResponse> CustomFields { get; set; }
    }

    public class ApplyWithSettingFieldsResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Salutation { get; set; }
        public string PhoneNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Cv { get; set; }
    }

    public class ApplyWithSettingPolicyResponse
    {
        public int Id { get; set; }
        public bool Required { get; set; }
        public string Content { get; set; }
    }

    public class ApplyWithSettingCustomFieldResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string DefaultValue { get; set; }
        public ICollection<string> Values { get; set; }
    }

    public class ApplyWithSettingPoliciesResponse
    {
        public ApplyWithSettingPolicyResponse Information { get; set; }
        public ApplyWithSettingPolicyResponse Consent { get; set; }
    }
}
