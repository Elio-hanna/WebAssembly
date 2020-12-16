#pragma checksum "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\Pages\Dashboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c6fa4713730e0e5c0d82cc2f6f9a03a4078ee72"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebAssembly.Pages
{
    #line hidden
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using WebAssembly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using WebAssembly.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\Pages\Dashboard.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\Pages\Dashboard.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\Pages\Dashboard.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\Pages\Dashboard.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\Pages\Dashboard.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\Pages\Dashboard.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\Pages\Dashboard.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\Pages\Dashboard.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\Pages\Dashboard.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\Pages\Dashboard.razor"
using Newtonsoft.Json.Converters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\Pages\Dashboard.razor"
           [Microsoft.AspNetCore.Authorization.Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dashboard")]
    public partial class Dashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\Pages\Dashboard.razor"
       
    DateTime localDate = DateTime.Now;
    todoData[] todos;
    string email = "markraheb97@gmail.com";

    SfSchedule<todoData> ScheduleRef;
    SfSchedule<todoData> ScheduleObj;

    protected override async Task OnInitializedAsync()
    {
        var data = await localStorage.GetItemAsync<string>("todos");
        todos = System.Text.Json.JsonSerializer.Deserialize<todoData[]>(data);
        if (todos == null)
        {

        }
        if (todos != null)
        {
            populateScheduler();
        }
    }

    public void populateScheduler()
    {
        foreach (var t in todos)
        {
            DataSource.Add(new todoData
            {
                Id = t.Id,
                Subject = t.Subject,
                Description = t.Description,
                StartTime = t.StartTime,
                EndTime = t.EndTime,
            });
        }
    }

    public async Task saveFile()
    {
        List<todoData> todos = await ScheduleRef.GetEvents();
        List<todoData> t = new List<todoData> {
            new todoData
            {
                Id = 1,
                Subject = "ezpz",
                Description = ":)",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now,
            }
        };

        var jsonData = System.Text.Json.JsonSerializer.Serialize(t);
        await localStorage.SetItemAsync("todos", jsonData);
    }

    public async Task OnDataBound()
    {
        List<todoData> todos = await ScheduleRef.GetEvents();
        var jsonData = System.Text.Json.JsonSerializer.Serialize(todos);
        await localStorage.SetItemAsync("todos", jsonData);
    }

    List<todoData> DataSource = new List<todoData> { };

    public class todoData
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public bool IsAllDay { get; set; }
        public string RecurrenceRule { get; set; }
        public string RecurrenceException { get; set; }
        public Nullable<int> RecurrenceID { get; set; }
    }

    public class jsonData
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
