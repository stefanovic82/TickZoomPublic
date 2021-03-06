﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Matthew Ward" email="mrward@users.sourceforge.net"/>
//     <version>$Revision: 5343 $</version>
// </file>

using System;
using System.Windows.Forms;

namespace RubyBinding.Tests.Utils
{
	public class NullPropertyUserControl : UserControl
	{
		string fooBar;
		
		public string FooBar {
			get { return fooBar; }
			set { fooBar = value; }
		}
		
		public NullPropertyUserControl()
		{
		}
	}
}
