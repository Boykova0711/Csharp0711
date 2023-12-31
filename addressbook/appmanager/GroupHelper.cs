﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace WebAddressbookTests
{
    public class GroupHelper : HelperBase
    {
      
       public GroupHelper(ApplicationManager manager) : base(manager)
        {
        }

        public GroupHelper Create(GroupData group)
        {
            manager.Navigator?.GoToGroupPage();
            InitGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnGroupPage();
            return this;
        }
        public GroupHelper Modify(int v, GroupData newData)
        {
            manager.Navigator?.GoToGroupPage();
            SelectGroup(v);
            InitGroupModification() ;
            FillGroupForm(newData);
            SubmitGroupModification();
            ReturnGroupPage();
            return this;
        }

        
        public GroupHelper Remove(int v)
        {
            manager.Navigator?.GoToGroupPage();

            SelectGroup(v);
            RemoveGroup();
            ReturnToGroupsPage();
            return this;
        }
        public GroupHelper InitGroupCreation()
            {

                driver?.FindElement(By.Name("new")).Click();
            return this;
            }
            public GroupHelper FillGroupForm(GroupData group)
        {
           
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);

            
            return this;
        }
        public new void Type(By locator, string text)
        {
            if (text != null)

            {
                driver?.FindElement(locator).Click();
                driver?.FindElement(locator).Clear();
                driver?.FindElement(locator).SendKeys(text);
            }


        }

        public GroupHelper SubmitGroupCreation()
            {

                driver?.FindElement(By.Name("submit")).Click();
            return this;
        }
            public GroupHelper ReturnGroupPage()
            {

                driver?.FindElement(By.LinkText("group page")).Click();
                driver?.FindElement(By.LinkText("Logout")).Click();
            return this;
        }
            public GroupHelper SelectGroup(int index)
            {
                driver?.FindElement(By.XPath("//span[" + index + "]/input")).Click();
            return this;
        }
            public GroupHelper RemoveGroup()
            {
                driver?.FindElement(By.Name("delete")).Click();
            return this;
        }
            public GroupHelper ReturnToGroupsPage()
            {
                driver?.FindElement(By.LinkText("group page")).Click();
            return this;
        }
        public GroupHelper SubmitGroupModification()
        {
            driver?.FindElement(By.Name("update")).Click();
            return this;
        }

        public GroupHelper InitGroupModification()
        {
            driver?.FindElement(By.Name("edit")).Click();
            return this;
        }



    }
}

