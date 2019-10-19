using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPOMproject.Pages
{
    public partial class SoftUniCoursePage
    {
        public void Navigate(SoftUniPage softUniPage)
        {
            softUniPage.Navigate("https://softuni.bg/");
            softUniPage.allCourseButton.Click();
            softUniPage.courseButton.Click();
        }

        public void AssertTag (string expected, SoftUniCoursePage pageTag)
        {
            Assert.AreEqual(expected, pageTag.headerTag.TagName, "Tag name should be h1");
        }

        public void AssertTagText (string expected, SoftUniCoursePage tagText)
        {
            Assert.AreEqual(expected, tagText.headerTag.Text, "Text in tag should contain: QA Automation - септември 2019");
        }
    }
}
