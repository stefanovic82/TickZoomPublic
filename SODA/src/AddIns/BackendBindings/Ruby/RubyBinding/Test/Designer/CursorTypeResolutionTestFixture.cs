﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Matthew Ward" email="mrward@users.sourceforge.net"/>
//     <version>$Revision: 5343 $</version>
// </file>

using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using ICSharpCode.RubyBinding;
using IronRuby.Compiler.Ast;
using NUnit.Framework;
using RubyBinding.Tests.Utils;

namespace RubyBinding.Tests.Designer
{
	/// <summary>
	/// Tests that the string "System.Windows.Forms.Cursors.AppStarting" can be resolved by the 
	/// RubyCodeDeserializer.
	/// </summary>
	[TestFixture]
	public class CursorTypeResolutionTestFixture : DeserializeAssignmentTestFixtureBase
	{
		public override string GetRubyCode()
		{
			return "self.Cursors = System::Windows::Forms::Cursors.AppStarting";
		}
		
		[Test]
		public void DeserializedObjectIsCursorsAppStarting()
		{
			Assert.AreEqual(Cursors.AppStarting, deserializedObject);
		}
		
		[Test]
		public void CursorsTypeResolved()
		{
			Assert.AreEqual("System.Windows.Forms.Cursors", base.componentCreator.LastTypeNameResolved);
		}
	}
}
