# Saudi National Address Integration

## Overview

This project is an ASP.NET Core 8 Razor Pages application that integrates with the **Saudi National Address API** to search for national addresses and display their locations on **Google Maps**.

Users can enter a Saudi National Address, and the application retrieves the corresponding geographic coordinates from the National Address API before displaying the location on an interactive map.

---

## Features

* Search Saudi National Address.
* Integration with Saudi National Address API.
* Interactive Google Maps display.
* Automatic map centering and marker placement.
* Clean Razor Pages architecture.
* REST API communication between Front-End and Back-End.
* Secure API key management using `appsettings.json`.

---

## Technology Stack

### Front-End

* HTML5
* CSS3
* Bootstrap 5
* JavaScript (ES6)
* Fetch API
* Google Maps JavaScript API

### Back-End

* ASP.NET Core 8
* Razor Pages
* ASP.NET Core Web API
* C#
* HttpClient
* Dependency Injection
* Configuration (appsettings.json)
* JSON Serialization

---

## Project Structure

```
SaudiNationalAddress
│
├── Controllers
│   └── NationalAddressController.cs
│
├── Services
│   └── NationalAddressService.cs
│
├── Models
│   └── NationalAddressResponse.cs
│
├── Pages
│   ├── Index.cshtml
│   └── Shared
│       └── _Layout.cshtml
│
├── wwwroot
│   ├── css
│   ├── js
│   └── images
│
├── appsettings.json
├── Program.cs
└── README.md
```

---

## Configuration

Update the `appsettings.json` file with your API credentials.

```json
{
  "GoogleMaps": {
    "ApiKey": "YOUR_GOOGLE_MAPS_API_KEY"
  },

  "NationalAddress": {
    "BaseUrl": "YOUR_NATIONAL_ADDRESS_API_URL",
    "ApiKey": "YOUR_NATIONAL_ADDRESS_API_KEY"
  }
}
```

---

## Workflow

1. User enters a Saudi National Address.
2. Front-End sends a request to the ASP.NET API.
3. Backend calls the Saudi National Address API.
4. The API returns address information and geographic coordinates.
5. Backend returns the response to the client.
6. Google Maps centers the map on the returned location.
7. A marker is added to indicate the exact address.

---

## API Endpoint

```
GET /api/NationalAddress?address={address}
```

Example:

```
GET /api/NationalAddress?address=Prince Mohammed Bin Abdulaziz Road Riyadh
```

---

## Security

* API keys are stored in `appsettings.json`.
* Secrets should be moved to User Secrets or Environment Variables in production.
* Never expose private API credentials in client-side code.

---

## Future Enhancements

* Address autocomplete.
* Reverse geocoding.
* Save favorite addresses.
* Search history.
* Multiple map providers.
* Authentication and authorization.
* Logging and monitoring.
* Unit and integration tests.

---

## Author

Developed using ASP.NET Core 8, Razor Pages, REST API, and Google Maps integration for Saudi National Address services.
