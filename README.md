# Transmitly.ChannelProvider.Firebase.Configuration

Shared Firebase configuration primitives for Transmitly channel-provider implementations.

## Should you use this package?

Use this package if you are authoring a Firebase channel provider (or extension) for the Transmitly ecosystem and need the common Firebase configuration types.

If you are building an application and just want to send push notifications through Firebase, use [`transmitly-channel-provider-firebase`](https://github.com/transmitly/transmitly-channel-provider-firebase) instead.

## What this package provides

- `FirebaseOptions`: common provider options (`Credential`, `ProjectId`, `ServiceAccountId`, `AppName`).
- `FirebaseCredential`: credential helpers for common auth sources.
- `FirebaseConstant.Id`: the default provider id (`"Firebase"`).
- `ChannelProviders.Firebase(...)`: extension for building a provider id with optional instance suffix.

## Credential helpers

`FirebaseCredential` supports the following factory methods:

- `GetApplicationDefault()`
- `FromJson(string json)`
- `FromAccessToken(string accessToken)`
- `FromFile(string filePath)`
- `FromStream(Stream stream)`

## Related projects

- [Transmitly](https://github.com/transmitly/transmitly)
- [transmitly-channel-provider-firebase](https://github.com/transmitly/transmitly-channel-provider-firebase)

---
_Copyright © Code Impressions, LLC. This open-source project is sponsored and maintained by Code Impressions and is licensed under the [Apache License, Version 2.0](http://apache.org/licenses/LICENSE-2.0.html)._
