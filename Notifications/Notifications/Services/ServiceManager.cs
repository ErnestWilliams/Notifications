//  ServiceManager.cs
//
//  Author:
//       Ernest Williams <ewilliams15@slb.com>
//
//  Copyright (c) 2017 Schlumberger Technology Corporation
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Acr.UserDialogs;
using ModernHttpClient;
using Notifications.Helpers;

namespace Notifications.Services
{
	public class ServiceManager
	{
        private static ServiceManager _manager;

        public static ServiceManager Instance => _manager ?? (_manager = new ServiceManager());

		public static async Task<string> ExecuteApiRequest(string url)
	    {
	        using (var client = new HttpClient(new NativeMessageHandler { DisableCaching = true }))
	        {
	            const int timeout = 20;
	            client.Timeout = TimeSpan.FromSeconds(timeout);

	            try	       {
	                Debug.WriteLine(url);

	                Stopwatch stopWatch = new Stopwatch();
	                stopWatch.Start();

                    var response = await client.GetAsync(url);
	                stopWatch.Stop();

					//CrossAnalytics.Current.TrackEvent(StaticConstants.AN_GET, StaticConstants.AN_MAPS, StaticConstants.AN_NETWORK);
					//CrossAnalytics.Current.TrackTime(StaticConstants.AN_TIME_TRACK, StaticConstants.AN_MAPS, stopWatch.ElapsedMilliseconds, Settings.Alias);

	                if (response.IsSuccessStatusCode)
	                {
	                    string responseStr = response.Content.ReadAsStringAsync().Result;
						if (responseStr != null){
							return responseStr;
						}

                        return "";
	                }
	                else
	                {
	                    string responseStr = response.Content.ReadAsStringAsync().Result;
						if (responseStr != null) {
							//FailureResponse.FailureInstance.FailureData = JsonConvert.DeserializeObject<BasicResponse>(responseStr);
						}

						return "";
	                }
	            }

	            catch (TaskCanceledException ex)
	            {
                    UserDialogs.Instance.HideLoading();
					UserDialogs.Instance.Alert(StaticConstants.SERVER_ERROR, ex.Message, StaticConstants.OK_BUTTON_TITLE);
	                //CrossAnalytics.Current.TrackException(ex, false);
	                return "";
	            }

	            catch (Exception ex)
	            {
	                //CrossAnalytics.Current.TrackException(ex, false);
	                Debug.WriteLine(ex.Message);
	                return "";
	            }
	        }
	    }
    }
}