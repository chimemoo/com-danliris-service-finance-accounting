using Com.Danliris.Service.Finance.Accounting.Lib.BusinessLogic.Services.JournalTransaction;
using Com.Danliris.Service.Finance.Accounting.Lib.Services.HttpClientService;
using Com.Danliris.Service.Finance.Accounting.Lib.ViewModels.OthersExpenditureProofDocumentViewModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Com.Danliris.Service.Finance.Accounting.Test.Services.OthersExpenditureProofDocument.Helper
{
    public class HttpClientOthersExpenditureServiceHelper : IHttpClientService
    {
        public Task<HttpResponseMessage> GetAsync(string url)
        {
            if (url.Contains("account-banks") && url.Contains("keyword"))
            {
                var defaultresponse = new APIDefaultResponse<List<AccountBank>>()
                {
                    data = new List<AccountBank>()
                };

                var result = new HttpResponseMessage()
                {
                    Content = new StringContent(JsonConvert.SerializeObject(defaultresponse))
                };

                return Task.FromResult(result);
            }
            else if (url.Contains("account-banks") && !url.Contains("keyword"))
            {
                var defaultresponse = new APIDefaultResponse<AccountBank>()
                {
                    data = new AccountBank()
                    {
                        Currency = new Currency()
                    }
                };

                var result = new HttpResponseMessage()
                {
                    Content = new StringContent(JsonConvert.SerializeObject(defaultresponse))
                };

                return Task.FromResult(result);
            }
            else if (url.Contains("bank-expenditure-notes/bank-document-no"))
            {
                var defaultresponse = new APIDefaultResponse<string>()
                {
                    data = "Test"
                };

                var result = new HttpResponseMessage()
                {
                    Content = new StringContent(JsonConvert.SerializeObject(defaultresponse))
                };

                return Task.FromResult(result);
            }


            return Task.FromResult(new HttpResponseMessage());
        }

        public Task<HttpResponseMessage> PostAsync(string url, HttpContent content)
        {
            return Task.FromResult(new HttpResponseMessage());
        }

        public Task<HttpResponseMessage> PutAsync(string url, HttpContent content)
        {
            return Task.FromResult(new HttpResponseMessage());
        }
    }
}
