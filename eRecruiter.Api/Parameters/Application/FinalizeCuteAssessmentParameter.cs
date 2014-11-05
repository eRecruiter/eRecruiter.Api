
namespace eRecruiter.Api.Parameters
{
    public class FinalizeCuteAssessmentParameter
    {
        public FinalizeCuteAssessmentParameter(int optionsId)
        {
            OptionsId = optionsId;
        }

        public int OptionsId { get; set; }
    }
}
