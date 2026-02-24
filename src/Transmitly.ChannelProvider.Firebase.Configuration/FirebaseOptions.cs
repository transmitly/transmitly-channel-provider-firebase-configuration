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
	/// Options available to configure a firebase channel provider.
	/// </summary>
	public sealed class FirebaseOptions
	{
		/// <summary>
		/// Firebase credentials.
		/// </summary>
		public FirebaseCredential? Credential { get; set; }
		/// <summary>
		/// Project Id.
		/// </summary>
		public string? ProjectId { get; set; }
		/// <summary>
		/// Service Account Id.
		/// </summary>
		public string? ServiceAccountId { get; set; }

		/// <summary>
		/// Firebase SDK uses a singleton pattern to manage firebase applications. This property is used to specify 
		/// the name of the application for which the credential is used. If not specified, it will be used for the 
		/// default application and any subsequent instance will reuse the initial credential. 
		/// 
		/// If specified, it will be used for the application with the specified name and any subsequent instance 
		/// with the same name will reuse the initial credential.
		/// </summary>
		public string AppName { get; set; }

	}
}