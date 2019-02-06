using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    /// <summary>
    /// Job Insight (Image Ad)
    /// </summary>
    public class JobInsightResponse 
    {
        /// <summary>
        /// Job Insight Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Internal name of the job insight.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Flag if the header is shown.
        /// </summary>
        public bool HasHeader { get; set; }

        /// <summary>
        /// Job Insight Header
        /// </summary>
        public JobInsightHeader Header { get; set; }

        /// <summary>
        /// Flag if the tasks are shown.
        /// </summary>
        public bool HasTasks { get; set; }

        /// <summary>
        /// Introduction for task section.
        /// </summary>
        public string TaskIntroduction { get; set; }

        /// <summary>
        /// Job Insight Tasks
        /// </summary>
        public IEnumerable<JobInsightTask> Tasks { get; set; }

        /// <summary>
        /// Flag if the benefits are shown.
        /// </summary>
        public bool HasBenefits { get; set; }

        /// <summary>
        /// Job Insight Benefits
        /// </summary>
        public IEnumerable<JobInsightBenefit> Benefits { get; set; }

        /// <summary>
        /// Flag if the testimonial is shown.
        /// </summary>
        public bool HasTestimonial { get; set; }
        
        /// <summary>
        /// Introduction for testimonial section.
        /// </summary>
        public string TestimonialIntroduction { get; set; }

        /// <summary>
        /// Job Insight Testimonials
        /// </summary>
        public IEnumerable<JobInsightTestimonial> Testimonials { get; set; }

        /// <summary>
        /// Flag if the video is shown.
        /// </summary>
        public bool HasVideo { get; set; }

        /// <summary>
        /// Introduction for video section.
        /// </summary>
        public string VideoIntroduction { get; set; }

        /// <summary>
        /// URL of the video for the video section.
        /// </summary>
        public string VideoUrl { get; set; }

        /// <summary>
        /// Flag if the process section is shown.
        /// </summary>
        public bool HasProcess { get; set; }

        /// <summary>
        /// Flag if the jobs section is shown.
        /// </summary>
        public bool HasJobs { get; set; }
    }
}
