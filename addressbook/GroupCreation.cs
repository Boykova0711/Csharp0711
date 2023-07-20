using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using static WebAddressbookTests.GroupHelper;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    { 
        [Test]
        public void GroupCreationTest()
        {
            navigator?.OpenHomePage();
            loginHelper?.Login(new AccountData ("admin", "secret"));
            navigator?.GoToGroupPage();
            groupHelper?.InitGroupCreation();
            GroupData group = new GroupData("test");
            group.Header = "testoviy";
            group.Footer = "test123";
            groupHelper?.FillGroupForm(group);
            groupHelper?.SubmitGroupCreation();
            groupHelper?.ReturnGroupPage();
        }        
    }
}