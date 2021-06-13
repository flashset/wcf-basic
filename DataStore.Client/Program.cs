using System;

namespace DataStore.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStoreService.OperationsClient client = new FileStoreService.OperationsClient();
                var result = client.Register(new FileStoreService.RegisterRequestModel()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "WCF Demo",
                    EmailId = "examples@sparkyflash.com"
                });
                Console.WriteLine(result.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.Read();
        }
    }
}
