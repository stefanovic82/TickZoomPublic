﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Matthew Ward" email="mrward@users.sourceforge.net"/>
//     <version>$Revision: 2128 $</version>
// </file>

using System;
using ICSharpCode.Core;

namespace ICSharpCode.XmlEditor
{
	/// <summary>
	/// Inserts a new comment node after the selected node.
	/// </summary>
	public class InsertCommentAfterCommand : AbstractMenuCommand
	{		
		public override void Run()
		{
			XmlTreeViewContainerControl view = Owner as XmlTreeViewContainerControl;
			if (view != null) {
				view.InsertCommentAfter();
			}
		}
	}
}
