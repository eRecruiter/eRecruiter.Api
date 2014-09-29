# eRecruiter API

Contains libraries to make communicating with the eRecruiter API a lot easier, by providing classes for all entities that are sent to/from the API, as well as helpers to parse the requests/responses.

**These libraries are NOT REQUIRED to use the eRecruiter API**, because it is based on simple REST and JSON or XML, but these libraries get you started a lot faster if you are using .NET to work with the eRecruiter API.

## Getting started with the eRecruiter API

Every eRecruiter API installation comes with a complete reference of all available methods und functionality - see `~/help` (where ~ is the root endpoint of your API installation). This document only provides a quick overview on how to get started as an API consumer.

### Authentication

To authenticate an API consumer we use something somewhat similar to OAuth 2 (but it's not OAuth, we would have required only a very simple subset of it, namely 0-legged-OAuth).

You need an API consumer ID and API Secret to authenticate. Please ask your eRecruiter Administrator to provide one.
The authentication flow:

1. Exchange your consumer ID and secret with a token. Call `POST ~/Api/` to exchange your ID and secret for a token. See the reference for the exact required parameters and response.
2. Include the token in the HTTP header of all your subsequent requests. The expected HTTP header name is `X-ApiToken`, the value is the returned token from step 1.
3. The token may expire. If this happens, exchange your consumer ID and secret for a new token (repeat step 1)
A missing or invalid token will return a HTTP 401 error code, if the called method requires authentication (almost all of them do).

There's a simple helper method to check if your authentication is working: Call `GET ~/Api/Ping`. This method works with and without valid authentication, but returns information about whether you're authorized or not.

### Working with the API
The API supports XML as well as JSON requests and responses (depending in what you request on your HTTP request header).
Please see the reference (`~/help`) for details about the API and its method. A good place to get started is, for example, `GET ~/Api/PublishedJobs` - this should display all the jobs that are published on the default applicant portal.
