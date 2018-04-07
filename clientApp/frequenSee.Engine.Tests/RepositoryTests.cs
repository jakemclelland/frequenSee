﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using frequenSee.Data.Entities;
using frequenSee.Models;
using frequenSee.Data.Interfaces;

namespace frequenSee.Engine.Tests
{
    /// <summary>
    /// Summary description for RepositoryTests
    /// </summary>
    [TestClass]
    public class RepositoryTests
    {
        public RepositoryTests()
        {
        }

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void SaveAnything()
        {
            IContentSource content = new ContentSource { Category = CategoryEnum.Personal, SourceId = 1, SourceUri = "xyz" };
            ContentSourceRepository repo = new ContentSourceRepository();
            var response = repo.Insert(content);
        }
    }
}
