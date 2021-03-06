﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Matthew Ward" email="mrward@users.sourceforge.net"/>
//     <version>$Revision: 5461 $</version>
// </file>

using System;
using ICSharpCode.PythonBinding;
using ICSharpCode.SharpDevelop.Dom;
using NUnit.Framework;
using PythonBinding.Tests.Utils;

namespace PythonBinding.Tests.Resolver
{
	[TestFixture]
	public class ResolverContextGetModuleForNameImportedAsDifferentNameTestFixture
	{
		PythonResolverContext resolverContext;
		ParseInformation parseInfo;
		
		[SetUp]
		public void Init()
		{
			string python =
				"from sys import exit as myexit";
			
			parseInfo = PythonParserHelper.CreateParseInfo(python);
			resolverContext = new PythonResolverContext(parseInfo);
		}
		
		[Test]
		public void ResolverContextGetModuleForNameReturnsSysForMyExitName()
		{
			Assert.AreEqual("sys", resolverContext.GetModuleForImportedName("myexit"));
		}
		
		[Test]
		public void ResolverContextGetModuleForImportedNameReturnsNullForExitImportedName()
		{
			Assert.IsNull(resolverContext.GetModuleForImportedName("exit"));
		}
		
		[Test]
		public void ResolverContextUnaliasImportedNameReturnsMyExitForExitImportedName()
		{
			Assert.AreEqual("exit", resolverContext.UnaliasImportedName("myexit"));
		}
		
		[Test]
		public void ResolverContextUnaliasImportedNameReturnsOriginalNameWhenNoAliasIsFound()
		{
			Assert.AreEqual("unknown", resolverContext.UnaliasImportedName("unknown"));
		}
	}
}
