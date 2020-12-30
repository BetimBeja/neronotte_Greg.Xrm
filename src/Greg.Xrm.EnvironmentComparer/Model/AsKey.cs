﻿using Microsoft.Xrm.Sdk;

namespace Greg.Xrm.EnvironmentComparer.Model
{
	public static class AsKey
	{
		public static IKeyProvider<Entity> UseGuid { get; } = new KeyProviderById();

		public static IKeyProvider<Entity> UseAttributes(params string[] attributeList)
		{
			return new KeyProviderByAttributeSet(attributeList);
		}
	}
}
