using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Sol_Demo.Data;
using Sol_Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Pages.Demo
{
    [Authorize]
    public partial class MyComponent<TItem,TItem1> where TItem:IPersonModel where TItem1:struct
    {
        private int counter = 0;

        [Parameter]
        public String Title { get; set; }

        [Inject]
        public WeatherForecastService WeatherForecastS { get; set; }

        [Parameter]
        public TItem Model { get; set; }

        [Parameter]
        public TItem1 Values { get; set; }

        
        public void Increment()
        {
            Console.WriteLine(Model.FirstName);
            Console.WriteLine(Model.LastName);

            Console.WriteLine(Values.ToString());

            counter++;
        }
    }
}
