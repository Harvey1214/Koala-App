using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KoalaApp.Shared;
using Microsoft.JSInterop;

namespace KoalaApp.Data
{
    public class WindowDimensions
    {
        public bool Mobile { get; set; } = false;

        public MainLayout MainLayout { get; set; }

        public BrowserDimension BrowserDimension { get; set; } = new BrowserDimension();
        private readonly IJSRuntime _js;

        public WindowDimensions(IJSRuntime js)
        {
            _js = js;
        }

        public async Task<BrowserDimension> GetDimensions()
        {
            return await _js.InvokeAsync<BrowserDimension>("getDimensions");
        }
    }

    public record BrowserDimension
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
