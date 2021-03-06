﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Umbraco.Headless.Client.Net.Delivery.Models;

namespace Umbraco.Headless.Client.Net.Delivery
{
    /// <summary>
    /// Interface exposing methods available for the Media part of the Content Delivery API
    /// https://cdn.umbraco.io/media
    /// </summary>
    public interface IMediaDelivery
    {
        /// <summary>
        /// Gets the root Media items
        /// </summary>
        /// <returns><see cref="IEnumerable{Media}"/></returns>
        Task<IEnumerable<Media>> GetRoot();

        /// <summary>
        /// Gets the root Media items as the specified type
        /// </summary>
        /// <typeparam name="T">A type that inherits from the <see cref="IMedia"/> interface</typeparam>
        /// <returns><see cref="IEnumerable{T}"/></returns>
        Task<IEnumerable<T>> GetRoot<T>() where T : IMedia;

        /// <summary>
        /// Gets a single Media item by its id
        /// </summary>
        /// <param name="id"><see cref="Guid"/> id of the Media item</param>
        /// <returns><see cref="Media"/></returns>
        Task<Media> GetById(Guid id);

        /// <summary>
        /// Gets a single Media item by its id as the specified type
        /// </summary>
        /// <typeparam name="T">A type that inherits from the <see cref="IMedia"/> interface</typeparam>
        /// <param name="id"><see cref="Guid"/> id of the Media item</param>
        /// <returns><see cref="T"/></returns>
        Task<T> GetById<T>(Guid id) where T : IMedia;

        /// <summary>
        /// Gets a paged list of Media items by their Parent Id
        /// </summary>
        /// <param name="id"><see cref="Guid"/> id of the Media item's Parent</param>
        /// <param name="page">Integer specifying the page number (Optional)</param>
        /// <param name="pageSize">Integer specifying the page size (Optional)</param>
        /// <returns><see cref="PagedMedia"/></returns>
        Task<PagedMedia> GetChildren(Guid id, int page = 1, int pageSize = 10);

        /// <summary>
        /// Gets a paged list of Media items by their Parent Id as the specified type
        /// </summary>
        /// <typeparam name="T">A type that inherits from the <see cref="IMedia"/> interface</typeparam>
        /// <param name="id"><see cref="Guid"/> id of the Media item's Parent</param>
        /// <param name="page">Integer specifying the page number (Optional)</param>
        /// <param name="pageSize">Integer specifying the page size (Optional)</param>
        /// <returns><see cref="PagedMedia{T}"/></returns>
        Task<PagedMedia<T>> GetChildren<T>(Guid id, int page = 1, int pageSize = 10) where T : IMedia;
    }
}
