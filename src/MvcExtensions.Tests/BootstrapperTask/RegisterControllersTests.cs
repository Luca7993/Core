﻿#region Copyright
// Copyright (c) 2009 - 2010, Kazi Manzur Rashid <kazimanzurrashid@gmail.com>.
// This source is subject to the Microsoft Public License. 
// See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL. 
// All other rights reserved.
#endregion

namespace MvcExtensions.Tests
{
    using System;
    using System.Web.Mvc;

    using Moq;
    using Xunit;

    public class RegisterControllersTests : IDisposable
    {
        public RegisterControllersTests()
        {
            RegisterControllers.Excluded = false;
            RegisterControllers.IgnoredTypes.Clear();
        }

        public void Dispose()
        {
            RegisterControllers.Excluded = false;
            RegisterControllers.IgnoredTypes.Clear();
        }

        [Fact]
        public void Should_register_available_controllers()
        {
            var adapter = SetupAdapter();

            adapter.Setup(sr => sr.RegisterType(null, typeof(DummyController), typeof(DummyController), LifetimeType.Transient)).Verifiable();

            new RegisterControllers().Execute(adapter.Object);

            adapter.Verify();
        }

        [Fact]
        public void Should_not_register_controllers_when_excluded()
        {
            var adapter = SetupAdapter();

            RegisterControllers.Excluded = true;

            new RegisterControllers().Execute(adapter.Object);

            adapter.Verify(sr => sr.RegisterType(null, typeof(DummyController), typeof(DummyController), LifetimeType.Transient), Times.Never());
        }

        [Fact]
        public void Should_not_register_controllers_when_controller_exists_in_ignored_list()
        {
            var adapter = SetupAdapter();

            RegisterControllers.IgnoredTypes.Add(typeof(DummyController));

            new RegisterControllers().Execute(adapter.Object);

            adapter.Verify(sr => sr.RegisterType(null, typeof(DummyController), typeof(DummyController), LifetimeType.Transient), Times.Never());
        }

        private static Mock<FakeAdapter> SetupAdapter()
        {
            var buildManager = new Mock<IBuildManager>();
            buildManager.Setup(bm => bm.ConcreteTypes).Returns(new[] { typeof(DummyController) });

            var adapter = new Mock<FakeAdapter>();

            adapter.Setup(sl => sl.GetInstance<IBuildManager>()).Returns(buildManager.Object);

            return adapter;
        }

        private sealed class DummyController : Controller
        {
        }
    }
}