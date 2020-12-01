﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Ø_167_1__HTTP_
{
    class Program
    {
        private static readonly HttpClient httpClient = new HttpClient();

        static async Task Main(string[] args)
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await httpClient.GetAsync("https://dawa.aws.dk/Kommuner");
            response.EnsureSuccessStatusCode();
            List<Kommune> lst = await response.Content.ReadAsAsync<List<Kommune>>();
            lst.OrderBy(i => i.Navn).ToList().ForEach(i => Console.WriteLine($"{i.Kode} {i.Navn}"));
        }
    }
    class Kommune
    {
        public string Navn { get; set; }
        public string Kode { get; set; }
    }
}
