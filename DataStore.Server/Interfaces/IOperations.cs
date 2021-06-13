using DataStore.Server.Models;
using System.ServiceModel;

namespace DataStore.Server.Interfaces
{
    [ServiceContract]
    public interface IOperations
    {
        [OperationContract]
        RegisterResponseModel Register(RegisterRequestModel data); 
    }
}
