using Kruger.Storage.Data.Access.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Kruger.Storage.Data.Access
{
    public interface ICustomerRepository
    {
        // General 
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //Customer
        Task<Customer[]> GetAllCustomers();

        // Camps
        Task<StorageOrder[]> GetAllStorageOrderByExpirationDateAsync(int customerId, DateTime? dateTime = null);
        //Task<Camp> GetCampAsync(string moniker, bool includeTalks = false);
        //Task<Camp[]> GetAllCampsByEventDate(DateTime dateTime, bool includeTalks = false);

        //// Talks
        //Task<Talk> GetTalkByMonikerAsync(string moniker, int talkId, bool includeSpeakers = false);
        //Task<Talk[]> GetTalksByMonikerAsync(string moniker, bool includeSpeakers = false);

        //// Speakers
        //Task<Speaker[]> GetSpeakersByMonikerAsync(string moniker);
        //Task<Speaker> GetSpeakerAsync(int speakerId);
        //Task<Speaker[]> GetAllSpeakersAsync();
    }
}
