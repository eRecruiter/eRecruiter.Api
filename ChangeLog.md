# eRecruiter API ChangeLog

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
