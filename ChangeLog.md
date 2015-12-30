# eRecruiter API ChangeLog


##v1.9.0
- New API endpoints for sending out-of-workflow e-mails (job and applicant permission required)
  - `Api/Mailer/Registration` can send registration confirmations / welcome e-mails to applicants
  - `Api/Mailer/Application` can send application confirmation e-mails to applicants

##v1.8.0
- New portal setting to indicate if the company picture should be visible on the applicant portal
	- `EnableCompanyPicturesOnJobsList`
- New properties for job
  - `CompanyPictureContent` Holds the content of the company picture
  - `CompanyPictureFileExtension` Holds the file extension of the company picture

##v1.7.0
- New properties for applicant
  - `GlobalId` Identifies the same applicant across different mandators
  - `ExternalId` Enables to set an optional Identifier for applicants, for example to reference from 3rd party applications.
- New API calls to get Applicants with same `GlobalId` from users mandator. 
- New API calls to get Applicants with same `ExternalId` from users mandator. 

##v1.6.1
- New portal setting to configure if the Flexdate selections should include the selection of the day.
  - `EnableExtendedDateSelection`

##v1.6.0
- New custom field type `Html` that supports public HTML custom fields

##v1.5.0
- New portal setting to configure the available language packs (EN/DE are enabled by default)
  - `LanguagePacks`

##v1.4.0
- New job publication type `MultiPostChannel` for multi-posting support in feeds and job ads.
- New job publication properties for multi-posting support in feeds and job ads:
  - `Account`
  - `Channel`
  - `Partner`
  - `PublicationDate`
  - `ExpirationDate`

##v1.3.0
- **Breaking** Change the type of some portal settings from `bool` to `DisplayType`:
 - `AskForTitles`
 - `AskForCitizenship`
- New portal settings to configure every field of the personal information page of the applicant in the Self-Service-Zone.
 - `AskForEmail`
 - `AskForPhoneNumber`
 - `AskForAddress`
 - `AskForCountry`
- New property `DefaultCitizenship` in the portal settings to set a default value for the applicant's citizenship property.
- New properties for each portal setting which applies to the registration form to handle the visibility of the fields on registration seperate to the Self-Service-Zone.
 - `AskForGenderOnRegistration`
 - `AskForTitlesOnRegistration`
 - `AskForEmailOnRegistration`
 - `AskForPhoneNumberOnRegistration`
 - `AskForBirthdateOnRegistration`
 - `AskForAddressOnRegistration`
 - `AskForCountryOnRegistration`
 - `AskForCitizenshipOnRegistration`
 - `AskForCvOnRegistration`
 - `AskForPhotoOnRegistration`
 - `AskForDocumentsOnRegistration`

##v1.2.3
- New property `EnableCvParsing` in portal settings, which specifies wether parsing of a Cv is possible on the Login, Register or job page.

##v1.2.2
- New property `GroupedJobProfiles` for a mandator which contains a more detailed list of job profiles. A `JobProfileResponse` contains the name, group and culture of a job profile.

##v1.2.1
- The XML documentation files are now included in the NuGet packages.

##v1.2.0
- New properties `Longitude` and `Latitude` for jobs.
- New property `MaximumDistanceToJobLocation` for applicants.
- New endpoints for managing mandators, users and API keys.

## v1.1.3
- New property `EnableDeleteForApplicant` in portal settings, indicating whether or not it should be possible for applicants to delete themselves.

## v1.1.2
- New method `DELETE Applicant` to anonymize or completely delete an applicant.

## v1.1.1
- **Breaking**: Since CV and Photo request/responses only require the `Content` and `FileExtension` properties, but not `Name`, `Type` or `IsPublic` like other documents, the API now sends and expects only these two properties.
- New property `IsPublic` for documents to indicate if the document should be visible on the applicant portal.

## v1.1.0
- **Breaking**: When creating an applicant it's now necessary to explicitly set the `DateOfCreation` property of the applicant.
- **Breaking**: The property `Channel` when GETting published jobs has been replaced with `JobPublicationType` that contains the `Name` and the `Type` of the requested job publication.
- It's now possible to GET a mandator without specifying a `uri`.
- New property `CustomFields` for mandators.
- New property `ClassificationTypes` for mandators.
- New property `Classification` and `ClassificationReason` for applicants.
- New property `ImportantInfo` for applicants.
- New property `JobPublicationTypes` for mandators.
- The property `PublishedOn` for jobs now contains the `Name` and the `Type` for each job publication.

## v1.0.0
The very first stable version. It's good, but not perfect yet, so we need a changelog ;-)
