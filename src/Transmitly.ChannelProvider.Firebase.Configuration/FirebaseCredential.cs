// ﻿﻿Copyright (c) Code Impressions, LLC. All Rights Reserved.
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
	/// Manages credentals for a firebase application.
	/// </summary>
	public sealed class FirebaseCredential
	{
		public string? Json { get; private set; }
		public string? AccessToken { get; private set; }
		public string? FilePath { get; private set; }
		public Stream? Stream { get; private set; }

		public bool IsStream => Stream != null;
		public bool IsJson => !string.IsNullOrWhiteSpace(Json);
		public bool IsAccessToken => !string.IsNullOrWhiteSpace(AccessToken);
		public bool IsFilePath => !string.IsNullOrWhiteSpace(FilePath);
		public bool IsDefault { get; private set; }

		/// <summary>
		/// Returns the Application Default Credentials which are ambient credentials that identify and authorize
		/// the whole application.
		/// </summary>
		/// <returns>The application default credentials.</returns>
		public static FirebaseCredential GetApplicationDefault()
		{
			return new FirebaseCredential { IsDefault = true };
		}

		/// <summary>
		/// Loads credential from a string containing JSON credential data.
		/// </summary>
		/// <param name="json">The JSON credential data.</param>
		/// <returns>A credential based on the provided JSON.</returns>
		public static FirebaseCredential FromJson(string json)
		{
			return new FirebaseCredential { Json = json };
		}

		/// <summary>
		/// Create a credential directly from the provided access token.
		/// The access token will not be automatically refreshed.
		/// </summary>
		/// <param name="accessToken">The access token to use within this credential.</param>
		/// <returns>A credential based on the provided access token.</returns>
		public static FirebaseCredential FromAccessToken(string accessToken)
		{
			return new FirebaseCredential { AccessToken = accessToken };
		}

		/// <summary>
		/// Loads credential from the specified file containing JSON credential data.
		/// </summary>
		/// <param name="filePath">The path to the credential file.</param>
		/// <returns>A credential based on the provided file.</returns>
		public static FirebaseCredential FromFile(string filePath)
		{
			return new FirebaseCredential { FilePath = filePath };
		}

		/// <summary>
		/// Loads credential from stream containing JSON credential data.
		/// </summary>
		/// <param name="stream">The stream containing the credential data.</param>
		/// <returns>A credential based on the provided stream.</returns>
		public static FirebaseCredential FromStream(Stream stream)
		{
			return new FirebaseCredential { Stream = stream };
		}
	}
}