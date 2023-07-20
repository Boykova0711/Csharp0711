﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            navigator?.OpenHomePage();
            loginHelper?.Login(new AccountData("admin", "secret"));
            navigator?.GoToGroupPage();
            groupHelper?.SelectGroup(3);
            groupHelper?.RemoveGroup();
            groupHelper?.ReturnToGroupsPage();
        }

    }
}
