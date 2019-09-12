using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnitTestTask
{
    enum PropertyType
    {
        Id,
        Name,
        XPath,
        LinkText,
        PartialLinkText,
        ClassName
    }
    class PropertiesCollection
    {
        // Auto-implemented property
        public static IWebDriver driver { get; set; }
    }
}
