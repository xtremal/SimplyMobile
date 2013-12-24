﻿using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using SimplyMobile.Core;
using SimplyMobile.Text;
using SimplyMobile.Text.ServiceStack;

namespace DependencyResolverTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var resolver = new DependencyResolver();

            resolver.SetDynamicGetter<IJsonSerializer>(() => new JsonSerializer());

            var serializer = resolver.GetService<IJsonSerializer>();

            Assert.IsNotNull(serializer);
        }
    }
}
