using Emos2.Infrastructure.Entities.Database;
using Emos2.Infrastructure.Entities.DatabaseEmos1;
using Emos2.Infrastructure.Repositories;
using Emos2.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Services
{
    public class ClientService : ServiceBaseEmos1<Client>, IClientService
    {
        private IRepositoryEmos1<Client> myRepository;

        public ClientService(IRepositoryEmos1<Client> clientRepository) : base(clientRepository)
        {
            this.myRepository = clientRepository;
        }

        public string GetConnectionString(string clientCode)
        {        
            var client = myRepository.SelectBy(x => x.Code == clientCode).FirstOrDefault();

            if (client == null)
            {
                throw new Exception($"No settings for client {clientCode}");
            }

            string databaseName = client.DatabaseName;
            string serverName = client.ServerName;
            string userId = client.UserID;

            return  $"Data Source={serverName};Initial Catalog={databaseName};user id={userId};password=Asdfghjklqwe1;MultipleActiveResultSets=True";

        }
    }
}
