﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebApiML.DTO;

namespace WebApiML.DAL
{
    // This code requires the Nuget package Microsoft.AspNet.WebApi.Client to be installed.
    // Instructions for doing this in Visual Studio:
    // Tools -> Nuget Package Manager -> Package Manager Console
    // Install-Package Microsoft.AspNet.WebApi.Client
    public class AzureDAO
    {
        public async Task<HttpResponseMessage> InvokeRequestResponseService(InputDTO inputDTO)
        {
            using (var client = new HttpClient())
            {
                var scoreRequest = new
                {
                    Inputs = new Dictionary<string, List<Dictionary<string, string>>>() {
                        {
                            "Input (Genre)",
                            new List<Dictionary<string, string>>(){new Dictionary<string, string>(){
                                            {
                                                "BirthYear", "" + inputDTO.BirthYear
                                            },
                                            {
                                                "Sex", inputDTO.Sex
                                            },
                                            {
                                                "isClubMember", inputDTO.isClubMember
                                            },
                                            {
                                                "Movie", inputDTO.Movie
                                            },
                                            {
                                                "Genre", inputDTO.Genre
                                            },
                                }
                            }
                        },
                        {
                            "Input (Movie)",
                            new List<Dictionary<string, string>>(){new Dictionary<string, string>(){
                                            {
                                                "BirthYear", "" + inputDTO.BirthYear
                                            },
                                            {
                                                "Sex", inputDTO.Sex
                                            },
                                            {
                                                "isClubMember", inputDTO.isClubMember
                                            },
                                            {
                                                "Movie", inputDTO.Movie
                                            },
                                            {
                                                "Genre", inputDTO.Genre
                                            },
                                }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };

                const string apiKey = "m3KGH0nKb0DCR5LAlkcmy7J0RqnccJNLngwRjwuPWOx5lyFnmhYgcRqNs5ZrtkocwGCSS1yvQxV/lhbadP8G7w=="; // Replace this with the API key for the web service
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                client.BaseAddress = new Uri("https://europewest.services.azureml.net/workspaces/7cf3d5547c944acfae5c6f01657406aa/services/3a527c97b3aa41a0b32a1a9e0b5962e0/execute?api-version=2.0&format=swagger");

                // WARNING: The 'await' statement below can result in a deadlock
                // if you are calling this code from the UI thread of an ASP.Net application.
                // One way to address this would be to call ConfigureAwait(false)
                // so that the execution does not attempt to resume on the original context.
                // For instance, replace code such as:
                //      result = await DoSomeTask()
                // with the following:
                //      result = await DoSomeTask().ConfigureAwait(false)

                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest).ConfigureAwait(false);
                return response;
            }
        }
    }
}