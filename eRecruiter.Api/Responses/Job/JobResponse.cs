using System;
using System.Collections.Generic;

namespace eRecruiter.Api.Responses
{
    public class JobResponse
    {
        public int Id { get; set; }
        public string InternalName { get; set; }
        public string InternalLocation { get; set; }

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

        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? OnlineDate { get; set; }
        public DateTime OnlineDateCorrected { get; set; }

        public IEnumerable<string> JobProfiles { get; set; }
        public IEnumerable<string> Regions { get; set; }
        public IEnumerable<CustomFieldValueResponse> CustomFields { get; set; }
        public IEnumerable<string> OccupationTypes { get; set; }
        public IEnumerable<string> CareerLevels { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public IEnumerable<JobPublicationResponse> PublishedOn { get; set; }
        public IEnumerable<string> AvailableCultures { get; set; }

        /// <summary>
        /// Logo of the company the job is associated with
        /// </summary>
        public byte[] CompanyPictureContent { get; set; }
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
        public bool HasQuestionnaire { get; set; }
    }
}
