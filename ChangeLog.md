# eRecruiter API ChangeLog

## 1.80.10
- New properties in `PortalSettingsResponse` for GDPR information policy.

## 1.80.9
- New properties in `JobResponse` for company location of job.

## 1.80.8
- New properties `GeoLocationResponse` for job locations.

## 1.80.5
- Changed `GoogleForJobsResponse` EmploymentType to int?.

## 1.80.4
- New property `VideoRecruitingProvider` for mandators.

## 1.80.3
- Adjust request naming to fit convention

## 1.80.2
- Change request method of `SendApplicationMessage` to POST

## 1.80.1
- Add trailing slash to endpoint URL

## 1.80.0
- Add new endpoint to send a message to the recruiter on successful application creation

## 1.79.3
- Update Api.Client

## 1.79.2
- Fix parameter in `SendApplicationMailRequest` from `RegistrationMailParameter` to `ApplicationMailParameter`.

## 1.79.1
- Add `EnableTransactionalFlow` to `PortalSettingsResponse`.

## 1.79.0
- Add `Id` to `QuestionnaireItemResponse`.

## 1.78.1
- Add `IndeedApplyWidgetUrl` to JobResponse and added new api endpont for PublishedJobRequest

## 1.78.0
- Add `IndeedApplyWidgetEnabled` & `IndeedApplyWidgetUrl` to `MandatorResponse`.

## 1.77.1
- Add `HiringOrganizationLogo` to `GoogleForJobsResponse`.

## 1.77.0
- Add `HiringOrganization` to `GoogleForJobsResponse`.

## 1.76.0
- Add `EnableSitemap` to `PortalSettingsResponse`.

## 1.75.0
- Add `ExpirationDate` to `JobResponse`.

## 1.74.0
- Add `Url` to `ApplyWithSettingPolicyResponse`.

## 1.73.0
- Add `CoverLetter` to `ApplyWithSettingFieldsResponse`.

## 1.72.3
- Changed `Name` field of `ApplyWithSettingCustomFieldResponse` class to `InternalName`.

## 1.72.2
- Changed `Values` field of `ApplyWithSettingCustomFieldResponse` class to a Collection of strings.

## 1.72.1
- Changed `Required` field of `ApplyWithSettingPolicyResponse` class to boolean.

## 1.72.0
- Added new endpoint to fetch "Apply With eRecruiter" setting based on clientId.
- `ApplyWithSettingResponse` has been added to support this new endpoint.

## 1.71.0
- Added new endpoint to create a new applicant and application for the data from "Apply With eRecruiter".
- `ApplyWithResponse` has been added.
- `ApplyWithRequest` has been added.

## 1.70.0
- Removed cache invalidation logic as the logic moved to a push based approach.

## 1.69.0
- Removed cache invalidation requests in `ApiHttpClient` to avoid deadlocks

## 1.68.3
- Fix `ApplicantVideoInterviewPutRequest` to return `IEnumerable<ApplicantVideoInterviewResponse>`

## 1.68.2
- Change `AskForVideoPitchOnRegistration` to `DisplayType` on `PortalSettingsResponse`

## 1.68.1
- Add `AskForVideoPitchOnRegistration` to `PortalSettingsResponse`

## 1.68.0
- Add `CammioPitchHash` to `JobResponse`
- Add `CammioClientId` and `CammioSecret` to `MandatorResponse`

## 1.67.1
- Changed `GoogleForJobsResponse` MinSalary and MaxSalary to double nullable types.

## 1.67.0
- Changed `GoogleForJobsResponse` MinSalary and MaxSalary to nullable types.
- Added `Currency` to `GoogleForJobsResponse`.
- Changed `EmploymentType` to a list.


## 1.66.0
- Added `InvalidCachedKeyRequest` and `InvalidCacheKeyResponse`
- Change `ApiHttpClient` to always try to get a cached item check if cache is valid.

## 1.65.0
- Added `GoogleForJobsResponse` to `JobResponse`
	- Added `GoogleForJobsLocationResponse`
	- Added `GoogleForJobsLocationResponse` list to `GoogleForJobsResponse`

## 1.64.0
-Added `KarriereApiUuId` and `KarriereOneClickWidget` to support karriere.at one-click widget. 

## 1.63.0
- Added `MandatorId` to `JobResponse` for better integration support in multi-mandator use cases.
- Added `TemplateName` to `JobResponose` to improve support in customer-built career sites.

## 1.62.0
- Added `GenderIdentity` to `ApplicantParameter`.
- Added `AskForGenderIdentity` to `PortalSettingsResponse`.
- Added `AskForGenderIdentityOnRegistration` to `PortalSettingsResponse`.

## 1.61.1
- Change KarriereOneClickRequest to override content and content type.

## 1.61.0
- Added new endpoint to create a new applicant and application for the data from "Apply by karriere.at".
- `KarriereOneClickResponse` has been added.
- `KarriereOneClickRequest` has been added.

## 1.60.0
- `InternalName` property has been added to the `JobPublicationResponse`.

## 1.59.0
- `UserAddress`, `UserZipCode` and `UserCity` have been added to handle the user location.


## 1.58.0
- `PasswordResponses` models updated to match new password policy features 

## 1.57.4
- The URL for the `InterestProfilesRequest` has been corrected to the actual API endpoint.


## 1.57.3
- The `JobIds` property has been added to the `InterestProfileResponse`.

## 1.57.2
- The `Testimonials` property has been added to the `JobInsightResponse`.

## 1.57.1
- The URL prefix for the applicant compass requests have been corrected to be compliant with the general API layout.

## 1.57.0
- The applicant compass requests, responses and parameters have been added. All requests require the permission to use the 
  applicant compass feature and a license for the feature.

## 1.56.0
- The `DefaultValue` property has been added to the `CustomFieldResponse`.

## 1.55.2
- The `ApplicantDocumentType` property has been added to `QuestionnaireItemResponse`.

## 1.55.1
- Changed `JobText` and `CustomField` to `JobTextParameter` and `CustomFieldParameter` respectively.


## 1.55.0
- Added new endpoint to create new jobs.
- Added `JobParameter` and `JobCreationResponse` to handle new requests to create jobs.

## 1.54.0
- The `ApplicantDocument` has been added to `QuestionnaireItemType`.

## 1.53.2
- The `HeaderColor` and the `BackgroundColor` have been added to `StepStoneChannelSettings`.

## 1.53.1
- Moved `ChannelSettings` from `JobsResponse` to `JobResponse`.

## 1.53.0
- `ChannelSettings` has been added.
    - `ChannelSettings` with `StepStone` settings has been added to `JobResponse`.

## 1.52.0
- The geo location name has been added.
    - `GeoLocationName` has been added to `JobResponse`.

## 1.51.0
- The job ad block headers have been added.
    - `HeaderBlock1`, `HeaderBlock2`, `HeaderBlock3`, `HeaderBlock4` have been added to `JobResponse`.

## 1.50.0
- The legacy XING API settings have been removed, the new _Login with XING_ integration must be used moving forward.
    - `XingConsumerKey` in the `PortalSettingsResponse` has been removed.
    - `XingConsumerSecret` in the `PortalSettingsResponse` has been removed.

## 1.49.0
- New property `ApplicationId` in ApplicationCreateResponse which retrieves the ID for the new application created.
- New properties `WorkflowStatusGroup` and `Rating` in ApplicationResponse which retrieve respectively the current workflow status group and application score if it is available.

## 1.48.0
- New portal settings properties that allow to control the new jobs map behaviour.
  - `EnableJobMap` controls the availablity of the job map (default: `false`)
  - `JobMapCollapsed` controls if the job map is visible when the job listing is loaded (default: `false`).

## 1.47.1
- The legacy XING API settings have been temporarily added:
    - `XingConsumerKey` in the `PortalSettingsResponse` has been temporarily added.
    - `XingConsumerSecret` in the `PortalSettingsResponse` has been temporarily added.

## 1.47.0
- New property `SocialMedia` of type `SocialMediaResponse` in JobResponse  which contains information about the social media header elements.

## 1.46.0
- The legacy XING API settings have been removed, the new _Login with XING_ integration must be used moving forward.
    - `XingConsumerKey` in the `PortalSettingsResponse` has been removed.
    - `XingConsumerSecret` in the `PortalSettingsResponse` has been removed.

## 1.45.0
- New property `GeoLocation` of type `GeoLocationResponse` in JobResponse  which contains information about the job geolocation.

## 1.44.0
- New API call to request the application by job ID (`ApplicationSearch` permission required).
    - `/Api/Applications/ByJob/:jobId` will return all open applications on a job.
- New API call to request applicants by a custom field and its value. (`Applicants` permission required).
    - `/Api/Applicants/ByCustomField/:customField?value=:customFieldValue` will return all applicants with a certain custom field value.

## 1.43.2
- New property in the `PortalSettings` which contains the ApplyWith jobs.ch access key.
    - `LoginWithJobCloudKey`

## 1.42.0
- New portal settings property which handles the inclusion of customer information in the XML feed.
    - `EnableCustomerInformationInXmlFeed` 
- New job response properties to expose the customer information of the job.
    - `CustomerId` contains the customer ID.
    - `CustomerName` contains the customer name.

## 1.41.1
- Fixed wrong parameter for `PoliciesGetRequest`

## 1.41.0
- New property which enables/disables the download of the european cv in the applicant profile.
    - `EnableEuropeanCvDownload` 

## 1.40.0
- Extended `ApplicantCvGetRequest` with a new endpoint to be possible generating the applicant european CV
  - `Api/Applicant/EuropeanCv/` can generate a new european CV for an applicant

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
- New API call to get applications by the referrer that created the application (`ApplicationSearch` permission required)

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
