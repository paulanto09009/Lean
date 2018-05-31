﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using System;
using System.Collections.Generic;
using QuantConnect.Data.UniverseSelection;
using QuantConnect.Interfaces;

namespace QuantConnect.Algorithm.Framework.Selection
{
    /// <summary>
    /// Provides a base class for universe selection models.
    /// </summary>
    public class UniverseSelectionModel : IUniverseSelectionModel
    {
        /// <summary>
        /// Gets the next time the framework should invoke the `CreateUniverses` method to refresh the set of universes.
        /// </summary>
        public virtual DateTime NextRefreshTimeUtc => DateTime.MaxValue;

        /// <summary>
        /// Creates the universes for this algorithm. Called once after <see cref="IAlgorithm.Initialize"/>
        /// </summary>
        /// <param name="algorithm">The algorithm instance to create universes for</param>
        /// <returns>The universes to be used by the algorithm</returns>
        public virtual IEnumerable<Universe> CreateUniverses(QCAlgorithmFramework algorithm)
        {
            throw new System.NotImplementedException("Types deriving from 'UniverseSelectionModel' must implement the 'IEnumerable<Universe> CreateUniverses(QCAlgorithmFramework) method.");
        }
    }
}