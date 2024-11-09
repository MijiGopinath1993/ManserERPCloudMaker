
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
//using OWASPZAPDotNetAPI;
using System.Threading;
// OWASPZAPDotNetAPI testing code needs to be removed
namespace DevextremeExamples
{
    public class Program
    {
        private static string _target = "https://northwindgrp.com/";
        private static string _apikey = "change-me-9203935709";
        //private static ClientApi _api = new ClientApi("20.220.80.252", 8080, _apikey);
        //private static IApiResponse _apiResponse;

        public static void Main(string[] args)
        {
            //string spiderScanId = StartSpidering();

            CreateHostBuilder(args).Build().Run();
        }

        public static void Go()
        {
        //    string spiderScanId = StartSpidering();
        //    //PollTheSpiderTillCompletion(spiderScanId);

        //    StartAjaxSpidering();
        //    PollTheAjaxSpiderTillCompletion();

        //    string activeScanId = StartActiveScanning(); 

            string reportFileName = string.Format("report-{0}", DateTime.Now.ToString("dd-MMM-yyyy-hh-mm-ss"));
            
        }

        //private static string StartActiveScanning()
        //{
        //    Console.WriteLine("Active Scanner: " + _target);
        //    _apiResponse = _api.ascan.scan(_target, "", "", "", "", "", "");

        //    string activeScanId = ((ApiResponseElement)_apiResponse).Value;
        //    return activeScanId;
        //}

        //private static void PollTheAjaxSpiderTillCompletion()
        //{
        //    while (true)
        //    {
        //        Sleep(1000);
        //        string ajaxSpiderStatusText = string.Empty;
        //        ajaxSpiderStatusText = Convert.ToString(((ApiResponseElement)_api.ajaxspider.status()).Value);
        //        if (ajaxSpiderStatusText.IndexOf("running", StringComparison.InvariantCultureIgnoreCase) > -1)
        //            Console.WriteLine("Ajax Spider running");
        //        else
        //            break;
        //    }

        //    Console.WriteLine("Ajax Spider complete");
        //    Sleep(10000);
        //}

        //private static void StartAjaxSpidering()
        //{
        //    Console.WriteLine("Ajax Spider: " + _target);
        //    _apiResponse = _api.ajaxspider.scan(_target, "", "", "");

        //    if ("OK" == ((ApiResponseElement)_apiResponse).Value)
        //        Console.WriteLine("Ajax Spider started for " + _target);
        //}

        //private static string StartSpidering()
        //{
        //    //Console.WriteLine("Spider: " + _target);
        //    _apiResponse = _api.spider.scan(_target, "", "", "", "");
        //    string scanid = ((ApiResponseElement)_apiResponse).Value;
        //    return scanid;
        //}

        //private static void LoadTargetUrlToSitesTree()
        //{
        //    _api.AccessUrl(_target);
        //}

        private static void Sleep(int milliseconds)
        {
            do
            {
                Thread.Sleep(milliseconds);
                Console.WriteLine("...zz" + Environment.NewLine);
                milliseconds = milliseconds - 2000;
            } while (milliseconds > 2000);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                     
                });
    }
}

//using DevextremeExamples;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Account}/{action=Login}/{id?}");

//Host.CreateDefaultBuilder(args)
//               .ConfigureWebHostDefaults(webBuilder =>
//               {
//                   webBuilder.UseStartup<Startup>();
//               });

////var builder = WebApplication.CreateBuilder(args);

//var startup = new Startup(builder.Configuration);
//startup.ConfigureServices(builder.Services); 
//startup.Configure(app, builder.Environment);

//app.Run();