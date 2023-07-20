using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    { 
        [Test]
        public void GroupCreationTest()
        {
            OpenHomePage();

            Login(new AccountData ("admin", "secret"));
            GoToGroupPage();
            InitGroupCreation();
            GroupData group = new GroupData("test");
            group.Header = "testoviy";
            group.Footer = "test123";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnGroupPage();
        }        
    }
}