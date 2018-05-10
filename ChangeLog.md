# eRecruiter API ChangeLog

## 1.39.0
- Extended `ApplicantPolicyResponse` with language, version and portal information.
  - `Language` indicating the language the policy is for.
  - `Url` indicating the portal URL the policy is for.
  - `IsOutdated` indicating that the policy has a newer version.

## 1.38.0
- Added portal and culture parameters to support per portal policies
  - `portal` has been added to `PoliciesGetRequest`
  - `culture` has been added to `PoliciesGetRequest`

## 1.37.0
- Changed naming of property which handles the visibility of the policy to be more clear.
  - `AskForPrivacyPolicyAgreement` has been renamed to `AskForConsentPolicy`

## 1.36.0
- Changed naming of policy types to be more clear.
  - `PrivacyPolicy` has been renamed to `Consent`
  - `DataProcessingAgreement` has been renamed to `Information`

## 1.35.1
- Changed property on ApplicantVideoInterviewParameter
  - `ApplicationId` is now nullable

## 1.35.0
- New API call to create a video interview for an applicant

## 1.34.0
- New property which handles the visibility of the privacy policy agreement on the registration form.
	- `AskForPrivacyPolicyAgreement` 

## 1.33.0
- New API call to retrieve the latest policies
- New API call to request a specific policy
- New API call to request the policies for an applicant
- New API call to update a policy for an applicant

## 1.32.0
- New type for `HistoryType` to support privacy policies updates.
	- `PrivacyPolicy`

## 1.31.0
- New API call to request the video interviews for an applicant.
	- The new API call requires the `VideoInterview` permission for the API key.
	- The response contains information about the video interview as well as an expiring link (3 views until expiration).

## 1.30.0
- New portal settings to indicate if pagination should be enabled in the jobs list and how many items should be displayed
	`EnablePaginationInJobsList`  
	`PageSizeJobsList`

## 1.29.0
- New API call to validate a password against the applicant portal password policy.

## 1.28.0
- New fields for `ApplicantParameter` to support information about the privacy policy (EU-DSVGO)
	- `PolicyAcceptedAt` used to transfer/set the date for acceptance of the privacy policy.

## 1.27.1
- Add documentation to custom fields to avoid further misunderstandings.
	
## 1.27.0
- New fields for `PortalSettings` response to support "Login with XING"
	- `LoginWithXingConsumerKey` used for "Login with XING"
	- `LoginWithXingSignatureSalt` used for "Login with XING"

## 1.26.1
- New fields for `PortalSettings` response to "Apply with Indeed" status setting
	- `IndeedApplyAllowed` used to enable/disable "Apply with Indeed"

## 1.26.0
- New property for `Job` has been added for the job's status.
	- `Status` represents the status of the job (draft, open, engaged, repositioned or cancelled).

## 1.25.0
- New fields for `PortalSettings` response to allow transmission of "Apply by karriere.at" settings
	- `KarriereApiKey` used for validation of "Apply by karriere.at" requests
	- `KarriereApiSecret` used for validation of "Apply by karriere.at" requests
- New API call to generate applicant log-on tokens (applicant permission required)

##v1.24.0
- New fields for `MandatorResponse` to expose the configured publication cultures
	- `Cultures` used for exposing publication cultures

##v1.23.0
- New fields for `PortalSettings` response to allow transmission of myVeeta and Instapp settings
	- `InstappToken` used for "Apply with Instapp"
	- `MyVeetaToken` used for "Apply with myVeeta"

##v1.22.0
- New fields for `PortalSettings` response to allow transmission of Indeed API settings
	- `IndeedApiToken` used for XML feed delivery
	- `IndeedApiSecret` used for "Apply with Indeed" request validation

##v1.21.1
- New time range filter for applications by referrer request

##v1.21.0
- New API call to get applications by the referrer that created the application (referrer permission required)

##v1.20.0
- Refactored CV parsing request and response
	- Add optional portal-URI in request url, such that the backend is able to determine the set parsing strategy for this portal
	- Extend cv parsing response with more detailed profile data

##v1.19.0
- New fields for `JobPublication` response to allow job ad and registration/application URL overrides.
	- `JobAdUrl` allows to override the location of the job ad
	- `ApplyUrl` allows to override the location of the registration/application form

##v1.18.2
- Fix typo in CompanySynchronizeResponse of parameter `Identifiyer` and rename to `Identifier`

##v1.18.1
- Ensured `GlobalId` is represented as `long` in all endpoints 

##v1.18.0
- New property for applicant
  - `IsLocked` indicates if the applicant is currently locked (prevents communication)

##v1.17.0
- New endpoint for adding a history entry to an applicant
  - `Api/Applicant/History` can create a history entry for an applicant

##v1.16.0
- New property for job
  - `ExtendedJobProfiles` includes the job profiles with group and culture information

##v1.15.0
- New API calls to get applicants with the same `GlobalId` from all mandators (mandator-agnostic permission required)

##v1.14.0
- Changed ``ApplicantParameter`` to allow ``GlobalId`` to be a nullable long value for better support in external systems

##v1.13.0
- New `company` synchronization for XML content (requires company permission for the api key) for the following endpoint
  - `Api/Synchronize/Company` can receive the content of an company XML formated string and synchronizes the mandators companies

##v1.12.0
- Upgrade of .NET Framework dependency to 4.6.1
- Upgrade of all dependencies to newer versions

##v1.11.0
- New properties for mandator
  - `OccupationTypes` holds the possible values for occupation types

##v1.10.0
- New portal setting to indicate if the double-opt-in registration flow should be enabled
    - `EnableDoubleOptIn`
- New endpoint for the mailer to send double-opt-in e-mail requests to applicants
    - `Api/Mailer/DoubleOptIn` can send double-opt-in requests to applicants

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
