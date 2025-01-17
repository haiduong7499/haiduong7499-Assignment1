﻿using Assignment.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.CustomerSite.Services
{
    public interface IProductApiClient
    {
        Task<IList<ProductRespone>> GetProducts();
        Task<ProductRespone> GetProductByID(string id);
        Task<IList<ProductRespone>> GetProductByCate(int idCate);

        Task<IList<RatingRespone>> GetRating(string id);

        Task<RatingRequest> PostRating(RatingRequest ratingRequest);
    }
}
