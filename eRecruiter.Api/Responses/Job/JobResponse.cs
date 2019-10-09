using eRecruiter.Api.Responses.Job;
using eRecruiter.Api.Responses.Job.Channels;
using System;
using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class JobResponse
    {
        /// <summary>
        /// The unique internal numeric job identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The mandator ID the job is located in.
        /// </summary>
        public int MandatorId { get; set; }

        public string InternalName { get; set; }
        public string InternalLocation { get; set; }

        /// <summary>
        /// Get the current status of the job.
        /// </summary>
        public JobStatus Status { get; set; }

        /// <summary>
        /// Gets the latitude coordinate value of the geography point of the job location in the earth coordinate system (SRID 4326).
        /// </summary>
        public double? Latitude { get; set; }
        /// <summary>
        /// Gets the longitude coordinate value of the geography point of the job location in the earth coordinate system (SRID 4326).
        /// </summary>
        public double? Longitude { get; set; }

        //information about the associated user
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserTitleBeforeName { get; set; }
        public string UserTitleAfterName { get; set; }
        public string UserFullName { get; set; }
        public Gender UserGender { get; set; }
        public string UserPhone { get; set; }
        public string UserEmail { get; set; }

        /// <summary>
        /// The date of creation of the job.
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// The date when the job was modified.
        /// </summary>
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// The date when the job was first published on any channel or portal.
        /// </summary>
        public DateTime? OnlineDate { get; set; }

        /// <summary>
        /// The publication date corrected by the "maximum publication duration setting".
        /// If the period from OnlineDate to the current date exceeds the value of the "maximum publication duration" 
        /// this date is modified with the amount of days specified in the "maximum publication duration", so it appears the job is more up to date.
        /// </summary>
        public DateTime OnlineDateCorrected { get; set; }

        public IEnumerable<string> JobProfiles { get; set; }

        /// <summary>
        /// Job profiles including group and culture information.
        /// </summary>
        public IEnumerable<JobProfileResponse> ExtendedJobProfiles { get; set; }
        public IEnumerable<string> Regions { get; set; }
        public IEnumerable<CustomFieldValueResponse> CustomFields { get; set; }
        public IEnumerable<string> OccupationTypes { get; set; }
        public IEnumerable<string> CareerLevels { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public IEnumerable<JobPublicationResponse> PublishedOn { get; set; }
        public IEnumerable<string> AvailableCultures { get; set; }
        public ChannelSettings Channels { get; set; }

        /// <summary>
        /// Content of the company logo the job is associated with
        /// </summary>
        public byte[] CompanyPictureContent { get; set; }
        /// <summary>
        /// File extension of the company logo the job is associated with
        /// </summary>
        public string CompanyPictureFileExtension { get; set; }

        //the job ad
        public string Culture { get; set; }
        public string Html { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Location { get; set; }
        public string CompanyDescription { get; set; }
        public string Block1 { get; set; }
        public string Block2 { get; set; }
        public string Block3 { get; set; }
        public string Block4 { get; set; }
        public string HeaderBlock1 { get; set; }
        public string HeaderBlock2 { get; set; }
        public string HeaderBlock3 { get; set; }
        public string HeaderBlock4 { get; set; }
        public string TemplateName { get; set; }
        public bool HasQuestionnaire { get; set; }
        public GoogleForJobsResponse GoogleForJobs { get; set; }

        #region Geocoding
        public GeoLocationResponse GeoLocation { get; set; }
        public string GeoLocationName { get; set; }
        #endregion Geocoding

        #region Social Media
        public SocialMediaResponse SocialMedia { get; set; }
        #endregion Social Media

        #region Customer

        /// <summary>
        /// ID of the customer the job is associated with.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Name of the customer the job is associated with.
        /// </summary>
        public string CustomerName { get; set; }

        #endregion

        #region UserLocation
        public string UserAddress{ get; set; }
        public string UserZipCode { get; set; }
        public string UserCity { get; set; }
        #endregion UserLocation

        #region Cammio
        public string CammioPitchHash { get; set; }
        #endregion Cammio

    }
}
