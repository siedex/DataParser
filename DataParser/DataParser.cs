﻿using System;
using System.Collections.Generic;
using DataParser.DataCollectors;
using DataParser.Models;

namespace DataParser
{
    public static class DataCollector
    {
        /// <summary>
        /// Parses ads from OLX by count
        /// </summary>
        /// <param name="count">Quantity of ads to parse</param>
        /// <returns>Returns collection of <see cref="AdvertismentModel"/></returns>
        public static IEnumerable<AdvertismentModel> CollectFromOLX(int count)
        {
            if (count == 0)
                throw new InvalidOperationException("Zero argument");

            OLXDataCollector dataCollector = new OLXDataCollector();
            return dataCollector.Collect(count);
        }

        /// <summary>
        /// Parses todays and yesterdays ads from OLX
        /// </summary>
        /// <returns>Returns collection of <see cref="AdvertismentModel"/></returns>
        public static IEnumerable<AdvertismentModel> CollectFromOLX()
        {
            OLXDataCollector dataCollector = new OLXDataCollector();
            return dataCollector.Collect(0);
        }

        /// <summary>
        /// Frees resources
        /// </summary>
        public static void FreeResources()
        {
            DataCollectors.PhoneCollectors.WebBrowserController.Instance.Dispose();
        }
    }
}
