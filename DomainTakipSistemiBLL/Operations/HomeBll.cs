using DomainTakipSistemiDTO.GeneralEntities;

namespace DomainTakipSistemiBLL.Operations
{
     public class HomeBll
    {
        public ApiResult GetMachineList()
        {
            provider = new ApiManager(url: "getMachineList");

            //apiResult.Result = false;

            try
            {
                HttpClient client = provider.GetClient();
                string serializedObject = JsonConvert.SerializeObject(searchMachineDto);
                var content = new StringContent(serializedObject, System.Text.Encoding.UTF8, "application/json");

                var result = client.PostAsync(provider._Url, content).Result;
                var stringresult = result.Content.ReadAsStringAsync().Result;
                apiResult = JsonConvert.DeserializeObject<ApiResult>(stringresult);
                if (apiResult.Result)
                {
                    apiResult.Data = JsonConvert.DeserializeObject<List<MachineDto>>(apiResult.Data.ToString());
                }
                return apiResult;

            }
            catch (Exception ex)
            {
                SeriLogger.Error(ex, "GetListByQuery", "");
                apiResult.Message = ex.Message;
                return apiResult;
            }
        }

    }
}