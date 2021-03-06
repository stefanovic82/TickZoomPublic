// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Matthew Ward" email="mrward@users.sourceforge.net"/>
//     <version>$Revision: 3978 $</version>
// </file>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using ICSharpCode.PythonBinding;
using NUnit.Framework;
using PythonBinding.Tests.Utils;

namespace PythonBinding.Tests.Designer
{
	/// <summary>
	/// When a text box is not added to the form's Control collection in InitializeComponent then:
	/// 
	/// 1) Text box should not be added to the form's Control collection when the form is created.
	/// 2) Text box should be registered with the designer via the IComponentCreator.Add method.
	/// 3) Text box should be created via the IComponentCreator.CreateInstance method.
	/// </summary>
	[TestFixture]
	public class TextBoxNotAddedToFormTestFixture : LoadFormTestFixtureBase
	{		
		public override string PythonCode {
			get {
				return "class MainForm(System.Windows.Forms.Form):\r\n" +
							"    def InitializeComponent(self):\r\n" +
							"        self._textBox1 = System.Windows.Forms.TextBox()\r\n" +
							"        self.SuspendLayout()\r\n" +
							"        # \r\n" +
							"        # textBox1\r\n" +
							"        # \r\n" +
							"        self._textBox1.Name = \"textBox1\"\r\n" +
							"        # \r\n" +
							"        # form1\r\n" +
							"        # \r\n" +
							"        self.ResumeLayout(False)\r\n";
			}
		}
		
		[Test]
		public void AddedComponentsContainsTextBox()
		{
			CreatedInstance instance = ComponentCreator.GetCreatedInstance(typeof(TextBox));
			
			AddedComponent c = new AddedComponent(instance.Object as IComponent, "textBox1");
			Assert.Contains(c, ComponentCreator.AddedComponents);
		}
		
		[Test]
		public void TextBoxIsNotAddedToForm()
		{
			Assert.AreEqual(0, Form.Controls.Count);
		}
	}
}
