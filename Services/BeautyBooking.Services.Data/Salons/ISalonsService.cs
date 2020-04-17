﻿namespace BeautyBooking.Services.Data.Salons
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ISalonsService
    {
        Task RegisterSalonAsync(string name, string address, string imageUrl, string ownerId, int categoryId);

        IEnumerable<T> GetAll<T>(int? count = null);

        Task DeleteSalonAsync(int id);

        T GetById<T>(int id);

        IEnumerable<T> GetByOwner<T>(string userId);
    }
}
