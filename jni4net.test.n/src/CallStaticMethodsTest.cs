﻿#region Copyright (C) 2009 by Pavel Savara
/*
This file is part of tools for jni4net - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
#endregion

using java.lang;
using net.sf.jni4net.tested;
using NUnit.Framework;

namespace net.sf.jni4net.test
{
    [TestFixture]
    public class CallStaticMethodsTest : TestBase
    {
        [Test]
        public void stringMethod()
        {
            String res = JavaCallStaticMethods.stringMethod("tteeesssttt");
            Assert.IsTrue("stringMethodtteeesssttt".Equals(res));
        }

        [Test]
        public void stringArray()
        {
            String res = JavaCallStaticMethods.stringArrayMethod(new String[]{"tteeesssttt",null,"asderf"});
            Assert.IsTrue("stringArrayMethod-3".Equals(res));
        }

        [Test]
        public void voidMethod()
        {
            JavaCallStaticMethods.voidMethod((String)"tteeesssttt");
        }
    }
}
