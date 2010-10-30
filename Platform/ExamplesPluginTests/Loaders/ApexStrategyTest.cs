﻿#region Copyright
/*
 * Software: TickZoom Trading Platform
 * Copyright 2009 M. Wayne Walter
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 * 
 * Business use restricted to 30 days except as otherwise stated in
 * in your Service Level Agreement (SLA).
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, see <http://www.tickzoom.org/wiki/Licenses>
 * or write to Free Software Foundation, Inc., 51 Franklin Street,
 * Fifth Floor, Boston, MA  02110-1301, USA.
 * 
 */
#endregion


using System;
using System.Collections.Generic;
using NUnit.Core;
using NUnit.Core.Extensibility;
using NUnit.Framework;
using TickZoom.Api;
using TickZoom.Common;

namespace Loaders
{
	[SuiteBuilder]
	public class DynamicTestSuite : ISuiteBuilder
	{
		private static readonly Log log = Factory.SysLog.GetLogger(typeof(DynamicTestSuite));
		public Test BuildFrom(Type type)
		{
			var loaders = Plugins.Instance.GetLoaders();
			return null;
		}
	
		public bool CanBuildFrom(Type type)
		{
			return type == typeof(DynamicTestSuite);
		}		
	}
	
	[TestFixture]
	public class ApexStrategyTest : StrategyTest
	{
		Log log = Factory.SysLog.GetLogger(typeof(ApexStrategyTest));
		
		public ApexStrategyTest() {
			LoaderName = "APX_Systems: APX Multi-Symbol Loader";
			Symbols = "USD/JPY";
			StoreKnownGood = true;
			ShowCharts = false;
			StartTime = new TimeStamp( 1800, 1, 1);
			EndTime = new TimeStamp( 2009, 6, 10);
		}
		
		[Test]
		public void SimpleTest() {
			
		}
	}
}
