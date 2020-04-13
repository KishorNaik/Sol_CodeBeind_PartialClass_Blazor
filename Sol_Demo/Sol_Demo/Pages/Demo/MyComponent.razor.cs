using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Demo
{
    public partial class MyComponent
    {
        private int counter = 0;

        [Parameter]
        public String Title { get; set; }

        public void Increment()
        {
            counter++;
        }
    }
}
