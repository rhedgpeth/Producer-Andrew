﻿/* This file was generated by Settings Studio
 *
 * Copyright © 2015 Colby Williams. All Rights Reserved.
 */

namespace SettingsStudio
{
	public static partial class Settings
	{
		#region Visible Settings


		public static string VersionNumber {
			get { return StringForKey (SettingsKeys.VersionNumber); }
#if __ANDROID__
			set { SetSetting (SettingsKeys.VersionNumber, value); }
#endif
		}

		public static string BuildNumber {
			get { return StringForKey (SettingsKeys.BuildNumber); }
#if __ANDROID__
			set { SetSetting (SettingsKeys.BuildNumber, value); }
#endif
		}

		public static string GitHash => StringForKey (SettingsKeys.GitCommitHash);


		public static bool TestProducer {
			get { return BoolForKey (SettingsKeys.TestProducer); }
			set { SetSetting (SettingsKeys.TestProducer, value); }
		}


		public static string UserReferenceKey {
			get { return StringForKey (SettingsKeys.UserReferenceKey); }
			set { SetSetting (SettingsKeys.UserReferenceKey, value); }
		}


		#endregion


		#region Hidden Settings

		public static string AvContentListSelectedFilter {
			get { return StringForKey (SettingsKeys.AvContentListSelectedFilter); }
			set { SetSetting (SettingsKeys.AvContentListSelectedFilter, value); }
		}


		public static int ProducerListSelectedRole {
			get { return Int32ForKey (SettingsKeys.ProducerListSelectedRole); }
			set { SetSetting (SettingsKeys.ProducerListSelectedRole, value); }
		}


		public static string LastAvContentDescription {
			get { return StringForKey (SettingsKeys.LastAvContentDescription); }
			set { SetSetting (SettingsKeys.LastAvContentDescription, value); }
		}

		#endregion
	}
}