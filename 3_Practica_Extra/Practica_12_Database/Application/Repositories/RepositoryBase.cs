/*
 * MIT License
 * 
 * Copyright (c) 2021 [FacuFalcone]
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using Application.Common;
using System.Collections.Generic;

namespace Application.Repositories {
    public abstract class RepositoryBase<T> : IRepository<T> {
        /// <summary>
        /// Order the list by ID and return it.
        /// </summary>
        /// <returns>The ordered list by id.</returns>
        public abstract List<T> GetAll();

        /// <summary>
        /// Gets a customer by its id.
        /// </summary>
        /// <param name="entityId">ID to search a customer into the list.</param>
        /// <returns>A customer by its id.</returns>
        public abstract T GetById(long entityId);

        /// <summary>
        /// Creates an entity in the list.
        /// </summary>
        /// <param name="entity">Entity to create.</param>
        public abstract void Create(T entity);

        /// <summary>
        /// Updates an entity of the list.
        /// </summary>
        /// <param name="entity">Entity to update</param>
        public abstract void Update(T entity);

        /// <summary>
        /// Removes an entity frmo the list.
        /// </summary>
        /// <param name="entity">Entity to remove</param>
        public abstract void Remove(T entity);
    }
}
