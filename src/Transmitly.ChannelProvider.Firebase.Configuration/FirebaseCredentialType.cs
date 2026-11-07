// Copyright (c) Code Impressions, LLC. All Rights Reserved.
//
//  Licensed under the Apache License, Version 2.0 (the "License")
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

namespace Transmitly.ChannelProvider.Firebase.Configuration
{
	/// <summary>
	/// The kind of credential JSON data is expected to contain.
	/// </summary>
	public enum FirebaseCredentialType
	{
		/// <summary>
		/// A service account key downloaded from the Firebase or Google Cloud console.
		/// </summary>
		ServiceAccount,
		/// <summary>
		/// A user credential created by <c>gcloud auth application-default login</c>.
		/// </summary>
		AuthorizedUser,
		/// <summary>
		/// A service account impersonated by another credential, created by
		/// <c>gcloud auth application-default login --impersonate-service-account</c>.
		/// </summary>
		ImpersonatedServiceAccount,
		/// <summary>
		/// A Workload Identity Federation configuration, for workloads running outside Google Cloud.
		/// </summary>
		ExternalAccount,
		/// <summary>
		/// A Workforce Identity Federation user credential.
		/// </summary>
		ExternalAccountAuthorizedUser
	}
}
