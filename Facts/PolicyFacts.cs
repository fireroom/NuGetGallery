﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using NuGetGallery.Areas.Admin.Controllers;
using Xunit;

namespace NuGetGallery
{
    // Tests for various code style and policy facts
    // Unit tests seem to be the best way to check these things. FxCop is probably better but harder.
    public class PolicyFacts
    {
        [Fact]
        public void AllAdminControllersHaveAuthorizeAttributeOnClass()
        {
            var failingTypes = TypesInTheSameNamespaceAs(typeof(AdminControllerBase))
                .Where(t => t.GetInterfaces().Contains(typeof(IController)))
                .Where(t => t.GetCustomAttribute<AuthorizeAttribute>(inherit: true) == null)
                .ToList();

            Assert.False(failingTypes.Any(),
                         "The following Admin controllers are unsecured:" + Environment.NewLine +
                         String.Join(Environment.NewLine, failingTypes.Select(t => "* " + t.FullName)));
        }

        private IEnumerable<Type> TypesInTheSameNamespaceAs(Type type)
        {
            return
                type.Assembly.GetTypes()
                    .Where(t => String.Equals(t.Namespace, type.Namespace, StringComparison.Ordinal))
                    .Where(t => t.GetCustomAttribute<GeneratedCodeAttribute>() == null);
        }
    }
}