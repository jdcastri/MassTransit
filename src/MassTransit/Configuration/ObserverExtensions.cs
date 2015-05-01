﻿// Copyright 2007-2015 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit
{
    using System;
    using ConsumeConfigurators;


    public static class ObserverExtensions
    {
        /// <summary>
        /// Subscribes an object instance to the bus
        /// </summary>
        /// <param name="configurator">Service Bus Service Configurator 
        /// - the item that is passed as a parameter to
        /// the action that is calling the configurator.</param>
        /// <param name="observer">The observer to connect to the endpoint</param>
        /// <returns>An instance subscription configurator.</returns>
        public static IObserverConfigurator<T> Observer<T>(this IReceiveEndpointConfigurator configurator, IObserver<ConsumeContext<T>> observer)
            where T : class
        {
            var observerConfigurator = new ObserverConfigurator<T>(observer);

            configurator.AddEndpointSpecification(observerConfigurator);

            return observerConfigurator;
        }
    }
}